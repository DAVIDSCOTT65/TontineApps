namespace UIProject.Forms
{
    partial class FrmEnvoieSMS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnconnect = new System.Windows.Forms.Button();
            this.label_statut = new System.Windows.Forms.Label();
            this.portnumber = new System.Windows.Forms.Label();
            this.cboTimeout = new System.Windows.Forms.Label();
            this.cboBaudRate = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.cboPort = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgSms = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.reseauPic = new System.Windows.Forms.PictureBox();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSms)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reseauPic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 10);
            this.panel1.TabIndex = 50;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 688);
            this.panel4.TabIndex = 54;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(758, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 688);
            this.panel3.TabIndex = 53;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(10, 688);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(748, 10);
            this.panel2.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(272, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(427, 23);
            this.label3.TabIndex = 56;
            this.label3.Text = "Bienvenue dans la partie de transmission SMS";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.btnconnect);
            this.panel5.Controls.Add(this.label_statut);
            this.panel5.Controls.Add(this.portnumber);
            this.panel5.Controls.Add(this.cboTimeout);
            this.panel5.Controls.Add(this.cboBaudRate);
            this.panel5.Controls.Add(this.label26);
            this.panel5.Controls.Add(this.cboPort);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(10, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(249, 678);
            this.panel5.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 83);
            this.label5.TabIndex = 31;
            this.label5.Text = "Selectionner votre modem dans la liste ci-dessous :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(17, 598);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 30;
            this.label1.Text = "Status :";
            // 
            // btnconnect
            // 
            this.btnconnect.BackColor = System.Drawing.Color.SeaGreen;
            this.btnconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconnect.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnconnect.ForeColor = System.Drawing.Color.White;
            this.btnconnect.Location = new System.Drawing.Point(44, 263);
            this.btnconnect.Name = "btnconnect";
            this.btnconnect.Size = new System.Drawing.Size(142, 33);
            this.btnconnect.TabIndex = 29;
            this.btnconnect.Text = "Connecter";
            this.btnconnect.UseVisualStyleBackColor = false;
            this.btnconnect.Click += new System.EventHandler(this.btnconnect_Click);
            // 
            // label_statut
            // 
            this.label_statut.AutoSize = true;
            this.label_statut.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label_statut.ForeColor = System.Drawing.Color.Red;
            this.label_statut.Location = new System.Drawing.Point(95, 598);
            this.label_statut.Name = "label_statut";
            this.label_statut.Size = new System.Drawing.Size(109, 21);
            this.label_statut.TabIndex = 28;
            this.label_statut.Text = "Deconnecté";
            // 
            // portnumber
            // 
            this.portnumber.AutoSize = true;
            this.portnumber.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.portnumber.Location = new System.Drawing.Point(17, 519);
            this.portnumber.Name = "portnumber";
            this.portnumber.Size = new System.Drawing.Size(28, 21);
            this.portnumber.TabIndex = 27;
            this.portnumber.Text = "19";
            this.portnumber.Visible = false;
            // 
            // cboTimeout
            // 
            this.cboTimeout.AutoSize = true;
            this.cboTimeout.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cboTimeout.Location = new System.Drawing.Point(17, 489);
            this.cboTimeout.Name = "cboTimeout";
            this.cboTimeout.Size = new System.Drawing.Size(37, 21);
            this.cboTimeout.TabIndex = 26;
            this.cboTimeout.Text = "600";
            this.cboTimeout.Visible = false;
            // 
            // cboBaudRate
            // 
            this.cboBaudRate.AutoSize = true;
            this.cboBaudRate.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cboBaudRate.Location = new System.Drawing.Point(17, 468);
            this.cboBaudRate.Name = "cboBaudRate";
            this.cboBaudRate.Size = new System.Drawing.Size(46, 21);
            this.cboBaudRate.TabIndex = 25;
            this.cboBaudRate.Text = "9600";
            this.cboBaudRate.Visible = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(-2, 204);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(71, 21);
            this.label26.TabIndex = 24;
            this.label26.Text = "Modem";
            // 
            // cboPort
            // 
            this.cboPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPort.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cboPort.FormattingEnabled = true;
            this.cboPort.Location = new System.Drawing.Point(2, 228);
            this.cboPort.Name = "cboPort";
            this.cboPort.Size = new System.Drawing.Size(242, 29);
            this.cboPort.TabIndex = 23;
            this.cboPort.SelectedIndexChanged += new System.EventHandler(this.cboPort_SelectedIndexChanged);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.reseauPic);
            this.panel6.Controls.Add(this.dgSms);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(276, 54);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(476, 310);
            this.panel6.TabIndex = 58;
            // 
            // dgSms
            // 
            this.dgSms.AllowUserToAddRows = false;
            this.dgSms.AllowUserToDeleteRows = false;
            this.dgSms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgSms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSms.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgSms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgSms.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgSms.Location = new System.Drawing.Point(8, 32);
            this.dgSms.Name = "dgSms";
            this.dgSms.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSms.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgSms.RowHeadersVisible = false;
            this.dgSms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSms.Size = new System.Drawing.Size(459, 262);
            this.dgSms.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.ForeColor = System.Drawing.Color.SeaGreen;
            this.label4.Location = new System.Drawing.Point(8, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 21);
            this.label4.TabIndex = 32;
            this.label4.Text = "Messages to send";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.txtOutput);
            this.panel7.Location = new System.Drawing.Point(276, 406);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(476, 271);
            this.panel7.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(8, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 31;
            this.label2.Text = "Output";
            // 
            // txtOutput
            // 
            this.txtOutput.Enabled = false;
            this.txtOutput.Location = new System.Drawing.Point(12, 30);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(455, 229);
            this.txtOutput.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(368, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 33);
            this.button1.TabIndex = 31;
            this.button1.Text = "Demarer l\'envoie";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Red;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(713, 10);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(45, 38);
            this.button8.TabIndex = 60;
            this.button8.Text = "X";
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // reseauPic
            // 
            this.reseauPic.Image = global::UIProject.Properties.Resources.Medium_Connection_50px;
            this.reseauPic.Location = new System.Drawing.Point(415, 2);
            this.reseauPic.Name = "reseauPic";
            this.reseauPic.Size = new System.Drawing.Size(56, 27);
            this.reseauPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.reseauPic.TabIndex = 41;
            this.reseauPic.TabStop = false;
            this.reseauPic.Visible = false;
            // 
            // FrmEnvoieSMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(768, 698);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEnvoieSMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEnvoieSMS";
            this.Load += new System.EventHandler(this.FrmEnvoieSMS_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSms)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reseauPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnconnect;
        private System.Windows.Forms.Label label_statut;
        private System.Windows.Forms.Label portnumber;
        private System.Windows.Forms.Label cboTimeout;
        private System.Windows.Forms.Label cboBaudRate;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox cboPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgSms;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox reseauPic;
    }
}