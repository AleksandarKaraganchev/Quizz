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
    public partial class PulneneNaVuprosi : Form
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StaniBogat11d;Integrated Security=True";
        SqlConnection connect;
        public PulneneNaVuprosi()
        {
            InitializeComponent();
        }

        private void PulneneNaVuprosi_Load(object sender, EventArgs e)
        {
            this.questionsTableAdapter.Fill(this.staniBogat11dDataSet.Questions);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mainForm = new Form1();
            mainForm.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (InputValidation())
            {
                try
                {
                    using (connect = new SqlConnection(connectionString))
                    {
                        connect.Open();
                        string sql = "Insert INTO Questions (Question, AnsA, AnsB, AnsC, AnsD, CorrectAns, Points) " +
                        "VALUES (@question, @ansA, @ansB, @ansC, @ansD, @correctAnswer, @points)";

                        using (SqlCommand cmd = new SqlCommand(sql, connect))
                        {
                            questionTextBox.Focus();
                            cmd.Parameters.AddWithValue("@question", questionTextBox.Text);
                            cmd.Parameters.AddWithValue("@ansA", ansATextBox.Text);
                            cmd.Parameters.AddWithValue("@ansB", ansBTextBox.Text);
                            cmd.Parameters.AddWithValue("@ansC", ansCTextBox.Text);
                            cmd.Parameters.AddWithValue("@ansD", ansDTextBox.Text);
                            cmd.Parameters.AddWithValue("@correctAnswer", correctAnsTextBox.Text);
                            if (int.TryParse(pointsTextBox.Text, out int points))
                            {
                                cmd.Parameters.AddWithValue("@points", points);
                            }
                            else
                            {
                                MessageBox.Show("Моля въведете валидно число за точки!");
                                return;
                            }

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Въпросът е добавен успешно!");
                            ClearForm();
                            this.questionsTableAdapter.Fill(this.staniBogat11dDataSet.Questions);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Грешка при добавяне: {ex.Message}");
                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (InputValidation() && !string.IsNullOrEmpty(idTextBox.Text))
            {
                try
                {
                    using (connect = new SqlConnection(connectionString))
                    {
                        connect.Open();
                        string sql = "UPDATE Questions SET Question = @question, AnsA = @ansA, AnsB = @ansB, AnsC = @ansC, AnsD = @ansD," +
                        "CorrectAns = @correctAnswer, Points = @points " +
                        "WHERE Id = @id";
                        using (SqlCommand cmd = new SqlCommand(sql, connect))
                        {
                            questionTextBox.Focus();
                            cmd.Parameters.AddWithValue("@question", questionTextBox.Text);
                            cmd.Parameters.AddWithValue("@ansA", ansATextBox.Text);
                            cmd.Parameters.AddWithValue("@ansB", ansBTextBox.Text);
                            cmd.Parameters.AddWithValue("@ansC", ansCTextBox.Text);
                            cmd.Parameters.AddWithValue("@ansD", ansDTextBox.Text);
                            cmd.Parameters.AddWithValue("@correctAnswer", correctAnsTextBox.Text);
                            if (int.TryParse(pointsTextBox.Text, out int points))
                            {
                                cmd.Parameters.AddWithValue("@points", points);
                            }
                            else
                            {
                                MessageBox.Show("Моля въведете валидно число за точки!");
                                return;
                            }
                            cmd.Parameters.AddWithValue("@id", int.Parse(idTextBox.Text));
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Въпросът е актуализиран успешно!");
                            ClearForm();
                            this.questionsTableAdapter.Fill(this.staniBogat11dDataSet.Questions);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Грешка при актуализиране: {ex.Message}");
                }

            }
            else
            {
                MessageBox.Show("Моля въведете валидно Id!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(idTextBox.Text))
            {
                try
                {
                    using (SqlConnection connect = new SqlConnection(connectionString))
                    {
                        connect.Open();
                        string sql = "DELETE From Questions WHERE Id = @id";
                        using (SqlCommand cmd = new SqlCommand(sql, connect))
                        {
                            idTextBox.Focus();
                            cmd.Parameters.AddWithValue("@id", int.Parse(idTextBox.Text));
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Въпросът е изтрит успешно!");
                            ClearForm();
                            this.questionsTableAdapter.Fill(this.staniBogat11dDataSet.Questions);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Грешка при изтриване: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Моля въведете валидно Id!");
            }
        }

        private void questionLabel_Click(object sender, EventArgs e)
        {

        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void questionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ansATextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private bool InputValidation()
        {
            if (string.IsNullOrEmpty(questionTextBox.Text) || string.IsNullOrEmpty(ansATextBox.Text) || string.IsNullOrEmpty(ansBTextBox.Text) ||
                string.IsNullOrEmpty(ansCTextBox.Text) || string.IsNullOrEmpty(ansDTextBox.Text) || string.IsNullOrEmpty(correctAnsTextBox.Text) || string.IsNullOrEmpty(pointsTextBox.Text))
            {
                MessageBox.Show("Моля попълнете всички полета!!!");
                return false;
            }
            return true;
        }
        private void ClearForm()
        {
            questionTextBox.Text = "";
            ansATextBox.Text = "";
            ansBTextBox.Text = "";
            ansCTextBox.Text = "";
            ansDTextBox.Text = "";
            correctAnsTextBox.Text = "";
            pointsTextBox.Text = "";
            idTextBox.Text = "";
        }
    }
}
