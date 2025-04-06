namespace Quizz
{
    partial class PulneneNaVuprosi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label questionLabel;
            System.Windows.Forms.Label ansALabel;
            System.Windows.Forms.Label ansBLabel;
            System.Windows.Forms.Label ansCLabel;
            System.Windows.Forms.Label ansDLabel;
            System.Windows.Forms.Label correctAnsLabel;
            System.Windows.Forms.Label pointsLabel;
            this.staniBogat11dDataSet = new Quizz.StaniBogat11dDataSet();
            this.questionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.questionsTableAdapter = new Quizz.StaniBogat11dDataSetTableAdapters.QuestionsTableAdapter();
            this.questionsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.staniBogat11dDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tableAdapterManager = new Quizz.StaniBogat11dDataSetTableAdapters.TableAdapterManager();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.ansATextBox = new System.Windows.Forms.TextBox();
            this.ansBTextBox = new System.Windows.Forms.TextBox();
            this.ansCTextBox = new System.Windows.Forms.TextBox();
            this.ansDTextBox = new System.Windows.Forms.TextBox();
            this.correctAnsTextBox = new System.Windows.Forms.TextBox();
            this.pointsTextBox = new System.Windows.Forms.TextBox();
            this.questionsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idLabel = new System.Windows.Forms.Label();
            questionLabel = new System.Windows.Forms.Label();
            ansALabel = new System.Windows.Forms.Label();
            ansBLabel = new System.Windows.Forms.Label();
            ansCLabel = new System.Windows.Forms.Label();
            ansDLabel = new System.Windows.Forms.Label();
            correctAnsLabel = new System.Windows.Forms.Label();
            pointsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.staniBogat11dDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staniBogat11dDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(18, 9);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 5;
            idLabel.Text = "Id:";
            // 
            // questionLabel
            // 
            questionLabel.AutoSize = true;
            questionLabel.Location = new System.Drawing.Point(9, 67);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new System.Drawing.Size(52, 13);
            questionLabel.TabIndex = 6;
            questionLabel.Text = "Question:";
            // 
            // ansALabel
            // 
            ansALabel.AutoSize = true;
            ansALabel.Location = new System.Drawing.Point(9, 117);
            ansALabel.Name = "ansALabel";
            ansALabel.Size = new System.Drawing.Size(38, 13);
            ansALabel.TabIndex = 8;
            ansALabel.Text = "Ans A:";
            // 
            // ansBLabel
            // 
            ansBLabel.AutoSize = true;
            ansBLabel.Location = new System.Drawing.Point(12, 183);
            ansBLabel.Name = "ansBLabel";
            ansBLabel.Size = new System.Drawing.Size(38, 13);
            ansBLabel.TabIndex = 10;
            ansBLabel.Text = "Ans B:";
            // 
            // ansCLabel
            // 
            ansCLabel.AutoSize = true;
            ansCLabel.Location = new System.Drawing.Point(12, 240);
            ansCLabel.Name = "ansCLabel";
            ansCLabel.Size = new System.Drawing.Size(38, 13);
            ansCLabel.TabIndex = 12;
            ansCLabel.Text = "Ans C:";
            // 
            // ansDLabel
            // 
            ansDLabel.AutoSize = true;
            ansDLabel.Location = new System.Drawing.Point(11, 295);
            ansDLabel.Name = "ansDLabel";
            ansDLabel.Size = new System.Drawing.Size(39, 13);
            ansDLabel.TabIndex = 14;
            ansDLabel.Text = "Ans D:";
            // 
            // correctAnsLabel
            // 
            correctAnsLabel.AutoSize = true;
            correctAnsLabel.Location = new System.Drawing.Point(11, 354);
            correctAnsLabel.Name = "correctAnsLabel";
            correctAnsLabel.Size = new System.Drawing.Size(65, 13);
            correctAnsLabel.TabIndex = 16;
            correctAnsLabel.Text = "Correct Ans:";
            // 
            // pointsLabel
            // 
            pointsLabel.AutoSize = true;
            pointsLabel.Location = new System.Drawing.Point(18, 418);
            pointsLabel.Name = "pointsLabel";
            pointsLabel.Size = new System.Drawing.Size(39, 13);
            pointsLabel.TabIndex = 18;
            pointsLabel.Text = "Points:";
            // 
            // staniBogat11dDataSet
            // 
            this.staniBogat11dDataSet.DataSetName = "StaniBogat11dDataSet";
            this.staniBogat11dDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // questionsBindingSource
            // 
            this.questionsBindingSource.DataMember = "Questions";
            this.questionsBindingSource.DataSource = this.staniBogat11dDataSet;
            // 
            // questionsTableAdapter
            // 
            this.questionsTableAdapter.ClearBeforeFill = true;
            // 
            // questionsBindingSource1
            // 
            this.questionsBindingSource1.DataMember = "Questions";
            this.questionsBindingSource1.DataSource = this.staniBogat11dDataSetBindingSource;
            // 
            // staniBogat11dDataSetBindingSource
            // 
            this.staniBogat11dDataSetBindingSource.DataSource = this.staniBogat11dDataSet;
            this.staniBogat11dDataSetBindingSource.Position = 0;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnBack.Location = new System.Drawing.Point(827, 241);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(148, 67);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Go back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Coral;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreate.Location = new System.Drawing.Point(151, 241);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(148, 67);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Salmon;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdate.Location = new System.Drawing.Point(368, 240);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(148, 67);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Aqua;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(595, 241);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(148, 67);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.QuestionsTableAdapter = this.questionsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Quizz.StaniBogat11dDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questionsBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(12, 25);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 6;
            this.idTextBox.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
            // 
            // questionTextBox
            // 
            this.questionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questionsBindingSource, "Question", true));
            this.questionTextBox.Location = new System.Drawing.Point(12, 83);
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(100, 20);
            this.questionTextBox.TabIndex = 7;
            this.questionTextBox.TextChanged += new System.EventHandler(this.questionTextBox_TextChanged);
            // 
            // ansATextBox
            // 
            this.ansATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questionsBindingSource, "AnsA", true));
            this.ansATextBox.Location = new System.Drawing.Point(12, 142);
            this.ansATextBox.Name = "ansATextBox";
            this.ansATextBox.Size = new System.Drawing.Size(100, 20);
            this.ansATextBox.TabIndex = 9;
            this.ansATextBox.TextChanged += new System.EventHandler(this.ansATextBox_TextChanged);
            // 
            // ansBTextBox
            // 
            this.ansBTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questionsBindingSource, "AnsB", true));
            this.ansBTextBox.Location = new System.Drawing.Point(12, 199);
            this.ansBTextBox.Name = "ansBTextBox";
            this.ansBTextBox.Size = new System.Drawing.Size(100, 20);
            this.ansBTextBox.TabIndex = 11;
            // 
            // ansCTextBox
            // 
            this.ansCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questionsBindingSource, "AnsC", true));
            this.ansCTextBox.Location = new System.Drawing.Point(12, 256);
            this.ansCTextBox.Name = "ansCTextBox";
            this.ansCTextBox.Size = new System.Drawing.Size(100, 20);
            this.ansCTextBox.TabIndex = 13;
            // 
            // ansDTextBox
            // 
            this.ansDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questionsBindingSource, "AnsD", true));
            this.ansDTextBox.Location = new System.Drawing.Point(14, 311);
            this.ansDTextBox.Name = "ansDTextBox";
            this.ansDTextBox.Size = new System.Drawing.Size(100, 20);
            this.ansDTextBox.TabIndex = 15;
            // 
            // correctAnsTextBox
            // 
            this.correctAnsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questionsBindingSource, "CorrectAns", true));
            this.correctAnsTextBox.Location = new System.Drawing.Point(14, 381);
            this.correctAnsTextBox.Name = "correctAnsTextBox";
            this.correctAnsTextBox.Size = new System.Drawing.Size(100, 20);
            this.correctAnsTextBox.TabIndex = 17;
            // 
            // pointsTextBox
            // 
            this.pointsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questionsBindingSource, "Points", true));
            this.pointsTextBox.Location = new System.Drawing.Point(15, 434);
            this.pointsTextBox.Name = "pointsTextBox";
            this.pointsTextBox.Size = new System.Drawing.Size(100, 20);
            this.pointsTextBox.TabIndex = 19;
            // 
            // questionsDataGridView
            // 
            this.questionsDataGridView.AutoGenerateColumns = false;
            this.questionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.questionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.questionsDataGridView.DataSource = this.questionsBindingSource;
            this.questionsDataGridView.Location = new System.Drawing.Point(132, 12);
            this.questionsDataGridView.Name = "questionsDataGridView";
            this.questionsDataGridView.Size = new System.Drawing.Size(843, 220);
            this.questionsDataGridView.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Question";
            this.dataGridViewTextBoxColumn2.HeaderText = "Question";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "AnsA";
            this.dataGridViewTextBoxColumn3.HeaderText = "AnsA";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "AnsB";
            this.dataGridViewTextBoxColumn4.HeaderText = "AnsB";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "AnsC";
            this.dataGridViewTextBoxColumn5.HeaderText = "AnsC";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "AnsD";
            this.dataGridViewTextBoxColumn6.HeaderText = "AnsD";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CorrectAns";
            this.dataGridViewTextBoxColumn7.HeaderText = "CorrectAns";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Points";
            this.dataGridViewTextBoxColumn8.HeaderText = "Points";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // PulneneNaVuprosi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 474);
            this.Controls.Add(this.questionsDataGridView);
            this.Controls.Add(pointsLabel);
            this.Controls.Add(this.pointsTextBox);
            this.Controls.Add(correctAnsLabel);
            this.Controls.Add(this.correctAnsTextBox);
            this.Controls.Add(ansDLabel);
            this.Controls.Add(this.ansDTextBox);
            this.Controls.Add(ansCLabel);
            this.Controls.Add(this.ansCTextBox);
            this.Controls.Add(ansBLabel);
            this.Controls.Add(this.ansBTextBox);
            this.Controls.Add(ansALabel);
            this.Controls.Add(this.ansATextBox);
            this.Controls.Add(questionLabel);
            this.Controls.Add(this.questionTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnBack);
            this.Name = "PulneneNaVuprosi";
            this.Text = "PulneneNaVuprosi";
            this.Load += new System.EventHandler(this.PulneneNaVuprosi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.staniBogat11dDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staniBogat11dDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private StaniBogat11dDataSet staniBogat11dDataSet;
        private System.Windows.Forms.BindingSource questionsBindingSource;
        private StaniBogat11dDataSetTableAdapters.QuestionsTableAdapter questionsTableAdapter;
        private System.Windows.Forms.BindingSource questionsBindingSource1;
        private System.Windows.Forms.BindingSource staniBogat11dDataSetBindingSource;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private StaniBogat11dDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.TextBox ansATextBox;
        private System.Windows.Forms.TextBox ansBTextBox;
        private System.Windows.Forms.TextBox ansCTextBox;
        private System.Windows.Forms.TextBox ansDTextBox;
        private System.Windows.Forms.TextBox correctAnsTextBox;
        private System.Windows.Forms.TextBox pointsTextBox;
        private System.Windows.Forms.DataGridView questionsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}
