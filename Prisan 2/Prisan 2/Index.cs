using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prisan_2
{
    public partial class STM
    {
        private string Student_name;
        private int Student_id;
        public STM(string student_name, int student_id)        {
            this.Student_name = student_name;
            this.Student_id = student_id;
        }

    }
    public partial class STM
    {
        public void display()
        {
            Console.WriteLine("Student's name is : " + Student_name);
            Console.WriteLine("Student's ID is : " + Student_id);
        }

    }


}