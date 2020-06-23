namespace database_exp7
{
    partial class T_ScoreInput
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbox_sid = new System.Windows.Forms.TextBox();
            this.tbox_score = new System.Windows.Forms.TextBox();
            this.cbox_cid = new System.Windows.Forms.ComboBox();
            this.check_fix = new System.Windows.Forms.CheckBox();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "课程号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(36, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "学号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(36, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "成绩：";
            // 
            // tbox_sid
            // 
            this.tbox_sid.Location = new System.Drawing.Point(86, 58);
            this.tbox_sid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbox_sid.Name = "tbox_sid";
            this.tbox_sid.Size = new System.Drawing.Size(139, 21);
            this.tbox_sid.TabIndex = 9;
            // 
            // tbox_score
            // 
            this.tbox_score.Location = new System.Drawing.Point(86, 92);
            this.tbox_score.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbox_score.Name = "tbox_score";
            this.tbox_score.Size = new System.Drawing.Size(139, 21);
            this.tbox_score.TabIndex = 10;
            // 
            // cbox_cid
            // 
            this.cbox_cid.FormattingEnabled = true;
            this.cbox_cid.Location = new System.Drawing.Point(86, 26);
            this.cbox_cid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbox_cid.Name = "cbox_cid";
            this.cbox_cid.Size = new System.Drawing.Size(139, 20);
            this.cbox_cid.TabIndex = 11;
            // 
            // check_fix
            // 
            this.check_fix.AutoSize = true;
            this.check_fix.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.check_fix.Location = new System.Drawing.Point(259, 28);
            this.check_fix.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.check_fix.Name = "check_fix";
            this.check_fix.Size = new System.Drawing.Size(106, 19);
            this.check_fix.TabIndex = 12;
            this.check_fix.Text = "固定课程号";
            this.check_fix.UseVisualStyleBackColor = true;
            // 
            // btn_next
            // 
            this.btn_next.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_next.Location = new System.Drawing.Point(50, 138);
            this.btn_next.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(121, 27);
            this.btn_next.TabIndex = 17;
            this.btn_next.Text = "确认并下一个";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_return
            // 
            this.btn_return.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_return.Location = new System.Drawing.Point(237, 138);
            this.btn_return.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(120, 27);
            this.btn_return.TabIndex = 18;
            this.btn_return.Text = "返   回";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // T_ScoreInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 187);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.check_fix);
            this.Controls.Add(this.cbox_cid);
            this.Controls.Add(this.tbox_score);
            this.Controls.Add(this.tbox_sid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "T_ScoreInput";
            this.Text = "成绩录入";
            this.Load += new System.EventHandler(this.T_ScoreInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbox_sid;
        private System.Windows.Forms.TextBox tbox_score;
        private System.Windows.Forms.ComboBox cbox_cid;
        private System.Windows.Forms.CheckBox check_fix;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_return;
    }
}