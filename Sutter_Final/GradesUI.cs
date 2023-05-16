using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

/*Samantha Sutter
 * Final Assignment
 * ITDEV-115-200
 * Janese Christie
 * 05/15/23 */


namespace Sutter_Final
{
    class GradesUI
    {
        StudentS myStudentS;

        public void MainMethod()
        {
            //Creating instance of StudentUI
            myStudentS = new StudentS();

            //Setting path to grades text file
            string path = "grades.txt";
            //Setting result to return from PopulateStudents with grades text file
            string result = myStudentS.PopulateStudents(path);

            
            //Verifying if file was successfully read
            //If return from PopulateStudents starts with "Error: " displaying error msg to user
            if (result.StartsWith("Error: "))
            {
                WriteLine("An error occurred while populating ");
                WriteLine(result);
            }
            //If populated correctly displaying students information
            else
            {
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
