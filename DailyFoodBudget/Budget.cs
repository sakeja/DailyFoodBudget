using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyFoodBudget
{
    class Budget
    {
        private Month month;
        private decimal
            dMonthlyBudget,
            dDailyBudget;

        public Budget(string input_month,
                      decimal input_budget)
        {
            month = new Month(month: input_month);
            dMonthlyBudget = input_budget;
            SetDailyBudget();
        }

        public void SetDailyBudget()
        {
            dDailyBudget = dMonthlyBudget / (decimal) month.GetDaysInMonth();
        }

        public decimal GetDailyBudget() { return dDailyBudget; }
    }
}
