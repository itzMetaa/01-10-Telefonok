namespace Telefonok
{
    partial class Form1
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
            this.groupBoxTelefon = new System.Windows.Forms.GroupBox();
            this.labelMarka = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMarka = new System.Windows.Forms.TextBox();
            this.textBoxTipus = new System.Windows.Forms.TextBox();
            this.numericUpDownAr = new System.Windows.Forms.NumericUpDown();
            this.buttonFelvetel = new System.Windows.Forms.Button();
            this.buttonModosit = new System.Windows.Forms.Button();
            this.buttonTorles = new System.Windows.Forms.Button();
            this.dataGridViewAdatok = new System.Windows.Forms.DataGridView();
            this.groupBoxTelefon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdatok)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTelefon
            // 
            this.groupBoxTelefon.Controls.Add(this.buttonTorles);
            this.groupBoxTelefon.Controls.Add(this.buttonModosit);
            this.groupBoxTelefon.Controls.Add(this.buttonFelvetel);
            this.groupBoxTelefon.Controls.Add(this.numericUpDownAr);
            this.groupBoxTelefon.Controls.Add(this.textBoxTipus);
            this.groupBoxTelefon.Controls.Add(this.textBoxMarka);
            this.groupBoxTelefon.Controls.Add(this.label3);
            this.groupBoxTelefon.Controls.Add(this.label2);
            this.groupBoxTelefon.Controls.Add(this.labelMarka);
            this.groupBoxTelefon.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTelefon.Name = "groupBoxTelefon";
            this.groupBoxTelefon.Size = new System.Drawing.Size(347, 103);
            this.groupBoxTelefon.TabIndex = 0;
            this.groupBoxTelefon.TabStop = false;
            this.groupBoxTelefon.Text = "Telefon Adatai";
            // 
            // labelMarka
            // 
            this.labelMarka.AutoSize = true;
            this.labelMarka.Location = new System.Drawing.Point(3, 20);
            this.labelMarka.Name = "labelMarka";
            this.labelMarka.Size = new System.Drawing.Size(37, 13);
            this.labelMarka.TabIndex = 0;
            this.labelMarka.Text = "Márka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ár";
            // 
            // textBoxMarka
            // 
            this.textBoxMarka.Location = new System.Drawing.Point(6, 36);
            this.textBoxMarka.Name = "textBoxMarka";
            this.textBoxMarka.Size = new System.Drawing.Size(100, 20);
            this.textBoxMarka.TabIndex = 3;
            // 
            // textBoxTipus
            // 
            this.textBoxTipus.Location = new System.Drawing.Point(112, 36);
            this.textBoxTipus.Name = "textBoxTipus";
            this.textBoxTipus.Size = new System.Drawing.Size(100, 20);
            this.textBoxTipus.TabIndex = 4;
            // 
            // numericUpDownAr
            // 
            this.numericUpDownAr.Location = new System.Drawing.Point(218, 36);
            this.numericUpDownAr.Name = "numericUpDownAr";
            this.numericUpDownAr.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownAr.TabIndex = 5;
            // 
            // buttonFelvetel
            // 
            this.buttonFelvetel.Location = new System.Drawing.Point(7, 63);
            this.buttonFelvetel.Name = "buttonFelvetel";
            this.buttonFelvetel.Size = new System.Drawing.Size(99, 23);
            this.buttonFelvetel.TabIndex = 6;
            this.buttonFelvetel.Text = "Új telefon";
            this.buttonFelvetel.UseVisualStyleBackColor = true;
            this.buttonFelvetel.Click += new System.EventHandler(this.buttonFelvetel_Click);
            // 
            // buttonModosit
            // 
            this.buttonModosit.Location = new System.Drawing.Point(112, 62);
            this.buttonModosit.Name = "buttonModosit";
            this.buttonModosit.Size = new System.Drawing.Size(100, 23);
            this.buttonModosit.TabIndex = 7;
            this.buttonModosit.Text = "Adatmódosítás";
            this.buttonModosit.UseVisualStyleBackColor = true;
            // 
            // buttonTorles
            // 
            this.buttonTorles.Location = new System.Drawing.Point(218, 63);
            this.buttonTorles.Name = "buttonTorles";
            this.buttonTorles.Size = new System.Drawing.Size(120, 23);
            this.buttonTorles.TabIndex = 8;
            this.buttonTorles.Text = "Törlés";
            this.buttonTorles.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAdatok
            // 
            this.dataGridViewAdatok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdatok.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewAdatok.Location = new System.Drawing.Point(0, 113);
            this.dataGridViewAdatok.Name = "dataGridViewAdatok";
            this.dataGridViewAdatok.Size = new System.Drawing.Size(477, 74);
            this.dataGridViewAdatok.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 187);
            this.Controls.Add(this.dataGridViewAdatok);
            this.Controls.Add(this.groupBoxTelefon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxTelefon.ResumeLayout(false);
            this.groupBoxTelefon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdatok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTelefon;
        private System.Windows.Forms.NumericUpDown numericUpDownAr;
        private System.Windows.Forms.TextBox textBoxTipus;
        private System.Windows.Forms.TextBox textBoxMarka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMarka;
        private System.Windows.Forms.Button buttonTorles;
        private System.Windows.Forms.Button buttonModosit;
        private System.Windows.Forms.Button buttonFelvetel;
        private System.Windows.Forms.DataGridView dataGridViewAdatok;
    }
}

