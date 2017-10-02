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
            ListBoxItem LBox_Months_Selection = LBox_Months.SelectedItem as ListBoxItem;
            Budget budget = new Budget(LBox_Months_Selection.Content.ToString(),
                                       Convert.ToDecimal(TBox_Budget_Monthly.Text));
            TBox_Budget_Daily.Text = budget.GetDailyBudget().ToString("0.##");
        }
    }
}
