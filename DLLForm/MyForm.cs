using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DLLForm
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
        }

        //Read and update a TextBox for first name
        public string FirstNameField
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }
    }
}
