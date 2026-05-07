namespace PWAConverterApp
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGeneratePWA = new System.Windows.Forms.Button();
            this.btnBrowseHtml = new System.Windows.Forms.Button();
            this.txtHtmlPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowseIcon = new System.Windows.Forms.Button();
            this.txtIconPath = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtThemeColor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBackgroundColor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDisplay = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStartUrl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtShortName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAppName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnModifyPWA = new System.Windows.Forms.Button();
            this.btnBrowseExistingPWA = new System.Windows.Forms.Button();
            this.txtExistingPwaPath = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.verticalLabel1 = new PWA_Converter_App.VerticalLabel();
            this.tvPWAfolder = new System.Windows.Forms.TreeView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbService = new System.Windows.Forms.ComboBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGeneratePWA);
            this.groupBox1.Controls.Add(this.btnBrowseHtml);
            this.groupBox1.Controls.Add(this.txtHtmlPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 380);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(964, 111);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generate New PWA";
            // 
            // btnGeneratePWA
            // 
            this.btnGeneratePWA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnGeneratePWA.FlatAppearance.BorderSize = 0;
            this.btnGeneratePWA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneratePWA.ForeColor = System.Drawing.Color.White;
            this.btnGeneratePWA.Location = new System.Drawing.Point(140, 65);
            this.btnGeneratePWA.Name = "btnGeneratePWA";
            this.btnGeneratePWA.Size = new System.Drawing.Size(800, 35);
            this.btnGeneratePWA.TabIndex = 18;
            this.btnGeneratePWA.Text = "Generate PWA";
            this.btnGeneratePWA.UseVisualStyleBackColor = false;
            this.btnGeneratePWA.Click += new System.EventHandler(this.btnGeneratePWA_Click);
            // 
            // btnBrowseHtml
            // 
            this.btnBrowseHtml.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseHtml.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBrowseHtml.Location = new System.Drawing.Point(812, 25);
            this.btnBrowseHtml.Name = "btnBrowseHtml";
            this.btnBrowseHtml.Size = new System.Drawing.Size(128, 25);
            this.btnBrowseHtml.TabIndex = 2;
            this.btnBrowseHtml.Text = "Browse...";
            this.btnBrowseHtml.UseVisualStyleBackColor = true;
            this.btnBrowseHtml.Click += new System.EventHandler(this.btnBrowseHtml_Click);
            // 
            // txtHtmlPath
            // 
            this.txtHtmlPath.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHtmlPath.Location = new System.Drawing.Point(140, 25);
            this.txtHtmlPath.Name = "txtHtmlPath";
            this.txtHtmlPath.ReadOnly = true;
            this.txtHtmlPath.Size = new System.Drawing.Size(666, 25);
            this.txtHtmlPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "HTML File:";
            // 
            // btnBrowseIcon
            // 
            this.btnBrowseIcon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseIcon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBrowseIcon.Location = new System.Drawing.Point(460, 240);
            this.btnBrowseIcon.Name = "btnBrowseIcon";
            this.btnBrowseIcon.Size = new System.Drawing.Size(80, 25);
            this.btnBrowseIcon.TabIndex = 17;
            this.btnBrowseIcon.Text = "Browse...";
            this.btnBrowseIcon.UseVisualStyleBackColor = true;
            this.btnBrowseIcon.Click += new System.EventHandler(this.btnBrowseIcon_Click);
            // 
            // txtIconPath
            // 
            this.txtIconPath.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIconPath.Location = new System.Drawing.Point(140, 240);
            this.txtIconPath.Name = "txtIconPath";
            this.txtIconPath.ReadOnly = true;
            this.txtIconPath.Size = new System.Drawing.Size(310, 25);
            this.txtIconPath.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Icon Path:";
            // 
            // txtThemeColor
            // 
            this.txtThemeColor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThemeColor.Location = new System.Drawing.Point(696, 86);
            this.txtThemeColor.Name = "txtThemeColor";
            this.txtThemeColor.Size = new System.Drawing.Size(252, 25);
            this.txtThemeColor.TabIndex = 14;
            this.txtThemeColor.Text = "#000000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(576, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Theme Color:";
            // 
            // txtBackgroundColor
            // 
            this.txtBackgroundColor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBackgroundColor.Location = new System.Drawing.Point(696, 35);
            this.txtBackgroundColor.Name = "txtBackgroundColor";
            this.txtBackgroundColor.Size = new System.Drawing.Size(252, 25);
            this.txtBackgroundColor.TabIndex = 12;
            this.txtBackgroundColor.Text = "#ffffff";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(576, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Background Color:";
            // 
            // cmbDisplay
            // 
            this.cmbDisplay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDisplay.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDisplay.FormattingEnabled = true;
            this.cmbDisplay.Items.AddRange(new object[] {
            "standalone",
            "fullscreen",
            "minimal-ui",
            "browser"});
            this.cmbDisplay.Location = new System.Drawing.Point(140, 188);
            this.cmbDisplay.Name = "cmbDisplay";
            this.cmbDisplay.Size = new System.Drawing.Size(400, 25);
            this.cmbDisplay.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Display Mode:";
            // 
            // txtStartUrl
            // 
            this.txtStartUrl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartUrl.Location = new System.Drawing.Point(140, 137);
            this.txtStartUrl.Name = "txtStartUrl";
            this.txtStartUrl.Size = new System.Drawing.Size(400, 25);
            this.txtStartUrl.TabIndex = 8;
            this.txtStartUrl.Text = "./index.html";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Start URL:";
            // 
            // txtShortName
            // 
            this.txtShortName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShortName.Location = new System.Drawing.Point(140, 86);
            this.txtShortName.Name = "txtShortName";
            this.txtShortName.Size = new System.Drawing.Size(400, 25);
            this.txtShortName.TabIndex = 6;
            this.txtShortName.Text = "MyPWA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Short Name:";
            // 
            // txtAppName
            // 
            this.txtAppName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppName.Location = new System.Drawing.Point(140, 35);
            this.txtAppName.Name = "txtAppName";
            this.txtAppName.Size = new System.Drawing.Size(400, 25);
            this.txtAppName.TabIndex = 4;
            this.txtAppName.Text = "My PWA App";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "App Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnModifyPWA);
            this.groupBox2.Controls.Add(this.btnBrowseExistingPWA);
            this.groupBox2.Controls.Add(this.txtExistingPwaPath);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 380);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(964, 111);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modify Existing PWA";
            this.groupBox2.Visible = false;
            // 
            // btnModifyPWA
            // 
            this.btnModifyPWA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnModifyPWA.FlatAppearance.BorderSize = 0;
            this.btnModifyPWA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyPWA.ForeColor = System.Drawing.Color.White;
            this.btnModifyPWA.Location = new System.Drawing.Point(140, 65);
            this.btnModifyPWA.Name = "btnModifyPWA";
            this.btnModifyPWA.Size = new System.Drawing.Size(800, 35);
            this.btnModifyPWA.TabIndex = 19;
            this.btnModifyPWA.Text = "Modify PWA";
            this.btnModifyPWA.UseVisualStyleBackColor = false;
            this.btnModifyPWA.Click += new System.EventHandler(this.btnModifyPWA_Click);
            // 
            // btnBrowseExistingPWA
            // 
            this.btnBrowseExistingPWA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseExistingPWA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBrowseExistingPWA.Location = new System.Drawing.Point(812, 25);
            this.btnBrowseExistingPWA.Name = "btnBrowseExistingPWA";
            this.btnBrowseExistingPWA.Size = new System.Drawing.Size(128, 25);
            this.btnBrowseExistingPWA.TabIndex = 5;
            this.btnBrowseExistingPWA.Text = "Browse...";
            this.btnBrowseExistingPWA.UseVisualStyleBackColor = true;
            this.btnBrowseExistingPWA.Click += new System.EventHandler(this.btnBrowseExistingPWA_Click);
            // 
            // txtExistingPwaPath
            // 
            this.txtExistingPwaPath.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExistingPwaPath.Location = new System.Drawing.Point(140, 25);
            this.txtExistingPwaPath.Name = "txtExistingPwaPath";
            this.txtExistingPwaPath.ReadOnly = true;
            this.txtExistingPwaPath.Size = new System.Drawing.Size(666, 25);
            this.txtExistingPwaPath.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "PWA Folder:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.verticalLabel1);
            this.groupBox3.Controls.Add(this.tvPWAfolder);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cmbService);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.txtAppName);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnBrowseIcon);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cmbDisplay);
            this.groupBox3.Controls.Add(this.txtThemeColor);
            this.groupBox3.Controls.Add(this.txtStartUrl);
            this.groupBox3.Controls.Add(this.txtShortName);
            this.groupBox3.Controls.Add(this.txtIconPath);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtBackgroundColor);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(964, 362);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "General info for PWA";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter_1);
            // 
            // verticalLabel1
            // 
            this.verticalLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.verticalLabel1.Flip = false;
            this.verticalLabel1.Location = new System.Drawing.Point(925, 136);
            this.verticalLabel1.Name = "verticalLabel1";
            this.verticalLabel1.Size = new System.Drawing.Size(23, 203);
            this.verticalLabel1.TabIndex = 25;
            this.verticalLabel1.Text = "Folder Tree View";
            // 
            // tvPWAfolder
            // 
            this.tvPWAfolder.Location = new System.Drawing.Point(579, 137);
            this.tvPWAfolder.Name = "tvPWAfolder";
            this.tvPWAfolder.Size = new System.Drawing.Size(346, 201);
            this.tvPWAfolder.TabIndex = 24;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PWA_Converter_App.Properties.Resources.remove;
            this.pictureBox2.Location = new System.Drawing.Point(508, 286);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PWA_Converter_App.Properties.Resources.add;
            this.pictureBox1.Location = new System.Drawing.Point(462, 287);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 294);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Service Worker:";
            // 
            // cmbService
            // 
            this.cmbService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbService.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbService.FormattingEnabled = true;
            this.cmbService.Items.AddRange(new object[] {
            "index.html",
            "manifest.json",
            "icons/icon-192x192.png",
            "icons/icon-512x512.png"});
            this.cmbService.Location = new System.Drawing.Point(140, 291);
            this.cmbService.Name = "cmbService";
            this.cmbService.Size = new System.Drawing.Size(310, 25);
            this.cmbService.TabIndex = 21;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(97, 335);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(70, 21);
            this.radioButton2.TabIndex = 19;
            this.radioButton2.Text = "Modify";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 335);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 21);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Generate ";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(984, 500);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PWA Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBrowseHtml;
        private System.Windows.Forms.TextBox txtHtmlPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAppName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtShortName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStartUrl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDisplay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBackgroundColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtThemeColor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBrowseIcon;
        private System.Windows.Forms.TextBox txtIconPath;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGeneratePWA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnModifyPWA;
        private System.Windows.Forms.Button btnBrowseExistingPWA;
        private System.Windows.Forms.TextBox txtExistingPwaPath;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbService;
        private System.Windows.Forms.TreeView tvPWAfolder;
        private PWA_Converter_App.VerticalLabel verticalLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
