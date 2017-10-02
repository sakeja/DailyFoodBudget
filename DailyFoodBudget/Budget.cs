namespace DailyFoodBudget
{
    class Budget
    {
        private Month month;
        private decimal
            monthlyBudget,
            dailyBudget;

        public Budget(string input_month,
                      decimal input_budget)
        {
            month = new Month(month: input_month);
            monthlyBudget = input_budget;
            SetDailyBudget();
        }

        public void SetDailyBudget()
        {
            dailyBudget = monthlyBudget / month.GetDaysInMonth();
        }

        public decimal GetDailyBudget() { return dailyBudget; }
    }
}
