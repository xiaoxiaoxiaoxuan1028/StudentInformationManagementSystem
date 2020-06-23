namespace database_exp7
{
    partial class Stu_Search
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label_fail = new System.Windows.Forms.Label();
            this.label_gpa = new System.Windows.Forms.Label();
            this.label_credit = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.course_data = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbox_term = new System.Windows.Forms.ComboBox();
            this.btn_termsearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbox_cid = new System.Windows.Forms.ComboBox();
            this.btn_cidsearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_return = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.course_data)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.course_data);
            this.groupBox2.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(37, 195);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(725, 231);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "查询结果";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label_fail);
            this.groupBox4.Controls.Add(this.label_gpa);
            this.groupBox4.Controls.Add(this.label_credit);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(553, 22);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(165, 190);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "统计结果";
            // 
            // label_fail
            // 
            this.label_fail.AutoSize = true;
            this.label_fail.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_fail.Location = new System.Drawing.Point(101, 102);
            this.label_fail.Name = "label_fail";
            this.label_fail.Size = new System.Drawing.Size(39, 15);
            this.label_fail.TabIndex = 15;
            this.label_fail.Text = "    ";
            // 
            // label_gpa
            // 
            this.label_gpa.AutoSize = true;
            this.label_gpa.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_gpa.Location = new System.Drawing.Point(101, 72);
            this.label_gpa.Name = "label_gpa";
            this.label_gpa.Size = new System.Drawing.Size(39, 15);
            this.label_gpa.TabIndex = 15;
            this.label_gpa.Text = "    ";
            // 
            // label_credit
            // 
            this.label_credit.AutoSize = true;
            this.label_credit.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_credit.Location = new System.Drawing.Point(99, 42);
            this.label_credit.Name = "label_credit";
            this.label_credit.Size = new System.Drawing.Size(39, 15);
            this.label_credit.TabIndex = 14;
            this.label_credit.Text = "    ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(5, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "不合格门数：";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(61, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "GPA：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(21, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "已修学分：";
            // 
            // course_data
            // 
            this.course_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.course_data.Location = new System.Drawing.Point(48, 22);
            this.course_data.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.course_data.Name = "course_data";
            this.course_data.RowHeadersWidth = 51;
            this.course_data.RowTemplate.Height = 30;
            this.course_data.Size = new System.Drawing.Size(485, 190);
            this.course_data.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbox_term);
            this.groupBox1.Controls.Add(this.btn_termsearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(37, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(725, 79);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "按学期检索";
            // 
            // cbox_term
            // 
            this.cbox_term.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbox_term.FormattingEnabled = true;
            this.cbox_term.Location = new System.Drawing.Point(132, 32);
            this.cbox_term.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbox_term.Name = "cbox_term";
            this.cbox_term.Size = new System.Drawing.Size(184, 26);
            this.cbox_term.TabIndex = 5;
            // 
            // btn_termsearch
            // 
            this.btn_termsearch.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_termsearch.Location = new System.Drawing.Point(541, 29);
            this.btn_termsearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_termsearch.Name = "btn_termsearch";
            this.btn_termsearch.Size = new System.Drawing.Size(104, 30);
            this.btn_termsearch.TabIndex = 4;
            this.btn_termsearch.Text = "查  询";
            this.btn_termsearch.UseVisualStyleBackColor = true;
            this.btn_termsearch.Click += new System.EventHandler(this.btn_termsearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(45, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "学期：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbox_cid);
            this.groupBox3.Controls.Add(this.btn_cidsearch);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(37, 100);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(725, 79);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "按课程号检索";
            // 
            // cbox_cid
            // 
            this.cbox_cid.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbox_cid.FormattingEnabled = true;
            this.cbox_cid.Location = new System.Drawing.Point(132, 28);
            this.cbox_cid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbox_cid.Name = "cbox_cid";
            this.cbox_cid.Size = new System.Drawing.Size(184, 26);
            this.cbox_cid.TabIndex = 6;
            // 
            // btn_cidsearch
            // 
            this.btn_cidsearch.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_cidsearch.Location = new System.Drawing.Point(541, 28);
            this.btn_cidsearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cidsearch.Name = "btn_cidsearch";
            this.btn_cidsearch.Size = new System.Drawing.Size(104, 30);
            this.btn_cidsearch.TabIndex = 4;
            this.btn_cidsearch.Text = "查  询";
            this.btn_cidsearch.UseVisualStyleBackColor = true;
            this.btn_cidsearch.Click += new System.EventHandler(this.btn_cidsearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(27, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "课程号：";
            // 
            // btn_return
            // 
            this.btn_return.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_return.Location = new System.Drawing.Point(315, 440);
            this.btn_return.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(147, 34);
            this.btn_return.TabIndex = 20;
            this.btn_return.Text = "返   回";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // Stu_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Stu_Search";
            this.Text = "课程及成绩查询";
            this.Load += new System.EventHandler(this.Stu_Search_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.course_data)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView course_data;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbox_term;
        private System.Windows.Forms.Button btn_termsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_cidsearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label_fail;
        private System.Windows.Forms.Label label_gpa;
        private System.Windows.Forms.Label label_credit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.ComboBox cbox_cid;
    }
}