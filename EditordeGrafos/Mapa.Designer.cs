namespace EditordeGrafos
{
    partial class Mapa
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
            this.caminoTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Whiterun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matriz = new System.Windows.Forms.Button();
            this.Solitude = new System.Windows.Forms.CheckBox();
            this.TheReach = new System.Windows.Forms.CheckBox();
            this.FalkreathHold = new System.Windows.Forms.CheckBox();
            this.WinterHold = new System.Windows.Forms.CheckBox();
            this.Rift = new System.Windows.Forms.CheckBox();
            this.EastMarch = new System.Windows.Forms.CheckBox();
            this.Whiteruners = new System.Windows.Forms.CheckBox();
            this.ThePale = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // caminoTextBox
            // 
            this.caminoTextBox.Location = new System.Drawing.Point(12, 13);
            this.caminoTextBox.Multiline = true;
            this.caminoTextBox.Name = "caminoTextBox";
            this.caminoTextBox.Size = new System.Drawing.Size(259, 184);
            this.caminoTextBox.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EditordeGrafos.Properties.Resources.the_map_of_skyrim_by_theonepistol_lg_3994207351;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(323, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(469, 323);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Whiterun});
            this.dataGridView1.Location = new System.Drawing.Point(12, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(259, 235);
            this.dataGridView1.TabIndex = 2;
            // 
            // Whiterun
            // 
            this.Whiterun.HeaderText = "Region";
            this.Whiterun.Name = "Whiterun";
            // 
            // Matriz
            // 
            this.Matriz.Location = new System.Drawing.Point(511, 75);
            this.Matriz.Name = "Matriz";
            this.Matriz.Size = new System.Drawing.Size(114, 23);
            this.Matriz.TabIndex = 3;
            this.Matriz.Text = "MuestraMatriz";
            this.Matriz.UseVisualStyleBackColor = true;
            this.Matriz.Click += new System.EventHandler(this.Matriz_Click);
            // 
            // Solitude
            // 
            this.Solitude.AutoSize = true;
            this.Solitude.Location = new System.Drawing.Point(426, 148);
            this.Solitude.Name = "Solitude";
            this.Solitude.Size = new System.Drawing.Size(64, 17);
            this.Solitude.TabIndex = 4;
            this.Solitude.Text = "Solitude";
            this.Solitude.UseVisualStyleBackColor = true;
            this.Solitude.CheckedChanged += new System.EventHandler(this.Solitude_CheckedChanged);
            // 
            // TheReach
            // 
            this.TheReach.AutoSize = true;
            this.TheReach.Location = new System.Drawing.Point(352, 269);
            this.TheReach.Name = "TheReach";
            this.TheReach.Size = new System.Drawing.Size(77, 17);
            this.TheReach.TabIndex = 5;
            this.TheReach.Text = "TheReach";
            this.TheReach.UseVisualStyleBackColor = true;
            this.TheReach.CheckedChanged += new System.EventHandler(this.TheReach_CheckedChanged);
            // 
            // FalkreathHold
            // 
            this.FalkreathHold.AutoSize = true;
            this.FalkreathHold.Location = new System.Drawing.Point(511, 377);
            this.FalkreathHold.Name = "FalkreathHold";
            this.FalkreathHold.Size = new System.Drawing.Size(92, 17);
            this.FalkreathHold.TabIndex = 6;
            this.FalkreathHold.Text = "FalkreathHold";
            this.FalkreathHold.UseVisualStyleBackColor = true;
            this.FalkreathHold.CheckedChanged += new System.EventHandler(this.FalkreathHold_CheckedChanged);
            // 
            // WinterHold
            // 
            this.WinterHold.AutoSize = true;
            this.WinterHold.Location = new System.Drawing.Point(632, 163);
            this.WinterHold.Name = "WinterHold";
            this.WinterHold.Size = new System.Drawing.Size(79, 17);
            this.WinterHold.TabIndex = 7;
            this.WinterHold.Text = "WinterHold";
            this.WinterHold.UseVisualStyleBackColor = true;
            this.WinterHold.CheckedChanged += new System.EventHandler(this.WinterHold_CheckedChanged);
            // 
            // Rift
            // 
            this.Rift.AutoSize = true;
            this.Rift.Location = new System.Drawing.Point(703, 362);
            this.Rift.Name = "Rift";
            this.Rift.Size = new System.Drawing.Size(42, 17);
            this.Rift.TabIndex = 8;
            this.Rift.Text = "Rift";
            this.Rift.UseVisualStyleBackColor = true;
            this.Rift.CheckedChanged += new System.EventHandler(this.Rift_CheckedChanged);
            // 
            // EastMarch
            // 
            this.EastMarch.AutoSize = true;
            this.EastMarch.Location = new System.Drawing.Point(703, 300);
            this.EastMarch.Name = "EastMarch";
            this.EastMarch.Size = new System.Drawing.Size(77, 17);
            this.EastMarch.TabIndex = 9;
            this.EastMarch.Text = "EastMarch";
            this.EastMarch.UseVisualStyleBackColor = true;
            this.EastMarch.CheckedChanged += new System.EventHandler(this.EastMarch_CheckedChanged);
            // 
            // Whiteruners
            // 
            this.Whiteruners.AutoSize = true;
            this.Whiteruners.Location = new System.Drawing.Point(549, 288);
            this.Whiteruners.Name = "Whiteruners";
            this.Whiteruners.Size = new System.Drawing.Size(69, 17);
            this.Whiteruners.TabIndex = 10;
            this.Whiteruners.Text = "Whiterun";
            this.Whiteruners.UseVisualStyleBackColor = true;
            this.Whiteruners.CheckedChanged += new System.EventHandler(this.Whiterun_CheckedChanged);
            // 
            // ThePale
            // 
            this.ThePale.AutoSize = true;
            this.ThePale.Location = new System.Drawing.Point(575, 203);
            this.ThePale.Name = "ThePale";
            this.ThePale.Size = new System.Drawing.Size(66, 17);
            this.ThePale.TabIndex = 11;
            this.ThePale.Text = "ThePale";
            this.ThePale.UseVisualStyleBackColor = true;
            this.ThePale.CheckedChanged += new System.EventHandler(this.ThePale_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Empezar recorrido";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Mapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ThePale);
            this.Controls.Add(this.Whiteruners);
            this.Controls.Add(this.EastMarch);
            this.Controls.Add(this.Rift);
            this.Controls.Add(this.WinterHold);
            this.Controls.Add(this.FalkreathHold);
            this.Controls.Add(this.TheReach);
            this.Controls.Add(this.Solitude);
            this.Controls.Add(this.Matriz);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.caminoTextBox);
            this.Name = "Mapa";
            this.Text = "Mapa";
            this.Click += new System.EventHandler(this.button1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox caminoTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Whiterun;
        private System.Windows.Forms.Button Matriz;
        private System.Windows.Forms.CheckBox Solitude;
        private System.Windows.Forms.CheckBox TheReach;
        private System.Windows.Forms.CheckBox FalkreathHold;
        private System.Windows.Forms.CheckBox WinterHold;
        private System.Windows.Forms.CheckBox Rift;
        private System.Windows.Forms.CheckBox EastMarch;
        private System.Windows.Forms.CheckBox Whiteruners;
        private System.Windows.Forms.CheckBox ThePale;
        private System.Windows.Forms.Button button1;
    }
}