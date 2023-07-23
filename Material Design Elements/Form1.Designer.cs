namespace Material_Design_Elements
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
            this.btnSelectFile = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRadioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnSelectFolder = new MaterialSkin.Controls.MaterialButton();
            this.txtMetadata = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.lstFiles = new MaterialSkin.Controls.MaterialListView();
            this.SuspendLayout();
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.AutoSize = false;
            this.btnSelectFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelectFile.Depth = 0;
            this.btnSelectFile.DrawShadows = true;
            this.btnSelectFile.HighEmphasis = true;
            this.btnSelectFile.Icon = null;
            this.btnSelectFile.Location = new System.Drawing.Point(23, 85);
            this.btnSelectFile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSelectFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(131, 36);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "Browse File";
            this.btnSelectFile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSelectFile.UseAccentColor = false;
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click_1);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(354, 77);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(326, 47);
            this.materialCard1.TabIndex = 1;
            // 
            // materialCheckbox1
            // 
            this.materialCheckbox1.AutoSize = true;
            this.materialCheckbox1.Depth = 0;
            this.materialCheckbox1.Location = new System.Drawing.Point(55, 141);
            this.materialCheckbox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox1.Name = "materialCheckbox1";
            this.materialCheckbox1.Ripple = true;
            this.materialCheckbox1.Size = new System.Drawing.Size(171, 37);
            this.materialCheckbox1.TabIndex = 2;
            this.materialCheckbox1.Text = "materialCheckbox1";
            this.materialCheckbox1.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(461, 150);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(107, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "materialLabel1";
            // 
            // materialRadioButton1
            // 
            this.materialRadioButton1.AutoSize = true;
            this.materialRadioButton1.Depth = 0;
            this.materialRadioButton1.Location = new System.Drawing.Point(694, 85);
            this.materialRadioButton1.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton1.Name = "materialRadioButton1";
            this.materialRadioButton1.Ripple = true;
            this.materialRadioButton1.Size = new System.Drawing.Size(190, 37);
            this.materialRadioButton1.TabIndex = 4;
            this.materialRadioButton1.TabStop = true;
            this.materialRadioButton1.Text = "materialRadioButton1";
            this.materialRadioButton1.UseVisualStyleBackColor = true;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelectFolder.Depth = 0;
            this.btnSelectFolder.DrawShadows = true;
            this.btnSelectFolder.HighEmphasis = true;
            this.btnSelectFolder.Icon = null;
            this.btnSelectFolder.Location = new System.Drawing.Point(198, 85);
            this.btnSelectFolder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSelectFolder.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(138, 36);
            this.btnSelectFolder.TabIndex = 6;
            this.btnSelectFolder.Text = "Browse Folder";
            this.btnSelectFolder.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSelectFolder.UseAccentColor = false;
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // txtMetadata
            // 
            this.txtMetadata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtMetadata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMetadata.Depth = 0;
            this.txtMetadata.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMetadata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtMetadata.Hint = "";
            this.txtMetadata.Location = new System.Drawing.Point(464, 188);
            this.txtMetadata.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMetadata.Name = "txtMetadata";
            this.txtMetadata.Size = new System.Drawing.Size(420, 525);
            this.txtMetadata.TabIndex = 7;
            this.txtMetadata.Text = "";
            // 
            // lstFiles
            // 
            this.lstFiles.AutoSizeTable = false;
            this.lstFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lstFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstFiles.Depth = 0;
            this.lstFiles.FullRowSelect = true;
            this.lstFiles.HideSelection = false;
            this.lstFiles.Location = new System.Drawing.Point(55, 188);
            this.lstFiles.MinimumSize = new System.Drawing.Size(200, 100);
            this.lstFiles.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lstFiles.MouseState = MaterialSkin.MouseState.OUT;
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.OwnerDraw = true;
            this.lstFiles.Size = new System.Drawing.Size(385, 525);
            this.lstFiles.TabIndex = 8;
            this.lstFiles.UseCompatibleStateImageBehavior = false;
            this.lstFiles.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 787);
            this.Controls.Add(this.lstFiles);
            this.Controls.Add(this.txtMetadata);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.materialRadioButton1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialCheckbox1);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.btnSelectFile);
            this.Name = "Form1";
            this.Text = "Master Metadata Blaster";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnSelectFile;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
        private MaterialSkin.Controls.MaterialButton btnSelectFolder;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtMetadata;
        private MaterialSkin.Controls.MaterialListView lstFiles;
    }
}

