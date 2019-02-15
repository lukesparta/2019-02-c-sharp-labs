using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace lab_108_list_files_and_folders_01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            if (File.Exists("gamerDetails.txt"))
            {
                loadGamer();
            }
            getFolders();
            getFiles();
        }

        //Create a Gaming Home Page
        //Name of gamer (save to text file)
        //Level reached
        //Top score
        //Prize for the best presented interface

        //On click of save button
        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            string[] gamerDet = new string[] { txtGamerName.Text, txtLevel.Text, txtScore.Text };

            //create a file and add gamer details
            File.WriteAllText("gamerDetails.txt", gamerDet[0] + $"{Environment.NewLine}");
            File.AppendAllText("gamerDetails.txt", gamerDet[1] + $"{Environment.NewLine}");
            File.AppendAllText("gamerDetails.txt", gamerDet[2]);
        }

        public void loadGamer()
        {
            txtGamerName.Text = File.ReadAllLines("gamerDetails.txt")[0];
            txtLevel.Text = File.ReadAllLines("gamerDetails.txt")[1];
            txtScore.Text = File.ReadAllLines("gamerDetails.txt")[2];
        }

        //Next iteration  :  add an up/down button to increase the score 106

        //On click of score down button
        private void ScoreDown_Click(object sender, RoutedEventArgs e)
        {
            //if score input field isn't empty
            if (txtScore.Text != "")
            {
                //take one from the score and append it back to text field
                var score = Int32.Parse(txtScore.Text);
                score--;
                txtScore.Text = score.ToString();
            }
        }

        //On click of score up button
        private void ScoreUp_Click(object sender, RoutedEventArgs e)
        {
            //if score input field isn't empty
            if (txtScore.Text != "")
            {
                //take one from the score and append it back to text field
                var score = Int32.Parse(txtScore.Text);
                score++;
                txtScore.Text = score.ToString();
            }
            else
            {
                //If score is empty add '1' to it.
                txtScore.Text = "1";
            }
        }

        //List box - List all folders in project root 107
        //Manually create folders
        private void getFolders()
        {
            foreach (string s in Directory.GetDirectories("C:/2019-02-c-sharp-labs/labs"))
            {
                folderList1.Items.Add(s);
            }
        }


        //List box - List all folders in project root and list files in seperate list box 108
        //Manually create folders and files
        private void getFiles()
        {
            string[] files = Directory.GetFileSystemEntries(@"C:/2019-02-c-sharp-labs/labs", "*", SearchOption.AllDirectories);

            foreach (var file in files)
            {
                fileList.Items.Add(file);
            }
        }


        //Add a textbox for a new file name 109
        //Add a textblock for data to add to file
        //Add a save button to create a new text file
        //Permit Exception if file exists
    }
}
