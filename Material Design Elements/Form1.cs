using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using Material_Design_Elements;
using MaterialSkin.Controls;
using MetadataExtractor;
using System.IO;
using MetadataExtractor.Formats.Exif;

namespace Material_Design_Elements
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }



        private void DisplayFileMetadata(string filePath)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(filePath);

                txtMetadata.Text = $"File Name: {fileInfo.Name}\r\n";
                txtMetadata.Text += $"File Format: {fileInfo.Extension}\r\n";
                txtMetadata.Text += $"File Size: {fileInfo.Length} bytes\r\n";

                // Reading metadata using MetadataExtractor
                var directories = ImageMetadataReader.ReadMetadata(filePath);
                foreach (var directory in directories)
                {
                    foreach (var tag in directory.Tags)
                    {
                        txtMetadata.Text += $"{directory.Name} - {tag.Name} = {tag.Description}\r\n";
                    }
                    if (directory.HasError)
                    {
                        foreach (var error in directory.Errors)
                            Console.WriteLine($"ERROR: {error}");
                    }
                }

                txtMetadata.Text += "---------------\r\n";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to get metadata for file {filePath}: " + ex.Message);
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSelectFile_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                DisplayFileMetadata(openFileDialog.FileName);
            }
        }
    }
}
