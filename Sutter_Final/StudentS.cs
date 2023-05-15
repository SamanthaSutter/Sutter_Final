using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Sutter_Final
{
    class StudentS
    {
        List<Student> theStudentList;



        public string PopulateStudents(string path)
        {
            //this is the method you need to implement...NO CONSOLE LOGIC in this file.
            //use the parameter path for file name, and return an error string!!
            //1) create instance of theStudentList (theStudentList = new List<Student>();)
            List<Student> theStudentList = new List<Student>();
            
            //2) create an instance of the StreamReader Class to read the data from the file named in the variable path

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;
                    //3) Open the File and read line by line using theReadLIne command
                    //9) read next line and loop until null or line = ""
                    while ((line = sr.ReadLine()) != null)
                    {
                        //4) split the line
                        string[] data = line.Split(',');
                        string id = data[0];
                        string firstName = data[1];
                        string lastName = data[2];

                        //5) create one instance of Student, fill in id, first and last through the constructor
                        Student student = new Student(id , firstName, lastName);

                        //6) now loop through remaining fields 3 - 23 for earned and possible and set though method EnterGrade.
                        for (int i = 3; i < data.Length; i += 2)
                        {
                            int earned = Int16.Parse(data[i]);
                            int possible = Int16.Parse(data[i + 1]);
                            student.EnterGrade( earned, possible);
                        }
                        //7) call CalGrade on the Student object - that sets the average and grade.
                        student.CalGrade();
                        //8) Add that Student to theStudentList (theStudentList.Add(aStudent);)
                        theStudentList.Add(student);
                    }
                    //10) Close the file
                    sr.Close();
                }
            }
            //do not forgot to use a Try/Catch block.
            catch (Exception e)
            {
                return "Error: " + e.Message;
            }
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

