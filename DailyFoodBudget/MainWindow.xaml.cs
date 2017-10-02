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
            ListBoxItem LBoxMonthsSelection;
            string lboxMonthsSelectionStr = "";
            decimal tboxBudgetMonthlyDec = 0;

            try
            {
                LBoxMonthsSelection =
                    LBox_Months.SelectedItem as ListBoxItem;

                if (LBoxMonthsSelection == null)
                    throw new ArgumentNullException();

                lboxMonthsSelectionStr =
                    LBoxMonthsSelection.Content.ToString();

                if (String.IsNullOrEmpty(lboxMonthsSelectionStr))
                    throw new ArgumentNullException();

                try
                {
                    tboxBudgetMonthlyDec =
                        Convert.ToDecimal(TBox_Budget_Monthly.Text);

                    if (tboxBudgetMonthlyDec == 0) throw new FormatException();
                }

                catch (FormatException) { MessageBox.Show("Ange månadsbudget!"); }

                catch (OverflowException)
                {
                    MessageBox.Show(
                        "Ange en månadsbudget mellan " +
                        decimal.MinValue + "kr" +
                        " och " +
                        decimal.MaxValue + "kr");
                }
            }

            catch (ArgumentNullException)
            {
                MessageBox.Show("Välj månad!");
            }

            if (!(String.IsNullOrEmpty(lboxMonthsSelectionStr)) &&
                tboxBudgetMonthlyDec != 0)
            {
                Budget MyBudget = new Budget(
                    lboxMonthsSelectionStr,
                    tboxBudgetMonthlyDec);

                TBox_Budget_Daily.Text =
                    MyBudget.GetDailyBudget().ToString("0.##") + "kr";
            }
        }
    }
}
