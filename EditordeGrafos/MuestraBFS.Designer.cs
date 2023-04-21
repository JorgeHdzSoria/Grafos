namespace EditordeGrafos
{
    partial class Amplitud
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
            this.textBoxBFS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxBFS
            // 
            this.textBoxBFS.Location = new System.Drawing.Point(12, 12);
            this.textBoxBFS.Multiline = true;
            this.textBoxBFS.Name = "textBoxBFS";
            this.textBoxBFS.Size = new System.Drawing.Size(306, 67);
            this.textBoxBFS.TabIndex = 0;
            // 
            // Amplitud
            // 
            this.ClientSize = new System.Drawing.Size(676, 444);
            this.Controls.Add(this.textBoxBFS);
            this.Name = "Amplitud";
            this.Text = "Busqueda en amplitud";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxBFS;
    }
}