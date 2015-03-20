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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rTicket));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LoteriaCheckList = new System.Windows.Forms.CheckedListBox();
            this.ImprimirButton = new System.Windows.Forms.Button();
            this.TicketGridView = new System.Windows.Forms.DataGridView();
            this.JugadaTextBox = new System.Windows.Forms.TextBox();
            this.MontoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AgregarTextBox = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BorrarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.HoraTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Loteria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jugada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TicketGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LoteriaCheckList);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 126);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loteria";
            // 
            // LoteriaCheckList
            // 
            this.LoteriaCheckList.FormattingEnabled = true;
            this.LoteriaCheckList.Items.AddRange(new object[] {
            "Real",
            "Nacional",
            "Loteka",
            "Leidsa"});
            this.LoteriaCheckList.Location = new System.Drawing.Point(6, 19);
            this.LoteriaCheckList.Name = "LoteriaCheckList";
            this.LoteriaCheckList.Size = new System.Drawing.Size(227, 89);
            this.LoteriaCheckList.TabIndex = 10;
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
            this.TicketGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TicketGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Loteria,
            this.Tanda,
            this.Fecha,
            this.Jugada,
            this.Monto});
            this.TicketGridView.Location = new System.Drawing.Point(6, 45);
            this.TicketGridView.Name = "TicketGridView";
            this.TicketGridView.Size = new System.Drawing.Size(595, 386);
            this.TicketGridView.TabIndex = 10;
            this.TicketGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TicketGridView_CellContentClick);
            // 
            // JugadaTextBox
            // 
            this.JugadaTextBox.Location = new System.Drawing.Point(216, 15);
            this.JugadaTextBox.Name = "JugadaTextBox";
            this.JugadaTextBox.Size = new System.Drawing.Size(100, 20);
            this.JugadaTextBox.TabIndex = 11;
            this.JugadaTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MontoTextBox
            // 
            this.MontoTextBox.Location = new System.Drawing.Point(404, 15);
            this.MontoTextBox.Name = "MontoTextBox";
            this.MontoTextBox.Size = new System.Drawing.Size(100, 20);
            this.MontoTextBox.TabIndex = 12;
            this.MontoTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Jugada:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(352, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Monto:";
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(501, 457);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalTextBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(455, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Total:";
            // 
            // AgregarTextBox
            // 
            this.AgregarTextBox.Location = new System.Drawing.Point(510, 12);
            this.AgregarTextBox.Name = "AgregarTextBox";
            this.AgregarTextBox.Size = new System.Drawing.Size(75, 23);
            this.AgregarTextBox.TabIndex = 17;
            this.AgregarTextBox.Text = "Agregar";
            this.AgregarTextBox.UseVisualStyleBackColor = true;
            this.AgregarTextBox.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BorrarButton);
            this.groupBox2.Controls.Add(this.GuardarButton);
            this.groupBox2.Controls.Add(this.ImprimirButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 285);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controladores";
            // 
            // BorrarButton
            // 
            this.BorrarButton.Image = ((System.Drawing.Image)(resources.GetObject("BorrarButton.Image")));
            this.BorrarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BorrarButton.Location = new System.Drawing.Point(168, 19);
            this.BorrarButton.Name = "BorrarButton";
            this.BorrarButton.Size = new System.Drawing.Size(75, 34);
            this.BorrarButton.TabIndex = 21;
            this.BorrarButton.Text = "Borrar Partida";
            this.BorrarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BorrarButton.UseVisualStyleBackColor = true;
            this.BorrarButton.Click += new System.EventHandler(this.button3_Click);
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
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.HoraTextBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.TicketGridView);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.AgregarTextBox);
            this.groupBox3.Controls.Add(this.TotalTextBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.JugadaTextBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.MontoTextBox);
            this.groupBox3.Location = new System.Drawing.Point(316, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(607, 483);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Jugada";
            // 
            // HoraTextBox
            // 
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
            // Loteria
            // 
            this.Loteria.HeaderText = "Loteria";
            this.Loteria.Name = "Loteria";
            // 
            // Tanda
            // 
            this.Tanda.HeaderText = "Tanda";
            this.Tanda.Name = "Tanda";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // Jugada
            // 
            this.Jugada.HeaderText = "Jugada";
            this.Jugada.Name = "Jugada";
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(54, 20);
            this.textBox1.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Tanda:";
            // 
            // rTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 507);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "rTicket";
            this.Text = "Registro de Ticket";
            this.Load += new System.EventHandler(this.rTicket_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TicketGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ImprimirButton;
        private System.Windows.Forms.CheckedListBox LoteriaCheckList;
        private System.Windows.Forms.DataGridView TicketGridView;
        private System.Windows.Forms.TextBox JugadaTextBox;
        private System.Windows.Forms.TextBox MontoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AgregarTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BorrarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.TextBox HoraTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loteria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jugada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
    }
}