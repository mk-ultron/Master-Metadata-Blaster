﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin;
using MetadataExtractor;
using System.IO;
using MaterialSkin.Controls;
using System.Drawing;

// Michael Atkin
// ------------------------------------------------------------
// 7/17/2023 - 2 hrs: researched C# UI toolsets and found MaterialSkin, followed tutorial to add the controls to the Toolbox and experimented with adding different controls 
// 7/18/2023 - 2 hrs: researched different libraries for handling the metadata functions. Decided to use MetadataExtractor and started learning more about the classes I can use to accomplish my goal.
// 7/22/2023 - 3 hrs: Researched more about using System.IO classes to be able to add the ability to select either a file or a folder from the UI. Focused on adding event handlers for each button
// 7/24/2023 - 2 hrs: mostly debugging errors in different places and getting everything somewhat functional for my incremental assignment submission
// 7/26/2023 - 3 hrs: added the preview image box, researched event handling for drag and drop. debugged
// 7/28/2023 - 2 hrs: implemented drag and drop behavior, updated displayMetadata method to dispose of previously loaded image when selecting another one, and to do disposal when the form is closed
// 7/29/2023 - 1 hr: additional debugging, tried to add background image for picture preview but couldn't get it how I wanted. added comments and submitted incremental progress update
// 8/10/2023 - 4 hours: researching and debugging how to get the folder select pane to populate items and display their metadata. I had to add code to clear the ListView before adding items, print out every image file path you attempt to add to the list to ensure the paths are correct and the files exists, add explicit redrawing, and check the ListViewItem creation and ListView properties to figure it out. After I got the list of folder items to finally display I had to figure out why the metadata list wasn't populating when I selected an item. I eventually found that the event wasn't correctly bound to the event handler method.
// 8/12/2023 - 3 hours: improving the UI, replaced the regular text box with a rich text box control so I can add more formatting to the metadata.

namespace Material_Design_Elements
{
    public partial class Form1 : MaterialForm
    {
        // A list to hold the file paths
        private List<string> filePaths = new List<string>();

        public Form1()
        {
            InitializeComponent();
            rtbMetadata.ReadOnly = true;

            // Initialize MaterialSkinManager and add this form to its management
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
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

            linkLabelGitHub.Text = "github";

            linkLabelGitHub.LinkClicked += (sender, e) =>
            {
                System.Diagnostics.Process.Start("https://github.com/mk-ultron/");
            };
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

                // Now, clear the background image of the pictureBoxPreview
                pictureBoxPreview.BackgroundImage = null;
            }
        }

        // Handle the DragLeave event for PictureBox, revert the border style to original
        private void pictureBoxPreview_DragLeave(object sender, EventArgs e)
        {
            pictureBoxPreview.BorderStyle = BorderStyle.None; // Restore to original style
        }

        private void chkTogglePreview_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTogglePreview.Checked)
            {
                pictureBoxPreview.Visible = true; // Show the picture box
            }
            else
            {
                pictureBoxPreview.Visible = false; // Hide the picture box
            }
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

                rtbMetadata.Clear();

                AppendBoldText("File Name: ");
                rtbMetadata.AppendText($"{fileInfo.Name}\r\n");

                AppendBoldText("File Format: ");
                rtbMetadata.AppendText($"{fileInfo.Extension}\r\n");

                long fileSizeInBytes = fileInfo.Length;
                double fileSizeInKB = fileSizeInBytes / 1024.0;
                double fileSizeInMB = fileSizeInKB / 1024.0;

                AppendBoldText("File Size: ");
                if (fileSizeInKB < 1000)
                {
                    rtbMetadata.AppendText($"{fileSizeInKB:F2} KB\r\n");
                }
                else
                {
                    rtbMetadata.AppendText($"{fileSizeInMB:F2} MB\r\n");
                }

                //Using a HashSet to keep track of metadata entries we've already added to the RichTextBox.By maintaining the seenMetadata HashSet and using it to filter out duplicates, we ensure that each metadata entry appears only once in the results.
                HashSet<string> seenMetadata = new HashSet<string>();
                List<string> nonPriorityMetadata = new List<string>();

                // Define a priority order for metadata tags
                List<string> priorityMetadataOrder = new List<string>
                {
                    "File - File Modified Date",
                    "Date/Time Original"
                };

                // Reading metadata using MetadataExtractor
                var directories = ImageMetadataReader.ReadMetadata(filePath);
                foreach (var directory in directories)
                {
                    foreach (var tag in directory.Tags)
                    {
                        string metadataInfo = $"{directory.Name} - {tag.Name} = {tag.Description}";

                        // Check if the tag information matches priority order based on combined directory and tag name
                        if (priorityMetadataOrder.Contains($"{directory.Name} - {tag.Name}") && !seenMetadata.Contains(metadataInfo))
                        {
                            rtbMetadata.AppendText(metadataInfo + "\r\n");
                            seenMetadata.Add(metadataInfo);
                        }
                        // Otherwise, save it for later
                        else if (!seenMetadata.Contains(metadataInfo))
                        {
                            nonPriorityMetadata.Add(metadataInfo);
                            seenMetadata.Add(metadataInfo);
                        }
                    }

                    if (directory.HasError)
                    {
                        foreach (var error in directory.Errors)
                            Console.WriteLine($"ERROR: {error}");
                    }
                }

                // Now, add non-priority metadata to the display
                foreach (string metadataInfo in nonPriorityMetadata)
                {
                    rtbMetadata.AppendText(metadataInfo + "\r\n");
                }

                // Load the image into the PictureBox
                pictureBoxPreview.Image = new Bitmap(filePath);

                rtbMetadata.AppendText("---------------\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to get metadata for file {filePath}: " + ex.Message);
            }
        }


        //This method is a helper function that appends bold text to the RichTextBox. It calculates the positions at which to start and end the bolding based on the length of the text being added.
        private void AppendBoldText(string text)
        {
            int start = rtbMetadata.TextLength;
            rtbMetadata.AppendText(text);
            int end = rtbMetadata.TextLength;

            rtbMetadata.Select(start, end - start);
            rtbMetadata.SelectionFont = new Font(rtbMetadata.Font, FontStyle.Bold);
            rtbMetadata.SelectionLength = 0; // clear selection
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (pictureBoxPreview.Image != null)
            {
                pictureBoxPreview.Image.Dispose();
            }
        }

        private void LoadImageIntoPictureBox(string imagePath)
        {
            // Assuming you're loading an image like this
            pictureBoxPreview.Image = Image.FromFile(imagePath);

            // Now, clear the background image
            pictureBoxPreview.BackgroundImage = null;
        }

        // This event handler is triggered when the "Select Folder" button is clicked
        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            // Show the folder dialog and check if a folder was selected
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                // Clear the ListView before adding new items
                lstFiles.Items.Clear();

                // Ensure there's a column in the ListView for details view
                if (lstFiles.Columns.Count == 0)
                {
                    lstFiles.Columns.Add("File Name", -2, HorizontalAlignment.Left);
                }

                lstFiles.View = View.Details;  // Set the view to show details
                lstFiles.FullRowSelect = true; // Select the item and subitems when selection is made

                // Suspend drawing
                lstFiles.BeginUpdate();

                // Get all the files in the selected folder
                string[] files = System.IO.Directory.GetFiles(folderBrowserDialog.SelectedPath);
                foreach (string file in files)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    // Only add files with image extensions to the ListView
                    if (new[] { ".jpg", ".jpeg", ".png", ".gif", ".bmp" }.Contains(fileInfo.Extension.ToLower()))
                    {
                        Console.WriteLine($"Adding to ListView: {file}");
                        if (!File.Exists(file))
                        {
                            Console.WriteLine($"Error: File does not exist - {file}");
                            continue; // Skip adding this file
                        }

                        // Create a new ListViewItem for each file
                        ListViewItem item = new ListViewItem();
                        item.Text = fileInfo.Name;  // Set the text explicitly
                                                    // Store the full file path in the Tag property
                        item.Tag = file;
                        lstFiles.Items.Add(item);
                    }
                    else
                    {
                        Console.WriteLine($"Skipped: {fileInfo.Name}");
                    }
                }

                // Resume drawing
                lstFiles.EndUpdate();
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


        private void lstFiles_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
