namespace iLotery.Registros
{
    partial class rTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rTicket));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Jugadas = new System.Windows.Forms.GroupBox();
            this.TandaComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AgregarTextBox = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TNTextBox = new System.Windows.Forms.TextBox();
            this.SNTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PNTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MontoTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LoteriaComboBox = new System.Windows.Forms.ComboBox();
            this.ImprimirButton = new System.Windows.Forms.Button();
            this.TicketGridView = new System.Windows.Forms.DataGridView();
            this.Loteria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jugada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Primer_Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Segundo_Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tercer_Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BorrarButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.HoraTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.Jugadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TicketGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // Jugadas
            // 
            this.Jugadas.Controls.Add(this.SearchButton);
            this.Jugadas.Controls.Add(this.IDTextBox);
            this.Jugadas.Controls.Add(this.label10);
            this.Jugadas.Controls.Add(this.TandaComboBox);
            this.Jugadas.Controls.Add(this.label9);
            this.Jugadas.Controls.Add(this.label5);
            this.Jugadas.Controls.Add(this.label8);
            this.Jugadas.Controls.Add(this.AgregarTextBox);
            this.Jugadas.Controls.Add(this.label7);
            this.Jugadas.Controls.Add(this.TNTextBox);
            this.Jugadas.Controls.Add(this.SNTextBox);
            this.Jugadas.Controls.Add(this.comboBox1);
            this.Jugadas.Controls.Add(this.label1);
            this.Jugadas.Controls.Add(this.PNTextBox);
            this.Jugadas.Controls.Add(this.label2);
            this.Jugadas.Controls.Add(this.MontoTextBox);
            this.Jugadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Jugadas.Location = new System.Drawing.Point(12, 38);
            this.Jugadas.Name = "Jugadas";
            this.Jugadas.Size = new System.Drawing.Size(248, 260);
            this.Jugadas.TabIndex = 3;
            this.Jugadas.TabStop = false;
            this.Jugadas.Text = "Jugadas";
            // 
            // TandaComboBox
            // 
            this.TandaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TandaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TandaComboBox.FormattingEnabled = true;
            this.TandaComboBox.Items.AddRange(new object[] {
            "Tarde",
            "Noche"});
            this.TandaComboBox.Location = new System.Drawing.Point(105, 95);
            this.TandaComboBox.Name = "TandaComboBox";
            this.TandaComboBox.Size = new System.Drawing.Size(51, 21);
            this.TandaComboBox.TabIndex = 22;
            this.TandaComboBox.SelectedIndexChanged += new System.EventHandler(this.TandaComboBox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label9.Location = new System.Drawing.Point(6, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Tercer Lugar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Tanda:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(6, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Segundo Numero:";
            // 
            // AgregarTextBox
            // 
            this.AgregarTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarTextBox.Location = new System.Drawing.Point(87, 228);
            this.AgregarTextBox.Name = "AgregarTextBox";
            this.AgregarTextBox.Size = new System.Drawing.Size(75, 23);
            this.AgregarTextBox.TabIndex = 17;
            this.AgregarTextBox.Text = "Agregar";
            this.AgregarTextBox.UseVisualStyleBackColor = true;
            this.AgregarTextBox.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(6, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Primer Numero:";
            // 
            // TNTextBox
            // 
            this.TNTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TNTextBox.Location = new System.Drawing.Point(105, 176);
            this.TNTextBox.MaxLength = 10;
            this.TNTextBox.Name = "TNTextBox";
            this.TNTextBox.Size = new System.Drawing.Size(40, 20);
            this.TNTextBox.TabIndex = 3;
            this.TNTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TNTextBox_KeyPress);
            // 
            // SNTextBox
            // 
            this.SNTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SNTextBox.Location = new System.Drawing.Point(105, 150);
            this.SNTextBox.MaxLength = 3;
            this.SNTextBox.Name = "SNTextBox";
            this.SNTextBox.Size = new System.Drawing.Size(40, 20);
            this.SNTextBox.TabIndex = 21;
            this.SNTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SNTextBox_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Pale",
            "Quiniela",
            "Tripleta"});
            this.comboBox1.Location = new System.Drawing.Point(105, 67);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 24);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Jugada:";
            // 
            // PNTextBox
            // 
            this.PNTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PNTextBox.Location = new System.Drawing.Point(105, 124);
            this.PNTextBox.MaxLength = 3;
            this.PNTextBox.Name = "PNTextBox";
            this.PNTextBox.Size = new System.Drawing.Size(40, 20);
            this.PNTextBox.TabIndex = 11;
            this.PNTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.PNTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JugadaTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(6, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Monto:";
            // 
            // MontoTextBox
            // 
            this.MontoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MontoTextBox.Location = new System.Drawing.Point(105, 202);
            this.MontoTextBox.MaxLength = 10;
            this.MontoTextBox.Name = "MontoTextBox";
            this.MontoTextBox.Size = new System.Drawing.Size(40, 20);
            this.MontoTextBox.TabIndex = 12;
            this.MontoTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.MontoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MontoTextBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Loteria:";
            // 
            // LoteriaComboBox
            // 
            this.LoteriaComboBox.AllowDrop = true;
            this.LoteriaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LoteriaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoteriaComboBox.FormattingEnabled = true;
            this.LoteriaComboBox.Items.AddRange(new object[] {
            "IdLoteria",
            "Nombre"});
            this.LoteriaComboBox.Location = new System.Drawing.Point(63, 14);
            this.LoteriaComboBox.Name = "LoteriaComboBox";
            this.LoteriaComboBox.Size = new System.Drawing.Size(121, 24);
            this.LoteriaComboBox.TabIndex = 0;
            this.LoteriaComboBox.SelectedIndexChanged += new System.EventHandler(this.LoteriaComboBox_SelectedIndexChanged);
            // 
            // ImprimirButton
            // 
            this.ImprimirButton.Image = ((System.Drawing.Image)(resources.GetObject("ImprimirButton.Image")));
            this.ImprimirButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ImprimirButton.Location = new System.Drawing.Point(6, 19);
            this.ImprimirButton.Name = "ImprimirButton";
            this.ImprimirButton.Size = new System.Drawing.Size(75, 34);
            this.ImprimirButton.TabIndex = 7;
            this.ImprimirButton.Text = "Imprimir Partida";
            this.ImprimirButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ImprimirButton.UseVisualStyleBackColor = true;
            this.ImprimirButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // TicketGridView
            // 
            this.TicketGridView.AllowUserToAddRows = false;
            this.TicketGridView.AllowUserToOrderColumns = true;
            this.TicketGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TicketGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TicketGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Loteria,
            this.Tanda,
            this.Fecha,
            this.Jugada,
            this.Primer_Numero,
            this.Segundo_Numero,
            this.Tercer_Numero,
            this.Monto});
            this.TicketGridView.Location = new System.Drawing.Point(6, 26);
            this.TicketGridView.Name = "TicketGridView";
            this.TicketGridView.ReadOnly = true;
            this.TicketGridView.Size = new System.Drawing.Size(900, 405);
            this.TicketGridView.TabIndex = 10;
            this.TicketGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TicketGridView_CellContentClick);
            // 
            // Loteria
            // 
            this.Loteria.HeaderText = "Loteria";
            this.Loteria.Name = "Loteria";
            this.Loteria.ReadOnly = true;
            // 
            // Tanda
            // 
            this.Tanda.HeaderText = "Tanda";
            this.Tanda.Name = "Tanda";
            this.Tanda.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Jugada
            // 
            this.Jugada.HeaderText = "Jugada";
            this.Jugada.Name = "Jugada";
            this.Jugada.ReadOnly = true;
            // 
            // Primer_Numero
            // 
            this.Primer_Numero.HeaderText = "Primer Numero";
            this.Primer_Numero.Name = "Primer_Numero";
            this.Primer_Numero.ReadOnly = true;
            this.Primer_Numero.Width = 120;
            // 
            // Segundo_Numero
            // 
            this.Segundo_Numero.HeaderText = "Segundo Numero";
            this.Segundo_Numero.Name = "Segundo_Numero";
            this.Segundo_Numero.ReadOnly = true;
            this.Segundo_Numero.Width = 120;
            // 
            // Tercer_Numero
            // 
            this.Tercer_Numero.HeaderText = "Tercer Numero";
            this.Tercer_Numero.Name = "Tercer_Numero";
            this.Tercer_Numero.ReadOnly = true;
            this.Tercer_Numero.Width = 120;
            // 
            // Monto
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            this.Monto.DefaultCellStyle = dataGridViewCellStyle1;
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTextBox.Location = new System.Drawing.Point(806, 453);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalTextBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(760, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Total:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.BorrarButton);
            this.groupBox2.Controls.Add(this.BuscarButton);
            this.groupBox2.Controls.Add(this.GuardarButton);
            this.groupBox2.Controls.Add(this.ImprimirButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 304);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 191);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controladores";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // BorrarButton
            // 
            this.BorrarButton.Image = ((System.Drawing.Image)(resources.GetObject("BorrarButton.Image")));
            this.BorrarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BorrarButton.Location = new System.Drawing.Point(167, 59);
            this.BorrarButton.Name = "BorrarButton";
            this.BorrarButton.Size = new System.Drawing.Size(75, 34);
            this.BorrarButton.TabIndex = 23;
            this.BorrarButton.Text = "Borrar Partida";
            this.BorrarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BorrarButton.UseVisualStyleBackColor = true;
            this.BorrarButton.Click += new System.EventHandler(this.BorrarButton_Click);
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.Location = new System.Drawing.Point(167, 19);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(75, 34);
            this.BuscarButton.TabIndex = 22;
            this.BuscarButton.Text = "Buscar Partida";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.Location = new System.Drawing.Point(87, 19);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 34);
            this.GuardarButton.TabIndex = 20;
            this.GuardarButton.Text = "Guardar Partida";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.HoraTextBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.TicketGridView);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.TotalTextBox);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(266, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(912, 483);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Jugada";
            // 
            // HoraTextBox
            // 
            this.HoraTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoraTextBox.Location = new System.Drawing.Point(52, 453);
            this.HoraTextBox.Name = "HoraTextBox";
            this.HoraTextBox.ReadOnly = true;
            this.HoraTextBox.Size = new System.Drawing.Size(100, 20);
            this.HoraTextBox.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 456);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Fecha:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Buscar Ticket:";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(105, 29);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(40, 20);
            this.IDTextBox.TabIndex = 27;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(151, 27);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(54, 23);
            this.SearchButton.TabIndex = 28;
            this.SearchButton.Text = "Buscar";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // rTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 507);
            this.Controls.Add(this.LoteriaComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Jugadas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "rTicket";
            this.Text = "Registro de Ticket";
            this.Load += new System.EventHandler(this.rTicket_Load);
            this.Jugadas.ResumeLayout(false);
            this.Jugadas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TicketGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Jugadas;
        private System.Windows.Forms.Button ImprimirButton;
        private System.Windows.Forms.DataGridView TicketGridView;
        private System.Windows.Forms.TextBox PNTextBox;
        private System.Windows.Forms.TextBox MontoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AgregarTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.TextBox HoraTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox LoteriaComboBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ComboBox TandaComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BorrarButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TNTextBox;
        private System.Windows.Forms.TextBox SNTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loteria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jugada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Primer_Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Segundo_Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tercer_Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label label10;
    }
}