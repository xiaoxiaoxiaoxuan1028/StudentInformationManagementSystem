namespace database_exp7
{
    partial class ChangePwd2
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
            this.tbox_newpwd1 = new System.Windows.Forms.TextBox();
            this.tbox_newpwd2 = new System.Windows.Forms.TextBox();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(52, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "新密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(26, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "确认新密码：";
            // 
            // tbox_newpwd1
            // 
            this.tbox_newpwd1.Location = new System.Drawing.Point(116, 26);
            this.tbox_newpwd1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbox_newpwd1.Name = "tbox_newpwd1";
            this.tbox_newpwd1.Size = new System.Drawing.Size(139, 21);
            this.tbox_newpwd1.TabIndex = 8;
            // 
            // tbox_newpwd2
            // 
            this.tbox_newpwd2.Location = new System.Drawing.Point(116, 57);
            this.tbox_newpwd2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbox_newpwd2.Name = "tbox_newpwd2";
            this.tbox_newpwd2.Size = new System.Drawing.Size(139, 21);
            this.tbox_newpwd2.TabIndex = 9;
            // 
            // btn_next
            // 
            this.btn_next.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_next.Location = new System.Drawing.Point(55, 95);
            this.btn_next.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(78, 25);
            this.btn_next.TabIndex = 16;
            this.btn_next.Text = "确  认";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_close.Location = new System.Drawing.Point(160, 95);
            this.btn_close.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(78, 25);
            this.btn_close.TabIndex = 17;
            this.btn_close.Text = "关  闭";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // ChangePwd2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 141);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.tbox_newpwd2);
            this.Controls.Add(this.tbox_newpwd1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ChangePwd2";
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.ChangePwd2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox_newpwd1;
        private System.Windows.Forms.TextBox tbox_newpwd2;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_close;
    }
}