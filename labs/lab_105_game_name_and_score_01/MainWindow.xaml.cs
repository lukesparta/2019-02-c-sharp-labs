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
using static System.Console;

namespace lab_105_game_name_and_score_01
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
        }

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

        //Create a Gaming Home Page
        //Name of gamer (save to text file)
        //Level reached
        //Top score
        //Prize for the best presented interface


        //Next iteration  :  add an up/down button to increase the score 106



        //List box - List all folders in project root 107
        //Manually create folders



        //List box - List all folders in project root and list files in seperate list box 108
        //Manually create folders and files



        //Add a textbox for a new file name 109
        //Add a textblock for data to add to file
        //Add a save button to create a new text file
        //Permit Exception if file exists
    }
}
