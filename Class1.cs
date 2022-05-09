using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INHERITANCE
{
    internal class Student
    {
        public int tot, sub;
        public float avg;
        public string grade;
    }

    class School : Student
    {
        public string gradecal()
        {
            avg = tot/sub;
            if (avg <= 90&& avg<=100)
            {
                grade ="A";
            }
            else
            {
                grade ="B";
            }
            return grade;

        }
    }
        class College : Student
        {
            public string gradecal()
            {
                avg = tot/sub;
                if (avg <= 90&& avg<=100)
                {
                    grade="1";
                }
                else
                {
                    grade="2";
                }
                return grade;
            }
        }
    }

        
