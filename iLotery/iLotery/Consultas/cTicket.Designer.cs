namespace iLotery.Consultas
{
    partial class cTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cTicket));
            this.Busquedagroupbox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BuscarTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BuscarComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DatosGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CantidadTextBox = new System.Windows.Forms.TextBox();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.Busquedagroupbox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Busquedagroupbox1
            // 
            this.Busquedagroupbox1.Controls.Add(this.button1);
            this.Busquedagroupbox1.Controls.Add(this.BuscarTextBox);
            this.Busquedagroupbox1.Controls.Add(this.label2);
            this.Busquedagroupbox1.Controls.Add(this.BuscarComboBox);
            this.Busquedagroupbox1.Controls.Add(this.label1);
            this.Busquedagroupbox1.Location = new System.Drawing.Point(12, 12);
            this.Busquedagroupbox1.Name = "Busquedagroupbox1";
            this.Busquedagroupbox1.Size = new System.Drawing.Size(706, 53);
            this.Busquedagroupbox1.TabIndex = 0;
            this.Busquedagroupbox1.TabStop = false;
            this.Busquedagroupbox1.Text = "Busqueda";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(612, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Buscar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BuscarTextBox
            // 
            this.BuscarTextBox.Location = new System.Drawing.Point(220, 23);
            this.BuscarTextBox.Name = "BuscarTextBox";
            this.BuscarTextBox.Size = new System.Drawing.Size(362, 20);
            this.BuscarTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "=";
            // 
            // BuscarComboBox
            // 
            this.BuscarComboBox.FormattingEnabled = true;
            this.BuscarComboBox.Items.AddRange(new object[] {
            "IdTicket",
            "Loteria",
            "Tanda",
            "Jugada",
            "Monto"});
            this.BuscarComboBox.Location = new System.Drawing.Point(74, 23);
            this.BuscarComboBox.Name = "BuscarComboBox";
            this.BuscarComboBox.Size = new System.Drawing.Size(121, 21);
            this.BuscarComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Por:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DatosGridView);
            this.groupBox2.Location = new System.Drawing.Point(12, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(706, 276);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // DatosGridView
            // 
            this.DatosGridView.AllowUserToAddRows = false;
            this.DatosGridView.AllowUserToDeleteRows = false;
            this.DatosGridView.AllowUserToOrderColumns = true;
            this.DatosGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosGridView.Location = new System.Drawing.Point(6, 19);
            this.DatosGridView.Name = "DatosGridView";
            this.DatosGridView.ReadOnly = true;
            this.DatosGridView.Size = new System.Drawing.Size(694, 251);
            this.DatosGridView.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CantidadTextBox);
            this.groupBox1.Controls.Add(this.TotalTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 353);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 64);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(559, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total:";
            // 
            // CantidadTextBox
            // 
            this.CantidadTextBox.Location = new System.Drawing.Point(64, 28);
            this.CantidadTextBox.Name = "CantidadTextBox";
            this.CantidadTextBox.ReadOnly = true;
            this.CantidadTextBox.Size = new System.Drawing.Size(100, 20);
            this.CantidadTextBox.TabIndex = 3;
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(600, 28);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalTextBox.TabIndex = 4;
            // 
            // cTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 429);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Busquedagroupbox1);
            this.Name = "cTicket";
            this.Text = "Consulta de Tickets";
            this.Busquedagroupbox1.ResumeLayout(false);
            this.Busquedagroupbox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatosGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Busquedagroupbox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox BuscarTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox BuscarComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DatosGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CantidadTextBox;
        private System.Windows.Forms.TextBox TotalTextBox;
    }
}