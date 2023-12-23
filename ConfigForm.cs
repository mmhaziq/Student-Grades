using System;
using System.IO;
using System.Windows.Forms;

namespace StudentGrades
{
    public partial class ConfigForm : Form
    {
        private OpenFileDialog openFileDialog;
        private double passFailThreshold;
        private string configFile = Path.Combine(Environment.CurrentDirectory, "config.txt");

        public ConfigForm()
        {
            InitializeComponent();
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files|*.txt|All Files|*.*";
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            // Load configuration when the form is loaded
            LoadConfiguration();
            textBoxPassFailThreshold.Text = PassFailThreshold.ToString();
        }

        private void LoadConfiguration()
        {
            try
            {
                // Display the OpenFileDialog and set the configuration file if selected
                do
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        configFile = openFileDialog.FileName;
                        // Check if the configuration file exists and read the threshold value
                        if (File.Exists(configFile))
                        {
                            string[] lines = File.ReadAllLines(configFile);
                            if (lines.Length > 0 && double.TryParse(lines[0], out double threshold))
                            {
                                PassFailThreshold = threshold;
                                textBoxPassFailThreshold.Text = PassFailThreshold.ToString();

                            }
                        }
                    }
                    // Repeat the loop until a valid configuration is loaded
                } while (!IsValidConfiguration());

                MessageBox.Show("Valid configuration loaded successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading configuration: {ex.Message}");
            }
        }

        private bool IsValidConfiguration()
        {
            // Implement your logic to check if the loaded configuration is valid
            // For example, check if PassFailThreshold is within a specific range
            return passFailThreshold >= 1 && passFailThreshold <= 100;
        }

        // Other methods and properties...

        // Save the configuration to the file
        private void SaveConfiguration()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(configFile, false))
                {
                    writer.WriteLine(PassFailThreshold);
                    writer.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving configuration: {ex.Message}");
            }
        }

        // Property to get and set the pass-fail threshold
        public double PassFailThreshold
        {
            get { return passFailThreshold; }
            set
            {
                // Validate and set the threshold value
                if (value >= 1 && value <= 100)
                {
                    passFailThreshold = value;
                    textBoxPassFailThreshold.Text = value.ToString();
                }
                else
                {
                    MessageBox.Show("Threshold must be between 1 and 100.");
                }
            }
        }

        // Event handler for the Close button
        private void buttonClose_Click(object sender, EventArgs e)
        {
            double threshold;
            if (double.TryParse(textBoxPassFailThreshold.Text, out threshold))
            {
                // Check if the threshold is within the valid range
                if (threshold >= 1 && threshold <= 100)
                {
                    // Set the threshold, save the configuration, and hide the form
                    PassFailThreshold = threshold;
                    SaveConfiguration();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Threshold must be between 1 and 100.");
                }
            }
            else
            {
                MessageBox.Show("Invalid threshold value in the text box.");
            }
        }

        // Event handler for the ConfigFile button
        private void buttonConfigFile_Click(object sender, EventArgs e)
        {
            // Load configuration when the ConfigFile button is clicked
            LoadConfiguration();
        }
    }
}
