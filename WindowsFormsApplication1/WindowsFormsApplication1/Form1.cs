using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        String strfileName;
        String strfilePath;
        String strContent;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Wrtie_Click(object sender, EventArgs e)
        {
            strfileName = textBox1.Text;
            strfilePath = textBox2.Text;
            strContent = textBox3.Text;
            String argument = strfilePath + "\\" + strfileName;
           // MessageBox.Show(argument);

            System.IO.File.WriteAllText(argument, strContent);
            MessageBox.Show("File Written: "+argument);
         }


        private void Append_Click(object sender, EventArgs e)
        {
            strfileName = textBox1.Text;
            strfilePath = textBox2.Text;
            strContent = textBox3.Text;
            String argument = strfilePath + "\\" + strfileName;
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(argument, true))
            {
                file.WriteLine(strContent);
            }

            MessageBox.Show("The Text Appended to: "+argument);
        }


        private void Read_Click(object sender, EventArgs e)
        {
            strfileName = textBox1.Text;
            strfilePath = textBox2.Text;
            strContent = textBox3.Text;
            String argument = strfilePath + "\\" + strfileName;
            //MessageBox.Show(argument);

            String Output = System.IO.File.ReadAllText(argument);
           
            MessageBox.Show("Data from: "+strfileName+" \n "+Output);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this.Controls);
            MessageBox.Show("All Text Books Cleared");
        }

        private void ClearTextBoxes(Control.ControlCollection cc)
        {
            foreach (Control ctrl in cc)
            {
                TextBox tb = ctrl as TextBox;
                if (tb != null)
                    tb.Text = "";
                else
                    ClearTextBoxes(ctrl.Controls);
            }
        }


        private void sort_action(object sender, EventArgs e)
        {
           // MessageBox.Show(textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
