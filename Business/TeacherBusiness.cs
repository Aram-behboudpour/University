using Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
   public class TeacherBusiness
    {
        
        public string GetFullName(TeacherModel Model)

        {
            string FullName;
            FullName =  Model.FirstName + Model.LastName;
            return $"Teacher FullName is : {FullName} ";

           

        }

        public string ShowMessage ()
        {
            return "Welcome to university dear Arash";
        }

        public int GetSalary (TeacherModel Model)
        {
            if (Model.Age > 10)
                return 1000;
            else
                return 500;

        }

    }
}
