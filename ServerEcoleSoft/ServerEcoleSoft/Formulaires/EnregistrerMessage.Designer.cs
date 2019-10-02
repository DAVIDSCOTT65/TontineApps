namespace ServerEcoleSoft.Formulaires
{
    partial class EnregistrerMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnregistrerMessage));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GridMessagerie = new System.Windows.Forms.DataGridView();
            this.radio_choix = new System.Windows.Forms.RadioButton();
            this.radio_tous = new System.Windows.Forms.RadioButton();
            this.label122 = new System.Windows.Forms.Label();
            this.MStexte = new System.Windows.Forms.TextBox();
            this.txtSendTimes = new System.Windows.Forms.TextBox();
            this.label120 = new System.Windows.Forms.Label();
            this.chkMultipleTimes = new System.Windows.Forms.CheckBox();
            this.Numtext = new System.Windows.Forms.TextBox();
            this.chkUnicode = new System.Windows.Forms.CheckBox();
            this.label121 = new System.Windows.Forms.Label();
            this.chkAlert = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.GridMessagerie)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(183, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 23);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Recherche :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GridMessagerie
            // 
            this.GridMessagerie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridMessagerie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridMessagerie.Location = new System.Drawing.Point(27, 86);
            this.GridMessagerie.Name = "GridMessagerie";
            this.GridMessagerie.Size = new System.Drawing.Size(371, 402);
            this.GridMessagerie.TabIndex = 8;
            this.GridMessagerie.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridMessagerie_CellClick);
            // 
            // radio_choix
            // 
            this.radio_choix.AutoSize = true;
            this.radio_choix.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.radio_choix.Location = new System.Drawing.Point(561, 20);
            this.radio_choix.Name = "radio_choix";
            this.radio_choix.Size = new System.Drawing.Size(72, 19);
            this.radio_choix.TabIndex = 33;
            this.radio_choix.TabStop = true;
            this.radio_choix.Text = "CHOISIR";
            this.radio_choix.UseVisualStyleBackColor = true;
            // 
            // radio_tous
            // 
            this.radio_tous.AutoSize = true;
            this.radio_tous.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.radio_tous.Location = new System.Drawing.Point(454, 22);
            this.radio_tous.Name = "radio_tous";
            this.radio_tous.Size = new System.Drawing.Size(57, 19);
            this.radio_tous.TabIndex = 32;
            this.radio_tous.TabStop = true;
            this.radio_tous.Text = "TOUS";
            this.radio_tous.UseVisualStyleBackColor = true;
            // 
            // label122
            // 
            this.label122.AutoSize = true;
            this.label122.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label122.Location = new System.Drawing.Point(628, 175);
            this.label122.Name = "label122";
            this.label122.Size = new System.Drawing.Size(42, 15);
            this.label122.TabIndex = 31;
            this.label122.Text = "Times";
            // 
            // MStexte
            // 
            this.MStexte.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.MStexte.Location = new System.Drawing.Point(450, 239);
            this.MStexte.Multiline = true;
            this.MStexte.Name = "MStexte";
            this.MStexte.Size = new System.Drawing.Size(372, 194);
            this.MStexte.TabIndex = 23;
            // 
            // txtSendTimes
            // 
            this.txtSendTimes.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.txtSendTimes.Location = new System.Drawing.Point(559, 173);
            this.txtSendTimes.Name = "txtSendTimes";
            this.txtSendTimes.Size = new System.Drawing.Size(63, 21);
            this.txtSendTimes.TabIndex = 30;
            this.txtSendTimes.Text = "1";
            // 
            // label120
            // 
            this.label120.AutoSize = true;
            this.label120.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label120.Location = new System.Drawing.Point(451, 220);
            this.label120.Name = "label120";
            this.label120.Size = new System.Drawing.Size(65, 15);
            this.label120.TabIndex = 24;
            this.label120.Text = "Message :";
            // 
            // chkMultipleTimes
            // 
            this.chkMultipleTimes.AutoSize = true;
            this.chkMultipleTimes.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.chkMultipleTimes.Location = new System.Drawing.Point(459, 176);
            this.chkMultipleTimes.Name = "chkMultipleTimes";
            this.chkMultipleTimes.Size = new System.Drawing.Size(71, 19);
            this.chkMultipleTimes.TabIndex = 29;
            this.chkMultipleTimes.Text = "Envoyer";
            this.chkMultipleTimes.UseVisualStyleBackColor = true;
            // 
            // Numtext
            // 
            this.Numtext.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Numtext.Location = new System.Drawing.Point(561, 72);
            this.Numtext.Name = "Numtext";
            this.Numtext.Size = new System.Drawing.Size(210, 21);
            this.Numtext.TabIndex = 25;
            // 
            // chkUnicode
            // 
            this.chkUnicode.AutoSize = true;
            this.chkUnicode.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.chkUnicode.Location = new System.Drawing.Point(459, 156);
            this.chkUnicode.Name = "chkUnicode";
            this.chkUnicode.Size = new System.Drawing.Size(109, 19);
            this.chkUnicode.TabIndex = 28;
            this.chkUnicode.Text = "check unicode";
            this.chkUnicode.UseVisualStyleBackColor = true;
            // 
            // label121
            // 
            this.label121.AutoSize = true;
            this.label121.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label121.Location = new System.Drawing.Point(452, 75);
            this.label121.Name = "label121";
            this.label121.Size = new System.Drawing.Size(103, 15);
            this.label121.TabIndex = 26;
            this.label121.Text = "Num Telephone : ";
            // 
            // chkAlert
            // 
            this.chkAlert.AutoSize = true;
            this.chkAlert.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.chkAlert.Location = new System.Drawing.Point(459, 133);
            this.chkAlert.Name = "chkAlert";
            this.chkAlert.Size = new System.Drawing.Size(60, 19);
            this.chkAlert.TabIndex = 27;
            this.chkAlert.Text = "Alerte";
            this.chkAlert.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(450, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 30);
            this.button1.TabIndex = 34;
            this.button1.Text = "Envoyé";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(96, 63);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(95, 17);
            this.radioButton1.TabIndex = 35;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Autres reseaux";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(27, 63);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(48, 17);
            this.radioButton2.TabIndex = 36;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Airtel";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // EnregistrerMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(864, 499);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radio_choix);
            this.Controls.Add(this.radio_tous);
            this.Controls.Add(this.label122);
            this.Controls.Add(this.MStexte);
            this.Controls.Add(this.txtSendTimes);
            this.Controls.Add(this.label120);
            this.Controls.Add(this.chkMultipleTimes);
            this.Controls.Add(this.Numtext);
            this.Controls.Add(this.chkUnicode);
            this.Controls.Add(this.label121);
            this.Controls.Add(this.chkAlert);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridMessagerie);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EnregistrerMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnregistrerMessage";
            this.Load += new System.EventHandler(this.EnregistrerMessage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridMessagerie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridMessagerie;
        private System.Windows.Forms.RadioButton radio_choix;
        private System.Windows.Forms.RadioButton radio_tous;
        private System.Windows.Forms.Label label122;
        private System.Windows.Forms.TextBox MStexte;
        private System.Windows.Forms.TextBox txtSendTimes;
        private System.Windows.Forms.Label label120;
        private System.Windows.Forms.CheckBox chkMultipleTimes;
        private System.Windows.Forms.TextBox Numtext;
        private System.Windows.Forms.CheckBox chkUnicode;
        private System.Windows.Forms.Label label121;
        private System.Windows.Forms.CheckBox chkAlert;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}