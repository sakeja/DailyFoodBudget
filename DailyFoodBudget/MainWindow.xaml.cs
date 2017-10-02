/*
 * TODO: Implementera separat InputHandler-klass.
 * TODO: Implementera separat ErrorHandler-klass.
 */

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
            // Objekt som representerar vald månad.
            ListBoxItem LBoxMonthsSelection;
            // Objektets innehåll (månad) representerat som sträng.
            string lboxMonthsSelectionStr = "";
            // decimal-datatyp för finansiella tillämpningar.
            decimal tboxBudgetMonthlyDec = 0;

            // Säkerställ att en månad är vald.
            try
            {
                // Tilldela instansen vald månad.
                LBoxMonthsSelection =
                    LBox_Months.SelectedItem as ListBoxItem;

                /*
                 * Om ingen månad är vald, trigga undantag då
                 * LBoxMonthsSelection är null.
                 */
                if (LBoxMonthsSelection == null)
                    throw new ArgumentNullException();

                // Hämta objektets innehåll (månaden) representerat som sträng.
                lboxMonthsSelectionStr =
                    LBoxMonthsSelection.Content.ToString();

                // Säkerställ att månadsbudget är angiven.
                try
                {
                    /*
                     * Konvertera angiven månadsbudget från sträng till decimal
                     * datatyp.
                     */
                    tboxBudgetMonthlyDec =
                        Convert.ToDecimal(TBox_Budget_Monthly.Text);

                    /*
                     * Convert.ToDecimal(String) returnerar 0 om String är null.
                     * Trigga undantag om månadsbudget ej är angiven.
                     */
                    if (tboxBudgetMonthlyDec == 0) throw new FormatException();
                }

                // Visa felmedd. om månadsbudget ej är angiven.
                catch (FormatException)
                {
                    MessageBox.Show("Ange månadsbudget!", "Ett fel uppstod!");
                }

                /*
                 * Visa felmedd. om månadsbudgeten är för stor eller liten för
                 * datatypen decimal.
                 */
                catch (OverflowException)
                {
                    MessageBox.Show(
                        "Ange en månadsbudget mellan " +
                        decimal.MinValue + "kr" +
                        " och " +
                        decimal.MaxValue + "kr",
                        "Ett fel uppstod!");
                }
            }

            // Visa felmeddelande om månad ej är angiven.
            catch (ArgumentNullException)
            {
                MessageBox.Show("Välj månad!", "Ett fel uppstod!");
            }

            /*
             * Säkerställ slutligen att en månad och dess tillhörande
             * budgetbelopp är angivna innan Budget-klassen instansieras.
             */
            if (!(String.IsNullOrEmpty(lboxMonthsSelectionStr)) &&
                tboxBudgetMonthlyDec != 0)
            {
                Budget MyBudget = new Budget(
                    input_month: lboxMonthsSelectionStr,
                    input_budget: tboxBudgetMonthlyDec);

                // Visa beräknad dagsbudget med två decimalers precision.
                TBox_Budget_Daily.Text =
                    MyBudget.GetDailyBudget().ToString("0.##") + "kr";
            }
        }
    }
}
