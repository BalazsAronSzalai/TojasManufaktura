namespace TojasManufaktura
{
    partial class FrmTermeles
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dTPDatum = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cBTojas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nUDMenny = new System.Windows.Forms.NumericUpDown();
            this.cBMunkas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnFelvetel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMenny)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(13, 13);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(589, 237);
            this.dgv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dátum:";
            // 
            // dTPDatum
            // 
            this.dTPDatum.Location = new System.Drawing.Point(13, 285);
            this.dTPDatum.Name = "dTPDatum";
            this.dTPDatum.Size = new System.Drawing.Size(131, 20);
            this.dTPDatum.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tojás:";
            // 
            // cBTojas
            // 
            this.cBTojas.FormattingEnabled = true;
            this.cBTojas.Location = new System.Drawing.Point(178, 283);
            this.cBTojas.Name = "cBTojas";
            this.cBTojas.Size = new System.Drawing.Size(90, 21);
            this.cBTojas.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mennyiség:";
            // 
            // nUDMenny
            // 
            this.nUDMenny.Location = new System.Drawing.Point(298, 285);
            this.nUDMenny.Name = "nUDMenny";
            this.nUDMenny.Size = new System.Drawing.Size(76, 20);
            this.nUDMenny.TabIndex = 6;
            // 
            // cBMunkas
            // 
            this.cBMunkas.FormattingEnabled = true;
            this.cBMunkas.Location = new System.Drawing.Point(397, 283);
            this.cBMunkas.Name = "cBMunkas";
            this.cBMunkas.Size = new System.Drawing.Size(205, 21);
            this.cBMunkas.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(397, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Munkás:";
            // 
            // BtnFelvetel
            // 
            this.BtnFelvetel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnFelvetel.Location = new System.Drawing.Point(16, 312);
            this.BtnFelvetel.Name = "BtnFelvetel";
            this.BtnFelvetel.Size = new System.Drawing.Size(586, 30);
            this.BtnFelvetel.TabIndex = 9;
            this.BtnFelvetel.Text = "Új bejegyzés felvétele";
            this.BtnFelvetel.UseVisualStyleBackColor = true;
            this.BtnFelvetel.Click += new System.EventHandler(this.BtnFelvetel_Click);
            // 
            // FrmTermeles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 354);
            this.Controls.Add(this.BtnFelvetel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cBMunkas);
            this.Controls.Add(this.nUDMenny);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cBTojas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dTPDatum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.Name = "FrmTermeles";
            this.Text = "Termelés";
            this.Load += new System.EventHandler(this.FrmTermeles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMenny)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dTPDatum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBTojas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nUDMenny;
        private System.Windows.Forms.ComboBox cBMunkas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnFelvetel;
    }
}