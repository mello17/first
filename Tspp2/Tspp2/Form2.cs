using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Tspp2
{
    public partial class Form2 : Form
    {
        Student obj = new Student("", "", "", 0,0);
        Dekanat obj1 = new Dekanat("","","",0,0);
        prosm obj2 = new prosm();
        DataTable gr= new DataTable();
      //  Student[] arr = new Student[3];
        
        public Form2()
        {
            InitializeComponent();
             
            //gr.Columns.Add("Лаб работа№1");
            //gr.Columns.Add("Лаб работа№2");
            //gr.Columns.Add("Лаб работа№3");
            //gr.Columns.Add("Лаб работа№4");
            //gr.Columns.Add("Лаб работа№5");
            //gr.Columns.Add("Cредняя оценка");
                dataGridView1.Columns.Add(" ","ФИО");
          //  this.dataGridView1.DataSource = gr.Columns;

           
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            prosm o = new prosm();
            o.Visible = true;
        }
    }
}
