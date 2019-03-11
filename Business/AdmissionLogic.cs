using System;
using System.Collections.Generic;
using System.Text;
using Contract;

namespace Business
{
    public class AdmissionLogic
    {
        public string CapacityExceed(AdmissionModel model)
        {
            string result = string.Empty;

            if (model.NumberOfSubmittedStudents > model.CapacityOfStudents)
                result = $"The course {model.Course} has reached the maximum size of capacity";

            return result;
        }

        public string CourseSpecification(AdmissionModel model)
        {
            return $"The Course '{model.Course}' will carry out in {model.Duration} hours with the number of {model.CapacityOfStudents} Students";
        }

        public string GetPersianCloseDate(AdmissionModel model)
        {
            System.Globalization.PersianCalendar pdate = new System.Globalization.PersianCalendar();
            var closeYear = pdate.GetYear(model.DateOfClose);
            var closeMonth = pdate.GetMonth(model.DateOfClose);
            var closeDay = pdate.GetDayOfMonth(model.DateOfClose);
            return $"{closeYear}/{closeMonth.ToString().PadLeft('0')}/{closeDay.ToString().PadLeft('0')}";
        }

        public DateTime GetGeorgianCloseDate(AdmissionModel model)
        {
            return model.DateOfClose;
        }


    }
}
