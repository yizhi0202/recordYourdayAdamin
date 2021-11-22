namespace testAdmin
{
    partial class scenicSpotPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comeback = new Sunny.UI.UIButton();
            this.scenicSpotInfoDataGridView = new Sunny.UI.UIDataGridView();
            this.delete = new Sunny.UI.UIButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.audit = new Sunny.UI.UIButton();
            this.choose = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.auditState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voteNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.introduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.scenicSpotInfoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // comeback
            // 
            this.comeback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comeback.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comeback.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comeback.IsScaled = false;
            this.comeback.Location = new System.Drawing.Point(302, 40);
            this.comeback.MinimumSize = new System.Drawing.Size(1, 1);
            this.comeback.Name = "comeback";
            this.comeback.Size = new System.Drawing.Size(100, 35);
            this.comeback.Style = Sunny.UI.UIStyle.Custom;
            this.comeback.TabIndex = 8;
            this.comeback.Text = "返回";
            this.comeback.Click += new System.EventHandler(this.comeback_Click);
            // 
            // scenicSpotInfoDataGridView
            // 
            this.scenicSpotInfoDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.scenicSpotInfoDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.scenicSpotInfoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.scenicSpotInfoDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.scenicSpotInfoDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.scenicSpotInfoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.scenicSpotInfoDataGridView.ColumnHeadersHeight = 32;
            this.scenicSpotInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.scenicSpotInfoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.choose,
            this.auditState,
            this.dataGridViewTextBoxColumn1,
            this.userID,
            this.voteNum,
            this.publishTime,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.latitude,
            this.introduction,
            this.address});
            this.scenicSpotInfoDataGridView.EnableHeadersVisualStyles = false;
            this.scenicSpotInfoDataGridView.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.scenicSpotInfoDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.scenicSpotInfoDataGridView.Location = new System.Drawing.Point(40, 96);
            this.scenicSpotInfoDataGridView.Name = "scenicSpotInfoDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.scenicSpotInfoDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.scenicSpotInfoDataGridView.RowHeadersVisible = false;
            this.scenicSpotInfoDataGridView.RowHeight = 27;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.scenicSpotInfoDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.scenicSpotInfoDataGridView.RowTemplate.Height = 27;
            this.scenicSpotInfoDataGridView.SelectedIndex = -1;
            this.scenicSpotInfoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.scenicSpotInfoDataGridView.ShowGridLine = true;
            this.scenicSpotInfoDataGridView.Size = new System.Drawing.Size(1336, 680);
            this.scenicSpotInfoDataGridView.TabIndex = 7;
            // 
            // delete
            // 
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.FillColor = System.Drawing.Color.Red;
            this.delete.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.delete.IsScaled = false;
            this.delete.Location = new System.Drawing.Point(40, 40);
            this.delete.MinimumSize = new System.Drawing.Size(1, 1);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(100, 35);
            this.delete.Style = Sunny.UI.UIStyle.Custom;
            this.delete.TabIndex = 6;
            this.delete.Text = "删除";
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(665, 9);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(136, 38);
            this.uiLabel1.TabIndex = 5;
            this.uiLabel1.Text = "景点信息页";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // audit
            // 
            this.audit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.audit.FillColor = System.Drawing.Color.Green;
            this.audit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.audit.IsScaled = false;
            this.audit.Location = new System.Drawing.Point(169, 40);
            this.audit.MinimumSize = new System.Drawing.Size(1, 1);
            this.audit.Name = "audit";
            this.audit.Size = new System.Drawing.Size(100, 35);
            this.audit.Style = Sunny.UI.UIStyle.Custom;
            this.audit.TabIndex = 9;
            this.audit.Text = "审核";
            this.audit.Click += new System.EventHandler(this.audit_Click);
            // 
            // choose
            // 
            this.choose.HeaderText = "选择框";
            this.choose.Name = "choose";
            // 
            // auditState
            // 
            this.auditState.DataPropertyName = "audit";
            this.auditState.HeaderText = "审核状态";
            this.auditState.Name = "auditState";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "景点ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // userID
            // 
            this.userID.DataPropertyName = "userID";
            this.userID.HeaderText = "用户ID";
            this.userID.Name = "userID";
            // 
            // voteNum
            // 
            this.voteNum.DataPropertyName = "voteNum";
            this.voteNum.HeaderText = "点赞数";
            this.voteNum.Name = "voteNum";
            // 
            // publishTime
            // 
            this.publishTime.DataPropertyName = "publishTime";
            this.publishTime.HeaderText = "发布时间";
            this.publishTime.Name = "publishTime";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "title";
            this.dataGridViewTextBoxColumn2.HeaderText = "景点名称";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "subtitle";
            this.dataGridViewTextBoxColumn3.HeaderText = "简介";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "scenicSpotPhotoUrl";
            this.dataGridViewTextBoxColumn4.HeaderText = "景点图片";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "longitude";
            this.dataGridViewTextBoxColumn5.HeaderText = "经度";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // latitude
            // 
            this.latitude.DataPropertyName = "latitude";
            this.latitude.HeaderText = "纬度";
            this.latitude.Name = "latitude";
            // 
            // introduction
            // 
            this.introduction.DataPropertyName = "introduction";
            this.introduction.HeaderText = "介绍";
            this.introduction.Name = "introduction";
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "地址";
            this.address.Name = "address";
            // 
            // scenicSpotPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 798);
            this.Controls.Add(this.audit);
            this.Controls.Add(this.comeback);
            this.Controls.Add(this.scenicSpotInfoDataGridView);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.uiLabel1);
            this.Name = "scenicSpotPage";
            this.Text = "scenicSpotPage";
            this.Load += new System.EventHandler(this.scenicSpotPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scenicSpotInfoDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton comeback;
        private Sunny.UI.UIDataGridView scenicSpotInfoDataGridView;
        private Sunny.UI.UIButton delete;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton audit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn choose;
        private System.Windows.Forms.DataGridViewTextBoxColumn auditState;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userID;
        private System.Windows.Forms.DataGridViewTextBoxColumn voteNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn latitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn introduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
    }
}