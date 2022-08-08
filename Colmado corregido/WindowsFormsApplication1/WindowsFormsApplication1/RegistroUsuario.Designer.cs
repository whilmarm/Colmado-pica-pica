namespace WindowsFormsApplication1
{
    partial class RegistroUsuario
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
            this.BTNombre = new System.Windows.Forms.Label();
            this.LBPass = new System.Windows.Forms.Label();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.TBPass = new System.Windows.Forms.TextBox();
            this.Registrar = new System.Windows.Forms.Button();
            this.BTLimpiar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTNombre
            // 
            this.BTNombre.AutoSize = true;
            this.BTNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNombre.Location = new System.Drawing.Point(34, 54);
            this.BTNombre.Name = "BTNombre";
            this.BTNombre.Size = new System.Drawing.Size(71, 20);
            this.BTNombre.TabIndex = 0;
            this.BTNombre.Text = "Nombre";
            // 
            // LBPass
            // 
            this.LBPass.AutoSize = true;
            this.LBPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBPass.Location = new System.Drawing.Point(34, 92);
            this.LBPass.Name = "LBPass";
            this.LBPass.Size = new System.Drawing.Size(102, 20);
            this.LBPass.TabIndex = 1;
            this.LBPass.Text = "Contraseña";
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(111, 56);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(147, 20);
            this.TBNombre.TabIndex = 2;
            // 
            // TBPass
            // 
            this.TBPass.Location = new System.Drawing.Point(142, 92);
            this.TBPass.Name = "TBPass";
            this.TBPass.Size = new System.Drawing.Size(147, 20);
            this.TBPass.TabIndex = 3;
            // 
            // Registrar
            // 
            this.Registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrar.Location = new System.Drawing.Point(196, 240);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(93, 35);
            this.Registrar.TabIndex = 4;
            this.Registrar.Text = "Registrar";
            this.Registrar.UseVisualStyleBackColor = true;
            this.Registrar.Click += new System.EventHandler(this.Registrar_Click);
            // 
            // BTLimpiar
            // 
            this.BTLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTLimpiar.Location = new System.Drawing.Point(90, 240);
            this.BTLimpiar.Name = "BTLimpiar";
            this.BTLimpiar.Size = new System.Drawing.Size(88, 35);
            this.BTLimpiar.TabIndex = 5;
            this.BTLimpiar.Text = "Limpiar";
            this.BTLimpiar.UseVisualStyleBackColor = true;
            this.BTLimpiar.Click += new System.EventHandler(this.BTLimpiar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(306, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.detalle_tarjeta_sobre_guia_de_catas3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(337, 310);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTLimpiar);
            this.Controls.Add(this.Registrar);
            this.Controls.Add(this.TBPass);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.LBPass);
            this.Controls.Add(this.BTNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroUsuario";
            this.Text = "RegistroUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BTNombre;
        private System.Windows.Forms.Label LBPass;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.TextBox TBPass;
        private System.Windows.Forms.Button Registrar;
        private System.Windows.Forms.Button BTLimpiar;
        private System.Windows.Forms.Button button1;
    }
}