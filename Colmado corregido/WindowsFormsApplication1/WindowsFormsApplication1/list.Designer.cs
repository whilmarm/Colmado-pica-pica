namespace WindowsFormsApplication1
{
    partial class list
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de producto";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Arroz Campos      $50 x lb",
            "Arroz La Garza     $74 x lb",
            "Arroz Rody          $25 x lb",
            "Huevo Don Juan  $7 x un",
            "Salimi Induveca   $70 x lb",
            "Salimi Whil         $150 x lb",
            "Pollo D´  Kurama $100 x lb",
            "Sopita Doña Gallina $10 x lb",
            "Sopita Goya           $15 x lb",
            "Aceite Crisol          $200 x med  $300 x gran",
            "Aceite dally          $350 x med  $450 x gran",
            "Fosforo                 $10 x unidad",
            "Harina de trigo     $25 x lb",
            "Harina de negrito $50 x unidad",
            "Harina Mazola      $60 x lb",
            "Maiz                       $15 x lb",
            "Macarrones           $100 x unidad",
            "Cheetos                 $15 x unidad",
            "Doritos                   $35 x unidad",
            "Frito Lay                 $30 x unidad",
            "Nosotras                $50 x unidad",
            "Queso amarillo      $120 x lb",
            "Queso blanco        $100 x lb",
            "Kotex                       $45 x unidad",
            "Chuleta                  $110 x lb",
            "Galleta                    $10 x unidad",
            "Pan                         $10 x unidad",
            "Agua Dasani          $25 x unidad ",
            "Agua Planeta Azul $75 x unidad",
            "Sal Refina                $15 x unidad  ",
            "Azucar Celia Morena $25 x lb",
            "Azucar Blanca $30 x lb",
            "Cebolla $80 x lb",
            "Aji Morron $50 x lb",
            "Aji cubanela $89 x lb"});
            this.comboBox1.Location = new System.Drawing.Point(12, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(260, 21);
            this.comboBox1.TabIndex = 1;

            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Menu;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LemonChiffon;
            this.button1.Location = new System.Drawing.Point(179, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 22);
            this.button1.TabIndex = 14;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(300, 157);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "list";
            this.Text = "list";
            this.Load += new System.EventHandler(this.list_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}