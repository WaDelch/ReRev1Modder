using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rev1Modder
{
    public partial class frm_StartFrame : Form
    {
        public frm_StartFrame()
        {
            InitializeComponent();
            //txt_Path.Text = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\coop_table";
            txt_Path.Text = Application.StartupPath + @"\coop_table\game\coop_table";
        }

        private void btn_Path_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                txt_Path.Text = fbd.SelectedPath;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (txt_Path.Text == string.Empty)
            {
                MessageBox.Show("Select the coop_table folder.");
                return;
            }
            try
            {
                frm_MainFrame mFrame = new frm_MainFrame(txt_Path.Text);
                mFrame.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Error! Could not load files. Make sure you selected the correct folder.");
            }
        }
    }
}
