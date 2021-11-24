namespace testAdmin
{
    partial class commentPage
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
            this.commentInfoDataGridView = new Sunny.UI.UIDataGridView();
            this.delete = new Sunny.UI.UIButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.choose = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.commentInfoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // comeback
            // 
            this.comeback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comeback.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comeback.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comeback.IsScaled = false;
            this.comeback.Location = new System.Drawing.Point(202, 61);
            this.comeback.MinimumSize = new System.Drawing.Size(1, 1);
            this.comeback.Name = "comeback";
            this.comeback.Size = new System.Drawing.Size(100, 35);
            this.comeback.Style = Sunny.UI.UIStyle.Custom;
            this.comeback.TabIndex = 8;
            this.comeback.Text = "返回";
            this.comeback.Click += new System.EventHandler(this.comeback_Click);
            // 
            // commentInfoDataGridView
            // 
            this.commentInfoDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.commentInfoDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.commentInfoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.commentInfoDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.commentInfoDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.commentInfoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.commentInfoDataGridView.ColumnHeadersHeight = 32;
            this.commentInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.commentInfoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.choose,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.commentInfoDataGridView.EnableHeadersVisualStyles = false;
            this.commentInfoDataGridView.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.commentInfoDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.commentInfoDataGridView.Location = new System.Drawing.Point(66, 118);
            this.commentInfoDataGridView.Name = "commentInfoDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.commentInfoDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.commentInfoDataGridView.RowHeadersVisible = false;
            this.commentInfoDataGridView.RowHeight = 27;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.commentInfoDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.commentInfoDataGridView.RowTemplate.Height = 27;
            this.commentInfoDataGridView.SelectedIndex = -1;
            this.commentInfoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.commentInfoDataGridView.ShowGridLine = true;
            this.commentInfoDataGridView.Size = new System.Drawing.Size(871, 592);
            this.commentInfoDataGridView.TabIndex = 7;
            this.commentInfoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.commentInfoDataGridView_CellContentClick);
            // 
            // delete
            // 
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.FillColor = System.Drawing.Color.Red;
            this.delete.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.delete.IsScaled = false;
            this.delete.Location = new System.Drawing.Point(66, 61);
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
            this.uiLabel1.Location = new System.Drawing.Point(503, 17);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(136, 38);
            this.uiLabel1.TabIndex = 5;
            this.uiLabel1.Text = "评论信息页";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // choose
            // 
            this.choose.HeaderText = "选择框";
            this.choose.Name = "choose";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "userID";
            this.dataGridViewTextBoxColumn1.HeaderText = "用户ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "objectID";
            this.dataGridViewTextBoxColumn4.HeaderText = "对象ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "content";
            this.dataGridViewTextBoxColumn5.HeaderText = "评论内容";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // commentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 745);
            this.Controls.Add(this.comeback);
            this.Controls.Add(this.commentInfoDataGridView);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.uiLabel1);
            this.Name = "commentPage";
            this.Text = "commentPage";
            this.Load += new System.EventHandler(this.commentPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.commentInfoDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton comeback;
        private Sunny.UI.UIDataGridView commentInfoDataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn choose;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Sunny.UI.UIButton delete;
        private Sunny.UI.UILabel uiLabel1;
    }
}