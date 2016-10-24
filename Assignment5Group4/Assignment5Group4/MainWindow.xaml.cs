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

namespace Assignment5Group4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const string CORRECT_ANSWER = "Your answer is correct.";
        const string INCORRECT_ANSWER = "Your answer is incorrect.";
        int num1;
        int num2;      
        public MainWindow()
        {
            InitializeComponent();
            RandomNumber();    
        }
        public void RandomNumber()
        {
            Random ran1 = new Random();
            num1 = ran1.Next(100, 500);
            Random ran2 = new Random();
            num2 = ran2.Next(100, 500);
            lblRandonNumber.Content = num1.ToString() + " + " + num2.ToString() + "= ?";
        }
        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            
            int userChoice = int.Parse(txtUserChoice.Text);
            int additionResult = num1+num2;
            if (userChoice == additionResult)
                lblResult.Content = CORRECT_ANSWER;
            else
                lblResult.Content = INCORRECT_ANSWER;
        }
    }
}
