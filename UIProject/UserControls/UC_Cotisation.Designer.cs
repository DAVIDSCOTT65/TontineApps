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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Cotisation));
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.nouveauBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgCotisation = new System.Windows.Forms.DataGridView();
            this.ColNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIdcot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDateCo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDateCon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMontant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRefInscrit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRefRound = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMatricule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPostnom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFrais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serchTxt = new System.Windows.Forms.TextBox();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelAddCotisation = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.dgManyCotisation = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSemaine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fraisLbl = new System.Windows.Forms.Label();
            this.weeksCombo = new System.Windows.Forms.ComboBox();
            this.weekLbl = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.situationLbl = new System.Windows.Forms.Label();
            this.lastLbl = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.fraisCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateCotTxt = new System.Windows.Forms.MaskedTextBox();
            this.montantTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.membreCombo = new System.Windows.Forms.ComboBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCotisation)).BeginInit();
            this.panelGrid.SuspendLayout();
            this.panelAddCotisation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgManyCotisation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(497, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cotisations hebdomadaires";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.button7);
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
            // dgCotisation
            // 
            this.dgCotisation.AllowUserToAddRows = false;
            this.dgCotisation.AllowUserToDeleteRows = false;
            this.dgCotisation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgCotisation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCotisation.BackgroundColor = System.Drawing.Color.White;
            this.dgCotisation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCotisation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgCotisation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCotisation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNum,
            this.ColIdcot,
            this.ColDateCo,
            this.ColDateCon,
            this.ColMontant,
            this.Column1,
            this.ColRefInscrit,
            this.ColRefRound,
            this.ColMatricule,
            this.ColNom,
            this.ColPostnom,
            this.ColPrenom,
            this.ColSex,
            this.ColSem,
            this.ColFrais,
            this.ColDesignation,
            this.ColUser});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCotisation.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgCotisation.Location = new System.Drawing.Point(6, 45);
            this.dgCotisation.Name = "dgCotisation";
            this.dgCotisation.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCotisation.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgCotisation.RowHeadersVisible = false;
            this.dgCotisation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCotisation.Size = new System.Drawing.Size(1160, 471);
            this.dgCotisation.TabIndex = 59;
            // 
            // ColNum
            // 
            this.ColNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColNum.DataPropertyName = "Num";
            this.ColNum.HeaderText = "N°";
            this.ColNum.Name = "ColNum";
            this.ColNum.ReadOnly = true;
            this.ColNum.Width = 53;
            // 
            // ColIdcot
            // 
            this.ColIdcot.DataPropertyName = "Id";
            this.ColIdcot.HeaderText = "IdCotisation";
            this.ColIdcot.Name = "ColIdcot";
            this.ColIdcot.ReadOnly = true;
            this.ColIdcot.Visible = false;
            // 
            // ColDateCo
            // 
            this.ColDateCo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColDateCo.DataPropertyName = "DateCotisation";
            this.ColDateCo.HeaderText = "Date de Cotisation";
            this.ColDateCo.Name = "ColDateCo";
            this.ColDateCo.ReadOnly = true;
            this.ColDateCo.Width = 168;
            // 
            // ColDateCon
            // 
            this.ColDateCon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColDateCon.DataPropertyName = "DateConcernee";
            this.ColDateCon.HeaderText = "Date Concernée";
            this.ColDateCon.Name = "ColDateCon";
            this.ColDateCon.ReadOnly = true;
            this.ColDateCon.Width = 152;
            // 
            // ColMontant
            // 
            this.ColMontant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColMontant.DataPropertyName = "Montant";
            this.ColMontant.HeaderText = "Montant";
            this.ColMontant.Name = "ColMontant";
            this.ColMontant.ReadOnly = true;
            this.ColMontant.Width = 105;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Mont";
            this.Column1.HeaderText = "Mont";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // ColRefInscrit
            // 
            this.ColRefInscrit.DataPropertyName = "RefInscription";
            this.ColRefInscrit.HeaderText = "IdInscription";
            this.ColRefInscrit.Name = "ColRefInscrit";
            this.ColRefInscrit.ReadOnly = true;
            this.ColRefInscrit.Visible = false;
            // 
            // ColRefRound
            // 
            this.ColRefRound.DataPropertyName = "RefRound";
            this.ColRefRound.HeaderText = "IdRound";
            this.ColRefRound.Name = "ColRefRound";
            this.ColRefRound.ReadOnly = true;
            this.ColRefRound.Visible = false;
            // 
            // ColMatricule
            // 
            this.ColMatricule.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColMatricule.DataPropertyName = "Matricule";
            this.ColMatricule.HeaderText = "Matricule";
            this.ColMatricule.Name = "ColMatricule";
            this.ColMatricule.ReadOnly = true;
            this.ColMatricule.Width = 109;
            // 
            // ColNom
            // 
            this.ColNom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColNom.DataPropertyName = "Nom";
            this.ColNom.HeaderText = "Nom";
            this.ColNom.Name = "ColNom";
            this.ColNom.ReadOnly = true;
            this.ColNom.Width = 72;
            // 
            // ColPostnom
            // 
            this.ColPostnom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColPostnom.DataPropertyName = "Postnom";
            this.ColPostnom.HeaderText = "Postnom";
            this.ColPostnom.Name = "ColPostnom";
            this.ColPostnom.ReadOnly = true;
            this.ColPostnom.Width = 102;
            // 
            // ColPrenom
            // 
            this.ColPrenom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColPrenom.DataPropertyName = "Prenom";
            this.ColPrenom.HeaderText = "Prénom";
            this.ColPrenom.Name = "ColPrenom";
            this.ColPrenom.ReadOnly = true;
            this.ColPrenom.Width = 94;
            // 
            // ColSex
            // 
            this.ColSex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColSex.DataPropertyName = "Sexe";
            this.ColSex.HeaderText = "Sexe";
            this.ColSex.Name = "ColSex";
            this.ColSex.ReadOnly = true;
            this.ColSex.Width = 71;
            // 
            // ColSem
            // 
            this.ColSem.DataPropertyName = "RefSemaine";
            this.ColSem.HeaderText = "IdSemaine";
            this.ColSem.Name = "ColSem";
            this.ColSem.ReadOnly = true;
            this.ColSem.Visible = false;
            // 
            // ColFrais
            // 
            this.ColFrais.DataPropertyName = "RefFrais";
            this.ColFrais.HeaderText = "IdFrais";
            this.ColFrais.Name = "ColFrais";
            this.ColFrais.ReadOnly = true;
            this.ColFrais.Visible = false;
            // 
            // ColDesignation
            // 
            this.ColDesignation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColDesignation.DataPropertyName = "Designation";
            this.ColDesignation.HeaderText = "Frais";
            this.ColDesignation.Name = "ColDesignation";
            this.ColDesignation.ReadOnly = true;
            this.ColDesignation.Width = 68;
            // 
            // ColUser
            // 
            this.ColUser.DataPropertyName = "UserSession";
            this.ColUser.HeaderText = "User Session";
            this.ColUser.Name = "ColUser";
            this.ColUser.ReadOnly = true;
            this.ColUser.Visible = false;
            // 
            // serchTxt
            // 
            this.serchTxt.Location = new System.Drawing.Point(104, 12);
            this.serchTxt.Name = "serchTxt";
            this.serchTxt.Size = new System.Drawing.Size(823, 27);
            this.serchTxt.TabIndex = 70;
            this.serchTxt.TextChanged += new System.EventHandler(this.serchTxt_TextChanged);
            // 
            // panelGrid
            // 
            this.panelGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGrid.Controls.Add(this.pictureBox4);
            this.panelGrid.Controls.Add(this.dgCotisation);
            this.panelGrid.Controls.Add(this.serchTxt);
            this.panelGrid.Location = new System.Drawing.Point(3, 133);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(1171, 527);
            this.panelGrid.TabIndex = 71;
            this.panelGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGrid_Paint);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelAddCotisation
            // 
            this.panelAddCotisation.Controls.Add(this.label10);
            this.panelAddCotisation.Controls.Add(this.dgManyCotisation);
            this.panelAddCotisation.Controls.Add(this.fraisLbl);
            this.panelAddCotisation.Controls.Add(this.weeksCombo);
            this.panelAddCotisation.Controls.Add(this.weekLbl);
            this.panelAddCotisation.Controls.Add(this.checkBox2);
            this.panelAddCotisation.Controls.Add(this.label9);
            this.panelAddCotisation.Controls.Add(this.label8);
            this.panelAddCotisation.Controls.Add(this.situationLbl);
            this.panelAddCotisation.Controls.Add(this.lastLbl);
            this.panelAddCotisation.Controls.Add(this.addBtn);
            this.panelAddCotisation.Controls.Add(this.checkBox1);
            this.panelAddCotisation.Controls.Add(this.fraisCombo);
            this.panelAddCotisation.Controls.Add(this.label5);
            this.panelAddCotisation.Controls.Add(this.label2);
            this.panelAddCotisation.Controls.Add(this.dateCotTxt);
            this.panelAddCotisation.Controls.Add(this.montantTxt);
            this.panelAddCotisation.Controls.Add(this.label1);
            this.panelAddCotisation.Controls.Add(this.label4);
            this.panelAddCotisation.Controls.Add(this.membreCombo);
            this.panelAddCotisation.Location = new System.Drawing.Point(3, 399);
            this.panelAddCotisation.Name = "panelAddCotisation";
            this.panelAddCotisation.Size = new System.Drawing.Size(1167, 264);
            this.panelAddCotisation.TabIndex = 72;
            this.panelAddCotisation.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(602, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 21);
            this.label10.TabIndex = 111;
            this.label10.Text = "Type de Frais";
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgManyCotisation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgManyCotisation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgManyCotisation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.ColSemaine,
            this.Column3,
            this.Column12});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgManyCotisation.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgManyCotisation.Location = new System.Drawing.Point(807, 18);
            this.dgManyCotisation.Name = "dgManyCotisation";
            this.dgManyCotisation.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgManyCotisation.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgManyCotisation.RowHeadersVisible = false;
            this.dgManyCotisation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgManyCotisation.Size = new System.Drawing.Size(354, 227);
            this.dgManyCotisation.TabIndex = 102;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Numéro";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ColSemaine
            // 
            this.ColSemaine.HeaderText = "IdSemaine";
            this.ColSemaine.Name = "ColSemaine";
            this.ColSemaine.ReadOnly = true;
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
            // fraisLbl
            // 
            this.fraisLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fraisLbl.Location = new System.Drawing.Point(516, 139);
            this.fraisLbl.Name = "fraisLbl";
            this.fraisLbl.Size = new System.Drawing.Size(258, 19);
            this.fraisLbl.TabIndex = 110;
            this.fraisLbl.Text = "frais";
            this.fraisLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // weeksCombo
            // 
            this.weeksCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.weeksCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.weeksCombo.FormattingEnabled = true;
            this.weeksCombo.Location = new System.Drawing.Point(149, 163);
            this.weeksCombo.Name = "weeksCombo";
            this.weeksCombo.Size = new System.Drawing.Size(353, 29);
            this.weeksCombo.TabIndex = 109;
            this.weeksCombo.Visible = false;
            this.weeksCombo.SelectedIndexChanged += new System.EventHandler(this.weeksCombo_SelectedIndexChanged_1);
            // 
            // weekLbl
            // 
            this.weekLbl.AutoSize = true;
            this.weekLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekLbl.Location = new System.Drawing.Point(85, 167);
            this.weekLbl.Name = "weekLbl";
            this.weekLbl.Size = new System.Drawing.Size(58, 19);
            this.weekLbl.TabIndex = 108;
            this.weekLbl.Text = "Weeks";
            this.weekLbl.Visible = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(430, 29);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(189, 25);
            this.checkBox2.TabIndex = 107;
            this.checkBox2.Text = "Cotisations spéciales";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(602, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 21);
            this.label9.TabIndex = 106;
            this.label9.Text = "Observation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(622, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 21);
            this.label8.TabIndex = 105;
            this.label8.Text = "Laste";
            // 
            // situationLbl
            // 
            this.situationLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.situationLbl.ForeColor = System.Drawing.Color.SeaGreen;
            this.situationLbl.Location = new System.Drawing.Point(536, 194);
            this.situationLbl.Name = "situationLbl";
            this.situationLbl.Size = new System.Drawing.Size(223, 19);
            this.situationLbl.TabIndex = 104;
            this.situationLbl.Text = "Situation";
            this.situationLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lastLbl
            // 
            this.lastLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastLbl.Location = new System.Drawing.Point(565, 83);
            this.lastLbl.Name = "lastLbl";
            this.lastLbl.Size = new System.Drawing.Size(189, 19);
            this.lastLbl.TabIndex = 103;
            this.lastLbl.Text = "Dernière contribution";
            this.lastLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(227, 198);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(170, 35);
            this.addBtn.TabIndex = 92;
            this.addBtn.Text = "Ajouter";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Visible = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click_1);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 29);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(406, 25);
            this.checkBox1.TabIndex = 101;
            this.checkBox1.Text = "Enregistrer plusieurs cotisation pour ce membre ?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // fraisCombo
            // 
            this.fraisCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.fraisCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.fraisCombo.FormattingEnabled = true;
            this.fraisCombo.Location = new System.Drawing.Point(341, 128);
            this.fraisCombo.Name = "fraisCombo";
            this.fraisCombo.Size = new System.Drawing.Size(161, 29);
            this.fraisCombo.TabIndex = 100;
            this.fraisCombo.SelectedIndexChanged += new System.EventHandler(this.fraisCombo_SelectedIndexChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(292, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 19);
            this.label5.TabIndex = 99;
            this.label5.Text = "Frais";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 98;
            this.label2.Text = "Montant";
            // 
            // dateCotTxt
            // 
            this.dateCotTxt.Location = new System.Drawing.Point(149, 95);
            this.dateCotTxt.Mask = "00/00/0000";
            this.dateCotTxt.Name = "dateCotTxt";
            this.dateCotTxt.ReadOnly = true;
            this.dateCotTxt.Size = new System.Drawing.Size(353, 27);
            this.dateCotTxt.TabIndex = 97;
            this.dateCotTxt.ValidatingType = typeof(System.DateTime);
            // 
            // montantTxt
            // 
            this.montantTxt.Location = new System.Drawing.Point(149, 128);
            this.montantTxt.Name = "montantTxt";
            this.montantTxt.Size = new System.Drawing.Size(137, 27);
            this.montantTxt.TabIndex = 96;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 95;
            this.label1.Text = "Cotisation du ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 19);
            this.label4.TabIndex = 94;
            this.label4.Text = "Identité membre";
            // 
            // membreCombo
            // 
            this.membreCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.membreCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.membreCombo.FormattingEnabled = true;
            this.membreCombo.Location = new System.Drawing.Point(149, 60);
            this.membreCombo.Name = "membreCombo";
            this.membreCombo.Size = new System.Drawing.Size(353, 29);
            this.membreCombo.TabIndex = 93;
            this.membreCombo.SelectedIndexChanged += new System.EventHandler(this.membreCombo_SelectedIndexChanged_1);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(926, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 27);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 76;
            this.pictureBox4.TabStop = false;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = global::UIProject.Properties.Resources.Up_Squared_32px;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(1129, 13);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(45, 33);
            this.button7.TabIndex = 11;
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // UC_Cotisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelAddCotisation);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UC_Cotisation";
            this.Size = new System.Drawing.Size(1177, 663);
            this.Load += new System.EventHandler(this.UC_Cotisation_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCotisation)).EndInit();
            this.panelGrid.ResumeLayout(false);
            this.panelGrid.PerformLayout();
            this.panelAddCotisation.ResumeLayout(false);
            this.panelAddCotisation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgManyCotisation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button nouveauBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView dgCotisation;
        private System.Windows.Forms.TextBox serchTxt;
        public System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelAddCotisation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgManyCotisation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSemaine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.Label fraisLbl;
        private System.Windows.Forms.ComboBox weeksCombo;
        private System.Windows.Forms.Label weekLbl;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label situationLbl;
        private System.Windows.Forms.Label lastLbl;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox fraisCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox dateCotTxt;
        private System.Windows.Forms.TextBox montantTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox membreCombo;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdcot;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDateCo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDateCon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMontant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRefInscrit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRefRound;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMatricule;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPostnom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFrais;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUser;
        private System.Windows.Forms.Button button7;
    }
}
