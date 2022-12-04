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
        string Path;
        public frm_MainFrame(string p)
        {
            InitializeComponent();
            this.Path = p;
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
            }
            return tempTexts;
        }

        void PopulateFields()
        {
            IEnumerable<TextBox> weaponRateBoxes = GetTextFields("weaponRate");
            IEnumerable<TextBox> weaponLevelRateBoxes = GetTextFields("weaponLevelRate");
            IEnumerable<TextBox> weaponTagRateBoxes = GetTextFields("weaponTagRate");
            IEnumerable<TextBox> weaponSlotRateBoxes = GetTextFields("weaponSlotRate");
            byte[] getBytes = new byte[4];

            FileStream cFile = new FileStream(this.Path + "\\weaponRate.0A3E643B", FileMode.Open, FileAccess.Read);
            cFile.Position = 32;
            foreach (TextBox tb in weaponRateBoxes)
            {
                cFile.Read(getBytes, 0, 4);
                tb.Text = BitConverter.ToSingle(getBytes, 0).ToString();
                cFile.Position += 11;
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

        }

        //######################## Player Data ###################################

        private void lbx_PlayerSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbx_PlayerSelect.SelectedIndex < 0)
            {
                MessageBox.Show("Select a Player!");
                return;
            }
        }




        private void btn_ApplyPlayers_Click(object sender, EventArgs e)
        {

        }
    }
}
