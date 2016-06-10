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
    
    public partial class Form1 : Form
    {
        prosm o = new prosm();
        Form2 b = new Form2();
        public Form1()
        {
            InitializeComponent();
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Enter password";
            textBox1.PasswordChar = '*';
            textBox1.TextAlign = HorizontalAlignment.Center;
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


            
         
        
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.Text = "Enter password";
            textBox1.PasswordChar = '*';
            textBox1.TextAlign = HorizontalAlignment.Center;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            switch (textBox1.Text) {
                case "Dekan":
            
             //   MessageBox.Show("Good Day, Dekan");
                    this.Visible=false;
                   
                    o.Visible = true;

                    break;
                case "Lector":
                    this.Visible = false;
                    b.Visible = true;

                //MessageBox.Show("Good Day, Lector");

                    break;
                case "Assistant":
                    MessageBox.Show("Good Day, Assistant");
                    break;
                default: MessageBox.Show("Invalid password");
                    break;
            }
            
                
            }
        }
    }
  

