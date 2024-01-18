namespace AutomobileWinApp
{
    partial class frmCarManagement
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
            lbCarID = new Label();
            textBox1 = new TextBox();
            lbCarName = new Label();
            txtCarName = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            txtCarID = new TextBox();
            lbManufacturer = new Label();
            txtManufacturer = new TextBox();
            lbPrice = new Label();
            textBox6 = new TextBox();
            txtPrice = new TextBox();
            lbReleaseYear = new Label();
            txtReleaseYear = new TextBox();
            btnLoad = new Button();
            butnNew = new Button();
            btnDelete = new Button();
            dgvCarList = new DataGridView();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            SuspendLayout();
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new Point(54, 62);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new Size(50, 20);
            lbCarID.TabIndex = 0;
            lbCarID.Text = "Car ID";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(174, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 27);
            textBox1.TabIndex = 1;
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new Point(54, 128);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(75, 20);
            lbCarName.TabIndex = 0;
            lbCarName.Text = "Car Name";
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(174, 121);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(186, 27);
            txtCarName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 187);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 0;
            label3.Text = "label1";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(174, 180);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(186, 27);
            textBox3.TabIndex = 1;
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(174, 59);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(186, 27);
            txtCarID.TabIndex = 0;
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Location = new Point(54, 187);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new Size(97, 20);
            lbManufacturer.TabIndex = 0;
            lbManufacturer.Text = "Manufacturer";
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(174, 180);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(186, 27);
            txtManufacturer.TabIndex = 1;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(429, 66);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(41, 20);
            lbPrice.TabIndex = 0;
            lbPrice.Text = "Price";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(524, 59);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(186, 27);
            textBox6.TabIndex = 1;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(524, 59);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(186, 27);
            txtPrice.TabIndex = 1;
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Location = new Point(429, 128);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new Size(88, 20);
            lbReleaseYear.TabIndex = 0;
            lbReleaseYear.Text = "ReleaseYear";
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(524, 121);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(186, 27);
            txtReleaseYear.TabIndex = 1;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(102, 239);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(142, 45);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // butnNew
            // 
            butnNew.Location = new Point(328, 239);
            butnNew.Name = "butnNew";
            butnNew.Size = new Size(142, 45);
            butnNew.TabIndex = 2;
            butnNew.Text = "New";
            butnNew.UseVisualStyleBackColor = true;
            butnNew.Click += butnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(553, 239);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(142, 45);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvCarList
            // 
            dgvCarList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Location = new Point(12, 291);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.ReadOnly = true;
            dgvCarList.RowHeadersWidth = 51;
            dgvCarList.RowTemplate.Height = 29;
            dgvCarList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarList.Size = new Size(788, 289);
            dgvCarList.TabIndex = 3;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(328, 603);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(142, 45);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 672);
            Controls.Add(dgvCarList);
            Controls.Add(btnDelete);
            Controls.Add(btnClose);
            Controls.Add(butnNew);
            Controls.Add(btnLoad);
            Controls.Add(txtManufacturer);
            Controls.Add(lbManufacturer);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtCarName);
            Controls.Add(txtPrice);
            Controls.Add(txtCarID);
            Controls.Add(lbReleaseYear);
            Controls.Add(textBox6);
            Controls.Add(lbCarName);
            Controls.Add(lbPrice);
            Controls.Add(textBox1);
            Controls.Add(lbCarID);
            Name = "frmCarManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CarManagement";
            Load += frmCarManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCarID;
        private TextBox textBox1;
        private Label lbCarName;
        private TextBox txtCarName;
        private Label label3;
        private TextBox textBox3;
        private TextBox txtCarID;
        private Label lbManufacturer;
        private TextBox txtManufacturer;
        private Label lbPrice;
        private TextBox textBox6;
        private TextBox txtPrice;
        private Label lbReleaseYear;
        private TextBox txtReleaseYear;
        private Button btnLoad;
        private Button butnNew;
        private Button btnDelete;
        private DataGridView dgvCarList;
        private Button btnClose;
    }
}