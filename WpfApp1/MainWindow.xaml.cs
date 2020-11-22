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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int number = 0;

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (checkbox.IsChecked == true)
            {
                if ((radiobutton1.IsChecked == true || radiobutton2.IsChecked == true || radiobutton3.IsChecked == true) && textbox1.Text != "" && textbox2.Text != "" && number != 0)
                {
                    checkbox.IsChecked = true;
                    buttonOrder.IsEnabled = true;
                }
                else
                {
                    checkbox.IsChecked = false;
                    MessageBox.Show("Not all information was entered!");
                }
            }
            else if(checkbox.IsChecked == false)
            {
                buttonOrder.IsEnabled = false;
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(checkbox.IsChecked == true)
            {
                string str = "Name and Surname: " + textbox1.Text + "; Adress: " + textbox2.Text + "; Count of peoples: " + number;
                if (radiobutton1.IsChecked == true)
                    str += "; Economy";
                else if (radiobutton2.IsChecked == true)
                    str += "; Standart";
                else if (radiobutton3.IsChecked == true)
                    str += "; Comfort";
                MessageBox.Show(str);
            }
            else
            {
                MessageBox.Show("Acceptance of terms of use!");
            }
        }

        private void GrowButton_Click(object sender, RoutedEventArgs e)
        {
            if (number <= 7)
            {
                number += 1;
                textBoxCountOfPeople.Text = number.ToString();
            }
        }

        private void ButtonCancle_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text = "";
            textbox2.Text = "";
            number = 0;
            textBoxCountOfPeople.Text = "0";
            if (radiobutton1.IsChecked == true)
                radiobutton1.IsChecked = false;
            else if (radiobutton2.IsChecked == true)
                radiobutton2.IsChecked = false;
            else if (radiobutton3.IsChecked == true)
                radiobutton3.IsChecked = false;
            checkbox.IsChecked = false;
            buttonOrder.IsEnabled = false;
        }

        private void GrowButton_Click2(object sender, RoutedEventArgs e)
        {
            if (number >= 1)
            {
                number -= 1;
                textBoxCountOfPeople.Text = number.ToString();
            }
        }
    }
}
