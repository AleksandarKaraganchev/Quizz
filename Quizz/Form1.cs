using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizz
{
    public partial class Form1 : Form
    {
        SqlDataReader reader;
        SqlCommand command;
        SqlConnection connect;
        int totalScore;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAnsA_Click(object sender, EventArgs e)
        {
            BtnAnswerFunctionality(btnAnsA);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StaniBogat11d;Integrated Security=True";
            connect = new SqlConnection(connectionString);
            connect.Open();
            MessageBox.Show("Connection now opened");
            command = connect.CreateCommand();
            command.CommandText = "Select * from Questions";
            reader = command.ExecuteReader();
            ClearScreen();
            LoadRecordOnScreen();
        }

        private void LoadRecordOnScreen()
        {
            if (!reader.Read())
            {
                MessageBox.Show("The game ended!");
                this.Close();
                return;
                //scenarii pri  krai na igrata!
            }
            lblQuestion.Text = reader[1].ToString();
            btnAnsA.Text = reader[2].ToString();
            btnAnsB.Text = reader[3].ToString();
            btnAnsC.Text = reader[4].ToString();
            btnAnsD.Text = reader[5].ToString();
        }

        private void btnAnsB_Click(object sender, EventArgs e)
        {
            BtnAnswerFunctionality(btnAnsB);
        }

        private void btnAnsC_Click(object sender, EventArgs e)
        {
            BtnAnswerFunctionality(btnAnsC);
        }

        private void btnAnsD_Click(object sender, EventArgs e)
        {
            BtnAnswerFunctionality(btnAnsD);
        }

        private void BtnAnswerFunctionality(Button button)
        {
            if (button.Text == reader[6].ToString())
            {
                button.BackColor = Color.Green;
                MessageBox.Show($"Ти спечели {this.reader[7]} точки");
                totalScore += (int)reader[7];
                ClearScreen();
                LoadRecordOnScreen();
            }
            else
            {
                button.BackColor = Color.Red;
                MessageBox.Show("Грешен отговор");

                DialogResult ans = MessageBox.Show("Ще продължиш ли?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ans == DialogResult.Yes)
                {
                    reader.Close();
                    reader = command.ExecuteReader();
                    ClearScreen();
                    LoadRecordOnScreen();
                }
                else
                {
                    reader.Close();
                    connect.Close();
                    Form2 f2 = new Form2(totalScore);
                    this.Hide();
                    f2.Show();
                }
            }
        }

        private void ClearScreen()
        {
            btnAnsA.BackColor = Color.RoyalBlue;
            btnAnsB.BackColor = Color.RoyalBlue;
            btnAnsC.BackColor = Color.RoyalBlue;
            btnAnsD.BackColor = Color.RoyalBlue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PulneneNaVuprosi questions = new PulneneNaVuprosi();
            questions.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
