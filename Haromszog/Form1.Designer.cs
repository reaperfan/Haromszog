namespace Haromszog
{
    partial class MainForm
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
            this.btn_adatBetoltes = new System.Windows.Forms.Button();
            this.listBox_Hiba = new System.Windows.Forms.ListBox();
            this.listBox_Dharomszog = new System.Windows.Forms.ListBox();
            this.listBox_Kivalasztott = new System.Windows.Forms.ListBox();
            this.lbl_Hiba = new System.Windows.Forms.Label();
            this.lbl_Derekszogu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_adatBetoltes
            // 
            this.btn_adatBetoltes.Location = new System.Drawing.Point(12, 31);
            this.btn_adatBetoltes.Name = "btn_adatBetoltes";
            this.btn_adatBetoltes.Size = new System.Drawing.Size(130, 35);
            this.btn_adatBetoltes.TabIndex = 0;
            this.btn_adatBetoltes.Text = "Adatok betöltése";
            this.btn_adatBetoltes.UseVisualStyleBackColor = true;
            this.btn_adatBetoltes.Click += new System.EventHandler(this.Btn_adatBetoltes_Click);
            // 
            // listBox_Hiba
            // 
            this.listBox_Hiba.FormattingEnabled = true;
            this.listBox_Hiba.Location = new System.Drawing.Point(12, 98);
            this.listBox_Hiba.Name = "listBox_Hiba";
            this.listBox_Hiba.Size = new System.Drawing.Size(721, 173);
            this.listBox_Hiba.TabIndex = 1;
            // 
            // listBox_Dharomszog
            // 
            this.listBox_Dharomszog.FormattingEnabled = true;
            this.listBox_Dharomszog.Location = new System.Drawing.Point(12, 302);
            this.listBox_Dharomszog.Name = "listBox_Dharomszog";
            this.listBox_Dharomszog.Size = new System.Drawing.Size(182, 147);
            this.listBox_Dharomszog.TabIndex = 2;
            this.listBox_Dharomszog.SelectedIndexChanged += new System.EventHandler(this.ListBox_Dharomszog_SelectedIndexChanged);
            // 
            // listBox_Kivalasztott
            // 
            this.listBox_Kivalasztott.FormattingEnabled = true;
            this.listBox_Kivalasztott.Location = new System.Drawing.Point(211, 302);
            this.listBox_Kivalasztott.Name = "listBox_Kivalasztott";
            this.listBox_Kivalasztott.Size = new System.Drawing.Size(522, 147);
            this.listBox_Kivalasztott.TabIndex = 3;
            // 
            // lbl_Hiba
            // 
            this.lbl_Hiba.AutoSize = true;
            this.lbl_Hiba.Location = new System.Drawing.Point(9, 82);
            this.lbl_Hiba.Name = "lbl_Hiba";
            this.lbl_Hiba.Size = new System.Drawing.Size(146, 13);
            this.lbl_Hiba.TabIndex = 4;
            this.lbl_Hiba.Text = "Hibás adatok az állományban";
            // 
            // lbl_Derekszogu
            // 
            this.lbl_Derekszogu.AutoSize = true;
            this.lbl_Derekszogu.Location = new System.Drawing.Point(12, 286);
            this.lbl_Derekszogu.Name = "lbl_Derekszogu";
            this.lbl_Derekszogu.Size = new System.Drawing.Size(130, 13);
            this.lbl_Derekszogu.TabIndex = 5;
            this.lbl_Derekszogu.Text = "Derékszögű háromszögek";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kiválaszott derékszögű háromszög adatai";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Derekszogu);
            this.Controls.Add(this.lbl_Hiba);
            this.Controls.Add(this.listBox_Kivalasztott);
            this.Controls.Add(this.listBox_Dharomszog);
            this.Controls.Add(this.listBox_Hiba);
            this.Controls.Add(this.btn_adatBetoltes);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.Text = "Háromszögek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_adatBetoltes;
        private System.Windows.Forms.ListBox listBox_Hiba;
        private System.Windows.Forms.ListBox listBox_Dharomszog;
        public System.Windows.Forms.ListBox listBox_Kivalasztott;
        private System.Windows.Forms.Label lbl_Hiba;
        private System.Windows.Forms.Label lbl_Derekszogu;
        private System.Windows.Forms.Label label1;
    }
}

