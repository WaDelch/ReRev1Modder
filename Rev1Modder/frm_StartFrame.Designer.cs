namespace Rev1Modder
{
    partial class frm_StartFrame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_StartFrame));
            this.lbl_Rev1Modder = new System.Windows.Forms.Label();
            this.txt_Path = new System.Windows.Forms.TextBox();
            this.btn_Path = new System.Windows.Forms.Button();
            this.lbl_Path = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Rev1Modder
            // 
            this.lbl_Rev1Modder.AutoSize = true;
            this.lbl_Rev1Modder.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rev1Modder.Location = new System.Drawing.Point(15, 7);
            this.lbl_Rev1Modder.Name = "lbl_Rev1Modder";
            this.lbl_Rev1Modder.Size = new System.Drawing.Size(502, 29);
            this.lbl_Rev1Modder.TabIndex = 0;
            this.lbl_Rev1Modder.Text = "Resident Evil Revelations 1 Modding Tool";
            // 
            // txt_Path
            // 
            this.txt_Path.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Path.Location = new System.Drawing.Point(21, 84);
            this.txt_Path.Name = "txt_Path";
            this.txt_Path.Size = new System.Drawing.Size(499, 22);
            this.txt_Path.TabIndex = 1;
            this.txt_Path.Text = "C:\\Users\\Waldemar Delchmann\\Desktop\\myVer\\coop_table\\game\\coop_table";
            // 
            // btn_Path
            // 
            this.btn_Path.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Path.BackgroundImage")));
            this.btn_Path.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Path.Location = new System.Drawing.Point(526, 80);
            this.btn_Path.Name = "btn_Path";
            this.btn_Path.Size = new System.Drawing.Size(34, 31);
            this.btn_Path.TabIndex = 5;
            this.btn_Path.UseVisualStyleBackColor = true;
            this.btn_Path.Click += new System.EventHandler(this.btn_Path_Click);
            // 
            // lbl_Path
            // 
            this.lbl_Path.AutoSize = true;
            this.lbl_Path.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Path.Location = new System.Drawing.Point(18, 65);
            this.lbl_Path.Name = "lbl_Path";
            this.lbl_Path.Size = new System.Drawing.Size(278, 16);
            this.lbl_Path.TabIndex = 6;
            this.lbl_Path.Text = "Select the (uncompressed!) coop_table folder";
            // 
            // btn_Start
            // 
            this.btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.Location = new System.Drawing.Point(21, 121);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(121, 40);
            this.btn_Start.TabIndex = 7;
            this.btn_Start.Text = "Start Modding";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // frm_StartFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 175);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.lbl_Path);
            this.Controls.Add(this.btn_Path);
            this.Controls.Add(this.txt_Path);
            this.Controls.Add(this.lbl_Rev1Modder);
            this.Name = "frm_StartFrame";
            this.Text = "RE Rev1 Modder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Rev1Modder;
        private System.Windows.Forms.TextBox txt_Path;
        private System.Windows.Forms.Button btn_Path;
        private System.Windows.Forms.Label lbl_Path;
        private System.Windows.Forms.Button btn_Start;
    }
}