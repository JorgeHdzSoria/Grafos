namespace EditordeGrafos
{
    partial class MuestraKruskal
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
            this.caminoKruskalTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // caminoKruskalTextBox
            // 
            this.caminoKruskalTextBox.Location = new System.Drawing.Point(25, 13);
            this.caminoKruskalTextBox.Multiline = true;
            this.caminoKruskalTextBox.Name = "caminoKruskalTextBox";
            this.caminoKruskalTextBox.Size = new System.Drawing.Size(279, 98);
            this.caminoKruskalTextBox.TabIndex = 0;
            // 
            // MuestraKruskal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.caminoKruskalTextBox);
            this.Name = "MuestraKruskal";
            this.Text = "MuestraKruskal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox caminoKruskalTextBox;
    }
}