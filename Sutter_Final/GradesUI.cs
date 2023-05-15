using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Sutter_Final
{
    class GradesUI
    {
        StudentS myStudentS;

        public void MainMethod()
        {
            //instance an object of StudentUI..
            myStudentS = new StudentS();

            //Call StudentUI->PopulateStudents..
            string path = "grades.txt";
            string result = myStudentS.PopulateStudents(path);

            //Verify file was successfully read.
            //else display error message.
            if (result.StartsWith("Error: "))
            {
                WriteLine("An error occurred while populating ");
                WriteLine(result);
            }
            else
            {
                //if successfull call DisplayInfo()
               DisplayInfo();

            }
        }

        void DisplayInfo()
        {
            WriteLine("Student id\tLast Name\tAverage  \tGrade");

            for (int index = 0; index < myStudentS.ListLength; index++)
            {

                WriteLine(" {0} \t {1}    \t {2}    \t {3}", myStudentS.StudentID(index), myStudentS.StudentLastName(index), myStudentS.StudentAverage(index), myStudentS.StudentGrade(index));

            }
            ReadKey();
        }
    }
}
