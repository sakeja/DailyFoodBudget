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

using System;

namespace DailyFoodBudget
{
    class Month
    {
        // Objekt för att representera nuvarande datum.
        private DateTime CurrentDate;
        // Månaden att budgetera för.
        private string budgetMonth;
        // Totalt antal dagar i månaden att budgetera för.
        private int budgetDays;

        // Konstruktor.
        public Month(string month)
        {
            budgetMonth = month;
            // Initiera objektet till nuvarande datum och tid.
            CurrentDate = DateTime.Now;
            SetBudgetDays();
        }

        // Beräkna totalt antal dagar i månaden att budgetera för.
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

        // Metod för att hämta totalt antal dagar i budgetmånaden.
        public int GetDaysInMonth() { return budgetDays; }
    }
}
