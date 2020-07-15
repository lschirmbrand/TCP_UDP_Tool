namespace TCP_UDP_Tool
{
    partial class GUI
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.tab1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_Run = new System.Windows.Forms.Button();
            this.label_run = new System.Windows.Forms.Label();
            this.dataGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bnt_import = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.checkClient = new System.Windows.Forms.CheckBox();
            this.btn_export = new System.Windows.Forms.Button();
            this.label_export = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.label_stop = new System.Windows.Forms.Label();
            this.partnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tab1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.tabPage1);
            this.tab1.Controls.Add(this.tabPage2);
            this.tab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab1.Location = new System.Drawing.Point(12, 71);
            this.tab1.Name = "tab1";
            this.tab1.SelectedIndex = 0;
            this.tab1.Size = new System.Drawing.Size(585, 798);
            this.tab1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label_stop);
            this.tabPage1.Controls.Add(this.btn_Stop);
            this.tabPage1.Controls.Add(this.btn_Run);
            this.tabPage1.Controls.Add(this.label_run);
            this.tabPage1.Controls.Add(this.dataGV);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(577, 761);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Automatischer Mode";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_Run
            // 
            this.btn_Run.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Run.BackgroundImage")));
            this.btn_Run.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Run.Location = new System.Drawing.Point(524, 6);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(41, 36);
            this.btn_Run.TabIndex = 6;
            this.btn_Run.UseVisualStyleBackColor = true;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // label_run
            // 
            this.label_run.AutoSize = true;
            this.label_run.Location = new System.Drawing.Point(463, 12);
            this.label_run.Name = "label_run";
            this.label_run.Size = new System.Drawing.Size(55, 24);
            this.label_run.TabIndex = 5;
            this.label_run.Text = "RUN:";
            // 
            // dataGV
            // 
            this.dataGV.AllowUserToOrderColumns = true;
            this.dataGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGV.Location = new System.Drawing.Point(11, 48);
            this.dataGV.Name = "dataGV";
            this.dataGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGV.Size = new System.Drawing.Size(554, 703);
            this.dataGV.TabIndex = 4;
            this.dataGV.Visible = false;
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "IP-Adress";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Ports";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Width = 155;
            // 
            // Column3
            // 
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Status";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.Width = 200;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(577, 761);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manueller Mode";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bnt_import
            // 
            this.bnt_import.Location = new System.Drawing.Point(16, 879);
            this.bnt_import.Name = "bnt_import";
            this.bnt_import.Size = new System.Drawing.Size(216, 34);
            this.bnt_import.TabIndex = 3;
            this.bnt_import.Text = "Import Filedtata";
            this.bnt_import.UseVisualStyleBackColor = true;
            this.bnt_import.Click += new System.EventHandler(this.bnt_import_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "CLIENTMODE";
            // 
            // checkClient
            // 
            this.checkClient.AutoSize = true;
            this.checkClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkClient.Location = new System.Drawing.Point(151, 38);
            this.checkClient.Name = "checkClient";
            this.checkClient.Size = new System.Drawing.Size(15, 14);
            this.checkClient.TabIndex = 5;
            this.checkClient.UseVisualStyleBackColor = true;
            // 
            // btn_export
            // 
            this.btn_export.BackColor = System.Drawing.Color.Transparent;
            this.btn_export.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_export.BackgroundImage")));
            this.btn_export.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_export.ForeColor = System.Drawing.Color.Black;
            this.btn_export.Location = new System.Drawing.Point(463, 26);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(40, 41);
            this.btn_export.TabIndex = 5;
            this.btn_export.UseVisualStyleBackColor = false;
            // 
            // label_export
            // 
            this.label_export.AutoSize = true;
            this.label_export.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_export.Location = new System.Drawing.Point(312, 32);
            this.label_export.Name = "label_export";
            this.label_export.Size = new System.Drawing.Size(145, 24);
            this.label_export.TabIndex = 6;
            this.label_export.Text = "EXPORT DATA";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "tcp",
            "udp"});
            this.comboBox1.Location = new System.Drawing.Point(427, 879);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 880);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "PROTOKOLL:";
            // 
            // btn_Stop
            // 
            this.btn_Stop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Stop.BackgroundImage")));
            this.btn_Stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Stop.Location = new System.Drawing.Point(526, 6);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(39, 34);
            this.btn_Stop.TabIndex = 7;
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // label_stop
            // 
            this.label_stop.AutoSize = true;
            this.label_stop.Location = new System.Drawing.Point(452, 12);
            this.label_stop.Name = "label_stop";
            this.label_stop.Size = new System.Drawing.Size(66, 24);
            this.label_stop.TabIndex = 8;
            this.label_stop.Text = "STOP:";
            this.label_stop.Click += new System.EventHandler(this.label_stop_Click);
            // 
            // partnerBindingSource
            // 
            this.partnerBindingSource.DataSource = typeof(TCP_UDP_Tool.Partner);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(609, 925);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label_export);
            this.Controls.Add(this.bnt_import);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.checkClient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tab1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(625, 964);
            this.MinimumSize = new System.Drawing.Size(625, 964);
            this.Name = "GUI";
            this.Text = "Form1";
            this.tab1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bnt_import;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkClient;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Label label_export;
        private System.Windows.Forms.DataGridView dataGV;
        private System.Windows.Forms.BindingSource partnerBindingSource;
        private System.Windows.Forms.Button btn_Run;
        private System.Windows.Forms.Label label_run;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label_stop;
        private System.Windows.Forms.Button btn_Stop;
    }
}

