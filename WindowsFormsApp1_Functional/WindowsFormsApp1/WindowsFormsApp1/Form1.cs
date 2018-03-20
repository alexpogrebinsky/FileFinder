using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // global variables
        string userFilePathInput;
        string userExtensionInput;
        string[] files;

        private void userFilePath_TextChanged(object sender, EventArgs e)
        {
        }

        private void searchFilePath_Click(object sender, EventArgs e)
        {
            // assigning global variables equal to text and combo box values
            userFilePathInput = userFilePath.Text; // text box value for file path
            userExtensionInput = userExtInput.Text; // combo box value for extension

            // getting files per user input as arguements
            files = Directory.GetFileSystemEntries(userFilePathInput, "*" + userExtensionInput, SearchOption.AllDirectories);

            // looping though files in array and putting them in list box
            for (int i = 0; i < files.Length; i++)
            {
                LBOutputList.Items.Add(files[i]);
         
            }

        }

        private void userExtInput_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void LBOutputList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void userSearchText_Click(object sender, EventArgs e)
        {
            // assigning global variables equal to text and combo box values
            userFilePathInput = userFilePath.Text; // text box value for file path
            userExtensionInput = userExtInput.Text; // combo box value for extension

            // getting files per user input as arguements
            files = Directory.GetFileSystemEntries(userFilePathInput, "*" + userExtensionInput, SearchOption.AllDirectories);


                foreach (var file in files)
                {
                    var result = searchFile(file.ToString(), userTextInput.Text);
                    if (result)
                        LBOutputList.Items.Add(file.ToString());
                    //break;
                }

        }

        private bool searchFile(string fileName, string searchString)
        {
            bool stringFound = false;
                FileStream file = new FileStream(fileName, FileMode.Open);
                StreamReader sr = new StreamReader(file);
            try
            {  //open file


                while (!sr.EndOfStream)
                {
                    //Read one line at a time
                    var line = sr.ReadLine();
                    

                    //Examine each line to see if it contains searchString
                    if (line.ToUpper().Contains(searchString.ToUpper()))
                    {
                        stringFound = true;
                        break;
                    }
            
                }            
            }

            catch (IOException ex)
            {
                //MessageBox.Show("Sorry no files contain the words: " + searchString);
                MessageBox.Show("Error: " + ex.Message);
                ErrorLog("Error in the searchFile" + ex.Message);
                //MessageBox.Show("no file");

            }

            finally
            {
                file.Close();
            }

            return stringFound;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public void ErrorLog(string strErrorLog)
        {
            try
            {
                string strFileName = "eventlog.txt";
                string strPath = Application.StartupPath;

                File.AppendAllText(strPath + "\\" + strFileName, strErrorLog + "-" + DateTime.Now.ToString() + "\r\n");
            }

            catch (Exception ex)
            {
                ErrorLog("Error in the ErrorLog: " + ex.Message);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LBOutputList.Items.Clear();
            userTextInput.Text = "";
            userExtInput.Text = "";
            userFilePathInput = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

