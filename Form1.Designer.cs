
namespace David_Satterfield_Unit9_IT481
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
            this.CheckconnectionLabel = new System.Windows.Forms.Label();
            this.ViewDataBase = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CountRecords = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckconnectionLabel
            // 
            this.CheckconnectionLabel.AutoSize = true;
            this.CheckconnectionLabel.Location = new System.Drawing.Point(643, 57);
            this.CheckconnectionLabel.Name = "CheckconnectionLabel";
            this.CheckconnectionLabel.Size = new System.Drawing.Size(148, 20);
            this.CheckconnectionLabel.TabIndex = 0;
            this.CheckconnectionLabel.Text = "Connection Checking";
            // 
            // ViewDataBase
            // 
            this.ViewDataBase.Location = new System.Drawing.Point(182, 387);
            this.ViewDataBase.Name = "ViewDataBase";
            this.ViewDataBase.Size = new System.Drawing.Size(394, 31);
            this.ViewDataBase.TabIndex = 1;
            this.ViewDataBase.Text = "View DataBase";
            this.ViewDataBase.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(181, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(395, 188);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CountRecords
            // 
            this.CountRecords.Location = new System.Drawing.Point(643, 133);
            this.CountRecords.Name = "CountRecords";
            this.CountRecords.Size = new System.Drawing.Size(121, 29);
            this.CountRecords.TabIndex = 3;
            this.CountRecords.Text = "Count Records";
            this.CountRecords.UseVisualStyleBackColor = true;
            this.CountRecords.Click += new System.EventHandler(this.CountRecords_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(643, 98);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(138, 20);
            this.lblCount.TabIndex = 4;
            this.lblCount.Text = "Number of Records";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(98, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 9;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(13, 110);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(94, 29);
            this.Button1.TabIndex = 10;
            this.Button1.Text = "Submit";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 451);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.CountRecords);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ViewDataBase);
            this.Controls.Add(this.CheckconnectionLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CheckconnectionLabel;
        private System.Windows.Forms.Button ViewDataBase;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button CountRecords;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Button1;
    }
}