using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tspp2
{
   public class Student 
    {
        public string Name;
        public string Family;

        //public string Fakultet;
        public string Group;
        public string Course;
        public int Sr_ocen;
        public int Obj_prop;
       public Student obj;
        public Student(String name, String family, String group, int sr, int prop)
        {
            Name = name;
            this.Family = family;
            //this.Fakultet = Fakultet;
            this.Group = group;
           // this.Course = Course;
            this.Sr_ocen = sr;
            this.Obj_prop = prop;

        }
        public string family
        {
            get
            {
                return family;
            }
            set
            {
                family= value;
            }
        }
        public string name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string group
        {
            get
            {
                return group;
            }
            set
            {
                group = value;
            }
        }
        public string sr
        {
            get
            {
                return sr;
            }
            set
            {
                sr = value;
            }
        }
        public string gr
        {
            get
            {
                return gr;
            }
            set
            {
                gr = value;
            }
        }
    }
    class Dekanat : Student
    {
        public List <Student> hm = new List<Student>();
       
        public Dekanat(string name, String Family, String Group, int Sr_ocen, int Obj_prop)
       : base(name, Family,  Group,Sr_ocen, Obj_prop)
        {
        }
        
        public List<Student> add_student()
        {
           hm.Add(  obj = new Student(


                Name ,

                Family ,

                Group ,
                 Sr_ocen, Obj_prop));
            

           
            return hm;
        }
        void prosmotr()
        {
            
        }
    }

static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
