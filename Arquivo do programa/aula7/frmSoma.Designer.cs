namespace aula7
{
    partial class frmSoma
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
            this.lblValor1 = new System.Windows.Forms.Label();
            this.iblValor2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSomar = new System.Windows.Forms.Button();
            this.txtV1 = new System.Windows.Forms.TextBox();
            this.txtV2 = new System.Windows.Forms.TextBox();
            this.txtSoma = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor1.Location = new System.Drawing.Point(92, 88);
            this.lblValor1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(69, 24);
            this.lblValor1.TabIndex = 0;
            this.lblValor1.Text = "Valor 1";
            // 
            // iblValor2
            // 
            this.iblValor2.AutoSize = true;
            this.iblValor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iblValor2.Location = new System.Drawing.Point(92, 142);
            this.iblValor2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.iblValor2.Name = "iblValor2";
            this.iblValor2.Size = new System.Drawing.Size(69, 24);
            this.iblValor2.TabIndex = 1;
            this.iblValor2.Text = "Valor 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 328);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soma";
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(195, 208);
            this.btnSomar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(262, 69);
            this.btnSomar.TabIndex = 3;
            this.btnSomar.Text = "Somar";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // txtV1
            // 
            this.txtV1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtV1.Location = new System.Drawing.Point(195, 88);
            this.txtV1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtV1.Name = "txtV1";
            this.txtV1.Size = new System.Drawing.Size(260, 26);
            this.txtV1.TabIndex = 4;
            // 
            // txtV2
            // 
            this.txtV2.Location = new System.Drawing.Point(195, 142);
            this.txtV2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtV2.Name = "txtV2";
            this.txtV2.Size = new System.Drawing.Size(260, 26);
            this.txtV2.TabIndex = 5;
            // 
            // txtSoma
            // 
            this.txtSoma.Enabled = false;
            this.txtSoma.Location = new System.Drawing.Point(195, 326);
            this.txtSoma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoma.Name = "txtSoma";
            this.txtSoma.Size = new System.Drawing.Size(260, 26);
            this.txtSoma.TabIndex = 6;
            this.txtSoma.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // frmSoma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 474);
            this.Controls.Add(this.txtSoma);
            this.Controls.Add(this.txtV2);
            this.Controls.Add(this.txtV1);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iblValor2);
            this.Controls.Add(this.lblValor1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSoma";
            this.Text = "Programa de Soma";
            this.Load += new System.EventHandler(this.frmSoma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.Label iblValor2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.TextBox txtV1;
        private System.Windows.Forms.TextBox txtV2;
        private System.Windows.Forms.TextBox txtSoma;
    }
}