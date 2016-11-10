namespace WindowsFormsApplication1
{
    partial class Calcolatrice
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.virgola = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.diviso = new System.Windows.Forms.Button();
            this.per = new System.Windows.Forms.Button();
            this.immissione = new System.Windows.Forms.TextBox();
            this.meno = new System.Windows.Forms.Button();
            this.storico = new System.Windows.Forms.TextBox();
            this.piu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // virgola
            // 
            this.virgola.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.virgola.Location = new System.Drawing.Point(112, 247);
            this.virgola.Name = "virgola";
            this.virgola.Size = new System.Drawing.Size(44, 40);
            this.virgola.TabIndex = 35;
            this.virgola.Text = ",";
            this.virgola.UseVisualStyleBackColor = true;
            this.virgola.Click += new System.EventHandler(this.virgola_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(162, 247);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(44, 40);
            this.clear.TabIndex = 34;
            this.clear.Text = "CE";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // b0
            // 
            this.b0.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b0.Location = new System.Drawing.Point(12, 247);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(94, 40);
            this.b0.TabIndex = 33;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // b1
            // 
            this.b1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(12, 201);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(44, 40);
            this.b1.TabIndex = 32;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b2
            // 
            this.b2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(62, 201);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(44, 40);
            this.b2.TabIndex = 31;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b3
            // 
            this.b3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Location = new System.Drawing.Point(112, 201);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(44, 40);
            this.b3.TabIndex = 30;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // equals
            // 
            this.equals.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equals.Location = new System.Drawing.Point(162, 109);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(44, 132);
            this.equals.TabIndex = 29;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // b6
            // 
            this.b6.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b6.Location = new System.Drawing.Point(112, 155);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(44, 40);
            this.b6.TabIndex = 28;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // b5
            // 
            this.b5.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b5.Location = new System.Drawing.Point(62, 155);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(44, 40);
            this.b5.TabIndex = 27;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b4
            // 
            this.b4.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b4.Location = new System.Drawing.Point(13, 155);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(44, 40);
            this.b4.TabIndex = 26;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b9
            // 
            this.b9.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b9.Location = new System.Drawing.Point(112, 109);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(44, 40);
            this.b9.TabIndex = 25;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // b8
            // 
            this.b8.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b8.Location = new System.Drawing.Point(62, 109);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(44, 40);
            this.b8.TabIndex = 24;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b7
            // 
            this.b7.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b7.Location = new System.Drawing.Point(13, 109);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(44, 40);
            this.b7.TabIndex = 23;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // diviso
            // 
            this.diviso.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diviso.Location = new System.Drawing.Point(162, 63);
            this.diviso.Name = "diviso";
            this.diviso.Size = new System.Drawing.Size(44, 40);
            this.diviso.TabIndex = 22;
            this.diviso.Text = "/";
            this.diviso.UseVisualStyleBackColor = true;
            this.diviso.Click += new System.EventHandler(this.diviso_Click);
            // 
            // per
            // 
            this.per.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.per.Location = new System.Drawing.Point(112, 63);
            this.per.Name = "per";
            this.per.Size = new System.Drawing.Size(44, 40);
            this.per.TabIndex = 21;
            this.per.Text = "*";
            this.per.UseVisualStyleBackColor = true;
            this.per.Click += new System.EventHandler(this.per_Click);
            // 
            // immissione
            // 
            this.immissione.Enabled = false;
            this.immissione.Location = new System.Drawing.Point(13, 37);
            this.immissione.Name = "immissione";
            this.immissione.Size = new System.Drawing.Size(193, 20);
            this.immissione.TabIndex = 20;
            // 
            // meno
            // 
            this.meno.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meno.Location = new System.Drawing.Point(62, 63);
            this.meno.Name = "meno";
            this.meno.Size = new System.Drawing.Size(44, 40);
            this.meno.TabIndex = 19;
            this.meno.Text = "-";
            this.meno.UseVisualStyleBackColor = true;
            this.meno.Click += new System.EventHandler(this.meno_Click);
            // 
            // storico
            // 
            this.storico.Enabled = false;
            this.storico.Location = new System.Drawing.Point(12, 10);
            this.storico.Name = "storico";
            this.storico.Size = new System.Drawing.Size(194, 20);
            this.storico.TabIndex = 18;
            // 
            // piu
            // 
            this.piu.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.piu.Location = new System.Drawing.Point(12, 63);
            this.piu.Name = "piu";
            this.piu.Size = new System.Drawing.Size(44, 40);
            this.piu.TabIndex = 17;
            this.piu.Text = "+";
            this.piu.UseVisualStyleBackColor = true;
            this.piu.Click += new System.EventHandler(this.piu_Click);
            // 
            // Calcolatrice
            // 
            this.AcceptButton = this.equals;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 298);
            this.Controls.Add(this.virgola);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.diviso);
            this.Controls.Add(this.per);
            this.Controls.Add(this.immissione);
            this.Controls.Add(this.meno);
            this.Controls.Add(this.storico);
            this.Controls.Add(this.piu);
            this.Name = "Calcolatrice";
            this.ShowIcon = false;
            this.Text = "Calcolatrice";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button virgola;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button diviso;
        private System.Windows.Forms.Button per;
        private System.Windows.Forms.TextBox immissione;
        private System.Windows.Forms.Button meno;
        private System.Windows.Forms.TextBox storico;
        private System.Windows.Forms.Button piu;
    }
}

