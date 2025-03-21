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
            this.staniBogat11dDataSet = new Quizz.StaniBogat11dDataSet();
            this.questionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.questionsTableAdapter = new Quizz.StaniBogat11dDataSetTableAdapters.QuestionsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ansADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ansBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ansCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ansDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correctAnsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.staniBogat11dDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.staniBogat11dDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staniBogat11dDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.questionDataGridViewTextBoxColumn,
            this.ansADataGridViewTextBoxColumn,
            this.ansBDataGridViewTextBoxColumn,
            this.ansCDataGridViewTextBoxColumn,
            this.ansDDataGridViewTextBoxColumn,
            this.correctAnsDataGridViewTextBoxColumn,
            this.pointsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.questionsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(846, 292);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // questionDataGridViewTextBoxColumn
            // 
            this.questionDataGridViewTextBoxColumn.DataPropertyName = "Question";
            this.questionDataGridViewTextBoxColumn.HeaderText = "Question";
            this.questionDataGridViewTextBoxColumn.Name = "questionDataGridViewTextBoxColumn";
            // 
            // ansADataGridViewTextBoxColumn
            // 
            this.ansADataGridViewTextBoxColumn.DataPropertyName = "AnsA";
            this.ansADataGridViewTextBoxColumn.HeaderText = "AnsA";
            this.ansADataGridViewTextBoxColumn.Name = "ansADataGridViewTextBoxColumn";
            // 
            // ansBDataGridViewTextBoxColumn
            // 
            this.ansBDataGridViewTextBoxColumn.DataPropertyName = "AnsB";
            this.ansBDataGridViewTextBoxColumn.HeaderText = "AnsB";
            this.ansBDataGridViewTextBoxColumn.Name = "ansBDataGridViewTextBoxColumn";
            // 
            // ansCDataGridViewTextBoxColumn
            // 
            this.ansCDataGridViewTextBoxColumn.DataPropertyName = "AnsC";
            this.ansCDataGridViewTextBoxColumn.HeaderText = "AnsC";
            this.ansCDataGridViewTextBoxColumn.Name = "ansCDataGridViewTextBoxColumn";
            // 
            // ansDDataGridViewTextBoxColumn
            // 
            this.ansDDataGridViewTextBoxColumn.DataPropertyName = "AnsD";
            this.ansDDataGridViewTextBoxColumn.HeaderText = "AnsD";
            this.ansDDataGridViewTextBoxColumn.Name = "ansDDataGridViewTextBoxColumn";
            // 
            // correctAnsDataGridViewTextBoxColumn
            // 
            this.correctAnsDataGridViewTextBoxColumn.DataPropertyName = "CorrectAns";
            this.correctAnsDataGridViewTextBoxColumn.HeaderText = "CorrectAns";
            this.correctAnsDataGridViewTextBoxColumn.Name = "correctAnsDataGridViewTextBoxColumn";
            // 
            // pointsDataGridViewTextBoxColumn
            // 
            this.pointsDataGridViewTextBoxColumn.DataPropertyName = "Points";
            this.pointsDataGridViewTextBoxColumn.HeaderText = "Points";
            this.pointsDataGridViewTextBoxColumn.Name = "pointsDataGridViewTextBoxColumn";
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
            this.btnBack.Location = new System.Drawing.Point(47, 353);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(242, 67);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Go back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Coral;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreate.Location = new System.Drawing.Point(329, 353);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(159, 67);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Salmon;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdate.Location = new System.Drawing.Point(504, 353);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(141, 67);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Aqua;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(659, 353);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(148, 67);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // PulneneNaVuprosi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PulneneNaVuprosi";
            this.Text = "PulneneNaVuprosi";
            this.Load += new System.EventHandler(this.PulneneNaVuprosi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.staniBogat11dDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staniBogat11dDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private StaniBogat11dDataSet staniBogat11dDataSet;
        private System.Windows.Forms.BindingSource questionsBindingSource;
        private StaniBogat11dDataSetTableAdapters.QuestionsTableAdapter questionsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ansADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ansBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ansCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ansDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correctAnsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource questionsBindingSource1;
        private System.Windows.Forms.BindingSource staniBogat11dDataSetBindingSource;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}