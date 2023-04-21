namespace EditordeGrafos
{
    partial class MuestraDijkstra
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
            this.caminoDijkstra = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // caminoDijkstra
            // 
            this.caminoDijkstra.Location = new System.Drawing.Point(12, 21);
            this.caminoDijkstra.Multiline = true;
            this.caminoDijkstra.Name = "caminoDijkstra";
            this.caminoDijkstra.Size = new System.Drawing.Size(297, 95);
            this.caminoDijkstra.TabIndex = 0;
            // 
            // MuestraDijkstra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.caminoDijkstra);
            this.Name = "MuestraDijkstra";
            this.Text = "MuestraDijkstra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox caminoDijkstra;
    }
}