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
            this.txt_Instruction = new System.Windows.Forms.TextBox();
            this.label_run_selected = new System.Windows.Forms.Label();
            this.btn_Run_Selected = new System.Windows.Forms.Button();
            this.label_stop = new System.Windows.Forms.Label();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_Run = new System.Windows.Forms.Button();
            this.label_run = new System.Windows.Forms.Label();
            this.dataGV = new System.Windows.Forms.DataGridView();
            this.Checkbox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bnt_import = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.checkClient = new System.Windows.Forms.CheckBox();
            this.btn_export = new System.Windows.Forms.Button();
            this.label_export = new System.Windows.Forms.Label();
            this.pick_protocol = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AddRow = new System.Windows.Forms.Button();
            this.partnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGV2 = new System.Windows.Forms.DataGridView();
            this.btn_lookForPorts = new System.Windows.Forms.Button();
            this.tab1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV2)).BeginInit();
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
            this.tabPage1.Controls.Add(this.txt_Instruction);
            this.tabPage1.Controls.Add(this.label_run_selected);
            this.tabPage1.Controls.Add(this.btn_Run_Selected);
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
            // txt_Instruction
            // 
            this.txt_Instruction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Instruction.Location = new System.Drawing.Point(66, 152);
            this.txt_Instruction.Multiline = true;
            this.txt_Instruction.Name = "txt_Instruction";
            this.txt_Instruction.Size = new System.Drawing.Size(451, 554);
            this.txt_Instruction.TabIndex = 11;
            this.txt_Instruction.Text = resources.GetString("txt_Instruction.Text");
            // 
            // label_run_selected
            // 
            this.label_run_selected.AutoSize = true;
            this.label_run_selected.Location = new System.Drawing.Point(8, 11);
            this.label_run_selected.Name = "label_run_selected";
            this.label_run_selected.Size = new System.Drawing.Size(159, 24);
            this.label_run_selected.TabIndex = 10;
            this.label_run_selected.Text = "RUN SELECTED:";
            // 
            // btn_Run_Selected
            // 
            this.btn_Run_Selected.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Run_Selected.BackgroundImage")));
            this.btn_Run_Selected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Run_Selected.Location = new System.Drawing.Point(173, 6);
            this.btn_Run_Selected.Name = "btn_Run_Selected";
            this.btn_Run_Selected.Size = new System.Drawing.Size(41, 36);
            this.btn_Run_Selected.TabIndex = 9;
            this.btn_Run_Selected.UseVisualStyleBackColor = true;
            this.btn_Run_Selected.Click += new System.EventHandler(this.btn_Run_Selected_Click);
            // 
            // label_stop
            // 
            this.label_stop.AutoSize = true;
            this.label_stop.Location = new System.Drawing.Point(420, 11);
            this.label_stop.Name = "label_stop";
            this.label_stop.Size = new System.Drawing.Size(66, 24);
            this.label_stop.TabIndex = 8;
            this.label_stop.Text = "STOP:";
            // 
            // btn_Stop
            // 
            this.btn_Stop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Stop.BackgroundImage")));
            this.btn_Stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Stop.Location = new System.Drawing.Point(492, 6);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(39, 34);
            this.btn_Stop.TabIndex = 7;
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_Run
            // 
            this.btn_Run.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Run.BackgroundImage")));
            this.btn_Run.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Run.Location = new System.Drawing.Point(319, 6);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(41, 36);
            this.btn_Run.TabIndex = 6;
            this.btn_Run.UseVisualStyleBackColor = true;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // label_run
            // 
            this.label_run.AutoSize = true;
            this.label_run.Location = new System.Drawing.Point(258, 11);
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
            this.Checkbox,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGV.Location = new System.Drawing.Point(12, 46);
            this.dataGV.Name = "dataGV";
            this.dataGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGV.Size = new System.Drawing.Size(554, 703);
            this.dataGV.TabIndex = 4;
            this.dataGV.Visible = false;
            // 
            // Checkbox
            // 
            this.Checkbox.Frozen = true;
            this.Checkbox.HeaderText = "";
            this.Checkbox.Name = "Checkbox";
            this.Checkbox.Width = 30;
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "IP-Address";
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
            // bnt_import
            // 
            this.bnt_import.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_import.Location = new System.Drawing.Point(16, 875);
            this.bnt_import.Name = "bnt_import";
            this.bnt_import.Size = new System.Drawing.Size(139, 34);
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
            this.btn_export.Location = new System.Drawing.Point(542, 26);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(40, 41);
            this.btn_export.TabIndex = 5;
            this.btn_export.UseVisualStyleBackColor = false;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // label_export
            // 
            this.label_export.AutoSize = true;
            this.label_export.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_export.Location = new System.Drawing.Point(391, 32);
            this.label_export.Name = "label_export";
            this.label_export.Size = new System.Drawing.Size(145, 24);
            this.label_export.TabIndex = 6;
            this.label_export.Text = "EXPORT DATA";
            // 
            // pick_protocol
            // 
            this.pick_protocol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pick_protocol.FormattingEnabled = true;
            this.pick_protocol.Items.AddRange(new object[] {
            "tcp",
            "udp"});
            this.pick_protocol.Location = new System.Drawing.Point(474, 879);
            this.pick_protocol.Name = "pick_protocol";
            this.pick_protocol.Size = new System.Drawing.Size(123, 28);
            this.pick_protocol.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 882);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "PROTOCOL:";
            // 
            // btn_AddRow
            // 
            this.btn_AddRow.BackColor = System.Drawing.Color.Transparent;
            this.btn_AddRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddRow.Location = new System.Drawing.Point(189, 876);
            this.btn_AddRow.Name = "btn_AddRow";
            this.btn_AddRow.Size = new System.Drawing.Size(154, 34);
            this.btn_AddRow.TabIndex = 12;
            this.btn_AddRow.Text = "Add Row";
            this.btn_AddRow.UseVisualStyleBackColor = false;
            this.btn_AddRow.Click += new System.EventHandler(this.btn_AddRow_Click);
            // 
            // partnerBindingSource
            // 
            this.partnerBindingSource.DataSource = typeof(TCP_UDP_Tool.Partner);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_lookForPorts);
            this.tabPage2.Controls.Add(this.dataGV2);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(577, 761);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Check for available Ports";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGV2
            // 
            this.dataGV2.AllowUserToAddRows = false;
            this.dataGV2.AllowUserToDeleteRows = false;
            this.dataGV2.BackgroundColor = System.Drawing.Color.White;
            this.dataGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV2.Location = new System.Drawing.Point(6, 66);
            this.dataGV2.Name = "dataGV2";
            this.dataGV2.ReadOnly = true;
            this.dataGV2.Size = new System.Drawing.Size(565, 692);
            this.dataGV2.TabIndex = 0;
            // 
            // btn_lookForPorts
            // 
            this.btn_lookForPorts.Location = new System.Drawing.Point(357, 17);
            this.btn_lookForPorts.Name = "btn_lookForPorts";
            this.btn_lookForPorts.Size = new System.Drawing.Size(214, 43);
            this.btn_lookForPorts.TabIndex = 1;
            this.btn_lookForPorts.Text = "Start looking for Ports";
            this.btn_lookForPorts.UseVisualStyleBackColor = true;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(609, 925);
            this.Controls.Add(this.btn_AddRow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pick_protocol);
            this.Controls.Add(this.label_export);
            this.Controls.Add(this.bnt_import);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.checkClient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tab1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(625, 964);
            this.MinimumSize = new System.Drawing.Size(625, 964);
            this.Name = "GUI";
            this.Text = "TCP/UDP-Testtool";
            this.tab1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab1;
        private System.Windows.Forms.TabPage tabPage1;
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
        private System.Windows.Forms.ComboBox pick_protocol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_stop;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Checkbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label_run_selected;
        private System.Windows.Forms.Button btn_Run_Selected;
        private System.Windows.Forms.TextBox txt_Instruction;
        private System.Windows.Forms.Button btn_AddRow;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_lookForPorts;
        private System.Windows.Forms.DataGridView dataGV2;
    }
}

