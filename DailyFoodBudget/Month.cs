using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DailyFoodBudget
{
    class Month
    {
        private DateTime CurrentDate;
        private string sMonth;
        private int iDaysInMonth;

        public Month(string month)
        {
            sMonth = month;
            CurrentDate = DateTime.Now;
            SetDaysInMonth(month: sMonth);
            MessageBox.Show(sMonth);
        }

        public void SetDaysInMonth(string month)
        {
            switch (month)
            {
                case "Januari":
                    iDaysInMonth = DateTime.DaysInMonth(CurrentDate.Year, 1);
                    break;

                case "Februari":
                    iDaysInMonth = DateTime.DaysInMonth(CurrentDate.Year, 2);
                    break;

                case "Mars":
                    iDaysInMonth = DateTime.DaysInMonth(CurrentDate.Year, 3);
                    break;

                case "April":
                    iDaysInMonth = DateTime.DaysInMonth(CurrentDate.Year, 4);
                    break;

                case "Maj":
                    iDaysInMonth = DateTime.DaysInMonth(CurrentDate.Year, 5);
                    break;

                case "Juni":
                    iDaysInMonth = DateTime.DaysInMonth(CurrentDate.Year, 6);
                    break;

                case "Juli":
                    iDaysInMonth = DateTime.DaysInMonth(CurrentDate.Year, 7);
                    break;

                case "Augusti":
                    iDaysInMonth = DateTime.DaysInMonth(CurrentDate.Year, 8);
                    break;

                case "September":
                    iDaysInMonth = DateTime.DaysInMonth(CurrentDate.Year, 9);
                    break;

                case "Oktober":
                    iDaysInMonth = DateTime.DaysInMonth(CurrentDate.Year, 10);
                    break;

                case "November":
                    iDaysInMonth = DateTime.DaysInMonth(CurrentDate.Year, 11);
                    break;

                case "December":
                    iDaysInMonth = DateTime.DaysInMonth(CurrentDate.Year, 12);
                    break;

                default:
                    iDaysInMonth = 30;
                    break;
            }
        }

        public int GetDaysInMonth() { return iDaysInMonth; }
    }
}
