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

namespace DailyFoodBudget
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_Calc_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem LBox_Months_Selection;
            string LBox_Months_Selection_Str = "";
            decimal TBox_Budget_Monthly_Dec = 0;

            try
            {
                LBox_Months_Selection =
                    LBox_Months.SelectedItem as ListBoxItem;

                if (LBox_Months_Selection == null)
                    throw new ArgumentNullException();

                LBox_Months_Selection_Str =
                    LBox_Months_Selection.Content.ToString();

                if (String.IsNullOrEmpty(LBox_Months_Selection_Str))
                    throw new ArgumentNullException();
            }

            catch (ArgumentNullException)
            {
                MessageBox.Show("Välj månad!");
            }

            try
            {
                TBox_Budget_Monthly_Dec =
                    Convert.ToDecimal(TBox_Budget_Monthly.Text);

                if (TBox_Budget_Monthly_Dec == 0) throw new FormatException();
            }

            catch (FormatException) { MessageBox.Show("Ange månadsbudget!"); }

            catch (OverflowException)
            {
                MessageBox.Show(
                    "Ange ett värde mellan " +
                    decimal.MinValue +
                    " och " +
                    decimal.MaxValue);
            }

            if (!(String.IsNullOrEmpty(LBox_Months_Selection_Str)) &&
                TBox_Budget_Monthly_Dec != 0)
            {
                Budget MyBudget = new Budget(
                    LBox_Months_Selection_Str,
                    TBox_Budget_Monthly_Dec);

                TBox_Budget_Daily.Text =
                    MyBudget.GetDailyBudget().ToString("0.##") + "kr";
            }
        }
    }
}
