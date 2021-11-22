namespace testAdmin
{
    partial class Form1
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
            this.uiAvatar1 = new Sunny.UI.UIAvatar();
            this.login = new Sunny.UI.UIButton();
            this.accountBox = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.passBox = new Sunny.UI.UITextBox();
            this.SuspendLayout();
            // 
            // uiAvatar1
            // 
            this.uiAvatar1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiAvatar1.IsScaled = false;
            this.uiAvatar1.Location = new System.Drawing.Point(120, 37);
            this.uiAvatar1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiAvatar1.Name = "uiAvatar1";
            this.uiAvatar1.Size = new System.Drawing.Size(60, 60);
            this.uiAvatar1.TabIndex = 0;
            this.uiAvatar1.Text = "uiAvatar1";
            // 
            // login
            // 
            this.login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.login.IsScaled = false;
            this.login.Location = new System.Drawing.Point(403, 405);
            this.login.MinimumSize = new System.Drawing.Size(1, 1);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(100, 35);
            this.login.TabIndex = 2;
            this.login.Text = "登录";
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // accountBox
            // 
            this.accountBox.ButtonSymbol = 61761;
            this.accountBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.accountBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.accountBox.IsScaled = false;
            this.accountBox.Location = new System.Drawing.Point(286, 199);
            this.accountBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.accountBox.Maximum = 2147483647D;
            this.accountBox.Minimum = -2147483648D;
            this.accountBox.MinimumSize = new System.Drawing.Size(1, 16);
            this.accountBox.Name = "accountBox";
            this.accountBox.Size = new System.Drawing.Size(377, 49);
            this.accountBox.TabIndex = 5;
            this.accountBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.accountBox.TextChanged += new System.EventHandler(this.accountBox_TextChanged);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(398, 37);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(150, 39);
            this.uiLabel1.TabIndex = 6;
            this.uiLabel1.Text = "你好管理员";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(115, 209);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(150, 39);
            this.uiLabel2.TabIndex = 7;
            this.uiLabel2.Text = "账号";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(115, 272);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(150, 39);
            this.uiLabel3.TabIndex = 8;
            this.uiLabel3.Text = "密码";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // passBox
            // 
            this.passBox.ButtonSymbol = 61761;
            this.passBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.passBox.IsScaled = false;
            this.passBox.Location = new System.Drawing.Point(286, 272);
            this.passBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passBox.Maximum = 2147483647D;
            this.passBox.Minimum = -2147483648D;
            this.passBox.MinimumSize = new System.Drawing.Size(1, 16);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(377, 49);
            this.passBox.TabIndex = 6;
            this.passBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.passBox.TextChanged += new System.EventHandler(this.passBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 646);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.accountBox);
            this.Controls.Add(this.login);
            this.Controls.Add(this.uiAvatar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIAvatar uiAvatar1;
        private Sunny.UI.UIButton login;
        private Sunny.UI.UITextBox accountBox;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox passBox;
    }
}

