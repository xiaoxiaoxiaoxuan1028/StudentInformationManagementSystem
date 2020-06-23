namespace database_exp7
{
    partial class ChangePwd1
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
            this.tbox_pwd = new System.Windows.Forms.TextBox();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.check_fix = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(38, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "原密码：";
            // 
            // tbox_pwd
            // 
            this.tbox_pwd.Location = new System.Drawing.Point(101, 37);
            this.tbox_pwd.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_pwd.Name = "tbox_pwd";
            this.tbox_pwd.Size = new System.Drawing.Size(139, 21);
            this.tbox_pwd.TabIndex = 7;
            // 
            // btn_next
            // 
            this.btn_next.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_next.Location = new System.Drawing.Point(90, 84);
            this.btn_next.Margin = new System.Windows.Forms.Padding(2);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(78, 25);
            this.btn_next.TabIndex = 15;
            this.btn_next.Text = "下一步";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_return
            // 
            this.btn_return.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_return.Location = new System.Drawing.Point(211, 84);
            this.btn_return.Margin = new System.Windows.Forms.Padding(2);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(78, 25);
            this.btn_return.TabIndex = 17;
            this.btn_return.Text = "返  回";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.changepwd1_return_Click);
            // 
            // check_fix
            // 
            this.check_fix.AutoSize = true;
            this.check_fix.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.check_fix.Location = new System.Drawing.Point(253, 37);
            this.check_fix.Margin = new System.Windows.Forms.Padding(2);
            this.check_fix.Name = "check_fix";
            this.check_fix.Size = new System.Drawing.Size(90, 19);
            this.check_fix.TabIndex = 18;
            this.check_fix.Text = "显示密码";
            this.check_fix.UseVisualStyleBackColor = true;
            this.check_fix.CheckedChanged += new System.EventHandler(this.check_fix_CheckedChanged);
            // 
            // ChangePwd1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 141);
            this.Controls.Add(this.check_fix);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.tbox_pwd);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChangePwd1";
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.ChangePwd1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_pwd;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.CheckBox check_fix;
    }
}