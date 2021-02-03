namespace BrowserSelect
{
    partial class frm_settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_settings));
            this.btn_setdefault = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.dgvBrowsers = new System.Windows.Forms.DataGridView();
            this.colEnabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colBrowser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrder = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_apply = new System.Windows.Forms.Button();
            this.gv_filters = new System.Windows.Forms.DataGridView();
            this.pattern = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.browser = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chk_check_update = new System.Windows.Forms.CheckBox();
            this.btn_check_update = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrowsers)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_filters)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_setdefault
            // 
            this.btn_setdefault.Location = new System.Drawing.Point(7, 113);
            this.btn_setdefault.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_setdefault.Name = "btn_setdefault";
            this.btn_setdefault.Size = new System.Drawing.Size(260, 48);
            this.btn_setdefault.TabIndex = 0;
            this.btn_setdefault.Text = "Set as Default Browser";
            this.btn_setdefault.UseVisualStyleBackColor = true;
            this.btn_setdefault.Click += new System.EventHandler(this.btn_setdefault_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 115);
            this.label1.TabIndex = 1;
            this.label1.Text = "BrowserSelect must be set as default browser for it to function correctly. this b" +
    "utton will set it as the default browser.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btn_refresh);
            this.groupBox1.Controls.Add(this.dgvBrowsers);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(489, 630);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Browsers";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(362, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 29);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(235, 0);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(120, 29);
            this.btn_refresh.TabIndex = 2;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // dgvBrowsers
            // 
            this.dgvBrowsers.AllowUserToAddRows = false;
            this.dgvBrowsers.AllowUserToDeleteRows = false;
            this.dgvBrowsers.AllowUserToResizeColumns = false;
            this.dgvBrowsers.AllowUserToResizeRows = false;
            this.dgvBrowsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBrowsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBrowsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEnabled,
            this.colBrowser,
            this.colOrder});
            this.dgvBrowsers.Location = new System.Drawing.Point(7, 35);
            this.dgvBrowsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvBrowsers.Name = "dgvBrowsers";
            this.dgvBrowsers.RowHeadersVisible = false;
            this.dgvBrowsers.RowHeadersWidth = 62;
            this.dgvBrowsers.RowTemplate.Height = 28;
            this.dgvBrowsers.Size = new System.Drawing.Size(475, 587);
            this.dgvBrowsers.TabIndex = 7;
            // 
            // colEnabled
            // 
            this.colEnabled.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colEnabled.DataPropertyName = "IsEnabled";
            this.colEnabled.FalseValue = "false";
            this.colEnabled.HeaderText = "Enabled";
            this.colEnabled.IndeterminateValue = "null";
            this.colEnabled.MinimumWidth = 8;
            this.colEnabled.Name = "colEnabled";
            this.colEnabled.TrueValue = "true";
            this.colEnabled.Width = 74;
            // 
            // colBrowser
            // 
            this.colBrowser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBrowser.DataPropertyName = "Name";
            this.colBrowser.HeaderText = "Browser";
            this.colBrowser.MinimumWidth = 8;
            this.colBrowser.Name = "colBrowser";
            this.colBrowser.ReadOnly = true;
            // 
            // colOrder
            // 
            this.colOrder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colOrder.DataPropertyName = "Order";
            this.colOrder.HeaderText = "Order";
            this.colOrder.MinimumWidth = 8;
            this.colOrder.Name = "colOrder";
            this.colOrder.Width = 55;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_setdefault);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(18, 652);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(275, 170);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Default Browser";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btn_cancel);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.linkLabel1);
            this.groupBox3.Controls.Add(this.btn_apply);
            this.groupBox3.Controls.Add(this.gv_filters);
            this.groupBox3.Location = new System.Drawing.Point(515, 18);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(520, 804);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Auto Select Filters";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(277, 759);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(112, 35);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "Close";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(9, 759);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Help";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(212, 235);
            this.linkLabel1.Location = new System.Drawing.Point(4, 24);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(512, 76);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = resources.GetString("linkLabel1.Text");
            this.linkLabel1.UseCompatibleTextRendering = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btn_apply
            // 
            this.btn_apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_apply.Enabled = false;
            this.btn_apply.Location = new System.Drawing.Point(398, 759);
            this.btn_apply.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(112, 35);
            this.btn_apply.TabIndex = 5;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // gv_filters
            // 
            this.gv_filters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gv_filters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_filters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pattern,
            this.browser});
            this.gv_filters.Location = new System.Drawing.Point(9, 105);
            this.gv_filters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gv_filters.Name = "gv_filters";
            this.gv_filters.RowHeadersWidth = 62;
            this.gv_filters.Size = new System.Drawing.Size(502, 645);
            this.gv_filters.TabIndex = 1;
            this.gv_filters.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.gv_filters_CellBeginEdit);
            this.gv_filters.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.gv_filters_DataError);
            this.gv_filters.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.gv_filters_CellBeginEdit);
            this.gv_filters.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.gv_filters_CellBeginEdit);
            // 
            // pattern
            // 
            this.pattern.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pattern.DataPropertyName = "Pattern";
            this.pattern.HeaderText = "Pattern";
            this.pattern.MinimumWidth = 8;
            this.pattern.Name = "pattern";
            this.pattern.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // browser
            // 
            this.browser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.browser.DataPropertyName = "Browser";
            this.browser.HeaderText = "Browser";
            this.browser.MinimumWidth = 8;
            this.browser.Name = "browser";
            this.browser.Width = 73;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chk_check_update);
            this.groupBox4.Controls.Add(this.btn_check_update);
            this.groupBox4.Location = new System.Drawing.Point(301, 652);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(206, 170);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Update checker";
            // 
            // chk_check_update
            // 
            this.chk_check_update.AutoSize = true;
            this.chk_check_update.Location = new System.Drawing.Point(47, 49);
            this.chk_check_update.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_check_update.Name = "chk_check_update";
            this.chk_check_update.Size = new System.Drawing.Size(85, 24);
            this.chk_check_update.TabIndex = 1;
            this.chk_check_update.Text = "Enable";
            this.chk_check_update.UseVisualStyleBackColor = true;
            this.chk_check_update.CheckedChanged += new System.EventHandler(this.chk_check_update_CheckedChanged);
            // 
            // btn_check_update
            // 
            this.btn_check_update.Location = new System.Drawing.Point(8, 113);
            this.btn_check_update.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_check_update.Name = "btn_check_update";
            this.btn_check_update.Size = new System.Drawing.Size(190, 48);
            this.btn_check_update.TabIndex = 0;
            this.btn_check_update.Text = "check now";
            this.btn_check_update.UseVisualStyleBackColor = true;
            this.btn_check_update.Click += new System.EventHandler(this.btn_check_update_Click);
            // 
            // frm_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(1053, 833);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(526, 607);
            this.Name = "frm_settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_settings_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_settings_FormClosed);
            this.Load += new System.EventHandler(this.frm_settings_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrowsers)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_filters)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_setdefault;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gv_filters;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.DataGridViewTextBoxColumn pattern;
        private System.Windows.Forms.DataGridViewComboBoxColumn browser;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chk_check_update;
        private System.Windows.Forms.Button btn_check_update;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.DataGridView dgvBrowsers;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colEnabled;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBrowser;
        private System.Windows.Forms.DataGridViewComboBoxColumn colOrder;
    }
}