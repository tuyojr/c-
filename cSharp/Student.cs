using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp
{
    internal class Student
    {

        public string name;
        public string path;
        public double cgpa;


        public Student(string aName, string aPath, double aCgpa)
        {

            name = aName;
            path = aPath;
            cgpa = aCgpa;

        }

        public string Honors()
        {
            if (cgpa >= 3.5)
            {
                return "Congratulations " + name + "! You are a honors student with " + cgpa + " CGPA in " + path;
                //return true; (if the return type was boolean)
            } else
            {
                return "Congratulations " + name + " on your graduation! You finished with " + cgpa + " CGPA in " + path;
                //return false; (if the return type was boolean)
            }
        }

    }
}
