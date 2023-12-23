//Input: Student name, 3 grades
//Process: Calculate Average
//Output: Display inputs and average
//Additional: Display name, focus errors, validation, clear data


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGrades
{
    public partial class Form1 : Form
    {
        //private string configFilePath = "config.txt";
        //private string logFilePath = "log.txt";
        string studentType = "Undergraduate";
        private const string undergraduate = "Undergraduate";
        private const string graduate = "Graduate";
        private const string passFail = "Pass/Fail";
        private string logFilePath = Path.Combine(Environment.CurrentDirectory, "log.txt");

        private ConfigForm configForm;
        

        public Form1()
        {
            InitializeComponent();
            configForm = new ConfigForm();

            buttonLog.Click += buttonLog_Click;
        }

        public double PassFailThreshold
        {
            get { return configForm.PassFailThreshold; }
            set { configForm.PassFailThreshold = value; }
        }

        public void SetPassFailThresholdFromConfig(double threshold)
        {
            PassFailThreshold = threshold;
        }

        //public double ConfigThreshold { get; set; }

        //public string StudentName
        //{
        //    get { return textName.Text.Trim(); }
        //    set { textName.Text = value; }
        //}

        //public double Grade1
        //{
        //    get
        //    {
        //        double grade;
        //        return double.TryParse(textGrade1.Text, out grade) ? grade : 0;
        //    }
        //    set { textGrade1.Text = value.ToString(); }
        //}

        //public double Grade2
        //{
        //    get
        //    {
        //        double grade;
        //        return double.TryParse(textGrade2.Text, out grade) ? grade : 0;
        //    }
        //    set { textGrade2.Text = value.ToString(); }
        //}

        //public double Grade3
        //{
        //    get
        //    {
        //        double grade;
        //        return double.TryParse(textGrade3.Text, out grade) ? grade : 0;
        //    }
        //    set { textGrade3.Text = value.ToString(); }
        //}

        private double GetGrade(TextBox textBox)
        {
            double grade;
            return double.TryParse(textBox.Text, out grade) ? grade : 0;
        }

        private void SetGrade(TextBox textBox, double value)
        {
            textBox.Text = value.ToString();
        }

        private void btnCalcAvg_Click(object sender, EventArgs e)
        {

            // Parse grades and handle conversion errors
            double grade_one, grade_two, grade_three = 0;
            bool isGradeOneValid = double.TryParse(textGrade1.Text, out grade_one);
            bool isGradeTwoValid = double.TryParse(textGrade2.Text, out grade_two);
            bool isGradeThreeValid = double.TryParse(textGrade3.Text, out grade_three);

            // Validate the name input
            string name = textName.Text.Trim(); // Trim to remove spaces

            //Clear listbox
            
            //Clear input field

            bool isInputValid = true;

            // Check if any grade is invalid
            if (!isGradeOneValid || !isGradeTwoValid || !isGradeThreeValid)
            {
                isInputValid = false;
                listOutput.Items.Add("Invalid input");
            }
            else
            {
                // Check if grades are within the 0-100 range
                if (!IsGradeValid(grade_one) || !IsGradeValid(grade_two) || !IsGradeValid(grade_three))
                {
                    isInputValid = false;
                    listOutput.Items.Add("Grades must be between 0 and 100");
                }

                if (isInputValid)
                {
                    //double threshold = configForm.PassFailThreshold;
                    //// Calculate average
                    //double average = calculateAverage(grade_one, grade_two, grade_three);

                    //string overallGrade = CalculateOverallGrade(average);

                    //displayResult(name, grade_one, grade_two, grade_three, average, overallGrade);

                    //LogTransaction($"Name: {name}, Grade-1: {grade_one}, Grade-2: {grade_two}, Grade-3: {grade_three}, Average: {average}, Overall Grade: {overallGrade}");

                    double threshold = configForm.PassFailThreshold;
                    double average = calculateAverage(grade_one, grade_two, grade_three);
                    string overallGrade = CalculateOverallGrade(average);
                    string program = studentType;

                    displayResult(
                        ("Name\n", name),
                        ("Grade-1\n", grade_one),
                        ("Grade-2\n", grade_two),
                        ("Grade-3\n", grade_three),
                        ("Average\n", average.ToString("N1")),
                        ("Overall Grade\n", overallGrade)
                    );

                    LogTransaction($"Program: {program},Name: {name}, Grade-1: {grade_one}, Grade-2: {grade_two}, Grade-3: {grade_three}, Average: {average}, Overall Grade: {overallGrade}");

                }
            }
        }

        private bool IsGradeValid(double grade)
        {
            return grade >= 0 && grade <= 100;
        }
        private double calculateAverage(double grade_one, double grade_two, double grade_three)

        {
            
            return (grade_one + grade_two + grade_three) / 3;
        }

        private void displayResult(params (string Label, object Value)[] results)
        {
            foreach (var result in results)
            {
                listOutput.Items.Add($"{result.Label}:");
                listOutput.Items.Add($"{result.Value}");
                //LogTransaction($"{result.Label}: {result.Value}");
            }
            listOutput.Items.Add("\n");
            //LogTransaction("\n");
        }

        //private void displayResult(string name,double grade_one,double grade_two,double grade_three,double average,string overallGrade) 
        //{

        //    listOutput.Items.Add("Name: " + name);

        //    listOutput.Items.Add("Grade-1: " + grade_one);

        //    listOutput.Items.Add("Grade-2: " + grade_two);

        //    listOutput.Items.Add("Grade-3: " + grade_three);

        //    listOutput.Items.Add("Average: " + average.ToString("N1"));

        //    listOutput.Items.Add("Overall Grade: " + overallGrade + "\n");

        //    listOutput.Items.Add("\n");
        //}

        private void btnClr_Click(object sender, EventArgs e)
        {
            // Clear the text fields
            textName.Text = "";
            textGrade1.Text = "";
            textGrade2.Text = "";
            textGrade3.Text = "";

            // Clear the list box
            //listOutput.Items.Clear();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            DialogResult buttonSelected;
            buttonSelected = MessageBox.Show("Quit?", "Exit", MessageBoxButtons.YesNo);
            if(buttonSelected == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private string CalculateOverallGrade(double average)
        {

            string grade = "N/A";

            if (average > 95)
            {
                grade = "A";
            }
            else if (average > 89)
            {
                grade = "A-";
            }
            else if (average > 86)
            {
                grade = "B+";
            }
            else if (average > 83)
            {
                grade = "B";
            }
            else if (average > 79)
            {
                grade = "B-";
            }
            else if (average > 76)
            {
                grade = "C+";
            }
            else if (average > 73)
            {
                grade = "C";
            }
            else if (average > 69)
            {
                grade = "C-";
            }
            else if (average > 66)
            {
                grade = "D+";
            }
            else if (average > 63)
            {
                grade = "D";
            }
            else if (average > 59)
            {
                grade = "D-";
            }
            else
            {
                grade = "F";
            }

            switch (studentType)
            {
                case "Undergraduate":
                    
                    break;


                case "Graduate":
                    if (average < 70)
                    {
                        grade = "F";
                    }
                    break;

                case "Pass/Fail":
                    if (average < PassFailThreshold)
                    {
                        grade = "Fail";
                    }
                    else
                    {
                        grade = "Pass";
                    }
                    break;
                default:
                    listOutput.Items.Add("This should not happen");
                    break;
            }
            return grade;
        }

        private void radioUndergraduate_CheckedChanged(object sender, EventArgs e)
        {
            if(radioUndergraduate.Checked)
            {
                studentType = undergraduate;
            }
        }

        private void radioGraduate_CheckedChanged(object sender, EventArgs e)
        {
            if(radioGraduate.Checked)
            {
                studentType = graduate;
            }
        }

        private void radioPassFail_CheckedChanged(object sender, EventArgs e)
        {
            if(radioPassFail.Checked)
            {
                studentType = passFail;
            }
        }

        //private void LogTransaction(string transaction)
        //{
        //    try
        //    {
        //        using (StreamWriter writer = File.AppendText(logFilePath))
        //        {
        //            writer.WriteLine($"{DateTime.Now.ToString()} - {transaction}");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error logging transaction: " + ex.Message);
        //    }
        //}

        //private void LogTransaction(string transaction)
        //{

        //    FileStream fileStream = null;
        //    try
        //    {
        //        string logEntry = $"{DateTime.Now.ToString()} - {transaction}\n";
        //        File.AppendAllText(logFilePath, logEntry);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error logging transaction: " + ex.Message);
        //    }
        //    finally
        //    {
        //        if (fileStream != null)
        //        {
        //            fileStream.Close();
        //            fileStream.Dispose(); // Ensure proper resource cleanup
        //        }
        //    }
        //}

        


        private void LogTransaction(string transaction)
        {
            StreamWriter writer = null;
            try
            {
                writer = File.AppendText(logFilePath);
                    string logEntry = $"{DateTime.Now.ToString()} - {transaction}\n";
                    writer.Write(logEntry);
                
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error logging transaction: " + ex.Message);
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                    //writer.Dispose();
                }
            }
        }


        private void toolStripMenuItemConfig_Click(object sender, EventArgs e)
        {
            configForm.PassFailThreshold = PassFailThreshold;
            configForm.ShowDialog();
            SetPassFailThresholdFromConfig(configForm.PassFailThreshold);
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            string[] logEntries = File.ReadAllLines(logFilePath);

            // Clear existing items in the list box
            listOutput.Items.Clear();

            // Output only those transactions that match the currently selected button
            foreach (string logEntry in logEntries)
            {
                if (logEntry.Contains(studentType)) // Assuming studentType represents the currently selected button
                {
                    listOutput.Items.Add(logEntry);
                }
            }
        }
    }
    }