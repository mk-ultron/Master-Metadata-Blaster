using System;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSelectFile = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnSelectFolder = new MaterialSkin.Controls.MaterialButton();
            this.txtMetadata = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.lstFiles = new MaterialSkin.Controls.MaterialListView();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.AutoSize = false;
            this.btnSelectFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelectFile.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSelectFile.Depth = 0;
            this.btnSelectFile.HighEmphasis = true;
            this.btnSelectFile.Icon = null;
            this.btnSelectFile.Location = new System.Drawing.Point(360, 96);
            this.btnSelectFile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSelectFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSelectFile.Size = new System.Drawing.Size(131, 36);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "Choose File";
            this.btnSelectFile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSelectFile.UseAccentColor = false;
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click_1);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(360, 150);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(69, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Metadata";
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelectFolder.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSelectFolder.Depth = 0;
            this.btnSelectFolder.HighEmphasis = true;
            this.btnSelectFolder.Icon = null;
            this.btnSelectFolder.Location = new System.Drawing.Point(55, 96);
            this.btnSelectFolder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSelectFolder.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSelectFolder.Size = new System.Drawing.Size(137, 36);
            this.btnSelectFolder.TabIndex = 6;
            this.btnSelectFolder.Text = "Choose Folder";
            this.btnSelectFolder.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSelectFolder.UseAccentColor = false;
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // txtMetadata
            // 
            this.txtMetadata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtMetadata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMetadata.Depth = 0;
            this.txtMetadata.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMetadata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtMetadata.Location = new System.Drawing.Point(360, 188);
            this.txtMetadata.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMetadata.Name = "txtMetadata";
            this.txtMetadata.Size = new System.Drawing.Size(368, 525);
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
            this.lstFiles.Size = new System.Drawing.Size(266, 525);
            this.lstFiles.TabIndex = 8;
            this.lstFiles.UseCompatibleStateImageBehavior = false;
            this.lstFiles.View = System.Windows.Forms.View.Details;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(55, 150);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(88, 19);
            this.materialLabel2.TabIndex = 9;
            this.materialLabel2.Text = "Folder Items";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(761, 150);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(56, 19);
            this.materialLabel3.TabIndex = 11;
            this.materialLabel3.Text = "Preview";
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBoxPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxPreview.Location = new System.Drawing.Point(764, 188);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(383, 525);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPreview.TabIndex = 10;
            this.pictureBoxPreview.TabStop = false;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1186, 787);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.pictureBoxPreview);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.lstFiles);
            this.Controls.Add(this.txtMetadata);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnSelectFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Master Metadata Blaster";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnSelectFile;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btnSelectFolder;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtMetadata;
        private MaterialSkin.Controls.MaterialListView lstFiles;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}

