using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST01
{
    public partial class Form1 : Form
    {
        int add(int a, int b,int c)
        {
            return a + b + c;  
        }
        int sub(int a, int b)
        {
            return a - b;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_GO_Click(object sender, EventArgs e)
        {
            int sum = 0;
            int a = 5;
            int b = 4;
            int c = 0;
            sum = add(a, b, c);

            Console.WriteLine("add()=" + sum);
        }

    }
}
