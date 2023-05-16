using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

/*Samantha Sutter
 * Final Assignment
 * ITDEV-115-200
 * Janese Christie
 * 05/15/23 */

namespace Sutter_Final
{
    class StudentS
    {
        List<Student> theStudentList;

        public string PopulateStudents(string path)
        {
            //Instance of theStudentList
            theStudentList = new List<Student>();

            try
            {
                //Creating instance of SteamReader class to read data from file 
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;
                    //read next line and loop until null or line = ""
                    while ((line = sr.ReadLine()) != null)
                    {
                        //Split the line
                        string[] data = line.Split(',');
                        //Setting id, first name and last name
                        string id = data[0];
                        string firstName = data[1];
                        string lastName = data[2];

                        //Creating instance of student with filled id, first and last name
                        Student student = new Student(id , firstName, lastName);

                        //Loop through remaining fields 3 - 23 for earned and possible and set though method EnterGrade.
                        for (int i = 3; i < data.Length; i += 2)
                        {
                            int earned = int.Parse(data[i]);
                            int possible = int.Parse(data[i + 1]);
                            student.EnterGrade( earned, possible);
                        }
                        //Set the average and grade.
                        student.CalGrade();
                        //Adding student to theStudentList
                        theStudentList.Add(student);
                    }
                    //Closing the file
                    sr.Close();
                }
            }
            //Catching exception and returning error message
            catch (Exception e)
            {
                return "Error: " + e.Message;
            }
            //Returning message if populated successfully
            return "Populatuion completed successfully!";

        }

        public int ListLength
        {
            get { return theStudentList.Count; }
        }

        public string StudentID(int index)
        {
            return theStudentList.ElementAt(index).ID;
        }

        public string StudentLastName(int index)
        {
            return theStudentList.ElementAt(index).NameLast;
        }

        public string StudentGrade(int index)
        {

            return theStudentList.ElementAt(index).LetterGrade;
        }

        public float StudentAverage(int index)
        {

            return theStudentList.ElementAt(index).Average;
        }

    }

}

