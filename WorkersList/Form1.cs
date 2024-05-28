using EmployeeTypeA;
using System.Windows.Forms;

namespace WorkersList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Form2 form2 = new Form2())
            {
                if (!(form2.ShowDialog() == DialogResult.OK))
                {
                    return;
                }
            }

        }

        private void btnSeeEmployee_Click(object sender, EventArgs e)
        {
            using (Form3 form3 = new Form3())
            {
                if (!(form3.ShowDialog() == DialogResult.OK))
                {
                    return;
                }
            }
        }

        private void btnObservations_Click(object sender, EventArgs e)
        {
            using (Form4 form3 = new Form4())
            {
                if (!(form3.ShowDialog() == DialogResult.OK))
                {
                    return;
                }
            }
        }
    }
}
