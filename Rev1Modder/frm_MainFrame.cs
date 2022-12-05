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
            //var weaponRateBoxes = new List<Object>();
            //foreach (Control c in weaponRate.Controls)
            //    if(c is TextBox)
            //    weaponRateBoxes.Add(c);

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
            IEnumerable<TextBox> weaponRateBoxes = GetTextFields("weaponRate");
            IEnumerable<TextBox> weaponLevelRateBoxes = GetTextFields("weaponLevelRate");
            IEnumerable<TextBox> weaponTagRateBoxes = GetTextFields("weaponTagRate");
            IEnumerable<TextBox> weaponSlotRateBoxes = GetTextFields("weaponSlotRate");

            readBytes(weaponRateBoxes.ToArray(), wRatePath, 32, 11, 1);
            readBytes(weaponLevelRateBoxes.ToArray(), wLevelPath, 30, 6, 100);
            readBytes(weaponTagRateBoxes.ToArray(), wTagPath, 30, 6, 1);
            readBytes(weaponSlotRateBoxes.ToArray(), wSlotPath, 188, 1, 100);
        }

        void readBytes(TextBox[] tBoxes, string path, int startPos, int jump, int multiplier)
        {
            byte[] getBytes = new byte[4];
            FileStream cFile = new FileStream(path, FileMode.Open, FileAccess.Read);
            cFile.Position = startPos;
            foreach(TextBox tb in tBoxes)
            {
                cFile.Read(getBytes, 0, 4);
                tb.Text = (BitConverter.ToSingle(getBytes, 0) * multiplier).ToString();
                cFile.Position += jump;
            }
            cFile.Close();
        }

        void writeBytes(TextBox[] tBoxes, string path, int startPos, int jump, int divider)
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

        void ApplyWeaponRate()
        {

        }

        void ApplyWeaponLevelRate()
        {

        }

        void ApplyWeaponTagRate()
        {

        }

        void ApplyWeaponSlotRate()
        {

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
            IEnumerable<TextBox> weaponRateBoxes = GetTextFields("weaponRate");
            IEnumerable<TextBox> weaponLevelRateBoxes = GetTextFields("weaponLevelRate");
            IEnumerable<TextBox> weaponTagRateBoxes = GetTextFields("weaponTagRate");
            IEnumerable<TextBox> weaponSlotRateBoxes = GetTextFields("weaponSlotRate");
            float check100 = 0;

            if(rdb_WeaponRate.Checked)
            {
                foreach(TextBox tb in weaponRateBoxes)
                    check100 += Convert.ToSingle(tb.Text);
                if (check100 != 100)
                {
                    MessageBox.Show("Error! Make sure all Fields add up to exactly 100.");
                    return;
                }
                writeBytes(weaponRateBoxes.ToArray(), wRatePath, 30, 6, 1);
                MessageBox.Show("Writing complete.");
            }

            else if(rdb_WeaponLevelRate.Checked)
            {
                foreach(TextBox tb in weaponLevelRateBoxes)
                    check100 += Convert.ToSingle(tb.Text);
                if(check100 != 100)
                {
                    MessageBox.Show("Error! Make sure all Fields add up to exactly 100.");
                    return;
                }
                writeBytes(weaponLevelRateBoxes.ToArray(), wLevelPath, 30, 6, 100);
                MessageBox.Show("Writing complete.");
            }

            else if(rdb_WeaponTagRate.Checked)
            {
                foreach (TextBox tb in weaponTagRateBoxes)
                    check100 += Convert.ToSingle(tb.Text);
                if (check100 != 100)
                {
                    MessageBox.Show("Error! Make sure all Fields add up to exactly 100.");
                    return;
                }
                writeBytes(weaponTagRateBoxes.ToArray(), wTagPath, 30, 6, 1);
                MessageBox.Show("Writing complete.");
            }

            else if(rdb_WeaponSlotRate.Checked)
            {
                foreach (TextBox tb in weaponSlotRateBoxes)
                    check100 += Convert.ToSingle(tb.Text);
                if (check100 != 100)
                {
                    MessageBox.Show("Error! Make sure all Fields add up to exactly 100.");
                    return;
                }
                writeBytes(weaponTagRateBoxes.ToArray(), wTagPath, 30, 6, 100);
                MessageBox.Show("Writing complete.");
            }
        }

        //######################## Player Data ###################################

        private void lbx_PlayerSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbx_PlayerSelect.SelectedIndex < 0)
            {
                MessageBox.Show("Select a Player!");
                return;
            }
            IEnumerable<TextBox> playerTalentBoxes = GetTextFields("playerTalent");
            readBytes(playerTalentBoxes.ToArray(), pTalentPath, 64 + (95 * lbx_PlayerSelect.SelectedIndex), 1, 100);
        }

        private void btn_ApplyPlayers_Click(object sender, EventArgs e)
        {
            IEnumerable<TextBox> playerTalentBoxes = GetTextFields("playerTalent");
            float tempFloat;
            foreach(TextBox tb in playerTalentBoxes)
            {
                if (!Single.TryParse(tb.Text, out tempFloat) || tb.Text.Contains('-'))
                {
                    MessageBox.Show("Input error!");
                    return;
                }
            }
            writeBytes(playerTalentBoxes.ToArray(), pTalentPath, 64 + (95 * lbx_PlayerSelect.SelectedIndex), 1, 100);
            MessageBox.Show("Writing complete.");
        }
    }
}
