namespace ImageGenerator
{
    partial class frmMain
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtIcon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerateIcon = new System.Windows.Forms.Button();
            this.btnSelectIcon = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerateImages = new System.Windows.Forms.Button();
            this.btnSelectDir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.cbxCustom = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtSingleHeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSingleWidth = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSingleImage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSingleGenerate = new System.Windows.Forms.Button();
            this.btnSingleSelect = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(389, 114);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtIcon);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btnGenerateIcon);
            this.tabPage2.Controls.Add(this.btnSelectIcon);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(381, 87);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Icon";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtIcon
            // 
            this.txtIcon.Location = new System.Drawing.Point(57, 32);
            this.txtIcon.Name = "txtIcon";
            this.txtIcon.ReadOnly = true;
            this.txtIcon.Size = new System.Drawing.Size(142, 22);
            this.txtIcon.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(20, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Icon:";
            // 
            // btnGenerateIcon
            // 
            this.btnGenerateIcon.Enabled = false;
            this.btnGenerateIcon.Location = new System.Drawing.Point(286, 32);
            this.btnGenerateIcon.Name = "btnGenerateIcon";
            this.btnGenerateIcon.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateIcon.TabIndex = 5;
            this.btnGenerateIcon.Text = "Generate";
            this.btnGenerateIcon.UseVisualStyleBackColor = true;
            this.btnGenerateIcon.Click += new System.EventHandler(this.btnGenerateIcon_Click);
            // 
            // btnSelectIcon
            // 
            this.btnSelectIcon.Location = new System.Drawing.Point(205, 32);
            this.btnSelectIcon.Name = "btnSelectIcon";
            this.btnSelectIcon.Size = new System.Drawing.Size(75, 23);
            this.btnSelectIcon.TabIndex = 4;
            this.btnSelectIcon.Text = "Select";
            this.btnSelectIcon.UseVisualStyleBackColor = true;
            this.btnSelectIcon.Click += new System.EventHandler(this.btnSelectIcon_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbxCustom);
            this.tabPage1.Controls.Add(this.txtHeight);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtWidth);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtDirectory);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnGenerateImages);
            this.tabPage1.Controls.Add(this.btnSelectDir);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(381, 87);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Images";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtDirectory
            // 
            this.txtDirectory.Location = new System.Drawing.Point(69, 13);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.ReadOnly = true;
            this.txtDirectory.Size = new System.Drawing.Size(142, 22);
            this.txtDirectory.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Directory:";
            // 
            // btnGenerateImages
            // 
            this.btnGenerateImages.Enabled = false;
            this.btnGenerateImages.Location = new System.Drawing.Point(298, 13);
            this.btnGenerateImages.Name = "btnGenerateImages";
            this.btnGenerateImages.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateImages.TabIndex = 1;
            this.btnGenerateImages.Text = "Generate";
            this.btnGenerateImages.UseVisualStyleBackColor = true;
            this.btnGenerateImages.Click += new System.EventHandler(this.btnGenerateImages_Click);
            // 
            // btnSelectDir
            // 
            this.btnSelectDir.Location = new System.Drawing.Point(217, 13);
            this.btnSelectDir.Name = "btnSelectDir";
            this.btnSelectDir.Size = new System.Drawing.Size(75, 23);
            this.btnSelectDir.TabIndex = 0;
            this.btnSelectDir.Text = "Select";
            this.btnSelectDir.UseVisualStyleBackColor = true;
            this.btnSelectDir.Click += new System.EventHandler(this.btnSelectDir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Retina Width:";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(196, 52);
            this.txtWidth.MaxLength = 5;
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(40, 22);
            this.txtWidth.TabIndex = 5;
            this.txtWidth.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Retina Height:";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(320, 52);
            this.txtHeight.MaxLength = 5;
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(40, 22);
            this.txtHeight.TabIndex = 7;
            this.txtHeight.Text = "100";
            // 
            // cbxCustom
            // 
            this.cbxCustom.AutoSize = true;
            this.cbxCustom.Checked = true;
            this.cbxCustom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxCustom.Location = new System.Drawing.Point(21, 55);
            this.cbxCustom.Name = "cbxCustom";
            this.cbxCustom.Size = new System.Drawing.Size(83, 16);
            this.cbxCustom.TabIndex = 8;
            this.cbxCustom.Text = "Custom Size";
            this.cbxCustom.UseVisualStyleBackColor = true;
            this.cbxCustom.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtSingleHeight);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.txtSingleWidth);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.txtSingleImage);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.btnSingleGenerate);
            this.tabPage3.Controls.Add(this.btnSingleSelect);
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(381, 87);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Image";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtSingleHeight
            // 
            this.txtSingleHeight.Location = new System.Drawing.Point(270, 52);
            this.txtSingleHeight.MaxLength = 5;
            this.txtSingleHeight.Name = "txtSingleHeight";
            this.txtSingleHeight.Size = new System.Drawing.Size(40, 22);
            this.txtSingleHeight.TabIndex = 15;
            this.txtSingleHeight.Text = "100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "Retina Height:";
            // 
            // txtSingleWidth
            // 
            this.txtSingleWidth.Location = new System.Drawing.Point(146, 52);
            this.txtSingleWidth.MaxLength = 5;
            this.txtSingleWidth.Name = "txtSingleWidth";
            this.txtSingleWidth.Size = new System.Drawing.Size(40, 22);
            this.txtSingleWidth.TabIndex = 13;
            this.txtSingleWidth.Text = "100";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "Retina Width:";
            // 
            // txtSingleImage
            // 
            this.txtSingleImage.Location = new System.Drawing.Point(69, 13);
            this.txtSingleImage.Name = "txtSingleImage";
            this.txtSingleImage.ReadOnly = true;
            this.txtSingleImage.Size = new System.Drawing.Size(142, 22);
            this.txtSingleImage.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("PMingLiU", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(8, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Image:";
            // 
            // btnSingleGenerate
            // 
            this.btnSingleGenerate.Enabled = false;
            this.btnSingleGenerate.Location = new System.Drawing.Point(298, 13);
            this.btnSingleGenerate.Name = "btnSingleGenerate";
            this.btnSingleGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnSingleGenerate.TabIndex = 9;
            this.btnSingleGenerate.Text = "Generate";
            this.btnSingleGenerate.UseVisualStyleBackColor = true;
            this.btnSingleGenerate.Click += new System.EventHandler(this.btnSingleGenerate_Click);
            // 
            // btnSingleSelect
            // 
            this.btnSingleSelect.Location = new System.Drawing.Point(217, 13);
            this.btnSingleSelect.Name = "btnSingleSelect";
            this.btnSingleSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSingleSelect.TabIndex = 8;
            this.btnSingleSelect.Text = "Select";
            this.btnSingleSelect.UseVisualStyleBackColor = true;
            this.btnSingleSelect.Click += new System.EventHandler(this.btnSingleSelect_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 117);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CloudBox Image Generator";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnSelectDir;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerateImages;
        private System.Windows.Forms.TextBox txtIcon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerateIcon;
        private System.Windows.Forms.Button btnSelectIcon;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbxCustom;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtSingleHeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSingleWidth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSingleImage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSingleGenerate;
        private System.Windows.Forms.Button btnSingleSelect;
    }
}

