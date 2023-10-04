using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;

namespace marc_sheet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\t\t======\"school Marc Sheet\"======\n");
            Console.WriteLine("\t\t\t\t\t\t======\"Result of \b\b Final Exam\"=====\n");
            Console.Write("\t\t\t\t\t Class\t \"5\"  G.R.No  \"3139\"  Roll No.\"3139/1\"\n");

            Console.Write("======Enter Your F_Name:======");
            string fname = Console.ReadLine();
            Console.Write("======Enter Your L_Name:======");
            string lname = Console.ReadLine();
            Console.Write("======Enter Your Father_Name:======");
            string fhname = Console.ReadLine();
            Console.Write("======Enter Your Age:======");
            int age = int.Parse(Console.ReadLine());
            Console.Write("======Enter Your city:======");
            string city = Console.ReadLine();

            Console.Write("\t\t\t\t\tYur Full Name:{0} and Fater Name:{1}  {2} years old: form:{3}\n", fname + lname, fhname, age, city);

            Console.WriteLine("========================================================================================================================");



            Console.WriteLine("\t\t\t\t\t\t\t======\"Enter Your Subject  Marks\"======");
            Console.Write("======Islamic Studies:======");
            float islamic = float.Parse(Console.ReadLine());
            Console.Write("======English:======");
            float english = float.Parse(Console.ReadLine());
            Console.Write("======Pakistan Studies:======");
            float pakistan = float.Parse(Console.ReadLine());
            Console.Write("======Computer Science:======");
            float computer = float.Parse(Console.ReadLine());
            Console.Write("======Mathematics:======");
            float mathematics = float.Parse(Console.ReadLine());
            Console.Write("======Physics:======");
            float physics = float.Parse(Console.ReadLine());
            
            Console.WriteLine("========================================================================================================================");

            string grade = "faill";

            if (islamic >= 60 && islamic <= 65)
            {
                grade = "C";
            }
            else if (islamic >= 66 && islamic <= 71)
            {
                grade = "C+";
            }
            else if (islamic >= 72 && islamic <= 78)
            {
                grade = "B";
            }
            else if (islamic >= 79 && islamic <= 84)
            {
                grade = "B+";
            }
            else if (islamic > 84)
            {
                grade = "A";
            }

            
            //*************************************************************
            string e_Grade = "faill";

            if (english >= 60 && english <= 65)
            {
                e_Grade = "C";
            }
            else if (english >= 66 && english <= 71)
            {
                e_Grade = "C+";
            }
            else if (english >= 72 && english <= 78)
            {
                e_Grade = "B";
            }
            else if (english >= 79 && english <= 84)
            {
                e_Grade = "B+";
            }
            else if (english > 84)
            {
                e_Grade = "A";
            }
            //*************************************************************
            string p_Pakistan = "faill";

            if (pakistan >= 60 && pakistan <= 65)
            {
                p_Pakistan = "C";
            }
            else if (pakistan >= 66 && pakistan <= 71)
            {
                p_Pakistan = "C+";
            }
            else if (pakistan >= 72 && pakistan <= 78)
            {
                p_Pakistan = "B";
            }
            else if (pakistan >= 79 && pakistan <= 84)
            {
                p_Pakistan = "B+";
            }
            else if (pakistan > 84)
            {
                p_Pakistan = "A";
            }
            //*************************************************************
            string c_Grade = "faill";

            if (computer >= 60 && computer <= 65)
            {
                c_Grade = "C";
            }
            else if (computer >= 66 && computer <= 71)
            {
                c_Grade = "C+";
            }
            else if (computer >= 72 && computer <= 78)
            {
                c_Grade = "B";
            }
            else if (computer >= 79 && computer <= 84)
            {
                c_Grade = "B+";
            }
            else if (computer > 84)
            {
                c_Grade = "A";
            }
            //*************************************************************
            string m_Grade = "faill";

            if (mathematics >= 60 && mathematics <= 65)
            {
                m_Grade = "C";
            }
            else if (mathematics >= 66 && mathematics <= 71)
            {
                m_Grade = "C+";
            }
            else if (mathematics >= 72 && mathematics <= 78)
            {
                m_Grade = "B";
            }
            else if (mathematics >= 79 && mathematics <= 84)
            {
                m_Grade = "B+";
            }
            else if (mathematics > 84)
            {
                m_Grade = "A";
            }
            //*************************************************************
            string ph_Grade = "faill";

            if (physics >= 60 && physics <= 65)
            {
                ph_Grade = "C";
            }
            else if (physics >= 66 && physics <= 71)
            {
                ph_Grade = "C+";
            }
            else if (physics >= 72 && physics <= 78)
            {
                ph_Grade = "B";
            }
            else if (physics >= 79 && physics <= 84)
            {
                ph_Grade = "B+";
            }
            else if (physics > 84)
            {
                ph_Grade = "A";
            }

            Console.WriteLine("    Coruse        | Obtained Marks | Our Of | parcentage | Individual  grade |");
            Console.WriteLine(" islamic Studies  " + "        " + islamic + "       " + "  75 " + "        " + (islamic * 100 / 75) + "%" + " \t\t\t" + (grade));
            Console.WriteLine(" English          " + "        " + english + "       " + "  75 " + "        " + (english * 100 / 75) + "%" + " \t\t\t" + (e_Grade));
            Console.WriteLine(" Pakistan Studies " + "        " + pakistan + "       " + "  75 " + "       " + (pakistan * 100 / 75) + "%" + " \t\t\t" + (p_Pakistan));
            Console.WriteLine(" Computer Science " + "        " + computer + "       " + "  100 " + "        " + (computer * 100 / 100) + "%" + " \t\t\t" + (c_Grade));
            Console.WriteLine(" Mathematics      " + "        " + mathematics + "       " + "  100 " + "        " + (mathematics * 100 / 100)+ "%" + "\t\t\t" + (m_Grade));
            Console.WriteLine(" Physics          " + "        " + physics + "       " + "  100 " + "        " + (physics * 100 / 100) + "%"+ " \t\t\t" + (ph_Grade));
            Console.WriteLine("========================================================================================================================");
            

            Console.Write("\vTotal Marks : {0} \t", (islamic + english + pakistan + computer + mathematics + physics));

            int marks = Convert.ToInt32((pakistan + english + islamic + computer + mathematics + physics) / 525 * 100);




            string t_grade = "faill";

            if (marks >= 60 && marks <= 65)
            {
                t_grade = "C";
            }
            else if (marks >= 66 && marks <= 71)
            {
                t_grade = "C+";
            }
            else if (marks >= 72 && marks <= 78)
            {
                t_grade = "B";
            }
            else if (marks >= 79 && marks <= 84)
            {
                t_grade = "B+";
            }
            else if (marks > 84)
            {
                t_grade = "A";
            }

            Console.WriteLine("\v===============================================================================================");
            Console.WriteLine("\t\t\t\tPercentage:" + marks + "\t\t\t\tgrade:" +  t_grade);
        }
    }
}
