namespace zanyatie
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBok = new System.Windows.Forms.Label();
            this.lblObwod = new System.Windows.Forms.Label();
            this.lblPole = new System.Windows.Forms.Label();
            this.lblKomunikat = new System.Windows.Forms.Label();
            this.txtBok = new System.Windows.Forms.TextBox();
            this.txtObwod = new System.Windows.Forms.TextBox();
            this.txtPole = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBok
            // 
            this.lblBok.AutoSize = true;
            this.lblBok.Location = new System.Drawing.Point(35, 51);
            this.lblBok.Name = "lblBok";
            this.lblBok.Size = new System.Drawing.Size(26, 13);
            this.lblBok.TabIndex = 1;
            this.lblBok.Text = "Bok";
            this.lblBok.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblObwod
            // 
            this.lblObwod.AutoSize = true;
            this.lblObwod.Location = new System.Drawing.Point(22, 111);
            this.lblObwod.Name = "lblObwod";
            this.lblObwod.Size = new System.Drawing.Size(41, 13);
            this.lblObwod.TabIndex = 2;
            this.lblObwod.Text = "Obwod";
            // 
            // lblPole
            // 
            this.lblPole.AutoSize = true;
            this.lblPole.Location = new System.Drawing.Point(35, 171);
            this.lblPole.Name = "lblPole";
            this.lblPole.Size = new System.Drawing.Size(28, 13);
            this.lblPole.TabIndex = 3;
            this.lblPole.Text = "Pole";
            // 
            // lblKomunikat
            // 
            this.lblKomunikat.AutoSize = true;
            this.lblKomunikat.ForeColor = System.Drawing.Color.Red;
            this.lblKomunikat.Location = new System.Drawing.Point(269, 51);
            this.lblKomunikat.Name = "lblKomunikat";
            this.lblKomunikat.Size = new System.Drawing.Size(0, 13);
            this.lblKomunikat.TabIndex = 4;
            // 
            // txtBok
            // 
            this.txtBok.Location = new System.Drawing.Point(105, 44);
            this.txtBok.Name = "txtBok";
            this.txtBok.Size = new System.Drawing.Size(100, 20);
            this.txtBok.TabIndex = 6;
            this.txtBok.TextChanged += new System.EventHandler(this.txtBok_TextChanged);
            // 
            // txtObwod
            // 
            this.txtObwod.Enabled = false;
            this.txtObwod.Location = new System.Drawing.Point(105, 104);
            this.txtObwod.Name = "txtObwod";
            this.txtObwod.Size = new System.Drawing.Size(100, 20);
            this.txtObwod.TabIndex = 7;
            this.txtObwod.TextChanged += new System.EventHandler(this.txtObwod_TextChanged);
            // 
            // txtPole
            // 
            this.txtPole.Enabled = false;
            this.txtPole.Location = new System.Drawing.Point(105, 164);
            this.txtPole.Name = "txtPole";
            this.txtPole.Size = new System.Drawing.Size(100, 20);
            this.txtPole.TabIndex = 8;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(73, 247);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Wyczyscz";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(154, 247);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Zamknij";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtPole);
            this.Controls.Add(this.txtObwod);
            this.Controls.Add(this.txtBok);
            this.Controls.Add(this.lblKomunikat);
            this.Controls.Add(this.lblPole);
            this.Controls.Add(this.lblObwod);
            this.Controls.Add(this.lblBok);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kwadrat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBok;
        private System.Windows.Forms.Label lblObwod;
        private System.Windows.Forms.Label lblPole;
        private System.Windows.Forms.Label lblKomunikat;
        private System.Windows.Forms.TextBox txtBok;
        private System.Windows.Forms.TextBox txtObwod;
        private System.Windows.Forms.TextBox txtPole;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button1;
    }
}

