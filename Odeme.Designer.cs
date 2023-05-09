
namespace diyet_Uygulaması
{
    partial class Odeme
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
            this.Periyot = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.OdemeTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.OdemeTb1 = new System.Windows.Forms.Button();
            this.OdemeDgv = new System.Windows.Forms.DataGridView();
            this.AdSoyadCb = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OdemeDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Periyot
            // 
            this.Periyot.Font = new System.Drawing.Font("Oswald", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Periyot.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Periyot.Location = new System.Drawing.Point(3, 110);
            this.Periyot.Name = "Periyot";
            this.Periyot.Size = new System.Drawing.Size(248, 32);
            this.Periyot.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-2, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 26);
            this.label2.TabIndex = 23;
            this.label2.Text = "HASTA TC KİMLİK NO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Red;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(-2, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 26);
            this.label6.TabIndex = 28;
            this.label6.Text = "TUTAR";
            // 
            // OdemeTb
            // 
            this.OdemeTb.Location = new System.Drawing.Point(3, 251);
            this.OdemeTb.Name = "OdemeTb";
            this.OdemeTb.Size = new System.Drawing.Size(248, 22);
            this.OdemeTb.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-2, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 26);
            this.label1.TabIndex = 30;
            this.label1.Text = "ÖDEME AYI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(451, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 39);
            this.label3.TabIndex = 31;
            this.label3.Text = "ÖDEMELER";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Oswald", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(68, 346);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 44);
            this.button3.TabIndex = 35;
            this.button3.Text = "GERİ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Oswald", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(130, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 44);
            this.button1.TabIndex = 36;
            this.button1.Text = "SIFIRLA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OdemeTb1
            // 
            this.OdemeTb1.BackColor = System.Drawing.Color.Red;
            this.OdemeTb1.Font = new System.Drawing.Font("Oswald", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OdemeTb1.ForeColor = System.Drawing.Color.White;
            this.OdemeTb1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.OdemeTb1.Location = new System.Drawing.Point(3, 296);
            this.OdemeTb1.Name = "OdemeTb1";
            this.OdemeTb1.Size = new System.Drawing.Size(121, 44);
            this.OdemeTb1.TabIndex = 37;
            this.OdemeTb1.Text = "ÖDEME";
            this.OdemeTb1.UseVisualStyleBackColor = false;
            this.OdemeTb1.Click += new System.EventHandler(this.button2_Click);
            // 
            // OdemeDgv
            // 
            this.OdemeDgv.BackgroundColor = System.Drawing.Color.White;
            this.OdemeDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OdemeDgv.Location = new System.Drawing.Point(284, 81);
            this.OdemeDgv.Name = "OdemeDgv";
            this.OdemeDgv.RowHeadersWidth = 51;
            this.OdemeDgv.RowTemplate.Height = 24;
            this.OdemeDgv.Size = new System.Drawing.Size(543, 307);
            this.OdemeDgv.TabIndex = 39;
            // 
            // AdSoyadCb
            // 
            this.AdSoyadCb.FormattingEnabled = true;
            this.AdSoyadCb.Items.AddRange(new object[] {
            "08.00-08.30",
            "08.30-09.00",
            "09.00-09.30",
            "09.30-10.00",
            "10.00-10.30",
            "10.30-11.30",
            "11.30-12.00",
            "13.00-14.00",
            "14.00-15.00",
            "15.00-16.00",
            "16.00-17.00"});
            this.AdSoyadCb.Location = new System.Drawing.Point(3, 185);
            this.AdSoyadCb.Name = "AdSoyadCb";
            this.AdSoyadCb.Size = new System.Drawing.Size(248, 24);
            this.AdSoyadCb.TabIndex = 41;
            this.AdSoyadCb.SelectedIndexChanged += new System.EventHandler(this.AdSoyadCb_SelectedIndexChanged);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImage = global::diyet_Uygulaması.Properties.Resources.red_40144_1280;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button6.Location = new System.Drawing.Point(797, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(21, 23);
            this.button6.TabIndex = 40;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Odeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(830, 469);
            this.Controls.Add(this.AdSoyadCb);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.OdemeDgv);
            this.Controls.Add(this.OdemeTb1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OdemeTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Periyot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Odeme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odeme";
            this.Load += new System.EventHandler(this.Odeme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OdemeDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Periyot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox OdemeTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button OdemeTb1;
        private System.Windows.Forms.DataGridView OdemeDgv;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox AdSoyadCb;
    }
}