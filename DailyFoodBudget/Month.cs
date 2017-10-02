using System;

namespace DailyFoodBudget
{
    class Month
    {
        private DateTime CurrentDate;
        private string budgetMonth;
        private int budgetDays;

        public Month(string month)
        {
            budgetMonth = month;
            CurrentDate = DateTime.Now;
            SetBudgetDays();
        }

        public void SetBudgetDays()
        {
            switch (budgetMonth)
            {
                case "Januari":
                    budgetDays = DateTime.DaysInMonth(CurrentDate.Year, 1);
                    break;

                case "Februari":
                    budgetDays = DateTime.DaysInMonth(CurrentDate.Year, 2);
                    break;

                case "Mars":
                    budgetDays = DateTime.DaysInMonth(CurrentDate.Year, 3);
                    break;

                case "April":
                    budgetDays = DateTime.DaysInMonth(CurrentDate.Year, 4);
                    break;

                case "Maj":
                    budgetDays = DateTime.DaysInMonth(CurrentDate.Year, 5);
                    break;

                case "Juni":
                    budgetDays = DateTime.DaysInMonth(CurrentDate.Year, 6);
                    break;

                case "Juli":
                    budgetDays = DateTime.DaysInMonth(CurrentDate.Year, 7);
                    break;

                case "Augusti":
                    budgetDays = DateTime.DaysInMonth(CurrentDate.Year, 8);
                    break;

                case "September":
                    budgetDays = DateTime.DaysInMonth(CurrentDate.Year, 9);
                    break;

                case "Oktober":
                    budgetDays = DateTime.DaysInMonth(CurrentDate.Year, 10);
                    break;

                case "November":
                    budgetDays = DateTime.DaysInMonth(CurrentDate.Year, 11);
                    break;

                case "December":
                    budgetDays = DateTime.DaysInMonth(CurrentDate.Year, 12);
                    break;
            }
        }

        public int GetDaysInMonth() { return budgetDays; }
    }
}
