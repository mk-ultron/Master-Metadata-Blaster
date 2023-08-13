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
            this.btnSelectFolder = new MaterialSkin.Controls.MaterialButton();
            this.lstFiles = new MaterialSkin.Controls.MaterialListView();
            this.rtbMetadata = new System.Windows.Forms.RichTextBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.linkLabelGitHub = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkTogglePreview = new MaterialSkin.Controls.MaterialSwitch();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.AutoSize = false;
            this.btnSelectFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelectFile.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSelectFile.Depth = 0;
            this.btnSelectFile.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFile.HighEmphasis = true;
            this.btnSelectFile.Icon = null;
            this.btnSelectFile.Location = new System.Drawing.Point(458, 92);
            this.btnSelectFile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSelectFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSelectFile.Size = new System.Drawing.Size(191, 45);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "Choose File";
            this.btnSelectFile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSelectFile.UseAccentColor = false;
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click_1);
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.AutoSize = false;
            this.btnSelectFolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelectFolder.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSelectFolder.Depth = 0;
            this.btnSelectFolder.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFolder.HighEmphasis = true;
            this.btnSelectFolder.Icon = null;
            this.btnSelectFolder.Location = new System.Drawing.Point(30, 92);
            this.btnSelectFolder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSelectFolder.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSelectFolder.Size = new System.Drawing.Size(191, 45);
            this.btnSelectFolder.TabIndex = 6;
            this.btnSelectFolder.Text = "Choose Folder";
            this.btnSelectFolder.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSelectFolder.UseAccentColor = false;
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // lstFiles
            // 
            this.lstFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstFiles.AutoSizeTable = false;
            this.lstFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lstFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstFiles.Depth = 0;
            this.lstFiles.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFiles.FullRowSelect = true;
            this.lstFiles.HideSelection = false;
            this.lstFiles.Location = new System.Drawing.Point(30, 193);
            this.lstFiles.MinimumSize = new System.Drawing.Size(200, 100);
            this.lstFiles.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lstFiles.MouseState = MaterialSkin.MouseState.OUT;
            this.lstFiles.MultiSelect = false;
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.OwnerDraw = true;
            this.lstFiles.Size = new System.Drawing.Size(400, 499);
            this.lstFiles.TabIndex = 8;
            this.lstFiles.UseCompatibleStateImageBehavior = false;
            this.lstFiles.View = System.Windows.Forms.View.Details;
            this.lstFiles.SelectedIndexChanged += new System.EventHandler(this.lstFiles_SelectedIndexChanged);
            // 
            // rtbMetadata
            // 
            this.rtbMetadata.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rtbMetadata.BackColor = System.Drawing.Color.White;
            this.rtbMetadata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbMetadata.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbMetadata.Location = new System.Drawing.Point(458, 193);
            this.rtbMetadata.Name = "rtbMetadata";
            this.rtbMetadata.Size = new System.Drawing.Size(400, 499);
            this.rtbMetadata.TabIndex = 12;
            this.rtbMetadata.Text = "";
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.pictureBox1);
            this.materialCard1.Controls.Add(this.linkLabelGitHub);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(1151, 723);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MaximumSize = new System.Drawing.Size(200, 50);
            this.materialCard1.MinimumSize = new System.Drawing.Size(200, 50);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(200, 50);
            this.materialCard1.TabIndex = 13;
            // 
            // linkLabelGitHub
            // 
            this.linkLabelGitHub.AutoSize = true;
            this.linkLabelGitHub.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelGitHub.LinkColor = System.Drawing.Color.Gray;
            this.linkLabelGitHub.Location = new System.Drawing.Point(75, 11);
            this.linkLabelGitHub.Name = "linkLabelGitHub";
            this.linkLabelGitHub.Size = new System.Drawing.Size(67, 25);
            this.linkLabelGitHub.TabIndex = 0;
            this.linkLabelGitHub.TabStop = true;
            this.linkLabelGitHub.Text = "github";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "folder items";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(460, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "metadata";
            // 
            // chkTogglePreview
            // 
            this.chkTogglePreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTogglePreview.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkTogglePreview.AutoSize = true;
            this.chkTogglePreview.Checked = true;
            this.chkTogglePreview.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTogglePreview.Depth = 0;
            this.chkTogglePreview.Location = new System.Drawing.Point(886, 143);
            this.chkTogglePreview.Margin = new System.Windows.Forms.Padding(0);
            this.chkTogglePreview.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkTogglePreview.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkTogglePreview.Name = "chkTogglePreview";
            this.chkTogglePreview.Ripple = true;
            this.chkTogglePreview.Size = new System.Drawing.Size(160, 37);
            this.chkTogglePreview.TabIndex = 17;
            this.chkTogglePreview.Text = "image preview";
            this.chkTogglePreview.UseVisualStyleBackColor = true;
            this.chkTogglePreview.CheckedChanged += new System.EventHandler(this.chkTogglePreview_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Material_Design_Elements.Properties.Resources.NameLogo75D;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(148, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxPreview.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxPreview.BackgroundImage = global::Material_Design_Elements.Properties.Resources.drag_and_drop21;
            this.pictureBoxPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxPreview.Location = new System.Drawing.Point(886, 193);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(465, 499);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPreview.TabIndex = 10;
            this.pictureBoxPreview.TabStop = false;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1386, 804);
            this.Controls.Add(this.chkTogglePreview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.rtbMetadata);
            this.Controls.Add(this.pictureBoxPreview);
            this.Controls.Add(this.lstFiles);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.btnSelectFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1386, 804);
            this.Name = "Form1";
            this.Text = "Master Metadata Blaster";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnSelectFile;
        private MaterialSkin.Controls.MaterialButton btnSelectFolder;
        private MaterialSkin.Controls.MaterialListView lstFiles;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.RichTextBox rtbMetadata;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.LinkLabel linkLabelGitHub;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSwitch chkTogglePreview;
    }
}

