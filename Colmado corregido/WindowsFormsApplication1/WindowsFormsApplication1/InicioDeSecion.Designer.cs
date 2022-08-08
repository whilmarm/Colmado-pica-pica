namespace WindowsFormsApplication1
{
    partial class InicioDeSecion
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
            this.BTLimpiar = new System.Windows.Forms.Button();
            this.BTIniciarSecion = new System.Windows.Forms.Button();
            this.TBPass = new System.Windows.Forms.TextBox();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.LBPass = new System.Windows.Forms.Label();
            this.BTNombre = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTLimpiar
            // 
            this.BTLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTLimpiar.Location = new System.Drawing.Point(111, 248);
            this.BTLimpiar.Name = "BTLimpiar";
            this.BTLimpiar.Size = new System.Drawing.Size(94, 47);
            this.BTLimpiar.TabIndex = 11;
            this.BTLimpiar.Text = "Limpiar";
            this.BTLimpiar.UseVisualStyleBackColor = true;
            // 
            // BTIniciarSecion
            // 
            this.BTIniciarSecion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BTIniciarSecion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTIniciarSecion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTIniciarSecion.Location = new System.Drawing.Point(230, 248);
            this.BTIniciarSecion.Name = "BTIniciarSecion";
            this.BTIniciarSecion.Size = new System.Drawing.Size(97, 47);
            this.BTIniciarSecion.TabIndex = 10;
            this.BTIniciarSecion.Text = "Iniciar Sesion";
            this.BTIniciarSecion.UseVisualStyleBackColor = true;
            this.BTIniciarSecion.Click += new System.EventHandler(this.BTIniciarSecion_Click);
            // 
            // TBPass
            // 
            this.TBPass.Location = new System.Drawing.Point(163, 100);
            this.TBPass.Name = "TBPass";
            this.TBPass.Size = new System.Drawing.Size(147, 20);
            this.TBPass.TabIndex = 9;
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(132, 64);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(147, 20);
            this.TBNombre.TabIndex = 8;
            // 
            // LBPass
            // 
            this.LBPass.AutoSize = true;
            this.LBPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBPass.Location = new System.Drawing.Point(55, 100);
            this.LBPass.Name = "LBPass";
            this.LBPass.Size = new System.Drawing.Size(102, 20);
            this.LBPass.TabIndex = 7;
            this.LBPass.Text = "Contraseña";
            // 
            // BTNombre
            // 
            this.BTNombre.AutoSize = true;
            this.BTNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNombre.Location = new System.Drawing.Point(55, 62);
            this.BTNombre.Name = "BTNombre";
            this.BTNombre.Size = new System.Drawing.Size(71, 20);
            this.BTNombre.TabIndex = 6;
            this.BTNombre.Text = "Nombre";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(352, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InicioDeSecion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.detalle_tarjeta_sobre_guia_de_catas4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(383, 332);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTLimpiar);
            this.Controls.Add(this.BTIniciarSecion);
            this.Controls.Add(this.TBPass);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.LBPass);
            this.Controls.Add(this.BTNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InicioDeSecion";
            this.Text = "InicioDeSecion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTLimpiar;
        private System.Windows.Forms.Button BTIniciarSecion;
        private System.Windows.Forms.TextBox TBPass;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.Label LBPass;
        private System.Windows.Forms.Label BTNombre;
        private System.Windows.Forms.Button button1;
    }
}