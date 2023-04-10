using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void New_Butt_Click(object sender, EventArgs e)
        {
            this.New_butt.Enabled = false;
            this.Save_butt.Enabled = true;
            this.Info_gbox.Enabled = true;  
            /*-------------------------------------*/
            this.id_textBox1.ResetText();
            this.fn_textBox2.ResetText(); 
            this.ln_textBox3.ResetText();  
            this.t_textBox4.ResetText();
            this.cn_textBox5.ResetText();
            this.e_textBox6.ResetText();
            this.a_textBox7.ResetText();   
            this.c_textBox8.ResetText();   



        }

        private void Save_Butt_Click(object sender, EventArgs e)
        {
            if (this.id_textBox1.Text == "")
            {
                MessageBox.Show("You must enter the ID!");
                return;

            }
       
            this.Save_butt.Enabled = false;
            this.New_butt.Enabled = true;
            this.Info_gbox.Enabled = false;
            /*-------------------------------------*/
            string fn;
            fn = "C:\\Users\\vered\\";
            string p;
            /***************first name***************/
            p = fn + this.id_textBox1.Text + "_fn.txt";
            System.IO.File.WriteAllText(p, this.fn_textBox2.Text, Encoding.UTF8);
            /***************last name***************/
            p = fn + this.id_textBox1.Text + "_ln.txt";
            System.IO.File.WriteAllText(p, this.ln_textBox3.Text, Encoding.UTF8);
            /***************tel***************/
            p = fn + this.id_textBox1.Text + "_tel.txt";
            System.IO.File.WriteAllText(p, this.t_textBox4.Text, Encoding.UTF8);
            /***************cell***************/
            p = fn + this.id_textBox1.Text + "_cell.txt";
            System.IO.File.WriteAllText(p, this.cn_textBox5.Text, Encoding.UTF8);
            /***************email***************/
            p = fn + this.id_textBox1.Text + "_email.txt";
            System.IO.File.WriteAllText(p, this.e_textBox6.Text, Encoding.UTF8);
            p = fn + this.id_textBox1.Text + "_address.txt";
            System.IO.File.WriteAllText(p, this.a_textBox7.Text, Encoding.UTF8);
            /***************comment***************/
            p = fn + this.id_textBox1.Text + "_comment.txt";
            System.IO.File.WriteAllText(p, this.c_textBox8.Text, Encoding.UTF8);
            MessageBox.Show("Saved!");

        }

        private void Reg_Data_Load(object sender, EventArgs e)
        {
            this.Info_gbox.Enabled = true;  
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
