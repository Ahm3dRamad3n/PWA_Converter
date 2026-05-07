using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.Windows.Forms;
using PWA_Converter_App.Properties;

namespace PWAConverterApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeCustomStyles();
            InitializeDependencyInjection();
        }

        private void InitializeCustomStyles()
        {
            // Apply modern styles to standard controls
            this.BackColor = Color.FromArgb(44, 62, 80); // Dark background for the form
            this.Text = "PWA Converter";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

            // GroupBox styling
            ApplyGroupBoxStyle(groupBox1);
            ApplyGroupBoxStyle(groupBox2);
            ApplyGroupBoxStyle(groupBox3);

            // Label styling
            ApplyLabelStyle(label1);
            ApplyLabelStyle(label2);
            ApplyLabelStyle(label3);
            ApplyLabelStyle(label4);
            ApplyLabelStyle(label5);
            ApplyLabelStyle(label6);
            ApplyLabelStyle(label7);
            ApplyLabelStyle(label8);
            ApplyLabelStyle(label9);
            ApplyLabelStyle(label10);

            // TextBox styling
            ApplyTextBoxStyle(txtHtmlPath);
            ApplyTextBoxStyle(txtAppName);
            ApplyTextBoxStyle(txtShortName);
            ApplyTextBoxStyle(txtStartUrl);
            ApplyTextBoxStyle(txtBackgroundColor);
            ApplyTextBoxStyle(txtThemeColor);
            ApplyTextBoxStyle(txtIconPath);
            ApplyTextBoxStyle(txtExistingPwaPath);

            // ComboBox styling
            cmbDisplay.BackColor = Color.FromArgb(236, 240, 241);
            cmbDisplay.ForeColor = Color.FromArgb(52, 73, 94);
            cmbDisplay.FlatStyle = FlatStyle.Flat;
            cmbDisplay.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            cmbDisplay.SelectedIndex = 0; // Default to standalone

            // Button styling is already set in Designer.cs for flat appearance and colors
        }

        private void InitializeDependencyInjection()
        {
            string path = Path.Combine(Path.GetTempPath(), "Newtonsoft.Json.dll");
            using (Stream resourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("PWA_Converter_App.Newtonsoft.Json.dll"))
            {
                if (resourceStream != null)
                {
                    using (FileStream fileStream = new FileStream(path, FileMode.Create/*, FileAccess.Write*/))
                    {
                        resourceStream.CopyTo(fileStream);
                    }

                    // Register the AssemblyResolve event to load the assembly from the temporary path
                    AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
                    {
                        if (args.Name.StartsWith("Newtonsoft.Json"))
                        {
                            return Assembly.LoadFrom(path);
                        }
                        return null;
                    };
                }
                else
                {
                    MessageBox.Show("Failed to load embedded dependency: Newtonsoft.Json.dll", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ApplyGroupBoxStyle(GroupBox groupBox)
        {
            groupBox.ForeColor = Color.FromArgb(236, 240, 241); // Light gray for text
            groupBox.BackColor = Color.FromArgb(52, 73, 94); // Darker blue for group box background
            groupBox.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
        }

        private void ApplyLabelStyle(Label label)
        {
            label.ForeColor = Color.FromArgb(236, 240, 241); // Light gray for labels
            label.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
        }

        private void ApplyTextBoxStyle(TextBox textBox)
        {
            textBox.BorderStyle = BorderStyle.FixedSingle;
            textBox.BackColor = Color.FromArgb(236, 240, 241); // Light background for textboxes
            textBox.ForeColor = Color.FromArgb(52, 73, 94); // Dark text
            textBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
        }

        private void btnBrowseHtml_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "HTML files (*.html)|*.html|All files (*.*)|*.*";
                openFileDialog.Title = "Select index.html file";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtHtmlPath.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnBrowseIcon_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp|All files (*.*)|*.*";
                openFileDialog.Title = "Select PWA Icon file";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtIconPath.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnGeneratePWA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHtmlPath.Text))
            {
                MessageBox.Show("Please select an index.html file first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtAppName.Text) || string.IsNullOrEmpty(txtShortName.Text) || string.IsNullOrEmpty(txtStartUrl.Text))
            {
                MessageBox.Show("Please fill in all required PWA manifest fields (App Name, Short Name, Start URL).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Select output folder for the new PWA project";
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        List<string> serviceWorkerFiles = new List<string>();
                        for (int i = 0; i < cmbService.Items.Count; i++)
                        {
                            serviceWorkerFiles.Add(cmbService.Items[i].ToString());
                        }

                        PWAProcessor.GeneratePWA(
                            txtHtmlPath.Text,
                            txtAppName.Text,
                            txtShortName.Text,
                            txtStartUrl.Text,
                            cmbDisplay.SelectedItem.ToString(),
                            txtBackgroundColor.Text,
                            txtThemeColor.Text,
                            txtIconPath.Text,
                            serviceWorkerFiles,
                            folderBrowserDialog.SelectedPath
                        );
                        LoadDirectory(folderBrowserDialog.SelectedPath);
                        MessageBox.Show("PWA project generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error generating PWA: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnBrowseExistingPWA_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Select the root folder of an existing PWA project";
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    txtExistingPwaPath.Text = folderBrowserDialog.SelectedPath;
                    try
                    {
                        string appName, shortName, startUrl, display, backgroundColor, themeColor, iconPath;
                        List<string> serviceWorkerFiles;
                        PWAProcessor.LoadExistingPWA(txtExistingPwaPath.Text, out appName, out shortName, out startUrl, out display, out backgroundColor, out themeColor, out iconPath, out serviceWorkerFiles);

                        txtAppName.Text = appName;
                        txtShortName.Text = shortName;
                        txtStartUrl.Text = startUrl;
                        if (cmbDisplay.Items.Contains(display))
                        {
                            cmbDisplay.SelectedItem = display;
                        }
                        else
                        {
                            cmbDisplay.SelectedIndex = 0; // Default to standalone if not found
                        }
                        txtBackgroundColor.Text = backgroundColor;
                        txtThemeColor.Text = themeColor;
                        txtIconPath.Text = iconPath;
                        cmbService.Items.Clear();
                        foreach (string service in serviceWorkerFiles)
                        {
                            cmbService.Items.Add(service);
                        }
                        LoadDirectory(txtExistingPwaPath.Text);
                        MessageBox.Show("Existing PWA project loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading existing PWA: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnModifyPWA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtExistingPwaPath.Text))
            {
                MessageBox.Show("Please select an existing PWA project folder first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtAppName.Text) || string.IsNullOrEmpty(txtShortName.Text) || string.IsNullOrEmpty(txtStartUrl.Text))
            {
                MessageBox.Show("Please fill in all required PWA manifest fields (App Name, Short Name, Start URL).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                List<string> serviceWorkerFiles = new List<string>();
                for (int i = 0; i < cmbService.Items.Count; i++)
                {
                    serviceWorkerFiles.Add(cmbService.Items[i].ToString());
                }

                PWAProcessor.ModifyPWA(
                    txtExistingPwaPath.Text,
                    txtAppName.Text,
                    txtShortName.Text,
                    txtStartUrl.Text,
                    cmbDisplay.SelectedItem.ToString(),
                    txtBackgroundColor.Text,
                    txtThemeColor.Text,
                    txtIconPath.Text,
                    serviceWorkerFiles
                );
                MessageBox.Show("PWA project modified successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error modifying PWA: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (cmbService.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a service to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string serviceName = cmbService.SelectedItem.ToString();
            DialogResult result = MessageBox.Show($"Are you sure you want to delete the service '{serviceName}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
               cmbService.Items.Remove(serviceName);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.Title = "Select a service file to add";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string serviceName = Path.GetFileName(openFileDialog.FileName);
                    if (!cmbService.Items.Contains(serviceName))
                    {
                        cmbService.Items.Add(serviceName);
                        cmbService.SelectedItem = serviceName;
                    }
                    else
                    {
                        MessageBox.Show("This service is already added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = radioButton1.Checked;
            groupBox2.Visible = radioButton2.Checked;
        }

        private void LoadDirectory(string dirPath)
        {
            tvPWAfolder.Nodes.Clear();

            DirectoryInfo rootDirectoryInfo = new DirectoryInfo(dirPath);
            TreeNode rootNode = new TreeNode(rootDirectoryInfo.Name);
            rootNode.Tag = rootDirectoryInfo;

            // تعيين أيقونة الفولدر الرئيسي
            rootNode.ImageKey = "folder";
            rootNode.SelectedImageKey = "folder";

            tvPWAfolder.Nodes.Add(rootNode);

            // بنستدعي الدالة اللي هتبني باقي الشجرة
            BuildTree(rootDirectoryInfo, rootNode);

            // بنفتح الشجرة عشان نشوف أول مستوى
            rootNode.Expand();
        }

        private void BuildTree(DirectoryInfo directoryInfo, TreeNode parentNode)
        {
            try
            {
                // 1. نجيب كل الفولدرات الفرعية
                foreach (DirectoryInfo subDir in directoryInfo.GetDirectories())
                {
                    TreeNode dirNode = new TreeNode(subDir.Name);
                    dirNode.Tag = subDir;

                    dirNode.ImageKey = "folder";
                    dirNode.SelectedImageKey = "folder";

                    parentNode.Nodes.Add(dirNode);

                    // استدعاء ذاتي عشان نجيب الفولدرات اللي جوه الفولدر ده
                    BuildTree(subDir, dirNode);
                }

                // 2. نجيب كل الملفات اللي جوه الفولدر الحالي
                foreach (FileInfo file in directoryInfo.GetFiles())
                {
                    TreeNode fileNode = new TreeNode(file.Name);
                    fileNode.Tag = file;

                    // استدعاء دالة عشان تحدد اسم الأيقونة المناسبة للامتداد
                    string iconKey = GetIconKeyForFile(file.Extension);
                    fileNode.ImageKey = iconKey;
                    fileNode.SelectedImageKey = iconKey;

                    parentNode.Nodes.Add(fileNode);
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show($"You do not have permission to access the directory: {directoryInfo.FullName}", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string GetIconKeyForFile(string extension)
        {
            switch (extension.ToLower())
            {
                case ".html":
                case ".htm":
                    return "html";   

                case ".png":
                case ".jpg":
                case ".jpeg":
                case ".gif":
                case ".svg":
                case ".ico":
                    return "image";

                case ".js":
                    return "js";

                case ".json":
                    return "json";

                case ".css":
                    return "css";

                default:
                    return "file";   
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 1. بنعمل ImageList جديدة بالكود وبنضبط إعداداتها
            ImageList myImageList = new ImageList();
            myImageList.ImageSize = new Size(24, 24);
            myImageList.ColorDepth = ColorDepth.Depth32Bit;

            // 3. بنقرأ الصور من الفولدر وندي لكل صورة الـ (Key) بتاعها
            try
            {
                myImageList.Images.Add("folder", Resources.folder);
                myImageList.Images.Add("html", Resources.html);
                myImageList.Images.Add("image", Resources.image);
                myImageList.Images.Add("js", Resources.js);
                myImageList.Images.Add("json", Resources.json);
                myImageList.Images.Add("css", Resources.css);
                myImageList.Images.Add("file", Resources.file);

                // 4. أخيراً.. بنربط الـ ImageList دي بالـ TreeView بتاعك
                tvPWAfolder.ImageList = myImageList;
            }
            catch (Exception ex)
            {
                // لو نسيت تحط صورة في الفولدر، البرنامج مش هيقفل في صمت، هيطلعلك رسالة يقولك إيه اللي ناقص
                MessageBox.Show("في مشكلة في تحميل الأيقونات: " + ex.Message);
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
