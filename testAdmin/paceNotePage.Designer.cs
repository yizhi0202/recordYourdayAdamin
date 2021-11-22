namespace testAdmin
{
    partial class paceNotePage
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
            this.audit = new Sunny.UI.UIButton();
            this.comeback = new Sunny.UI.UIButton();
            this.paceNoteInfoDataGridView = new Sunny.UI.UIDataGridView();
            this.delete = new Sunny.UI.UIButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.choose = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.auditState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voteNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.introduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.paceNoteInfoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // audit
            // 
            this.audit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.audit.FillColor = System.Drawing.Color.Green;
            this.audit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.audit.IsScaled = false;
            this.audit.Location = new System.Drawing.Point(189, 47);
            this.audit.MinimumSize = new System.Drawing.Size(1, 1);
            this.audit.Name = "audit";
            this.audit.Size = new System.Drawing.Size(100, 35);
            this.audit.Style = Sunny.UI.UIStyle.Custom;
            this.audit.TabIndex = 14;
            this.audit.Text = "审核";
            this.audit.Click += new System.EventHandler(this.audit_Click);
            // 
            // comeback
            // 
            this.comeback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comeback.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comeback.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comeback.IsScaled = false;
            this.comeback.Location = new System.Drawing.Point(322, 47);
            this.comeback.MinimumSize = new System.Drawing.Size(1, 1);
            this.comeback.Name = "comeback";
            this.comeback.Size = new System.Drawing.Size(100, 35);
            this.comeback.Style = Sunny.UI.UIStyle.Custom;
            this.comeback.TabIndex = 13;
            this.comeback.Text = "返回";
            this.comeback.Click += new System.EventHandler(this.comeback_Click);
            // 
            // paceNoteInfoDataGridView
            // 
            this.paceNoteInfoDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.paceNoteInfoDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.paceNoteInfoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.paceNoteInfoDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.paceNoteInfoDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.paceNoteInfoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.paceNoteInfoDataGridView.ColumnHeadersHeight = 32;
            this.paceNoteInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.paceNoteInfoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.choose,
            this.auditState,
            this.dataGridViewTextBoxColumn1,
            this.userID,
            this.voteNum,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.introduction});
            this.paceNoteInfoDataGridView.EnableHeadersVisualStyles = false;
            this.paceNoteInfoDataGridView.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.paceNoteInfoDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.paceNoteInfoDataGridView.Location = new System.Drawing.Point(60, 103);
            this.paceNoteInfoDataGridView.Name = "paceNoteInfoDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.paceNoteInfoDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.paceNoteInfoDataGridView.RowHeadersVisible = false;
            this.paceNoteInfoDataGridView.RowHeight = 27;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.paceNoteInfoDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.paceNoteInfoDataGridView.RowTemplate.Height = 27;
            this.paceNoteInfoDataGridView.SelectedIndex = -1;
            this.paceNoteInfoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.paceNoteInfoDataGridView.ShowGridLine = true;
            this.paceNoteInfoDataGridView.Size = new System.Drawing.Size(1373, 680);
            this.paceNoteInfoDataGridView.TabIndex = 12;
            // 
            // delete
            // 
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.FillColor = System.Drawing.Color.Red;
            this.delete.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.delete.IsScaled = false;
            this.delete.Location = new System.Drawing.Point(60, 47);
            this.delete.MinimumSize = new System.Drawing.Size(1, 1);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(100, 35);
            this.delete.Style = Sunny.UI.UIStyle.Custom;
            this.delete.TabIndex = 11;
            this.delete.Text = "删除";
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(685, 16);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(136, 38);
            this.uiLabel1.TabIndex = 10;
            this.uiLabel1.Text = "路书信息页";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.dataGridViewTextBoxColumn1.HeaderText = "路书ID";
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
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "title";
            this.dataGridViewTextBoxColumn2.HeaderText = "路书名称";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "note";
            this.dataGridViewTextBoxColumn3.HeaderText = "感受";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "photo";
            this.dataGridViewTextBoxColumn4.HeaderText = "路书封面";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "score";
            this.dataGridViewTextBoxColumn5.HeaderText = "评分";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // introduction
            // 
            this.introduction.DataPropertyName = "scenicSpotInfo";
            this.introduction.HeaderText = "景点信息";
            this.introduction.Name = "introduction";
            // 
            // paceNotePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 798);
            this.Controls.Add(this.audit);
            this.Controls.Add(this.comeback);
            this.Controls.Add(this.paceNoteInfoDataGridView);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.uiLabel1);
            this.Name = "paceNotePage";
            this.Text = "paceNotePage";
            this.Load += new System.EventHandler(this.paceNotePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paceNoteInfoDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton audit;
        private Sunny.UI.UIButton comeback;
        private Sunny.UI.UIDataGridView paceNoteInfoDataGridView;
        private Sunny.UI.UIButton delete;
        private Sunny.UI.UILabel uiLabel1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn choose;
        private System.Windows.Forms.DataGridViewTextBoxColumn auditState;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userID;
        private System.Windows.Forms.DataGridViewTextBoxColumn voteNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn introduction;
    }
}