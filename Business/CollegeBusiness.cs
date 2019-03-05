using Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class CollegeBusiness
    {
        public string WelcomeMessage(CollegeModel collegeModel)
        {

            return $"Dear student, welcome to {collegeModel.Name} College.";
        }
        public string MaxSizeReached(CollegeModel collegeModel)
        {
            if(collegeModel.NumberOfClass> collegeModel.MaxCapacity)
            return $"{collegeModel.Name}College has reached the maximum size of capacity";
            return "";
        }
        public string NumberOfTeacher(CollegeModel collegeModel)
        {
            return $"{collegeModel.Name}College has Number of Teacher =  {collegeModel.NumberOfTeacher}";
        }
    }
}
