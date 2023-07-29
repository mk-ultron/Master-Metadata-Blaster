using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin;
using MetadataExtractor;
using System.IO;
using MaterialSkin.Controls;
using System.Drawing;

// Michael Atkin
// 7/24/2023
// MS539 - Basic GUI and Exception Handling

// I estimate that this project will take me about 30-40 hours total
// ------------------------------------------------------------
// 7/17/2023 - 2 hrs: researched C# UI toolsets and found MaterialSkin, followed tutorial to add the controls to the Toolbox and experimented with adding different controls 

// 7/18/2023 - 2 hrs: researched different libraries for handling the metadata functions. Decided to use MetadataExtractor and started learning more about the classes I can use to accomplish my goal.

// 7/22/2023 - 3 hrs: Researched more about using System.IO classes to be able to add the ability to select either a file or a folder from the UI. Focused on adding event handlers for each button

// 7/23/2023 - 2 hrs: Got the project hooked up to github and learned how to do commit, push, and pull requests in practice. Wanted to have snapshots of my code as it was working in different states of progress

// 7/24/2023 - 2 hrs: mostly debugging errors in different places and getting everything somewhat functional for my incremental assignment submission

namespace Material_Design_Elements
{
    public partial class Form1 : MaterialForm
    {
        // A list to hold the file paths
        private List<string> filePaths = new List<string>();

        public Form1()
        {
            InitializeComponent();
            txtMetadata.ReadOnly = true;

            // Initialize MaterialSkinManager and add this form to its management
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            // Set the theme and color scheme for this material form
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            // Enable drag and drop for the PictureBox
            pictureBoxPreview.AllowDrop = true;

            // Register drag and drop event handlers
            pictureBoxPreview.DragEnter += new DragEventHandler(pictureBoxPreview_DragEnter);
            pictureBoxPreview.DragDrop += new DragEventHandler(pictureBoxPreview_DragDrop);
            pictureBoxPreview.DragLeave += new EventHandler(pictureBoxPreview_DragLeave);
        
    }

        // This event handler is triggered when the "Select File" button is clicked
        private void btnSelectFile_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            // Show the file dialog and check if a file was selected
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // If a file was selected, display its metadata
                DisplayFileMetadata(openFileDialog.FileName);
            }
        }

        // Handle the DragEnter event for PictureBox, allow dropping files, and change the border style
        private void pictureBoxPreview_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
                pictureBoxPreview.BorderStyle = BorderStyle.FixedSingle; // Change border style when a file is dragged over
            }
        }

        // Handle the DragDrop event for PictureBox, get the file path, and call DisplayFileMetadata
        private void pictureBoxPreview_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
            {
                string filePath = files[0];
                DisplayFileMetadata(filePath); // Call the method to display metadata and preview the image
            }
        }

        // Handle the DragLeave event for PictureBox, revert the border style to original
        private void pictureBoxPreview_DragLeave(object sender, EventArgs e)
        {
            pictureBoxPreview.BorderStyle = BorderStyle.None; // Restore to original style
        }

        // This method reads the metadata of the selected file, displays it in a TextBox, and also loads the image into a PictureBox, disposing of any previously loaded image.
        private void DisplayFileMetadata(string filePath)
        {
            try
            {
                // Dispose of the previous image if it exists
                if (pictureBoxPreview.Image != null)
                {
                    pictureBoxPreview.Image.Dispose();
                    pictureBoxPreview.Image = null;
                }

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

                // Load the new image into the PictureBox
                pictureBoxPreview.Image = new Bitmap(filePath);

                txtMetadata.Text += "---------------\r\n";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to get metadata for file {filePath}: " + ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (pictureBoxPreview.Image != null)
            {
                pictureBoxPreview.Image.Dispose();
            }
        }



        // This event handler is triggered when the "Select Folder" button is clicked
        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            // Show the folder dialog and check if a folder was selected
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                // Get all the files in the selected folder
                string[] files = System.IO.Directory.GetFiles(folderBrowserDialog.SelectedPath);
                foreach (string file in files)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    // Only add files with image extensions to the ListView
                    if (new[] { ".jpg", ".jpeg", ".png", ".gif", ".bmp" }.Contains(fileInfo.Extension.ToLower()))
                    {
                        // Create a new ListViewItem for each file
                        ListViewItem item = new ListViewItem(fileInfo.Name);
                        // Store the full file path in the Tag property
                        item.Tag = file;
                        lstFiles.Items.Add(item);
                    }
                }
            }
        }

        // This event handler is triggered when the selected item in the ListView is changed
        private void lstFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFiles.SelectedItems.Count > 0)
            {
                // Since only one item can be selected, take the first item from the SelectedItems collection
                var firstSelectedItem = lstFiles.SelectedItems[0];
                // Assuming you stored the full file path in the Tag property of the ListViewItem
                string filePath = firstSelectedItem.Tag.ToString();
                // Display the metadata for the selected file
                DisplayFileMetadata(filePath);
            }
        }
    }
}