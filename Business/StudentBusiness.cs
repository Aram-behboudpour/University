using Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class StudentBusiness
    {
        public string GetFullName(StudentModel model)
        {
            return $"{model.FirstName} {model.LastName}";
        }

        public string GetWelcome(StudentModel model)
        {
            return $"Welcome to university {model.FirstName}";
        }
        public string ConvertDateOfBirth(StudentModel model)
        {
            System.Globalization.PersianCalendar p = new System.Globalization.PersianCalendar();
            var year = p.GetYear(model.DateOfBirth);
            var month = p.GetMonth(model.DateOfBirth);
            var day = p.GetDayOfMonth(model.DateOfBirth);
            return $"{year}/{month.ToString().PadLeft('0')}/{day.ToString().PadLeft('0')}";
        }
        public int GetSalary(StudentModel model)
        {
            if (model.Age >= 20)
            {
                return 100;
            }
            else
            {
                return 0;
            }
        }
    }
}
