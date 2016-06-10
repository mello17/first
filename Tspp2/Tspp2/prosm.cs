using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tspp2
{
    
    public partial class prosm : Form
    {
       Student obj=new Student("", "", "", 0,0);
        Dekanat obj1 =new Dekanat("", "", "", 0,0);
        public LinkedList<Student> StudentList=new LinkedList<Student>();
        DataTable ob = new DataTable();
        ReadOnlyAttribute rd;
        public prosm()
        {
           
            InitializeComponent();
            ob.Columns.Add("Имя");
            
           ob.Columns.Add("Фамилия");
            ob.Columns.Add("группа");
            ob.Columns.Add("Средняя оценка");
            ob.Columns.Add("Пропуски");
            
            Column1.Visible = false;
            Column2.Visible = false;
            Column3.Visible = false;
            Column4.Visible = false;
            Column5.Visible = false;
            StudentList = new LinkedList<Student>();
            this.dataGridView1.DataSource = ob;
            
            //  this.Hide();


        }
      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            obj.Name = textBox1.Text;
            //this.dataGridView1.DataSource = obj.Name;
            
          //  ob.Rows.Add(obj.Name);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            obj.Family = textBox2.Text;
          // this.dataGridView1.DataSource = obj.Family;
            // ob.Rows.Add(obj.Family);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
            obj.Group = textBox3.Text;
           // this.dataGridView1.DataSource = obj.Group;
            // ob.Rows.Add(obj.Group);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.dataGridView1.DataSource = obj1.hm;

         // StudentList.AddFirst(obj);
           
          //  ob.Rows.Add(obj.Name,obj.Family,obj.Group,obj.Sr_ocen,obj.Obj_prop);
            ob.Rows.Add(obj1.add_student());
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
          

            }
        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void prosm_Load(object sender, EventArgs e)
        {
            this.Text = "ProjectVasya";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "XML-файлы (*.xml)|*.xml|All files (*.*)|*.*";
            saveFileDialog1.Filter = "XML-файлы (*.xml)|*.xml|All files (*.*)|*.*";
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName == null)
            {
                return;
            }
            try
            {
                DataSet DS = new DataSet();
                DS.ReadXml(openFileDialog1.FileName);
                dataGridView1.DataSource = DS.Tables[0];
                dataGridView1.Refresh();
            }
            catch (FileNotFoundException exp)
            {
                MessageBox.Show(exp.Message + "\nФайл не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {

            saveFileDialog1.FileName = openFileDialog1.FileName;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) Save();
        }
        void Save()
        {
            try
            {
                DataSet  DS = new DataSet();
                DS.Tables.Add(ob);
                DS.WriteXml(saveFileDialog1.FileName);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void prosm_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 o = new Form1();
            this.Visible = false;
            o.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
        }
    }
    }

