namespace DBConn
{
    partial class Form1
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
            this.fetchData_button = new System.Windows.Forms.Button();
            this.startRow_textBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pageSize_textBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fetchData2_button = new System.Windows.Forms.Button();
            this.id_textBox = new System.Windows.Forms.TextBox();
            this.clearDataView_button = new System.Windows.Forms.Button();
            this.connString_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // fetchData_button
            // 
            this.fetchData_button.Location = new System.Drawing.Point(100, 115);
            this.fetchData_button.Name = "fetchData_button";
            this.fetchData_button.Size = new System.Drawing.Size(85, 23);
            this.fetchData_button.TabIndex = 0;
            this.fetchData_button.Text = "Fetch Data";
            this.fetchData_button.UseVisualStyleBackColor = true;
            this.fetchData_button.Click += new System.EventHandler(this.fetchData_button_Click);
            // 
            // startRow_textBox
            // 
            this.startRow_textBox.Location = new System.Drawing.Point(100, 33);
            this.startRow_textBox.Name = "startRow_textBox";
            this.startRow_textBox.Size = new System.Drawing.Size(172, 22);
            this.startRow_textBox.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(589, 395);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Start Row No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Page size:";
            // 
            // pageSize_textBox
            // 
            this.pageSize_textBox.Location = new System.Drawing.Point(100, 73);
            this.pageSize_textBox.Name = "pageSize_textBox";
            this.pageSize_textBox.Size = new System.Drawing.Size(172, 22);
            this.pageSize_textBox.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.fetchData_button);
            this.groupBox1.Controls.Add(this.pageSize_textBox);
            this.groupBox1.Controls.Add(this.startRow_textBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 186);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paging parameters Type-1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(323, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(604, 425);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data View";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(259, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(430, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Paging using Data Adapters";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.fetchData2_button);
            this.groupBox3.Controls.Add(this.id_textBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 313);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(305, 127);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Paging Parameters Type-2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Enter ID:";
            // 
            // fetchData2_button
            // 
            this.fetchData2_button.Location = new System.Drawing.Point(69, 85);
            this.fetchData2_button.Name = "fetchData2_button";
            this.fetchData2_button.Size = new System.Drawing.Size(92, 23);
            this.fetchData2_button.TabIndex = 1;
            this.fetchData2_button.Text = "Fetch by ID";
            this.fetchData2_button.UseVisualStyleBackColor = true;
            this.fetchData2_button.Click += new System.EventHandler(this.fetchData2_button_Click);
            // 
            // id_textBox
            // 
            this.id_textBox.Location = new System.Drawing.Point(69, 44);
            this.id_textBox.Name = "id_textBox";
            this.id_textBox.Size = new System.Drawing.Size(172, 22);
            this.id_textBox.TabIndex = 0;
            // 
            // clearDataView_button
            // 
            this.clearDataView_button.Location = new System.Drawing.Point(323, 552);
            this.clearDataView_button.Name = "clearDataView_button";
            this.clearDataView_button.Size = new System.Drawing.Size(117, 23);
            this.clearDataView_button.TabIndex = 10;
            this.clearDataView_button.Text = "Clear data view";
            this.clearDataView_button.UseVisualStyleBackColor = true;
            this.clearDataView_button.Click += new System.EventHandler(this.clearDataView_button_Click);
            // 
            // connString_textBox
            // 
            this.connString_textBox.Font = new System.Drawing.Font("Corbel", 10.25F, System.Drawing.FontStyle.Italic);
            this.connString_textBox.Location = new System.Drawing.Point(159, 74);
            this.connString_textBox.Name = "connString_textBox";
            this.connString_textBox.Size = new System.Drawing.Size(768, 24);
            this.connString_textBox.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Enter connection string:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(863, 570);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "vishnu s nair";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(941, 592);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.connString_textBox);
            this.Controls.Add(this.clearDataView_button);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fetchData_button;
        private System.Windows.Forms.TextBox startRow_textBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pageSize_textBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button fetchData2_button;
        private System.Windows.Forms.TextBox id_textBox;
        private System.Windows.Forms.Button clearDataView_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox connString_textBox;
        private System.Windows.Forms.Label label6;
    }
}

