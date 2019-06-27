namespace CenkBahçeliler
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnTasEkle = new System.Windows.Forms.Button();
            this.btnHareketEttir = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnTasEkle
            // 
            this.btnTasEkle.Location = new System.Drawing.Point(693, 92);
            this.btnTasEkle.Name = "btnTasEkle";
            this.btnTasEkle.Size = new System.Drawing.Size(132, 38);
            this.btnTasEkle.TabIndex = 1;
            this.btnTasEkle.Text = "Taş Ekle";
            this.btnTasEkle.UseVisualStyleBackColor = true;
            this.btnTasEkle.Click += new System.EventHandler(this.btnTasEkle_Click);
            // 
            // btnHareketEttir
            // 
            this.btnHareketEttir.Location = new System.Drawing.Point(693, 136);
            this.btnHareketEttir.Name = "btnHareketEttir";
            this.btnHareketEttir.Size = new System.Drawing.Size(132, 38);
            this.btnHareketEttir.TabIndex = 2;
            this.btnHareketEttir.Text = "Taşları Hareket Ettir";
            this.btnHareketEttir.UseVisualStyleBackColor = true;
            this.btnHareketEttir.Click += new System.EventHandler(this.btnHareketEttir_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(625, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Kale.png");
            this.ımageList1.Images.SetKeyName(1, "Fil.png");
            this.ımageList1.Images.SetKeyName(2, "At.png");
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(693, 191);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(195, 225);
            this.listBox1.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 514);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnHareketEttir);
            this.Controls.Add(this.btnTasEkle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTasEkle;
        private System.Windows.Forms.Button btnHareketEttir;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
        public override string ToString()
        {
            return Text;
        }
    }
}

