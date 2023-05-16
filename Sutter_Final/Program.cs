using System;

/*Samantha Sutter
 * Final Assignment
 * ITDEV-115-200
 * Janese Christie
 * 05/15/23 */


namespace Sutter_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating instance of GradesUI
            GradesUI ui = new GradesUI();
            //instantiating info class
            Info info = new Info();
            //displaying class information
            info.DisplayInfo("Final Assignment - Student List");
            //running the application
            ui.MainMethod();
        }
    }
}
