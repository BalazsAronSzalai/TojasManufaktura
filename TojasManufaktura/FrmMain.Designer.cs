namespace TojasManufaktura
{
    partial class FrmMain
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
            this.btnTermeles = new System.Windows.Forms.Button();
            this.btnStatisztika = new System.Windows.Forms.Button();
            this.btnKimutatas = new System.Windows.Forms.Button();
            this.btnKilepes = new System.Windows.Forms.Button();
            this.pBNyul = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBNyul)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTermeles
            // 
            this.btnTermeles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTermeles.Location = new System.Drawing.Point(13, 13);
            this.btnTermeles.Name = "btnTermeles";
            this.btnTermeles.Size = new System.Drawing.Size(192, 52);
            this.btnTermeles.TabIndex = 0;
            this.btnTermeles.Text = "Termelés";
            this.btnTermeles.UseVisualStyleBackColor = true;
            this.btnTermeles.Click += new System.EventHandler(this.btnTermeles_Click);
            // 
            // btnStatisztika
            // 
            this.btnStatisztika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStatisztika.Location = new System.Drawing.Point(13, 71);
            this.btnStatisztika.Name = "btnStatisztika";
            this.btnStatisztika.Size = new System.Drawing.Size(192, 52);
            this.btnStatisztika.TabIndex = 1;
            this.btnStatisztika.Text = "Statisztika";
            this.btnStatisztika.UseVisualStyleBackColor = true;
            this.btnStatisztika.Click += new System.EventHandler(this.btnStatisztika_Click);
            // 
            // btnKimutatas
            // 
            this.btnKimutatas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKimutatas.Location = new System.Drawing.Point(13, 129);
            this.btnKimutatas.Name = "btnKimutatas";
            this.btnKimutatas.Size = new System.Drawing.Size(192, 52);
            this.btnKimutatas.TabIndex = 2;
            this.btnKimutatas.Text = "Kimutatás";
            this.btnKimutatas.UseVisualStyleBackColor = true;
            // 
            // btnKilepes
            // 
            this.btnKilepes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKilepes.Location = new System.Drawing.Point(13, 187);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(192, 52);
            this.btnKilepes.TabIndex = 3;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.UseVisualStyleBackColor = true;
            this.btnKilepes.Click += new System.EventHandler(this.btnKilepes_Click);
            // 
            // pBNyul
            // 
            this.pBNyul.Location = new System.Drawing.Point(212, 13);
            this.pBNyul.Name = "pBNyul";
            this.pBNyul.Size = new System.Drawing.Size(478, 235);
            this.pBNyul.TabIndex = 4;
            this.pBNyul.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 260);
            this.Controls.Add(this.pBNyul);
            this.Controls.Add(this.btnKilepes);
            this.Controls.Add(this.btnKimutatas);
            this.Controls.Add(this.btnStatisztika);
            this.Controls.Add(this.btnTermeles);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBNyul)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTermeles;
        private System.Windows.Forms.Button btnStatisztika;
        private System.Windows.Forms.Button btnKimutatas;
        private System.Windows.Forms.Button btnKilepes;
        private System.Windows.Forms.PictureBox pBNyul;
    }
}

