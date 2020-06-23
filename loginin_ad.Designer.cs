namespace database_exp7
{
    partial class LoginIn_Ad
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
            this.label_lastlogin = new System.Windows.Forms.Label();
            this.label_aname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_course = new System.Windows.Forms.Button();
            this.btn_teacher = new System.Windows.Forms.Button();
            this.btn_stu = new System.Windows.Forms.Button();
            this.btn_choose = new System.Windows.Forms.Button();
            this.btn_user = new System.Windows.Forms.Button();
            this.btn_changepwd = new System.Windows.Forms.Button();
            this.ad_out = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_lastlogin);
            this.groupBox1.Controls.Add(this.label_aname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(32, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(389, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "管理员信息";
            // 
            // label_lastlogin
            // 
            this.label_lastlogin.AutoSize = true;
            this.label_lastlogin.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_lastlogin.Location = new System.Drawing.Point(115, 50);
            this.label_lastlogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_lastlogin.Name = "label_lastlogin";
            this.label_lastlogin.Size = new System.Drawing.Size(143, 15);
            this.label_lastlogin.TabIndex = 7;
            this.label_lastlogin.Text = "                 ";
            // 
            // label_aname
            // 
            this.label_aname.AutoSize = true;
            this.label_aname.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_aname.Location = new System.Drawing.Point(115, 26);
            this.label_aname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_aname.Name = "label_aname";
            this.label_aname.Size = new System.Drawing.Size(143, 15);
            this.label_aname.TabIndex = 6;
            this.label_aname.Text = "                 ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(28, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "上次登录：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(44, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "账户名：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_course
            // 
            this.btn_course.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_course.Location = new System.Drawing.Point(93, 118);
            this.btn_course.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_course.Name = "btn_course";
            this.btn_course.Size = new System.Drawing.Size(95, 24);
            this.btn_course.TabIndex = 1;
            this.btn_course.Text = "课程管理";
            this.btn_course.UseVisualStyleBackColor = true;
            this.btn_course.Click += new System.EventHandler(this.btn_course_Click);
            // 
            // btn_teacher
            // 
            this.btn_teacher.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_teacher.Location = new System.Drawing.Point(242, 118);
            this.btn_teacher.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_teacher.Name = "btn_teacher";
            this.btn_teacher.Size = new System.Drawing.Size(95, 24);
            this.btn_teacher.TabIndex = 2;
            this.btn_teacher.Text = "教师管理";
            this.btn_teacher.UseVisualStyleBackColor = true;
            this.btn_teacher.Click += new System.EventHandler(this.btn_teacher_Click);
            // 
            // btn_stu
            // 
            this.btn_stu.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_stu.Location = new System.Drawing.Point(94, 162);
            this.btn_stu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_stu.Name = "btn_stu";
            this.btn_stu.Size = new System.Drawing.Size(95, 26);
            this.btn_stu.TabIndex = 3;
            this.btn_stu.Text = "学生管理";
            this.btn_stu.UseVisualStyleBackColor = true;
            this.btn_stu.Click += new System.EventHandler(this.btn_stu_Click);
            // 
            // btn_choose
            // 
            this.btn_choose.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_choose.Location = new System.Drawing.Point(242, 162);
            this.btn_choose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_choose.Name = "btn_choose";
            this.btn_choose.Size = new System.Drawing.Size(95, 26);
            this.btn_choose.TabIndex = 4;
            this.btn_choose.Text = "选课管理";
            this.btn_choose.UseVisualStyleBackColor = true;
            this.btn_choose.Click += new System.EventHandler(this.btn_choose_Click);
            // 
            // btn_user
            // 
            this.btn_user.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_user.Location = new System.Drawing.Point(93, 210);
            this.btn_user.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_user.Name = "btn_user";
            this.btn_user.Size = new System.Drawing.Size(95, 26);
            this.btn_user.TabIndex = 5;
            this.btn_user.Text = "用户管理";
            this.btn_user.UseVisualStyleBackColor = true;
            this.btn_user.Click += new System.EventHandler(this.btn_user_Click);
            // 
            // btn_changepwd
            // 
            this.btn_changepwd.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_changepwd.Location = new System.Drawing.Point(242, 210);
            this.btn_changepwd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_changepwd.Name = "btn_changepwd";
            this.btn_changepwd.Size = new System.Drawing.Size(95, 26);
            this.btn_changepwd.TabIndex = 6;
            this.btn_changepwd.Text = "修改密码";
            this.btn_changepwd.UseVisualStyleBackColor = true;
            this.btn_changepwd.Click += new System.EventHandler(this.btn_changepwd_Click);
            // 
            // ad_out
            // 
            this.ad_out.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ad_out.Location = new System.Drawing.Point(188, 251);
            this.ad_out.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ad_out.Name = "ad_out";
            this.ad_out.Size = new System.Drawing.Size(57, 30);
            this.ad_out.TabIndex = 7;
            this.ad_out.Text = "退出";
            this.ad_out.UseVisualStyleBackColor = true;
            this.ad_out.Click += new System.EventHandler(this.ad_out_Click);
            // 
            // LoginIn_Ad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 290);
            this.Controls.Add(this.ad_out);
            this.Controls.Add(this.btn_changepwd);
            this.Controls.Add(this.btn_user);
            this.Controls.Add(this.btn_choose);
            this.Controls.Add(this.btn_stu);
            this.Controls.Add(this.btn_teacher);
            this.Controls.Add(this.btn_course);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginIn_Ad";
            this.Text = "管理员";
            this.Load += new System.EventHandler(this.LoginIn_Ad_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_course;
        private System.Windows.Forms.Button btn_teacher;
        private System.Windows.Forms.Button btn_stu;
        private System.Windows.Forms.Button btn_choose;
        private System.Windows.Forms.Button btn_user;
        private System.Windows.Forms.Button btn_changepwd;
        private System.Windows.Forms.Button ad_out;
        private System.Windows.Forms.Label label_lastlogin;
        private System.Windows.Forms.Label label_aname;
    }
}