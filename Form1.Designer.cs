namespace EFCoreApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            txtSearch = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtId = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            label4 = new Label();
            txtDescription = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(421, 97);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(363, 428);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(625, 39);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(159, 23);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(548, 42);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 2;
            label1.Text = "Search";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 133);
            label2.Name = "label2";
            label2.Size = new Size(24, 15);
            label2.TabIndex = 4;
            label2.Text = "I.D.";
            // 
            // txtId
            // 
            txtId.Location = new Point(138, 128);
            txtId.Name = "txtId";
            txtId.Size = new Size(253, 23);
            txtId.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 193);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 6;
            label3.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(138, 188);
            txtName.Name = "txtName";
            txtName.Size = new Size(253, 23);
            txtName.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(138, 298);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(253, 23);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(138, 348);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(253, 23);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(138, 397);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(253, 23);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 252);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 11;
            label4.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(138, 247);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(253, 23);
            txtDescription.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(827, 548);
            Controls.Add(label4);
            Controls.Add(txtDescription);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(dataGridView1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtSearch;
        private Label label1;
        private Label label2;
        private TextBox txtId;
        private Label label3;
        private TextBox txtName;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label4;
        private TextBox txtDescription;
    }
}
