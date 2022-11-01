namespace aula7
{
    partial class fmhelloword
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAperteAqui_Click = new System.Windows.Forms.Button();
            this.iblAperte = new System.Windows.Forms.Label();
            this.iblTexto2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAperteAqui_Click
            // 
            this.btnAperteAqui_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAperteAqui_Click.Location = new System.Drawing.Point(164, 83);
            this.btnAperteAqui_Click.Name = "btnAperteAqui_Click";
            this.btnAperteAqui_Click.Size = new System.Drawing.Size(141, 50);
            this.btnAperteAqui_Click.TabIndex = 0;
            this.btnAperteAqui_Click.Text = "Aperte aqui!";
            this.btnAperteAqui_Click.UseVisualStyleBackColor = true;
            this.btnAperteAqui_Click.Click += new System.EventHandler(this.btnHelloWorld_Click);
            // 
            // iblAperte
            // 
            this.iblAperte.AutoSize = true;
            this.iblAperte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iblAperte.Location = new System.Drawing.Point(194, 151);
            this.iblAperte.Name = "iblAperte";
            this.iblAperte.Size = new System.Drawing.Size(82, 25);
            this.iblAperte.TabIndex = 1;
            this.iblAperte.Text = "TEXTO";
            // 
            // iblTexto2
            // 
            this.iblTexto2.AutoSize = true;
            this.iblTexto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iblTexto2.Location = new System.Drawing.Point(195, 46);
            this.iblTexto2.Name = "iblTexto2";
            this.iblTexto2.Size = new System.Drawing.Size(74, 20);
            this.iblTexto2.TabIndex = 2;
            this.iblTexto2.Text = "TEXTO 2";
            // 
            // fmhelloword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 226);
            this.Controls.Add(this.iblTexto2);
            this.Controls.Add(this.iblAperte);
            this.Controls.Add(this.btnAperteAqui_Click);
            this.Name = "fmhelloword";
            this.Text = "Aula 7";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAperteAqui_Click;
        private System.Windows.Forms.Label iblAperte;
        private System.Windows.Forms.Label iblTexto2;
    }
}

