using Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class ClassBusiness
    {

        public string WelcomeMessage()
        {
            return "Welcome to 'ClassName' dear student.";
        }

        public string MaxSizeReached(ClassModel model)
        {
            if (model.CapacityOfStudents > 100)
                return "Size of Capacity  ";
            else return "";
        }

        public string ChairIsEmpty(ClassModel model)
        {
            if (model.Chair == 0)
                return "class has empty of chair";
            else
                return "";
        }

        public string GenarateTheArea(ClassModel model)
        {
            var AreaOfStudent = model.Area % model.CapacityOfStudents;

            return string.Format($"{AreaOfStudent} area of each student");
        }


    }
}
