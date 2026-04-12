namespace Sistema_de_Reserva_de_Hotel
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEstancia = new System.Windows.Forms.TextBox();
            this.dtmEntrada = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtmSalida = new System.Windows.Forms.DateTimePicker();
            this.numPersonas = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.clbServicios = new System.Windows.Forms.CheckedListBox();
            this.rtbResumen = new System.Windows.Forms.RichTextBox();
            this.btnCalcularReserva = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(105, 74);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(100, 22);
            this.txtCliente.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 70);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(80, 25);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Estancia";
            // 
            // txtEstancia
            // 
            this.txtEstancia.Location = new System.Drawing.Point(363, 78);
            this.txtEstancia.Name = "txtEstancia";
            this.txtEstancia.Size = new System.Drawing.Size(100, 22);
            this.txtEstancia.TabIndex = 3;
            this.txtEstancia.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dtmEntrada
            // 
            this.dtmEntrada.Location = new System.Drawing.Point(17, 171);
            this.dtmEntrada.Name = "dtmEntrada";
            this.dtmEntrada.Size = new System.Drawing.Size(200, 22);
            this.dtmEntrada.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Entrada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Salida";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dtmSalida
            // 
            this.dtmSalida.Location = new System.Drawing.Point(17, 254);
            this.dtmSalida.Name = "dtmSalida";
            this.dtmSalida.Size = new System.Drawing.Size(200, 22);
            this.dtmSalida.TabIndex = 7;
            // 
            // numPersonas
            // 
            this.numPersonas.Location = new System.Drawing.Point(613, 79);
            this.numPersonas.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numPersonas.Name = "numPersonas";
            this.numPersonas.Size = new System.Drawing.Size(120, 22);
            this.numPersonas.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(499, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Personas";
            // 
            // clbServicios
            // 
            this.clbServicios.FormattingEnabled = true;
            this.clbServicios.Items.AddRange(new object[] {
            "Wifi Premium",
            "Desayuno Buffet",
            "Estacionamiento",
            "Spa"});
            this.clbServicios.Location = new System.Drawing.Point(254, 171);
            this.clbServicios.Name = "clbServicios";
            this.clbServicios.Size = new System.Drawing.Size(149, 106);
            this.clbServicios.TabIndex = 10;
            // 
            // rtbResumen
            // 
            this.rtbResumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbResumen.Location = new System.Drawing.Point(478, 147);
            this.rtbResumen.Name = "rtbResumen";
            this.rtbResumen.ReadOnly = true;
            this.rtbResumen.Size = new System.Drawing.Size(255, 230);
            this.rtbResumen.TabIndex = 11;
            this.rtbResumen.Text = "***  RESUMEN RESERVA  ***\n\nCliente: \nEstancia: \nPersonas:\nServicios:\n------------" +
    "------------------------------\nTotal a pagar: $";
            // 
            // btnCalcularReserva
            // 
            this.btnCalcularReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularReserva.Location = new System.Drawing.Point(17, 352);
            this.btnCalcularReserva.Name = "btnCalcularReserva";
            this.btnCalcularReserva.Size = new System.Drawing.Size(122, 61);
            this.btnCalcularReserva.TabIndex = 12;
            this.btnCalcularReserva.Text = "Calcular Reserva";
            this.btnCalcularReserva.UseVisualStyleBackColor = true;
            this.btnCalcularReserva.Click += new System.EventHandler(this.btnCalcularReserva_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcularReserva);
            this.Controls.Add(this.rtbResumen);
            this.Controls.Add(this.clbServicios);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numPersonas);
            this.Controls.Add(this.dtmSalida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtmEntrada);
            this.Controls.Add(this.txtEstancia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCliente);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEstancia;
        private System.Windows.Forms.DateTimePicker dtmEntrada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtmSalida;
        private System.Windows.Forms.NumericUpDown numPersonas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox clbServicios;
        private System.Windows.Forms.RichTextBox rtbResumen;
        private System.Windows.Forms.Button btnCalcularReserva;
    }
}

