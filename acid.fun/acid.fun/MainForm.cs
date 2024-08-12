using acid.fun.Properties;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Windows.Forms;

namespace acid.fun
{
    public partial class MainForm : MaterialForm
    {
        public static CrosshairOverlay ov = new CrosshairOverlay();
        public MainForm()
        {
            InitializeComponent();
            client.OnLoad();
            menuEnabled.Text = Settings.Default.darkTextures.ToString();
            skyboxEnabled.Text = Settings.Default.graySky.ToString();
            this.menuEnabled.SelectedIndexChanged += new System.EventHandler(this.materialComboBox1_SelectedIndexChanged);
            this.skyboxEnabled.SelectedIndexChanged += new System.EventHandler(this.skyboxEnabled_SelectedIndexChanged);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.darkTextures = bool.Parse(menuEnabled.Text);
            Settings.Default.Save();


            if (Settings.Default.darkTextures)
            {
                string zipPath = Path.Combine(Application.StartupPath, "dependencies");

                string extractPath = null;
                if (client.GetRobloxClientName() == "Bloxstrap")
                {
                    extractPath = client.GetRobloxDirectory();
                }

                if (client.GetRobloxClientName() == "Roblox")
                {
                    extractPath = client.GetRobloxVersion();
                }

                try
                {
                    MessageBox.Show("Installing", "acid.fun", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    try
                    {
                            // If no exception is thrown, proceed with extraction
                         ZipFile.ExtractToDirectory(zipPath + "\\PC.zip", extractPath);
                         MessageBox.Show("Installation complete.", "acid.fun", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (InvalidDataException)
                    {
                        MessageBox.Show("The downloaded file is not a valid ZIP archive.", "acid.fun", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "acid.fun", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (client.GetRobloxClientName() == "Bloxstrap")
                {
                    Directory.Delete(client.GetRobloxDirectory() + "\\PlatformContent", true);
                }

                if (client.GetRobloxClientName() == "Roblox")
                {
                    Directory.Delete(client.GetRobloxVersion() + "\\PlatformContent", true);
                }
            }
        }

        private void skyboxEnabled_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.graySky = bool.Parse(skyboxEnabled.Text);
            Settings.Default.Save();


            if (Settings.Default.graySky)
            {
                client.AddFFlag("FFlagDebugSkyGray", "True");
                client.AddFFlag("FStringNote", "dadfwewfwefwew");

            }
            else
            {
                client.RemoveFFlag("FFlagDebugSkyGray");
                client.RemoveFFlag("FStringNote");
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialCard2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuEnabled_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void materialTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            client.RemoveFFlag(materialTextBox4.Text);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            client.AddFFlag(materialTextBox1.Text, materialTextBox2.Text);
        }

        private void materialCard4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            Settings.Default.crossType = materialComboBox1.Text;
            Settings.Default.crossSize = int.Parse(materialTextBox6.Text);
            Settings.Default.crossColor = Color.FromName(materialComboBox2.Text);
            Settings.Default.crossEnabled = true;
            Settings.Default.Save();

            ov.Invalidate();
            ov.Show();
        }

        private void materialCard7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            ov.Invalidate();
            ov.Hide();
        }

        private void materialComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialComboBox3.Text == "True") 
            { 
                if (client.GetRobloxClientName() == "Bloxstrap")
                {
                    string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

                    string versionsFolderPath = Path.Combine(localAppData, @"Bloxstrap\Versions");

                    string versionFolder = Directory.GetDirectories(versionsFolderPath).FirstOrDefault();
                    string fontsFolderPath = Path.Combine(versionFolder, "content", "fonts");

                    string[] fontFiles = Directory.GetFiles(fontsFolderPath, "*.ttf")
                 .Concat(Directory.GetFiles(fontsFolderPath, "*.otf"))
                 .ToArray();

                    foreach (string fontFile in fontFiles)
                    {
                        string fileName = Path.GetFileName(fontFile);

                        string destinationPath = Path.Combine(fontsFolderPath, fileName);

                        File.Copy(Application.StartupPath + "\\dependencies\\NotoSansCJKjp-Regular.otf", destinationPath, overwrite: true);

                    }

                }

                Settings.Default.minFont = true;
                Settings.Default.Save();
            }
        }
    }
}