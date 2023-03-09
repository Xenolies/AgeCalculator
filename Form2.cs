using System;
using System.Windows.Forms;

namespace AgeCalculator
{
    public partial class Form2 : Form
    {
        private long Age;

        public Form2(long age)
        {
            this.Age = age;
            InitializeComponent();
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "恭喜你, 你已经 " + Age.ToString() + " 岁了!!!";
            // throw new System.NotImplementedException();
        }

        public void label1_Get(object sender, EventArgs e)
        {
            
            //throw new System.NotImplementedException();
        }

    }
}