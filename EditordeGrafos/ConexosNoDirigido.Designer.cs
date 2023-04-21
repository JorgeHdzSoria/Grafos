namespace EditordeGrafos
{
    partial class ConexosNoDirigido
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
            this.NodoInicial = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NodoInicial
            // 
            this.NodoInicial.Location = new System.Drawing.Point(12, 12);
            this.NodoInicial.Multiline = true;
            this.NodoInicial.Name = "NodoInicial";
            this.NodoInicial.Size = new System.Drawing.Size(410, 195);
            this.NodoInicial.TabIndex = 0;
            // 
            // ConexosNoDirigido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NodoInicial);
            this.Name = "ConexosNoDirigido";
            this.Text = "ConexosNoDirigido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NodoInicial;
    }
}