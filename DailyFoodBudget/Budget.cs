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
