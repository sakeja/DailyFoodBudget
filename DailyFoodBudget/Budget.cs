/*
 * Laboration 2 i kursen Grundläggande programmering
 * Av Sam Jansson, 2017-10-02
 *
 * DailyFoodBudget: Ett simpelt program för att beräkna daglig matbudget.
 * 
 * Inkluderade klass(er):
 * Budget.cs: Beräknar med hjälp av Month-klassen dagsbudgeten baserat på vald
 * månad och totalt antal dagar i månaden.
 * 
 * Month.cs: Beräknar antal dagar att budgetera för baserat på vald månad.
 */

namespace DailyFoodBudget
{
    class Budget
    {
        private Month month;
        private decimal
            monthlyBudget,
            dailyBudget;

        // Konstruktor
        public Budget(string input_month,
                      decimal input_budget)
        {
            month = new Month(month: input_month);
            monthlyBudget = input_budget;
            SetDailyBudget();
        }

        // Beräkna dagsbudget.
        public void SetDailyBudget()
        {
            dailyBudget = monthlyBudget / month.GetDaysInMonth();
        }

        // Metod för att hämta dagsbudget.
        public decimal GetDailyBudget() { return dailyBudget; }
    }
}
