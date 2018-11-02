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

namespace gpa
{
    /// <summary>
    /// Interaction logic for cgpa.xaml
    /// </summary>
    public partial class cgpa : Page
    {
        public cgpa()
        {
            InitializeComponent();

            sem.Items.Add("1");
            sem.Items.Add("2");
            sem.Items.Add("3");
            sem.Items.Add("4");
            sem.Items.Add("5");
            sem.Items.Add("6");
            sem.Items.Add("7");
            sem.Items.Add("8");
            sem.SelectedIndex = 0;

        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            options o = new options();
            this.NavigationService.Navigate(o);
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void calculate_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                Double s1 = Convert.ToDouble(t1.Text);
                Double s2 = Convert.ToDouble(t2.Text);
                Double s3 = Convert.ToDouble(t3.Text);
                Double s4 = Convert.ToDouble(t4.Text);
                Double s5 = Convert.ToDouble(t5.Text);
                Double s6 = Convert.ToDouble(t6.Text);
                Double s7 = Convert.ToDouble(t7.Text);
                Double s8 = Convert.ToDouble(t8.Text);

                if (sem.SelectedIndex == 0)
                {
                    Double uppertot = s1 ;

                    Double gpa = uppertot / 1;

                    cgpal.Content = gpa.ToString();
                }

                if (sem.SelectedIndex == 1)
                {
                    Double uppertot = s1+s2;

                    Double gpa = uppertot / 2;

                    cgpal.Content = gpa.ToString();
                }

                if (sem.SelectedIndex == 2)
                {
                    Double uppertot = s1 + s2+s3;

                    Double gpa = uppertot / 3;

                    cgpal.Content = gpa.ToString();
                }

                if (sem.SelectedIndex == 3)
                {
                    Double uppertot = s1 + s2 + s3+s4;

                    Double gpa = uppertot / 4;

                    cgpal.Content = gpa.ToString();
                }

                if (sem.SelectedIndex == 4)
                {
                    Double uppertot = s1 + s2 + s3 + s4 + s5;

                    Double gpa = uppertot / 5;

                    cgpal.Content = gpa.ToString();
                }

                if (sem.SelectedIndex == 5)
                {
                    Double uppertot = s1 + s2 + s3 + s4 + s5+s6;

                    Double gpa = uppertot / 6;

                    cgpal.Content = gpa.ToString();
                }

                if (sem.SelectedIndex == 6)
                {
                    Double uppertot = s1 + s2 + s3 + s4 + s5 + s6+s7;

                    Double gpa = uppertot / 7;

                    cgpal.Content = gpa.ToString();
                }

                if (sem.SelectedIndex == 7)
                {
                    Double uppertot = s1 + s2 + s3 + s4 + s5 + s6 + s7+s8;

                    Double gpa = uppertot / 8;

                    cgpal.Content = gpa.ToString();
                }

               

            }

            catch
            {
                MessageBox.Show("Don't leave any Semester GPA box empty ! enter any number , if you are not using any GPA box");
            }
        }
    }
}
