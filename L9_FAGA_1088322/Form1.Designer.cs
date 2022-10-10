namespace L9_FAGA_1088322
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_modelo = new System.Windows.Forms.TextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.MODELO = new System.Windows.Forms.Label();
            this.DISPONIBLE = new System.Windows.Forms.Label();
            this.DESCUENTOAPLICADO = new System.Windows.Forms.Label();
            this.TIPOCAMBIODOLAR = new System.Windows.Forms.Label();
            this.PRECIO = new System.Windows.Forms.Label();
            this.MARCA = new System.Windows.Forms.Label();
            this.txt_descuentoaplicado = new System.Windows.Forms.TextBox();
            this.txt_tipocambiodolar = new System.Windows.Forms.TextBox();
            this.txt_disponible = new System.Windows.Forms.TextBox();
            this.txt_marca = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.btn_GUARDAR = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_modelo
            // 
            this.txt_modelo.Location = new System.Drawing.Point(94, 121);
            this.txt_modelo.Name = "txt_modelo";
            this.txt_modelo.Size = new System.Drawing.Size(125, 27);
            this.txt_modelo.TabIndex = 0;
            this.txt_modelo.TextChanged += new System.EventHandler(this.txt__TextChanged);
            // 
            // MODELO
            // 
            this.MODELO.AutoSize = true;
            this.MODELO.Location = new System.Drawing.Point(94, 98);
            this.MODELO.Name = "MODELO";
            this.MODELO.Size = new System.Drawing.Size(69, 20);
            this.MODELO.TabIndex = 1;
            this.MODELO.Text = "MODELO";
            // 
            // DISPONIBLE
            // 
            this.DISPONIBLE.AutoSize = true;
            this.DISPONIBLE.Location = new System.Drawing.Point(526, 98);
            this.DISPONIBLE.Name = "DISPONIBLE";
            this.DISPONIBLE.Size = new System.Drawing.Size(90, 20);
            this.DISPONIBLE.TabIndex = 2;
            this.DISPONIBLE.Text = "DISPONIBLE";
            // 
            // DESCUENTOAPLICADO
            // 
            this.DESCUENTOAPLICADO.AutoSize = true;
            this.DESCUENTOAPLICADO.Location = new System.Drawing.Point(243, 169);
            this.DESCUENTOAPLICADO.Name = "DESCUENTOAPLICADO";
            this.DESCUENTOAPLICADO.Size = new System.Drawing.Size(162, 20);
            this.DESCUENTOAPLICADO.TabIndex = 3;
            this.DESCUENTOAPLICADO.Text = "DESCUENTOAPLICADO";
            // 
            // TIPOCAMBIODOLAR
            // 
            this.TIPOCAMBIODOLAR.AutoSize = true;
            this.TIPOCAMBIODOLAR.Location = new System.Drawing.Point(94, 169);
            this.TIPOCAMBIODOLAR.Name = "TIPOCAMBIODOLAR";
            this.TIPOCAMBIODOLAR.Size = new System.Drawing.Size(144, 20);
            this.TIPOCAMBIODOLAR.TabIndex = 4;
            this.TIPOCAMBIODOLAR.Text = "TIPOCAMBIODOLAR";
            // 
            // PRECIO
            // 
            this.PRECIO.AutoSize = true;
            this.PRECIO.Location = new System.Drawing.Point(243, 98);
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.Size = new System.Drawing.Size(58, 20);
            this.PRECIO.TabIndex = 6;
            this.PRECIO.Text = "PRECIO";
            // 
            // MARCA
            // 
            this.MARCA.AutoSize = true;
            this.MARCA.Location = new System.Drawing.Point(384, 98);
            this.MARCA.Name = "MARCA";
            this.MARCA.Size = new System.Drawing.Size(60, 20);
            this.MARCA.TabIndex = 7;
            this.MARCA.Text = "MARCA";
            // 
            // txt_descuentoaplicado
            // 
            this.txt_descuentoaplicado.Location = new System.Drawing.Point(243, 192);
            this.txt_descuentoaplicado.Name = "txt_descuentoaplicado";
            this.txt_descuentoaplicado.Size = new System.Drawing.Size(125, 27);
            this.txt_descuentoaplicado.TabIndex = 8;
            // 
            // txt_tipocambiodolar
            // 
            this.txt_tipocambiodolar.Location = new System.Drawing.Point(94, 192);
            this.txt_tipocambiodolar.Name = "txt_tipocambiodolar";
            this.txt_tipocambiodolar.Size = new System.Drawing.Size(125, 27);
            this.txt_tipocambiodolar.TabIndex = 9;
            // 
            // txt_disponible
            // 
            this.txt_disponible.Location = new System.Drawing.Point(526, 121);
            this.txt_disponible.Name = "txt_disponible";
            this.txt_disponible.Size = new System.Drawing.Size(125, 27);
            this.txt_disponible.TabIndex = 10;
            // 
            // txt_marca
            // 
            this.txt_marca.Location = new System.Drawing.Point(384, 121);
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.Size = new System.Drawing.Size(125, 27);
            this.txt_marca.TabIndex = 11;
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(243, 121);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(125, 27);
            this.txt_precio.TabIndex = 12;
            // 
            // btn_GUARDAR
            // 
            this.btn_GUARDAR.Location = new System.Drawing.Point(243, 330);
            this.btn_GUARDAR.Name = "btn_GUARDAR";
            this.btn_GUARDAR.Size = new System.Drawing.Size(113, 28);
            this.btn_GUARDAR.TabIndex = 13;
            this.btn_GUARDAR.Text = "GUARDAR";
            this.btn_GUARDAR.UseVisualStyleBackColor = true;
            this.btn_GUARDAR.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(415, 327);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(113, 28);
            this.btn_limpiar.TabIndex = 14;
            this.btn_limpiar.Text = "LIMPIAR";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Prueba de Suma";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_GUARDAR);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_marca);
            this.Controls.Add(this.txt_disponible);
            this.Controls.Add(this.txt_tipocambiodolar);
            this.Controls.Add(this.txt_descuentoaplicado);
            this.Controls.Add(this.MARCA);
            this.Controls.Add(this.PRECIO);
            this.Controls.Add(this.TIPOCAMBIODOLAR);
            this.Controls.Add(this.DESCUENTOAPLICADO);
            this.Controls.Add(this.DISPONIBLE);
            this.Controls.Add(this.MODELO);
            this.Controls.Add(this.txt_modelo);
            this.Name = "Form1";
            this.Text = "MARCA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_modelo;
        private FontDialog fontDialog1;
        private Label MODELO;
        private Label DISPONIBLE;
        private Label DESCUENTOAPLICADO;
        private Label TIPOCAMBIODOLAR;
        private Label PRECIO;
        private Label MARCA;
        private TextBox txt_descuentoaplicado;
        private TextBox txt_tipocambiodolar;
        private TextBox txt_disponible;
        private TextBox txt_marca;
        private TextBox txt_precio;
        private Button btn_GUARDAR;
        private Button btn_limpiar;
        private Label label1;
    }
}