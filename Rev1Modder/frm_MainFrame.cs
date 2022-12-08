using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Rev1Modder
{
    public partial class frm_MainFrame : Form
    {
        string Path, wRatePath, wLevelPath, wTagPath, wSlotPath, pTalentPath;

        public frm_MainFrame(string p)
        {
            InitializeComponent();
            this.Path = p;
            this.wRatePath = this.Path + "\\weaponRate.0A3E643B";
            this.wLevelPath = this.Path + "\\weaponRarityRate.0A3E643B";
            this.wTagPath = this.Path + "\\weaponTagRate.0A3E643B";
            this.wSlotPath = this.Path + "\\weaponSlotRate.0A3E643B";
            this.pTalentPath = this.Path + "\\playerTalent.0A3E643B";
            PopulateFields();
        }

        IEnumerable<TextBox> GetTextFields(string ftype)
        {
            IEnumerable<TextBox> tempTexts = Enumerable.Empty<TextBox>();
            switch (ftype)
            {
                case "weaponRate":
                    tempTexts = this.weaponRate.tlp_WeaponRate.GetChildControls<TextBox>();
                    break;
                case "weaponLevelRate":
                    tempTexts = this.weaponLevelRate.tlp_WeaponLevelRate.GetChildControls<TextBox>();
                    break;
                case "weaponTagRate":
                    tempTexts = this.weaponTagRate.tlp_WeaponTagRate.GetChildControls<TextBox>();
                    break;
                case "weaponSlotRate":
                    tempTexts = this.weaponSlotRate.tlp_WeaponSlotRate.GetChildControls<TextBox>();
                    break;
                case "playerTalent":
                    tempTexts = this.tlp_Player.GetChildControls<TextBox>();
                    break;
            }
            return tempTexts;
        }

        void PopulateFields()
        {
            try
            {
                readBytes(GetTextFields("weaponRate").ToArray(), wRatePath, 32, 11, 1);
                readBytes(GetTextFields("weaponLevelRate").ToArray(), wLevelPath, 30, 6, 100);
                readBytes(GetTextFields("weaponTagRate").ToArray(), wTagPath, 30, 6, 1);
                for (int i = 0; i < 6; i++)
                    readBytes(GetTextFields("weaponSlotRate").ToArray().Skip(5 * i).Take(5).ToArray(), wSlotPath, 38 + (30 * i), 1, 100);
                //readBytes(GetTextFields("weaponSlotRate").ToArray(), wSlotPath, 188, 1, 100);
            }
            catch
            {
                this.Close();
            }
        }

        void readBytes(TextBox[] tBoxes, string path, int startPos, int jump, int multiplier)
        {
            byte[] getBytes = new byte[4];
            FileStream cFile = new FileStream(path, FileMode.Open, FileAccess.Read);
            cFile.Position = startPos;
            foreach (TextBox tb in tBoxes)
            {
                cFile.Read(getBytes, 0, 4);
                tb.Text = (BitConverter.ToSingle(getBytes, 0) * multiplier).ToString();
                cFile.Position += jump;
            }
            cFile.Close();
        }

        void writeBytes(TextBox[] tBoxes, string path, int startPos, int jump, int divider)
        {
            try
            {
                byte[] setBytes = new byte[4];
                FileStream cFile = new FileStream(path, FileMode.Open, FileAccess.Write);
                cFile.Position = startPos;
                foreach (TextBox tb in tBoxes)
                {
                    setBytes = BitConverter.GetBytes(Convert.ToSingle(tb.Text) / divider);
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

        bool InputCheck(TextBox[] tBoxes)
        {
            float checkSum = 0;
            foreach (TextBox tb in tBoxes)
                checkSum += Convert.ToSingle(tb.Text);
            if (checkSum != 100)
            {
                MessageBox.Show($"Error! Make sure all Fields add up to exactly 100 (per Set).\nCurrent value: {checkSum}");
                return false;
            }
            else
                return true;
        }

        private void frm_MainFrame_Load(object sender, EventArgs e)
        {
            lbx_PlayerSelect.SelectedIndex = 0;
            rdb_WeaponRate.Select();
        }

        private void rdb_WeaponRate_CheckedChanged(object sender, EventArgs e)
        {
            weaponRate.Visible = true;
            weaponLevelRate.Visible = false;
            weaponTagRate.Visible = false;
            weaponSlotRate.Visible = false;
        }

        private void rdb_WeaponLevel_CheckedChanged(object sender, EventArgs e)
        {
            weaponRate.Visible = false;
            weaponLevelRate.Visible = true;
            weaponTagRate.Visible = false;
            weaponSlotRate.Visible = false;
        }

        private void rdb_TagRate_CheckedChanged(object sender, EventArgs e)
        {
            weaponRate.Visible = false;
            weaponLevelRate.Visible = false;
            weaponTagRate.Visible = true;
            weaponSlotRate.Visible = false;
        }

        private void rdb_SlotRate_CheckedChanged(object sender, EventArgs e)
        {
            weaponRate.Visible = false;
            weaponLevelRate.Visible = false;
            weaponTagRate.Visible = false;
            weaponSlotRate.Visible = true;
        }

        private void btn_ApplyWeapons_Click(object sender, EventArgs e)
        {
            TextBox[] weaponRateBoxes = GetTextFields("weaponRate").ToArray();
            TextBox[] weaponLevelRateBoxes = GetTextFields("weaponLevelRate").ToArray();
            TextBox[] weaponTagRateBoxes = GetTextFields("weaponTagRate").ToArray();
            TextBox[] weaponSlotRateBoxes = GetTextFields("weaponSlotRate").ToArray();
            TextBox[] splitBoxes;

            if (rdb_WeaponRate.Checked)
            {
                if (InputCheck(weaponRateBoxes))
                {
                    writeBytes(weaponRateBoxes, wRatePath, 32, 11, 1);
                    MessageBox.Show("Writing complete.");
                }
            }

            else if (rdb_WeaponLevelRate.Checked)
            {
                if (InputCheck(weaponLevelRateBoxes))
                {
                    writeBytes(weaponLevelRateBoxes, wLevelPath, 30, 6, 100);
                    MessageBox.Show("Writing complete.");
                }
            }

            else if (rdb_WeaponTagRate.Checked)
            {
                if (InputCheck(weaponTagRateBoxes))
                {
                    writeBytes(weaponTagRateBoxes, wTagPath, 30, 6, 1);
                    MessageBox.Show("Writing complete.");
                }
            }

            else if (rdb_WeaponSlotRate.Checked)
            {

                for (int i = 0; i < 6; i++)
                {
                    splitBoxes = weaponSlotRateBoxes.Skip(5 * i).Take(5).ToArray();
                    if (InputCheck(splitBoxes))
                        writeBytes(splitBoxes, wSlotPath, 38 + (30 * i), 1, 100);
                    else
                        MessageBox.Show("Error in Set " + (i + 1));
                }
                MessageBox.Show("Writing complete.");
            }
        }

        //############################# Player Data ###################################

        private void lbx_PlayerSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbx_PlayerSelect.SelectedIndex < 0)
            {
                MessageBox.Show("Select a Player!");
                return;
            }
            readBytes(GetTextFields("playerTalent").ToArray(), pTalentPath, 64 + (95 * lbx_PlayerSelect.SelectedIndex), 1, 100);
        }

        private void btn_ApplyPlayers_Click(object sender, EventArgs e)
        {
            TextBox[] playerTalentBoxes = GetTextFields("playerTalent").ToArray();
            float tempFloat;
            foreach (TextBox tb in playerTalentBoxes)
            {
                if (!Single.TryParse(tb.Text, out tempFloat) || tb.Text.Contains('-'))
                {
                    MessageBox.Show("Input error!");
                    return;
                }
            }
            writeBytes(playerTalentBoxes, pTalentPath, 64 + (95 * lbx_PlayerSelect.SelectedIndex), 1, 100);
            MessageBox.Show("Writing complete.");
        }
    }
}
