namespace Prayer_Tracking_System
{
    partial class frmAdd
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
            this.components = new System.ComponentModel.Container();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.chkFajar = new System.Windows.Forms.CheckBox();
            this.chkZuhr = new System.Windows.Forms.CheckBox();
            this.chkAsar = new System.Windows.Forms.CheckBox();
            this.chkMaghrib = new System.Windows.Forms.CheckBox();
            this.chkIsha = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.pTS_dbDataSet = new Prayer_Tracking_System.PTS_dbDataSet();
            this.pTSdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pTS_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pTSdbDataSetBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(138, 76);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(276, 29);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Value = new System.DateTime(2024, 4, 29, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // chkFajar
            // 
            this.chkFajar.AutoSize = true;
            this.chkFajar.BackColor = System.Drawing.SystemColors.Control;
            this.chkFajar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkFajar.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.chkFajar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.chkFajar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.chkFajar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFajar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkFajar.Location = new System.Drawing.Point(100, 121);
            this.chkFajar.Margin = new System.Windows.Forms.Padding(2);
            this.chkFajar.Name = "chkFajar";
            this.chkFajar.Size = new System.Drawing.Size(71, 29);
            this.chkFajar.TabIndex = 1;
            this.chkFajar.Text = "Fajar";
            this.chkFajar.UseVisualStyleBackColor = false;
            // 
            // chkZuhr
            // 
            this.chkZuhr.AutoSize = true;
            this.chkZuhr.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkZuhr.Location = new System.Drawing.Point(100, 154);
            this.chkZuhr.Margin = new System.Windows.Forms.Padding(2);
            this.chkZuhr.Name = "chkZuhr";
            this.chkZuhr.Size = new System.Drawing.Size(71, 29);
            this.chkZuhr.TabIndex = 2;
            this.chkZuhr.Text = "Zuhr";
            this.chkZuhr.UseVisualStyleBackColor = true;
            // 
            // chkAsar
            // 
            this.chkAsar.AutoSize = true;
            this.chkAsar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAsar.Location = new System.Drawing.Point(100, 187);
            this.chkAsar.Margin = new System.Windows.Forms.Padding(2);
            this.chkAsar.Name = "chkAsar";
            this.chkAsar.Size = new System.Drawing.Size(68, 29);
            this.chkAsar.TabIndex = 3;
            this.chkAsar.Text = "Asar";
            this.chkAsar.UseVisualStyleBackColor = true;
            // 
            // chkMaghrib
            // 
            this.chkMaghrib.AutoSize = true;
            this.chkMaghrib.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMaghrib.Location = new System.Drawing.Point(100, 219);
            this.chkMaghrib.Margin = new System.Windows.Forms.Padding(2);
            this.chkMaghrib.Name = "chkMaghrib";
            this.chkMaghrib.Size = new System.Drawing.Size(103, 29);
            this.chkMaghrib.TabIndex = 4;
            this.chkMaghrib.Text = "Maghrib";
            this.chkMaghrib.UseVisualStyleBackColor = true;
            // 
            // chkIsha
            // 
            this.chkIsha.AutoSize = true;
            this.chkIsha.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsha.Location = new System.Drawing.Point(100, 252);
            this.chkIsha.Margin = new System.Windows.Forms.Padding(2);
            this.chkIsha.Name = "chkIsha";
            this.chkIsha.Size = new System.Drawing.Size(65, 29);
            this.chkIsha.TabIndex = 5;
            this.chkIsha.Text = "Isha";
            this.chkIsha.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(189)))), ((int)(((byte)(245)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(85, 11);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 31);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pTS_dbDataSet
            // 
            this.pTS_dbDataSet.DataSetName = "PTS_dbDataSet";
            this.pTS_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pTSdbDataSetBindingSource
            // 
            this.pTSdbDataSetBindingSource.DataSource = this.pTS_dbDataSet;
            this.pTSdbDataSetBindingSource.Position = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(166)))), ((int)(((byte)(133)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 56);
            this.panel1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(32, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Update Module";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(547, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(166)))), ((int)(((byte)(133)))));
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 299);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 67);
            this.panel2.TabIndex = 8;
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chkIsha);
            this.Controls.Add(this.chkMaghrib);
            this.Controls.Add(this.chkAsar);
            this.Controls.Add(this.chkZuhr);
            this.Controls.Add(this.chkFajar);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAdd";
            this.Text = "frmAdd";
            this.Load += new System.EventHandler(this.frmAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pTS_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pTSdbDataSetBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox chkFajar;
        private System.Windows.Forms.CheckBox chkZuhr;
        private System.Windows.Forms.CheckBox chkAsar;
        private System.Windows.Forms.CheckBox chkMaghrib;
        private System.Windows.Forms.CheckBox chkIsha;
        private System.Windows.Forms.Button btnSave;
        private PTS_dbDataSet pTS_dbDataSet;
        private System.Windows.Forms.BindingSource pTSdbDataSetBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
    }
}