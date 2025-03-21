using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizz
{
    public partial class PulneneNaVuprosi: Form
    {
        public PulneneNaVuprosi()
        {
            InitializeComponent();
        }

        private void PulneneNaVuprosi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'staniBogat11dDataSet.Questions' table. You can move, or remove it, as needed.
            this.questionsTableAdapter.Fill(this.staniBogat11dDataSet.Questions);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mainForm = new Form1();
            mainForm.Show();
        }
    }
}
