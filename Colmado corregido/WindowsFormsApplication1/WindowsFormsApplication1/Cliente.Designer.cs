namespace WindowsFormsApplication1
{
    partial class Cliente
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
            this.BNombre = new System.Windows.Forms.Label();
            this.BDireccion = new System.Windows.Forms.Label();
            this.BNumero = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.BEmail = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BNombre
            // 
            this.BNombre.AutoSize = true;
            this.BNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BNombre.Location = new System.Drawing.Point(12, 55);
            this.BNombre.Name = "BNombre";
            this.BNombre.Size = new System.Drawing.Size(76, 20);
            this.BNombre.TabIndex = 0;
            this.BNombre.Text = "Nombre:";
            // 
            // BDireccion
            // 
            this.BDireccion.AutoSize = true;
            this.BDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BDireccion.Location = new System.Drawing.Point(12, 118);
            this.BDireccion.Name = "BDireccion";
            this.BDireccion.Size = new System.Drawing.Size(89, 20);
            this.BDireccion.TabIndex = 1;
            this.BDireccion.Text = "Direccion:";
            // 
            // BNumero
            // 
            this.BNumero.AutoSize = true;
            this.BNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BNumero.Location = new System.Drawing.Point(12, 86);
            this.BNumero.Name = "BNumero";
            this.BNumero.Size = new System.Drawing.Size(76, 20);
            this.BNumero.TabIndex = 2;
            this.BNumero.Text = "Numero:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(102, 86);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(170, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(102, 118);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(170, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(102, 149);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(170, 20);
            this.textBox4.TabIndex = 9;
            // 
            // BEmail
            // 
            this.BEmail.AutoSize = true;
            this.BEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEmail.Location = new System.Drawing.Point(12, 149);
            this.BEmail.Name = "BEmail";
            this.BEmail.Size = new System.Drawing.Size(64, 20);
            this.BEmail.TabIndex = 11;
            this.BEmail.Text = "E-mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Datos del cliente";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(309, 251);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BEmail);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BNumero);
            this.Controls.Add(this.BDireccion);
            this.Controls.Add(this.BNombre);
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BNombre;
        private System.Windows.Forms.Label BDireccion;
        private System.Windows.Forms.Label BNumero;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label BEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}