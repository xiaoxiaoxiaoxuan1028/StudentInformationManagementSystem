namespace database_exp7
{
    partial class T_ScoreSearch
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbox_sid = new System.Windows.Forms.TextBox();
            this.btn_sidsearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_cidsearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label_min = new System.Windows.Forms.Label();
            this.label_max = new System.Windows.Forms.Label();
            this.label_avg = new System.Windows.Forms.Label();
            this.label_num = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.info_data = new System.Windows.Forms.DataGridView();
            this.btn_return = new System.Windows.Forms.Button();
            this.cbox_cid = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.info_data)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbox_sid);
            this.groupBox1.Controls.Add(this.btn_sidsearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(26, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(544, 63);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "按学号检索";
            // 
            // tbox_sid
            // 
            this.tbox_sid.Location = new System.Drawing.Point(99, 27);
            this.tbox_sid.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_sid.Name = "tbox_sid";
            this.tbox_sid.Size = new System.Drawing.Size(139, 21);
            this.tbox_sid.TabIndex = 6;
            // 
            // btn_sidsearch
            // 
            this.btn_sidsearch.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_sidsearch.Location = new System.Drawing.Point(406, 23);
            this.btn_sidsearch.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sidsearch.Name = "btn_sidsearch";
            this.btn_sidsearch.Size = new System.Drawing.Size(78, 24);
            this.btn_sidsearch.TabIndex = 4;
            this.btn_sidsearch.Text = "查  询";
            this.btn_sidsearch.UseVisualStyleBackColor = true;
            this.btn_sidsearch.Click += new System.EventHandler(this.btn_sidsearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbox_cid);
            this.groupBox2.Controls.Add(this.btn_cidsearch);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(26, 96);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(544, 63);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "按课程号检索";
            // 
            // btn_cidsearch
            // 
            this.btn_cidsearch.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_cidsearch.Location = new System.Drawing.Point(406, 22);
            this.btn_cidsearch.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cidsearch.Name = "btn_cidsearch";
            this.btn_cidsearch.Size = new System.Drawing.Size(78, 24);
            this.btn_cidsearch.TabIndex = 4;
            this.btn_cidsearch.Text = "查  询";
            this.btn_cidsearch.UseVisualStyleBackColor = true;
            this.btn_cidsearch.Click += new System.EventHandler(this.btn_cidsearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(20, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "课程号：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.info_data);
            this.groupBox3.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(26, 167);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(544, 184);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "成绩信息";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label_min);
            this.groupBox4.Controls.Add(this.label_max);
            this.groupBox4.Controls.Add(this.label_avg);
            this.groupBox4.Controls.Add(this.label_num);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(420, 18);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(112, 152);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "统计结果";
            // 
            // label_min
            // 
            this.label_min.AutoSize = true;
            this.label_min.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_min.Location = new System.Drawing.Point(68, 106);
            this.label_min.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_min.Name = "label_min";
            this.label_min.Size = new System.Drawing.Size(29, 12);
            this.label_min.TabIndex = 15;
            this.label_min.Text = "    ";
            // 
            // label_max
            // 
            this.label_max.AutoSize = true;
            this.label_max.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_max.Location = new System.Drawing.Point(68, 82);
            this.label_max.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_max.Name = "label_max";
            this.label_max.Size = new System.Drawing.Size(29, 12);
            this.label_max.TabIndex = 15;
            this.label_max.Text = "    ";
            // 
            // label_avg
            // 
            this.label_avg.AutoSize = true;
            this.label_avg.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_avg.Location = new System.Drawing.Point(68, 58);
            this.label_avg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_avg.Name = "label_avg";
            this.label_avg.Size = new System.Drawing.Size(29, 12);
            this.label_avg.TabIndex = 15;
            this.label_avg.Text = "    ";
            // 
            // label_num
            // 
            this.label_num.AutoSize = true;
            this.label_num.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_num.Location = new System.Drawing.Point(68, 34);
            this.label_num.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_num.Name = "label_num";
            this.label_num.Size = new System.Drawing.Size(29, 12);
            this.label_num.TabIndex = 14;
            this.label_num.Text = "    ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(16, 106);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "最低分：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(16, 82);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "最高分：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(16, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "平均分：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(4, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "选课人数：";
            // 
            // info_data
            // 
            this.info_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.info_data.Location = new System.Drawing.Point(22, 18);
            this.info_data.Margin = new System.Windows.Forms.Padding(2);
            this.info_data.Name = "info_data";
            this.info_data.RowHeadersWidth = 51;
            this.info_data.RowTemplate.Height = 30;
            this.info_data.Size = new System.Drawing.Size(385, 152);
            this.info_data.TabIndex = 2;
            // 
            // btn_return
            // 
            this.btn_return.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_return.Location = new System.Drawing.Point(233, 366);
            this.btn_return.Margin = new System.Windows.Forms.Padding(2);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(110, 27);
            this.btn_return.TabIndex = 20;
            this.btn_return.Text = "返   回";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // cbox_cid
            // 
            this.cbox_cid.FormattingEnabled = true;
            this.cbox_cid.Location = new System.Drawing.Point(99, 26);
            this.cbox_cid.Margin = new System.Windows.Forms.Padding(2);
            this.cbox_cid.Name = "cbox_cid";
            this.cbox_cid.Size = new System.Drawing.Size(139, 20);
            this.cbox_cid.TabIndex = 12;
            // 
            // T_ScoreSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 417);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "T_ScoreSearch";
            this.Text = "学生成绩查询";
            this.Load += new System.EventHandler(this.T_ScoreSearch_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.info_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbox_sid;
        private System.Windows.Forms.Button btn_sidsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_cidsearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView info_data;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label_min;
        private System.Windows.Forms.Label label_max;
        private System.Windows.Forms.Label label_avg;
        private System.Windows.Forms.Label label_num;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.ComboBox cbox_cid;
    }
}