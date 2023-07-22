namespace ATrialTes1
{
    partial class Managerment
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
            txtID = new TextBox();
            txtName = new TextBox();
            txtDec = new TextBox();
            dtpImportDate = new DateTimePicker();
            nudQuantity = new NumericUpDown();
            nudPrice = new NumericUpDown();
            cbGroup = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            label8 = new Label();
            dgvList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.Location = new Point(14, 144);
            txtID.Margin = new Padding(3, 4, 3, 4);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(261, 27);
            txtID.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(14, 209);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(261, 27);
            txtName.TabIndex = 2;
            // 
            // txtDec
            // 
            txtDec.Location = new Point(14, 336);
            txtDec.Margin = new Padding(3, 4, 3, 4);
            txtDec.Multiline = true;
            txtDec.Name = "txtDec";
            txtDec.Size = new Size(261, 141);
            txtDec.TabIndex = 4;
            // 
            // dtpImportDate
            // 
            dtpImportDate.Location = new Point(14, 273);
            dtpImportDate.Margin = new Padding(3, 4, 3, 4);
            dtpImportDate.Name = "dtpImportDate";
            dtpImportDate.Size = new Size(261, 27);
            dtpImportDate.TabIndex = 5;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(14, 505);
            nudQuantity.Margin = new Padding(3, 4, 3, 4);
            nudQuantity.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(262, 27);
            nudQuantity.TabIndex = 6;
            // 
            // nudPrice
            // 
            nudPrice.Location = new Point(14, 563);
            nudPrice.Margin = new Padding(3, 4, 3, 4);
            nudPrice.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(262, 27);
            nudPrice.TabIndex = 7;
            // 
            // cbGroup
            // 
            cbGroup.FormattingEnabled = true;
            cbGroup.Location = new Point(15, 619);
            cbGroup.Margin = new Padding(3, 4, 3, 4);
            cbGroup.Name = "cbGroup";
            cbGroup.Size = new Size(260, 28);
            cbGroup.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 120);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 9;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 185);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 10;
            label2.Text = "Branch Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 249);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 11;
            label3.Text = "Import Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 312);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 12;
            label4.Text = "Decription";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 483);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 13;
            label5.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 540);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 14;
            label6.Text = "Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 595);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 15;
            label7.Text = "Group";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(432, 16);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(381, 27);
            txtSearch.TabIndex = 16;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(821, 16);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(86, 31);
            btnSearch.TabIndex = 17;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ControlLight;
            btnAdd.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = SystemColors.ControlText;
            btnAdd.Location = new Point(298, 144);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(114, 133);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ControlLight;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = SystemColors.ControlText;
            btnUpdate.Location = new Point(298, 324);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(114, 133);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ControlLight;
            btnDelete.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ControlText;
            btnDelete.Location = new Point(298, 516);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(114, 133);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(15, 52);
            label8.Name = "label8";
            label8.Size = new Size(240, 37);
            label8.TabIndex = 21;
            label8.Text = "MANAGERMENT";
            // 
            // dgvList
            // 
            dgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.Location = new Point(432, 55);
            dgvList.Margin = new Padding(3, 4, 3, 4);
            dgvList.MultiSelect = false;
            dgvList.Name = "dgvList";
            dgvList.RowHeadersWidth = 51;
            dgvList.RowTemplate.Height = 25;
            dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvList.Size = new Size(718, 644);
            dgvList.TabIndex = 22;
            dgvList.CellClick += dgvList_CellClick;
            // 
            // Managerment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 715);
            Controls.Add(dgvList);
            Controls.Add(label8);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbGroup);
            Controls.Add(nudPrice);
            Controls.Add(nudQuantity);
            Controls.Add(dtpImportDate);
            Controls.Add(txtDec);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Managerment";
            Text = "Managerment";
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtDec;
        private DateTimePicker dtpImportDate;
        private NumericUpDown nudQuantity;
        private NumericUpDown nudPrice;
        private ComboBox cbGroup;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label8;
        private DataGridView dgvList;
    }
}