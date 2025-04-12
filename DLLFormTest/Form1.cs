using DLLForm;
using System.Windows.Forms;

namespace DLLFormTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MyForm? myForm;  //Keep a module reference to a form
        private void button1_Click(object sender, EventArgs e)
        {
            //See if we need to create the form
            if (myForm == null || myForm.IsDisposed)
            {
                myForm = new MyForm();
                myForm.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Check for form available
            if (myForm != null && !myForm.IsDisposed)
                label1.Text = "The first name is " + myForm.FirstNameField;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //In case previous form exists, close it
            if (myForm != null && !myForm.IsDisposed)
            {
                if (myForm.Visible)
                {
                    myForm.Close();
                    myForm.Dispose();
                }
            }
            myForm = new MyForm();
            if (myForm.ShowDialog() == DialogResult.Yes)    //Show modally
                Application.Exit();
            else
                label1.Text = "The first name is " + myForm.FirstNameField;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit app?", "Exiting", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
