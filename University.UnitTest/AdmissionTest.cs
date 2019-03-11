using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Contract;
using Business;


namespace University.UnitTest
{
    public class AdmissionTest
    {
        private static DateTime _date;
        public AdmissionTest()
        {
            _date = DateTime.Now;
        }

        [Theory]
        [InlineData("Math",20,15)]
        public void Test_Capacity_Exceed(string courseName,int submited,int capacity)
        {
            //Arrange
            var fakeModel = new AdmissionModel()
            {
                Course = courseName,
                NumberOfSubmittedStudents=submited,
                CapacityOfStudents=capacity
            };
            var fakeAdmissionLogic = new Business.AdmissionLogic();

            //Act
            var actualResult = fakeAdmissionLogic.CapacityExceed(fakeModel);

            //Assert
            Assert.Equal($"The course {fakeModel.Course} has reached the maximum size of capacity", actualResult);

        }

        [Theory]
        [InlineData("Math",40,30)]
        public void Test_Course_Specification(string courseName,int duration,int capacity)
        {
            //Arrange
            var fakeModel = new AdmissionModel()
            {
                Course = courseName,
                Duration = duration,
                CapacityOfStudents=capacity
            };
            var fakeAdmissionLogic = new Business.AdmissionLogic();

            //Act
            var actualResult = fakeAdmissionLogic.CourseSpecification(fakeModel);

            //Assert
            Assert.Equal($"The Course '{fakeModel.Course}' will carry out in {fakeModel.Duration} hours with the number of {fakeModel.CapacityOfStudents} Students", actualResult);
        }
         
       [Fact]
        public void Test_Get_Persian_CloseDate()
        {
            //Arrange
            var fakeModel = new AdmissionModel()
            {
                DateOfClose=_date
            };
            var fakeAdmissionLogic = new Business.AdmissionLogic();

            //Act
            var actualResult = fakeAdmissionLogic.GetPersianCloseDate(fakeModel);

            //Assert
            System.Globalization.PersianCalendar pdate = new System.Globalization.PersianCalendar();
            var closeYear = pdate.GetYear(fakeModel.DateOfClose);
            var closeMonth = pdate.GetMonth(fakeModel.DateOfClose);
            var closeDay = pdate.GetDayOfMonth(fakeModel.DateOfClose);
            Assert.Equal($"{closeYear}/{closeMonth.ToString().PadLeft('0')}/{closeDay.ToString().PadLeft('0')}", actualResult);
        }

       [Fact]
        public void Test_Get_Georgian_CloseDate()
        {
            //Arrange
            var fakeModel = new AdmissionModel()
            {
                DateOfClose = _date
            };
            var fakeAdmissionLogic = new Business.AdmissionLogic();

            //Act
            var actualResult = fakeAdmissionLogic.GetGeorgianCloseDate(fakeModel);

            //Assert
            Assert.Equal(fakeModel.DateOfClose, actualResult);
        }

    }
}
