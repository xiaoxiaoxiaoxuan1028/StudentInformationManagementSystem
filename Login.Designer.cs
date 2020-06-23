namespace database_exp7
{
    partial class form_login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label_title = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label_pswd = new System.Windows.Forms.Label();
            this.login_id = new System.Windows.Forms.TextBox();
            this.login_pwd = new System.Windows.Forms.TextBox();
            this.radioButton_stu = new System.Windows.Forms.RadioButton();
            this.radioButton_t = new System.Windows.Forms.RadioButton();
            this.radioButton_ad = new System.Windows.Forms.RadioButton();
            this.btn_login = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("华文行楷", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_title.Location = new System.Drawing.Point(123, 68);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(305, 37);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "学生成绩管理系统";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_id.Location = new System.Drawing.Point(126, 157);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(72, 20);
            this.label_id.TabIndex = 1;
            this.label_id.Text = "账号：";
            // 
            // label_pswd
            // 
            this.label_pswd.AutoSize = true;
            this.label_pswd.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_pswd.Location = new System.Drawing.Point(126, 218);
            this.label_pswd.Name = "label_pswd";
            this.label_pswd.Size = new System.Drawing.Size(72, 20);
            this.label_pswd.TabIndex = 2;
            this.label_pswd.Text = "密码：";
            // 
            // login_id
            // 
            this.login_id.Location = new System.Drawing.Point(225, 157);
            this.login_id.Name = "login_id";
            this.login_id.Size = new System.Drawing.Size(249, 24);
            this.login_id.TabIndex = 3;
            // 
            // login_pwd
            // 
            this.login_pwd.Location = new System.Drawing.Point(225, 215);
            this.login_pwd.Name = "login_pwd";
            this.login_pwd.PasswordChar = '*';
            this.login_pwd.Size = new System.Drawing.Size(249, 24);
            this.login_pwd.TabIndex = 4;
            // 
            // radioButton_stu
            // 
            this.radioButton_stu.AutoSize = true;
            this.radioButton_stu.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_stu.Location = new System.Drawing.Point(101, 297);
            this.radioButton_stu.Name = "radioButton_stu";
            this.radioButton_stu.Size = new System.Drawing.Size(60, 20);
            this.radioButton_stu.TabIndex = 5;
            this.radioButton_stu.TabStop = true;
            this.radioButton_stu.Text = "学生";
            this.radioButton_stu.UseVisualStyleBackColor = true;
            this.radioButton_stu.CheckedChanged += new System.EventHandler(this.radioButton_stu_CheckedChanged);
            // 
            // radioButton_t
            // 
            this.radioButton_t.AutoSize = true;
            this.radioButton_t.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_t.Location = new System.Drawing.Point(260, 297);
            this.radioButton_t.Name = "radioButton_t";
            this.radioButton_t.Size = new System.Drawing.Size(60, 20);
            this.radioButton_t.TabIndex = 6;
            this.radioButton_t.TabStop = true;
            this.radioButton_t.Text = "教师";
            this.radioButton_t.UseVisualStyleBackColor = true;
            // 
            // radioButton_ad
            // 
            this.radioButton_ad.AutoSize = true;
            this.radioButton_ad.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_ad.Location = new System.Drawing.Point(414, 297);
            this.radioButton_ad.Name = "radioButton_ad";
            this.radioButton_ad.Size = new System.Drawing.Size(77, 20);
            this.radioButton_ad.TabIndex = 7;
            this.radioButton_ad.TabStop = true;
            this.radioButton_ad.Text = "管理员";
            this.radioButton_ad.UseVisualStyleBackColor = true;
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_login.Location = new System.Drawing.Point(234, 362);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(142, 28);
            this.btn_login.TabIndex = 8;
            this.btn_login.Text = "登录";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // form_login
            // 
            this.ClientSize = new System.Drawing.Size(610, 438);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.radioButton_ad);
            this.Controls.Add(this.radioButton_t);
            this.Controls.Add(this.radioButton_stu);
            this.Controls.Add(this.login_pwd);
            this.Controls.Add(this.login_id);
            this.Controls.Add(this.label_pswd);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label_title);
            this.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "form_login";
            this.Text = "欢迎登录";
            this.Load += new System.EventHandler(this.form_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_pswd;
        private System.Windows.Forms.TextBox login_id;
        private System.Windows.Forms.TextBox login_pwd;
        private System.Windows.Forms.RadioButton radioButton_stu;
        private System.Windows.Forms.RadioButton radioButton_t;
        private System.Windows.Forms.RadioButton radioButton_ad;
        private System.Windows.Forms.Button btn_login;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}

