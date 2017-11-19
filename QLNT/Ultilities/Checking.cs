using System;
using System.Windows.Forms;

namespace QLNT.Ultilities
{
    class Checking
    {
        public static bool IsInOfDate(DateTime startDate, DateTime endDate)
        {
            return DateTime.Now >= startDate && DateTime.Now < endDate;
        }

    }
}

