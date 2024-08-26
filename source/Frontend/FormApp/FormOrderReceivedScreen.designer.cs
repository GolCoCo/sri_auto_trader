namespace SRI_AUTO_TRADER
{
    partial class FormOrderReceivedScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SignalDataGridView = new System.Windows.Forms.DataGridView();
            this.SignalProgressBar = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.ReceivedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SignalSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrokerSent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrokerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Symbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SignalDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SignalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SignalType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SignalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SignalHash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SignalSentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrokerStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SignalDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SignalDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SignalProgressBar)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.SignalDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SignalProgressBar, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1523, 511);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // SignalDataGridView
            // 
            this.SignalDataGridView.AllowUserToAddRows = false;
            this.SignalDataGridView.AllowUserToDeleteRows = false;
            this.SignalDataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Yellow;
            this.SignalDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.SignalDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SignalDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.SignalDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.SignalDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SignalDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SignalDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.SignalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SignalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReceivedTime,
            this.SignalSource,
            this.BrokerSent,
            this.BrokerType,
            this.Symbol,
            this.SignalDate,
            this.SignalTime,
            this.SignalType,
            this.SignalPrice,
            this.Qty,
            this.SignalHash,
            this.SignalSentStatus,
            this.BrokerStatus,
            this.SignalDB});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SignalDataGridView.DefaultCellStyle = dataGridViewCellStyle13;
            this.SignalDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SignalDataGridView.GridColor = System.Drawing.Color.Gainsboro;
            this.SignalDataGridView.Location = new System.Drawing.Point(3, 24);
            this.SignalDataGridView.MultiSelect = false;
            this.SignalDataGridView.Name = "SignalDataGridView";
            this.SignalDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SignalDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.SignalDataGridView.RowHeadersVisible = false;
            this.SignalDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Yellow;
            this.SignalDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.SignalDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SignalDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.SignalDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SignalDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Black;
            this.SignalDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SignalDataGridView.RowTemplate.Height = 24;
            this.SignalDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.SignalDataGridView.ShowCellErrors = false;
            this.SignalDataGridView.ShowCellToolTips = false;
            this.SignalDataGridView.ShowEditingIcon = false;
            this.SignalDataGridView.ShowRowErrors = false;
            this.SignalDataGridView.Size = new System.Drawing.Size(1517, 484);
            this.SignalDataGridView.StandardTab = true;
            this.SignalDataGridView.TabIndex = 1;
            // 
            // SignalProgressBar
            // 
            this.SignalProgressBar.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.Gradient;
            this.SignalProgressBar.BackMultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.SignalProgressBar.BackSegments = false;
            this.SignalProgressBar.Border3DStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.SignalProgressBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            this.SignalProgressBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SignalProgressBar.CustomText = null;
            this.SignalProgressBar.CustomWaitingRender = false;
            this.SignalProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SignalProgressBar.ForegroundImage = null;
            this.SignalProgressBar.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.SignalProgressBar.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.SignalProgressBar.Location = new System.Drawing.Point(0, 0);
            this.SignalProgressBar.Margin = new System.Windows.Forms.Padding(0);
            this.SignalProgressBar.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.SignalProgressBar.Name = "SignalProgressBar";
            this.SignalProgressBar.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Tube;
            this.SignalProgressBar.SegmentWidth = 12;
            this.SignalProgressBar.Size = new System.Drawing.Size(1523, 21);
            this.SignalProgressBar.TabIndex = 2;
            this.SignalProgressBar.Text = "progressBarAdv1";
            this.SignalProgressBar.TextVisible = false;
            this.SignalProgressBar.ThemeName = "Tube";
            this.SignalProgressBar.TubeEndColor = System.Drawing.Color.LimeGreen;
            this.SignalProgressBar.TubeStartColor = System.Drawing.Color.DarkGreen;
            this.SignalProgressBar.WaitingGradientWidth = 400;
            // 
            // ReceivedTime
            // 
            this.ReceivedTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ReceivedTime.FillWeight = 40F;
            this.ReceivedTime.HeaderText = "ReceivedTime";
            this.ReceivedTime.Name = "ReceivedTime";
            this.ReceivedTime.ReadOnly = true;
            // 
            // SignalSource
            // 
            this.SignalSource.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SignalSource.FillWeight = 20F;
            this.SignalSource.HeaderText = "SignalSource";
            this.SignalSource.Name = "SignalSource";
            this.SignalSource.ReadOnly = true;
            // 
            // BrokerSent
            // 
            this.BrokerSent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrokerSent.FillWeight = 20F;
            this.BrokerSent.HeaderText = "BrokerSent";
            this.BrokerSent.Name = "BrokerSent";
            this.BrokerSent.ReadOnly = true;
            // 
            // BrokerType
            // 
            this.BrokerType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrokerType.FillWeight = 20F;
            this.BrokerType.HeaderText = "BrokerType";
            this.BrokerType.Name = "BrokerType";
            this.BrokerType.ReadOnly = true;
            // 
            // Symbol
            // 
            this.Symbol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Symbol.FillWeight = 20F;
            this.Symbol.HeaderText = "Symbol";
            this.Symbol.Name = "Symbol";
            this.Symbol.ReadOnly = true;
            // 
            // SignalDate
            // 
            this.SignalDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SignalDate.FillWeight = 40F;
            this.SignalDate.HeaderText = "SignalDate";
            this.SignalDate.Name = "SignalDate";
            this.SignalDate.ReadOnly = true;
            // 
            // SignalTime
            // 
            this.SignalTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SignalTime.FillWeight = 40F;
            this.SignalTime.HeaderText = "SignalTime";
            this.SignalTime.Name = "SignalTime";
            this.SignalTime.ReadOnly = true;
            // 
            // SignalType
            // 
            this.SignalType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SignalType.FillWeight = 20F;
            this.SignalType.HeaderText = "SignalType";
            this.SignalType.Name = "SignalType";
            this.SignalType.ReadOnly = true;
            // 
            // SignalPrice
            // 
            this.SignalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SignalPrice.FillWeight = 20F;
            this.SignalPrice.HeaderText = "SignalPrice";
            this.SignalPrice.Name = "SignalPrice";
            this.SignalPrice.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Qty.FillWeight = 20F;
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // SignalHash
            // 
            this.SignalHash.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SignalHash.FillWeight = 50F;
            this.SignalHash.HeaderText = "SignalHash";
            this.SignalHash.Name = "SignalHash";
            this.SignalHash.ReadOnly = true;
            // 
            // SignalSentStatus
            // 
            this.SignalSentStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SignalSentStatus.FillWeight = 30F;
            this.SignalSentStatus.HeaderText = "SignalSentStatus";
            this.SignalSentStatus.Name = "SignalSentStatus";
            this.SignalSentStatus.ReadOnly = true;
            // 
            // BrokerStatus
            // 
            this.BrokerStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrokerStatus.FillWeight = 30F;
            this.BrokerStatus.HeaderText = "BrokerStatus";
            this.BrokerStatus.Name = "BrokerStatus";
            this.BrokerStatus.ReadOnly = true;
            // 
            // SignalDB
            // 
            this.SignalDB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SignalDB.FillWeight = 30F;
            this.SignalDB.HeaderText = "SignalDB";
            this.SignalDB.Name = "SignalDB";
            this.SignalDB.ReadOnly = true;
            // 
            // FormOrderReceivedScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CaptionBarColor = System.Drawing.Color.Silver;
            this.CaptionButtonHoverColor = System.Drawing.Color.Black;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1523, 511);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormOrderReceivedScreen";
            this.ShowIcon = false;
            this.ShowMaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Order Received Screen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormOrderReceivedScreen_FormClosing);
            this.Load += new System.EventHandler(this.FormOrderReceivedScreen_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SignalDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SignalProgressBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView SignalDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceivedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignalSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrokerSent;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrokerType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Symbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignalDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignalType;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignalHash;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignalSentStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrokerStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignalDB;
        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv SignalProgressBar;
    }
}