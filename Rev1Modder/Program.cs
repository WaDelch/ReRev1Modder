using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

/* ####################################################
 * ### Modding tool for Resident Evil Revelations 1 ###
 * ### Author: WaDelch                              ###
 * ####################################################
 */

namespace Rev1Modder
{
    internal static class Program
    {

        /// <summary>
        /// Main entry point.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_StartFrame());
        }

        public static IEnumerable<TControl> GetChildControls<TControl>(this Control control) where TControl : Control
        {
            var children = (control.Controls != null) ? control.Controls.OfType<TControl>() : Enumerable.Empty<TControl>();
            return children.SelectMany(c => GetChildControls<TControl>(c)).Concat(children);
        }

        public static bool InputCheck(TextBox[] tBoxes)
        {
            float checkSum = 0;
            foreach (TextBox tb in tBoxes)
                checkSum += Convert.ToSingle(tb.Text);
            if (checkSum != 100)
            {
                MessageBox.Show($"Error! Make sure all fields add up to exactly 100 (per set).\nCurrent value: {checkSum}");
                return false;
            }
            else
                return true;
        }
        public static void FillCbx(string[] items, ListBox lbx)
        {
            lbx.ClearSelected();
            lbx.Items.Clear();
            foreach (string s in items)
                lbx.Items.Add(s);
            lbx.SelectedIndex = 0;
        }

        public static void readBytes(TextBox[] tBoxes, string path, int startPos, int jump, int multiplier, bool isFloat)
        {
            byte[] getBytes = new byte[4];
            FileStream cFile = new FileStream(path, FileMode.Open, FileAccess.Read);
            cFile.Position = startPos;
            foreach (TextBox tb in tBoxes)
            {
                cFile.Read(getBytes, 0, 4);
                if (isFloat)
                    tb.Text = (BitConverter.ToSingle(getBytes, 0) * multiplier).ToString();
                else
                    tb.Text = (BitConverter.ToInt32(getBytes, 0) * multiplier).ToString();
                cFile.Position += jump;
            }
            cFile.Close();
        }

        public static void writeBytes(TextBox[] tBoxes, string path, int startPos, int jump, int divider, bool isFloat)
        {
            try
            {
                byte[] setBytes = new byte[4];
                FileStream cFile = new FileStream(path, FileMode.Open, FileAccess.Write);
                cFile.Position = startPos;
                foreach (TextBox tb in tBoxes)
                {
                    if (isFloat)
                        setBytes = BitConverter.GetBytes(Convert.ToSingle(tb.Text) / divider);
                    else
                        setBytes = BitConverter.GetBytes(Convert.ToInt32(tb.Text) / divider);
                    cFile.Write(setBytes, 0, 4);
                    cFile.Position += jump;
                }
                cFile.Close();
            }
            catch
            {
                MessageBox.Show("Failed to write data.");
            }
        }
    }
}
