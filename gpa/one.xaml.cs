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
    /// Interaction logic for one.xaml
    /// </summary>
    public partial class one : Page
    {
        public one()
        {
            InitializeComponent();

            cour.Items.Add("1");
            cour.Items.Add("2");
            cour.Items.Add("3");
            cour.Items.Add("4");
            cour.Items.Add("5");
            cour.Items.Add("6");
            cour.SelectedIndex = 0;

            labs.Items.Add("1");
            labs.Items.Add("2");
            labs.Items.Add("3");
            labs.Items.Add("4");
            labs.SelectedIndex = 0;

            credit1.Items.Add("2");
            credit1.Items.Add("3");
            credit1.SelectedIndex = 1;

            credit2.Items.Add("2");
            credit2.Items.Add("3");
            credit2.SelectedIndex = 1;

            credit3.Items.Add("2");
            credit3.Items.Add("3");
            credit3.SelectedIndex = 1;

            credit4.Items.Add("2");
            credit4.Items.Add("3");
            credit4.SelectedIndex = 1;

            credit5.Items.Add("2");
            credit5.Items.Add("3");
            credit5.SelectedIndex = 1;

            credit6.Items.Add("2");
            credit6.Items.Add("3");
            credit6.SelectedIndex = 1;



        }

        private void proceedbutton_Click(object sender, RoutedEventArgs e)
        {
            two twopage = new two();
            this.NavigationService.Navigate(twopage);

            if (labs.SelectedIndex == 0)
            {
                Double partial = Convert.ToDouble(cgl.Content);
                Double totpartial = partial + 0.7;
                twopage.finalgpalabel.Content = Convert.ToString(totpartial);
            }

            if (labs.SelectedIndex == 1)
            {
                Double partial = Convert.ToDouble(cgl.Content);
                Double totpartial = partial + 0.14;
                twopage.finalgpalabel.Content = Convert.ToString(totpartial);
            }

            if (labs.SelectedIndex == 2)
            {
                Double partial = Convert.ToDouble(cgl.Content);
                Double totpartial = partial + 0.21;
                twopage.finalgpalabel.Content = Convert.ToString(totpartial);
            }

            if (labs.SelectedIndex == 3)
            {
                Double partial = Convert.ToDouble(cgl.Content);
                Double totpartial = partial + 0.28;
                twopage.finalgpalabel.Content = Convert.ToString(totpartial);
            }

        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            options op = new options();
            this.NavigationService.Navigate(op);
        }

        private void cgb_Click(object sender, RoutedEventArgs e)
        {

            try
            {

                Double course1 = Convert.ToDouble(g1.Text);
                Double hourscourse1 = Convert.ToDouble(credit1.Text);
                Double val1 = course1 * hourscourse1;
                //  t11.Text = val3.ToString();

                Double course2 = Convert.ToDouble(g2.Text);
                Double hourscourse2 = Convert.ToDouble(credit2.Text);
                Double val2 = course2 * hourscourse2;
                //  t11.Text = val3.ToString();

                Double course3 = Convert.ToDouble(g3.Text);
                Double hourscourse3 = Convert.ToDouble(credit3.Text);
                Double val3 = course3 * hourscourse3;
                //  t11.Text = val3.ToString();

                Double course4 = Convert.ToDouble(g4.Text);
                Double hourscourse4 = Convert.ToDouble(credit4.Text);
                Double val4 = course4 * hourscourse4;
                //  t11.Text = val3.ToString();

                Double course5 = Convert.ToDouble(g5.Text);
                Double hourscourse5 = Convert.ToDouble(credit5.Text);
                Double val5 = course5 * hourscourse5;
                //  t11.Text = val3.ToString();

                Double course6 = Convert.ToDouble(g6.Text);
                Double hourscourse6 = Convert.ToDouble(credit6.Text);
                Double val6 = course6 * hourscourse6;
                //  t11.Text = val3.ToString();
            

            if (cour.SelectedIndex == 0)
            {
                Double uppertot = val1;

                Double lowertot = hourscourse1;

                Double gpa = uppertot / lowertot;

                cgl.Content = gpa.ToString();
            }

            if (cour.SelectedIndex == 1)
            {
                Double uppertot = val1 + val2;

                Double lowertot = hourscourse1 + hourscourse2;

                Double gpa = uppertot / lowertot;

                cgl.Content = gpa.ToString();
            }

            if (cour.SelectedIndex == 2)
            {
                Double uppertot = val1 + val2 + val3;

                Double lowertot = hourscourse1 + hourscourse2 + hourscourse3;

                Double gpa = uppertot / lowertot;

                cgl.Content = gpa.ToString();
            }

            if (cour.SelectedIndex == 3)
            {
                Double uppertot = val1 + val2 + val3 + val4;

                Double lowertot = hourscourse1 + hourscourse2 + hourscourse3 + hourscourse4;

                Double gpa = uppertot / lowertot;

                cgl.Content = gpa.ToString();
            }

            if (cour.SelectedIndex == 4)
            {
                Double uppertot = val1 + val2 + val3 + val4 + val5;

                Double lowertot = hourscourse1 + hourscourse2 + hourscourse3 + hourscourse4 + hourscourse5;

                Double gpa = uppertot / lowertot;

                cgl.Content = gpa.ToString();
            }

            if (cour.SelectedIndex == 5)
            {
                Double uppertot = val1 + val2 + val3 + val4 + val5 + val6;

                Double lowertot = hourscourse1 + hourscourse2 + hourscourse3 + hourscourse4 + hourscourse5 + hourscourse6;

                Double gpa = uppertot / lowertot;

                cgl.Content = gpa.ToString();

            }


            


            }

            catch
            {
                MessageBox.Show("don't leave any GPA box empty ! enter any number , if you are not using any GPA box");
            }

        }

        private void lgb_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Double lab1 = Convert.ToDouble(l1.Text);
                Double labval1 = lab1 * 1;   // b/c lab has 1 credit hour
                //  t11.Text = val3.ToString();

                Double lab2 = Convert.ToDouble(l2.Text);
                Double labval2 = lab2 * 1;   // b/c lab has 1 credit hour
                //  t11.Text = val3.ToString();

                Double lab3 = Convert.ToDouble(l3.Text);
                Double labval3 = lab3 * 1;   // b/c lab has 1 credit hour
                //  t11.Text = val3.ToString();

                Double lab4 = Convert.ToDouble(l4.Text);
                Double labval4 = lab4 * 1;   // b/c lab has 1 credit hour
                //  t11.Text = val3.ToString();

                Double lc1 = 1;
                Double lc2 = 1;
                Double lc3 = 1;
                Double lc4 = 1;


                if (labs.SelectedIndex == 0)
                {
                    Double uppertot = labval1;

                    Double lowertot = lc1;

                    Double lgpa = uppertot / lowertot;

                    lgl.Content = lgpa.ToString();
                }

                if (labs.SelectedIndex == 1)
                {
                    Double uppertot = labval1 + labval2;

                    Double lowertot = lc1 + lc2;

                    Double lgpa = uppertot / lowertot;

                    lgl.Content = lgpa.ToString();
                }

                if (labs.SelectedIndex == 2)
                {
                    Double uppertot = labval1 + labval2 + labval3 ;

                    Double lowertot = lc1 + lc2 + lc3 ;

                    Double lgpa = uppertot / lowertot;

                    lgl.Content = lgpa.ToString();
                }

                if (labs.SelectedIndex == 3)
                {
                    Double uppertot = labval1 + labval2 + labval3 + labval4;

                    Double lowertot = lc1 + lc2 + lc3 + lc4;

                    Double lgpa = uppertot / lowertot;

                    lgl.Content = lgpa.ToString();

                }


            }

            catch 
            {
                MessageBox.Show("Don't leave the Lab GPA boxes empty ! enter any number , if you are not using any GPA box");
            }
        }

       




    }
}
