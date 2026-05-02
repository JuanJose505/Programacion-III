namespace RespawnHub
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnJuegos = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnBiblioteca = new System.Windows.Forms.Button();
            this.btnSesionesdeJuego = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Inter", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(99, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Respawn Hub";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(103, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bienvenido de vuelta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(104, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "¿Que jugaremos hoy?";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.btnJuegos);
            this.panel1.Controls.Add(this.btnUsuarios);
            this.panel1.Controls.Add(this.btnBiblioteca);
            this.panel1.Controls.Add(this.btnSesionesdeJuego);
            this.panel1.Location = new System.Drawing.Point(76, 207);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 151);
            this.panel1.TabIndex = 9;
            // 
            // btnJuegos
            // 
            this.btnJuegos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnJuegos.Image = ((System.Drawing.Image)(resources.GetObject("btnJuegos.Image")));
            this.btnJuegos.Location = new System.Drawing.Point(165, 0);
            this.btnJuegos.Margin = new System.Windows.Forms.Padding(2);
            this.btnJuegos.Name = "btnJuegos";
            this.btnJuegos.Size = new System.Drawing.Size(148, 151);
            this.btnJuegos.TabIndex = 5;
            this.btnJuegos.UseVisualStyleBackColor = true;
            this.btnJuegos.Click += new System.EventHandler(this.btnJuegos_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.Location = new System.Drawing.Point(0, 0);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(152, 149);
            this.btnUsuarios.TabIndex = 4;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnBiblioteca
            // 
            this.btnBiblioteca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBiblioteca.Image = ((System.Drawing.Image)(resources.GetObject("btnBiblioteca.Image")));
            this.btnBiblioteca.Location = new System.Drawing.Point(485, 0);
            this.btnBiblioteca.Margin = new System.Windows.Forms.Padding(2);
            this.btnBiblioteca.Name = "btnBiblioteca";
            this.btnBiblioteca.Size = new System.Drawing.Size(143, 149);
            this.btnBiblioteca.TabIndex = 7;
            this.btnBiblioteca.UseVisualStyleBackColor = true;
            this.btnBiblioteca.Click += new System.EventHandler(this.btnBiblioteca_Click);
            // 
            // btnSesionesdeJuego
            // 
            this.btnSesionesdeJuego.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSesionesdeJuego.Image = ((System.Drawing.Image)(resources.GetObject("btnSesionesdeJuego.Image")));
            this.btnSesionesdeJuego.Location = new System.Drawing.Point(325, 0);
            this.btnSesionesdeJuego.Margin = new System.Windows.Forms.Padding(2);
            this.btnSesionesdeJuego.Name = "btnSesionesdeJuego";
            this.btnSesionesdeJuego.Size = new System.Drawing.Size(146, 149);
            this.btnSesionesdeJuego.TabIndex = 6;
            this.btnSesionesdeJuego.UseVisualStyleBackColor = true;
            this.btnSesionesdeJuego.Click += new System.EventHandler(this.btnSesionesdeJuego_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::RespawnHub.Properties.Resources.image_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(778, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Text = "Respawn Hub";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnJuegos;
        private System.Windows.Forms.Button btnSesionesdeJuego;
        private System.Windows.Forms.Button btnBiblioteca;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Panel panel1;
    }
}

