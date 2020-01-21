using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
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
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Tetris
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
             MySqlDb score = new MySqlDb("db4free.net", "tetrisgame", "tetris2020", "tetris2020");
            score.OpenConnection();
            Highscore playerscore = score.AddScore("Sabin", 5);


        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void HandleKeyPress(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Up)
            {
                //change block state
            }
            else if(e.Key == Key.Down)
            {

            }
            else if (e.Key == Key.Left)
            {

            }
            else if (e.Key == Key.Right)
            {

            }
            else
            {

            }
        }
    }
}
