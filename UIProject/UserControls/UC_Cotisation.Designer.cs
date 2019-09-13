namespace UIProject.UserControls
{
    partial class UC_Cotisation
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.nouveauBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.membreCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.montantTxt = new System.Windows.Forms.TextBox();
            this.dateCotTxt = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fraisCombo = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.dgInscit = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomComp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgManyCotisation = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastLbl = new System.Windows.Forms.Label();
            this.situationLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.weekLbl = new System.Windows.Forms.Label();
            this.weeksCombo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.fraisLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInscit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgManyCotisation)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(497, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cotisation journalière";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.nouveauBtn);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1177, 61);
            this.panel1.TabIndex = 36;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(994, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(170, 35);
            this.button4.TabIndex = 5;
            this.button4.Text = "Autres détails";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(250, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 35);
            this.button3.TabIndex = 4;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(77, 12);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(170, 35);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.Button2_Click);
            // 
            // nouveauBtn
            // 
            this.nouveauBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.nouveauBtn.FlatAppearance.BorderSize = 0;
            this.nouveauBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nouveauBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nouveauBtn.ForeColor = System.Drawing.Color.White;
            this.nouveauBtn.Location = new System.Drawing.Point(24, 12);
            this.nouveauBtn.Name = "nouveauBtn";
            this.nouveauBtn.Size = new System.Drawing.Size(47, 35);
            this.nouveauBtn.TabIndex = 2;
            this.nouveauBtn.Text = "+";
            this.nouveauBtn.UseVisualStyleBackColor = false;
            this.nouveauBtn.Click += new System.EventHandler(this.NouveauBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1177, 10);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1177, 10);
            this.panel2.TabIndex = 0;
            // 
            // membreCombo
            // 
            this.membreCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.membreCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.membreCombo.FormattingEnabled = true;
            this.membreCombo.Location = new System.Drawing.Point(158, 192);
            this.membreCombo.Name = "membreCombo";
            this.membreCombo.Size = new System.Drawing.Size(329, 29);
            this.membreCombo.TabIndex = 48;
            this.membreCombo.SelectedIndexChanged += new System.EventHandler(this.MembreCombo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 19);
            this.label4.TabIndex = 49;
            this.label4.Text = "Identité membre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 50;
            this.label1.Text = "Cotisation du ";
            // 
            // montantTxt
            // 
            this.montantTxt.Location = new System.Drawing.Point(158, 260);
            this.montantTxt.Name = "montantTxt";
            this.montantTxt.Size = new System.Drawing.Size(137, 27);
            this.montantTxt.TabIndex = 51;
            // 
            // dateCotTxt
            // 
            this.dateCotTxt.Location = new System.Drawing.Point(158, 227);
            this.dateCotTxt.Mask = "00/00/0000";
            this.dateCotTxt.Name = "dateCotTxt";
            this.dateCotTxt.Size = new System.Drawing.Size(273, 27);
            this.dateCotTxt.TabIndex = 52;
            this.dateCotTxt.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 53;
            this.label2.Text = "Montant";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(301, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 19);
            this.label5.TabIndex = 55;
            this.label5.Text = "Frais";
            // 
            // fraisCombo
            // 
            this.fraisCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.fraisCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.fraisCombo.FormattingEnabled = true;
            this.fraisCombo.Location = new System.Drawing.Point(350, 260);
            this.fraisCombo.Name = "fraisCombo";
            this.fraisCombo.Size = new System.Drawing.Size(137, 29);
            this.fraisCombo.TabIndex = 57;
            this.fraisCombo.SelectedIndexChanged += new System.EventHandler(this.FraisCombo_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(18, 161);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(406, 25);
            this.checkBox1.TabIndex = 58;
            this.checkBox1.Text = "Enregistrer plusieurs cotisation pour ce membre ?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(236, 330);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(170, 35);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Ajouter";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Visible = false;
            this.addBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // dgInscit
            // 
            this.dgInscit.AllowUserToAddRows = false;
            this.dgInscit.AllowUserToDeleteRows = false;
            this.dgInscit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgInscit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgInscit.BackgroundColor = System.Drawing.Color.White;
            this.dgInscit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgInscit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgInscit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInscit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column11,
            this.Column2,
            this.idM,
            this.Column4,
            this.NomComp,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgInscit.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgInscit.Location = new System.Drawing.Point(18, 387);
            this.dgInscit.Name = "dgInscit";
            this.dgInscit.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgInscit.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgInscit.RowHeadersVisible = false;
            this.dgInscit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgInscit.Size = new System.Drawing.Size(1146, 231);
            this.dgInscit.TabIndex = 59;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Numéro";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "UserSession";
            this.Column11.HeaderText = "UserSession";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DateInscrit";
            this.Column2.HeaderText = "Date d\'inscription";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // idM
            // 
            this.idM.DataPropertyName = "RefMembre";
            this.idM.HeaderText = "IdMembre";
            this.idM.Name = "idM";
            this.idM.ReadOnly = true;
            this.idM.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Matricule";
            this.Column4.HeaderText = "Matricule";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // NomComp
            // 
            this.NomComp.DataPropertyName = "NomComplet";
            this.NomComp.HeaderText = "Nom Complet";
            this.NomComp.Name = "NomComp";
            this.NomComp.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Nom";
            this.Column5.HeaderText = "Nom";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Postnom";
            this.Column6.HeaderText = "Postnom";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Prenom";
            this.Column7.HeaderText = "Prénom";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Sexe";
            this.Column8.HeaderText = "Sexe";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "RefRound";
            this.Column9.HeaderText = "IdRound";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Designation";
            this.Column10.HeaderText = "Round";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            // 
            // dgManyCotisation
            // 
            this.dgManyCotisation.AllowUserToAddRows = false;
            this.dgManyCotisation.AllowUserToDeleteRows = false;
            this.dgManyCotisation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgManyCotisation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgManyCotisation.BackgroundColor = System.Drawing.Color.White;
            this.dgManyCotisation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgManyCotisation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgManyCotisation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgManyCotisation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column3,
            this.Column12});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgManyCotisation.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgManyCotisation.Location = new System.Drawing.Point(810, 133);
            this.dgManyCotisation.Name = "dgManyCotisation";
            this.dgManyCotisation.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgManyCotisation.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgManyCotisation.RowHeadersVisible = false;
            this.dgManyCotisation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgManyCotisation.Size = new System.Drawing.Size(354, 232);
            this.dgManyCotisation.TabIndex = 60;
            this.dgManyCotisation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgManyCotisation_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Numéro";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Date";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Montant";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // lastLbl
            // 
            this.lastLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastLbl.Location = new System.Drawing.Point(571, 215);
            this.lastLbl.Name = "lastLbl";
            this.lastLbl.Size = new System.Drawing.Size(189, 19);
            this.lastLbl.TabIndex = 61;
            this.lastLbl.Text = "Dernière contribution";
            this.lastLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // situationLbl
            // 
            this.situationLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.situationLbl.Location = new System.Drawing.Point(621, 324);
            this.situationLbl.Name = "situationLbl";
            this.situationLbl.Size = new System.Drawing.Size(74, 19);
            this.situationLbl.TabIndex = 62;
            this.situationLbl.Text = "Situation";
            this.situationLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(623, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 19);
            this.label8.TabIndex = 63;
            this.label8.Text = "Laste";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(603, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 19);
            this.label9.TabIndex = 64;
            this.label9.Text = "Observation";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(439, 161);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(248, 25);
            this.checkBox2.TabIndex = 65;
            this.checkBox2.Text = "Réglement dettes LastWeek";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // weekLbl
            // 
            this.weekLbl.AutoSize = true;
            this.weekLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekLbl.Location = new System.Drawing.Point(94, 299);
            this.weekLbl.Name = "weekLbl";
            this.weekLbl.Size = new System.Drawing.Size(58, 19);
            this.weekLbl.TabIndex = 66;
            this.weekLbl.Text = "Weeks";
            this.weekLbl.Visible = false;
            // 
            // weeksCombo
            // 
            this.weeksCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.weeksCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.weeksCombo.FormattingEnabled = true;
            this.weeksCombo.Location = new System.Drawing.Point(158, 295);
            this.weeksCombo.Name = "weeksCombo";
            this.weeksCombo.Size = new System.Drawing.Size(329, 29);
            this.weeksCombo.TabIndex = 67;
            this.weeksCombo.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(603, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 19);
            this.label10.TabIndex = 69;
            this.label10.Text = "Type de Frais";
            // 
            // fraisLbl
            // 
            this.fraisLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fraisLbl.Location = new System.Drawing.Point(517, 271);
            this.fraisLbl.Name = "fraisLbl";
            this.fraisLbl.Size = new System.Drawing.Size(258, 19);
            this.fraisLbl.TabIndex = 68;
            this.fraisLbl.Text = "frais";
            this.fraisLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UC_Cotisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.fraisLbl);
            this.Controls.Add(this.weeksCombo);
            this.Controls.Add(this.weekLbl);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.situationLbl);
            this.Controls.Add(this.lastLbl);
            this.Controls.Add(this.dgManyCotisation);
            this.Controls.Add(this.dgInscit);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.fraisCombo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateCotTxt);
            this.Controls.Add(this.montantTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.membreCombo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UC_Cotisation";
            this.Size = new System.Drawing.Size(1177, 663);
            this.Load += new System.EventHandler(this.UC_Cotisation_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgInscit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgManyCotisation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button nouveauBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox membreCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox montantTxt;
        private System.Windows.Forms.MaskedTextBox dateCotTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox fraisCombo;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView dgInscit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomComp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridView dgManyCotisation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.Label lastLbl;
        private System.Windows.Forms.Label situationLbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label weekLbl;
        private System.Windows.Forms.ComboBox weeksCombo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label fraisLbl;
    }
}
