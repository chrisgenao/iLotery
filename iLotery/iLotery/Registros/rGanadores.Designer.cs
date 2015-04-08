namespace iLotery.Registros
{
    partial class rGanadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rGanadores));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.SLugarTextBox = new System.Windows.Forms.TextBox();
            this.TLugarTextBox = new System.Windows.Forms.TextBox();
            this.PLugarTextBox = new System.Windows.Forms.TextBox();
            this.LoteriaComboBox = new System.Windows.Forms.ComboBox();
            this.TandaComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GanadoresGridView = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loteria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Primer_Lugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Segundo_Lugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tercer_Lugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GanadoresGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // GuardarButton
            // 
            this.GuardarButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.Location = new System.Drawing.Point(449, 342);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 34);
            this.GuardarButton.TabIndex = 27;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LimpiarButton.Image = ((System.Drawing.Image)(resources.GetObject("LimpiarButton.Image")));
            this.LimpiarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LimpiarButton.Location = new System.Drawing.Point(369, 342);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(75, 34);
            this.LimpiarButton.TabIndex = 26;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LimpiarButton.UseVisualStyleBackColor = true;
            this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
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
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.AgregarButton);
            this.groupBox1.Controls.Add(this.SLugarTextBox);
            this.groupBox1.Controls.Add(this.TLugarTextBox);
            this.groupBox1.Controls.Add(this.PLugarTextBox);
            this.groupBox1.Controls.Add(this.LoteriaComboBox);
            this.groupBox1.Controls.Add(this.TandaComboBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(853, 57);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar # Ganador";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // AgregarButton
            // 
            this.AgregarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AgregarButton.Location = new System.Drawing.Point(772, 19);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(75, 23);
            this.AgregarButton.TabIndex = 10;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // SLugarTextBox
            // 
            this.SLugarTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SLugarTextBox.Location = new System.Drawing.Point(571, 21);
            this.SLugarTextBox.MaxLength = 3;
            this.SLugarTextBox.Name = "SLugarTextBox";
            this.SLugarTextBox.Size = new System.Drawing.Size(51, 20);
            this.SLugarTextBox.TabIndex = 9;
            this.SLugarTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SLugarTextBox_KeyPress);
            // 
            // TLugarTextBox
            // 
            this.TLugarTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TLugarTextBox.Location = new System.Drawing.Point(702, 21);
            this.TLugarTextBox.MaxLength = 3;
            this.TLugarTextBox.Name = "TLugarTextBox";
            this.TLugarTextBox.Size = new System.Drawing.Size(51, 20);
            this.TLugarTextBox.TabIndex = 8;
            this.TLugarTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TLugarTextBox_KeyPress);
            // 
            // PLugarTextBox
            // 
            this.PLugarTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PLugarTextBox.Location = new System.Drawing.Point(412, 21);
            this.PLugarTextBox.MaxLength = 3;
            this.PLugarTextBox.Name = "PLugarTextBox";
            this.PLugarTextBox.Size = new System.Drawing.Size(46, 20);
            this.PLugarTextBox.TabIndex = 7;
            this.PLugarTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PLugarTextBox_KeyPress);
            // 
            // LoteriaComboBox
            // 
            this.LoteriaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LoteriaComboBox.FormattingEnabled = true;
            this.LoteriaComboBox.Items.AddRange(new object[] {
            "IdLoteria",
            "Loteria"});
            this.LoteriaComboBox.Location = new System.Drawing.Point(51, 21);
            this.LoteriaComboBox.Name = "LoteriaComboBox";
            this.LoteriaComboBox.Size = new System.Drawing.Size(108, 21);
            this.LoteriaComboBox.TabIndex = 6;
            // 
            // TandaComboBox
            // 
            this.TandaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TandaComboBox.FormattingEnabled = true;
            this.TandaComboBox.Items.AddRange(new object[] {
            "Tarde",
            "Noche"});
            this.TandaComboBox.Location = new System.Drawing.Point(209, 21);
            this.TandaComboBox.Name = "TandaComboBox";
            this.TandaComboBox.Size = new System.Drawing.Size(121, 21);
            this.TandaComboBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tanda";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Primer Lugar";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Segundo Lugar";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(626, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tercer Lugar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loteria";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.GanadoresGridView);
            this.groupBox2.Location = new System.Drawing.Point(12, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(853, 260);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // GanadoresGridView
            // 
            this.GanadoresGridView.AllowUserToAddRows = false;
            this.GanadoresGridView.AllowUserToDeleteRows = false;
            this.GanadoresGridView.AllowUserToOrderColumns = true;
            this.GanadoresGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GanadoresGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GanadoresGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Loteria,
            this.Tanda,
            this.Primer_Lugar,
            this.Segundo_Lugar,
            this.Tercer_Lugar});
            this.GanadoresGridView.Location = new System.Drawing.Point(6, 19);
            this.GanadoresGridView.Name = "GanadoresGridView";
            this.GanadoresGridView.ReadOnly = true;
            this.GanadoresGridView.Size = new System.Drawing.Size(841, 235);
            this.GanadoresGridView.TabIndex = 0;
            this.GanadoresGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GanadoresGridView_CellContentClick);
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
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
            // Primer_Lugar
            // 
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.Primer_Lugar.DefaultCellStyle = dataGridViewCellStyle1;
            this.Primer_Lugar.HeaderText = "Primer Lugar";
            this.Primer_Lugar.Name = "Primer_Lugar";
            this.Primer_Lugar.ReadOnly = true;
            // 
            // Segundo_Lugar
            // 
            dataGridViewCellStyle2.Format = "N0";
            this.Segundo_Lugar.DefaultCellStyle = dataGridViewCellStyle2;
            this.Segundo_Lugar.HeaderText = "Segundo Lugar";
            this.Segundo_Lugar.Name = "Segundo_Lugar";
            this.Segundo_Lugar.ReadOnly = true;
            this.Segundo_Lugar.Width = 115;
            // 
            // Tercer_Lugar
            // 
            dataGridViewCellStyle3.Format = "N0";
            this.Tercer_Lugar.DefaultCellStyle = dataGridViewCellStyle3;
            this.Tercer_Lugar.HeaderText = "Tercer Lugar";
            this.Tercer_Lugar.Name = "Tercer_Lugar";
            this.Tercer_Lugar.ReadOnly = true;
            // 
            // rGanadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 388);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.LimpiarButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "rGanadores";
            this.ShowIcon = false;
            this.Text = "Registro de Ganadores";
            this.Load += new System.EventHandler(this.rGanadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GanadoresGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView GanadoresGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loteria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Primer_Lugar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Segundo_Lugar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tercer_Lugar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.TextBox SLugarTextBox;
        private System.Windows.Forms.TextBox TLugarTextBox;
        private System.Windows.Forms.TextBox PLugarTextBox;
        private System.Windows.Forms.ComboBox LoteriaComboBox;
        private System.Windows.Forms.ComboBox TandaComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        //private LoteriasReport.CachedCrystalReport1 cachedCrystalReport11;
    }
}