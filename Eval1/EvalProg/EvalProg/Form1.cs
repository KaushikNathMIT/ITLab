using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvalProg
{
    public partial class Form1 : Form
    {
        Customer customer = new Customer();
        public Form1()
        {
            InitializeComponent();
            customer.invalidAgeHandler += new CustomEventhandler(onInvalidAge);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int age = Convert.ToInt32(textBox1.Text);
            customer.Age = textBox1.Text;
        }
        private static void onInvalidAge(object source, CustomEventArgs e)
        {
            Console.WriteLine("The valid age is " + e.getOldAge());
        }
    }
}
