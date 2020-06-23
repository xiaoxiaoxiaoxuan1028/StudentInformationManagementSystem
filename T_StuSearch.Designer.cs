namespace database_exp7
{
    partial class T_StuSearch
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
            this.label4 = new System.Windows.Forms.Label();
            this.label_num = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.info_data = new System.Windows.Forms.DataGridView();
            this.btn_return = new System.Windows.Forms.Button();
            this.tbox_cid = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.info_data)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbox_sid);
            this.groupBox1.Controls.Add(this.btn_sidsearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(53, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(593, 79);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "按学号检索";
            // 
            // tbox_sid
            // 
            this.tbox_sid.Location = new System.Drawing.Point(132, 34);
            this.tbox_sid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbox_sid.Name = "tbox_sid";
            this.tbox_sid.Size = new System.Drawing.Size(184, 25);
            this.tbox_sid.TabIndex = 6;
            // 
            // btn_sidsearch
            // 
            this.btn_sidsearch.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_sidsearch.Location = new System.Drawing.Point(444, 29);
            this.btn_sidsearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sidsearch.Name = "btn_sidsearch";
            this.btn_sidsearch.Size = new System.Drawing.Size(104, 30);
            this.btn_sidsearch.TabIndex = 4;
            this.btn_sidsearch.Text = "查  询";
            this.btn_sidsearch.UseVisualStyleBackColor = true;
            this.btn_sidsearch.Click += new System.EventHandler(this.btn_sidsearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(45, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbox_cid);
            this.groupBox2.Controls.Add(this.btn_cidsearch);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(53, 110);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(593, 79);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "按课程号检索";
            // 
            // btn_cidsearch
            // 
            this.btn_cidsearch.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_cidsearch.Location = new System.Drawing.Point(444, 29);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label_num);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.info_data);
            this.groupBox3.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(53, 205);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(593, 265);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "学生信息";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(495, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "条记录";
            // 
            // label_num
            // 
            this.label_num.AutoSize = true;
            this.label_num.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_num.Location = new System.Drawing.Point(459, 228);
            this.label_num.Name = "label_num";
            this.label_num.Size = new System.Drawing.Size(39, 19);
            this.label_num.TabIndex = 4;
            this.label_num.Text = "   ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(424, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "共";
            // 
            // info_data
            // 
            this.info_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.info_data.Location = new System.Drawing.Point(48, 22);
            this.info_data.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.info_data.Name = "info_data";
            this.info_data.RowHeadersWidth = 51;
            this.info_data.RowTemplate.Height = 30;
            this.info_data.Size = new System.Drawing.Size(485, 190);
            this.info_data.TabIndex = 2;
            // 
            // btn_return
            // 
            this.btn_return.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_return.Location = new System.Drawing.Point(269, 484);
            this.btn_return.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(147, 34);
            this.btn_return.TabIndex = 19;
            this.btn_return.Text = "返   回";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // tbox_cid
            // 
            this.tbox_cid.Location = new System.Drawing.Point(132, 35);
            this.tbox_cid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbox_cid.Name = "tbox_cid";
            this.tbox_cid.Size = new System.Drawing.Size(184, 25);
            this.tbox_cid.TabIndex = 7;
            // 
            // T_StuSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 542);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "T_StuSearch";
            this.Text = "学生信息查询";
            this.Load += new System.EventHandler(this.T_StuSearch_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_num;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.TextBox tbox_cid;
    }
}