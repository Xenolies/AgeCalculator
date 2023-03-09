using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace AgeCalculator
{
    // 主窗体
    public partial class Form1 : Form
    {
        private long Age;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClick1_GetAge(object sender, EventArgs e)
        {
            // 将值传入子窗口 Form2
            Form2 form2 = new Form2(Age);
            form2.ShowDialog();

        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            // throw new System.NotImplementedException();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Age = 0;

            try
            {
                Age = Convert.ToInt64(textBox1.Text);
            }
            catch (Exception exception)
            {
                // Console.WriteLine(exception);
                // throw;
            }
            
            // throw new System.NotImplementedException();
        }
    }
    // 结果显示窗口
}