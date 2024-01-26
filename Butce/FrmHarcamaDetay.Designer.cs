
namespace Butce
{
    partial class FrmHarcamaDetay
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
            System.Windows.Forms.Label tarihLabel;
            System.Windows.Forms.Label kategoriLabel;
            System.Windows.Forms.Label tutarLabel;
            System.Windows.Forms.Label aciklamaLabel;
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.tarihDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.kategoriComboBox = new System.Windows.Forms.ComboBox();
            this.tutarTextBox = new System.Windows.Forms.TextBox();
            this.aciklamaTextBox = new System.Windows.Forms.TextBox();
            tarihLabel = new System.Windows.Forms.Label();
            kategoriLabel = new System.Windows.Forms.Label();
            tutarLabel = new System.Windows.Forms.Label();
            aciklamaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.Location = new System.Drawing.Point(159, 185);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(66, 39);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIptal.Location = new System.Drawing.Point(231, 185);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(66, 39);
            this.btnIptal.TabIndex = 4;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // tarihLabel
            // 
            tarihLabel.AutoSize = true;
            tarihLabel.Location = new System.Drawing.Point(34, 34);
            tarihLabel.Name = "tarihLabel";
            tarihLabel.Size = new System.Drawing.Size(34, 13);
            tarihLabel.TabIndex = 6;
            tarihLabel.Text = "Tarih:";
            // 
            // tarihDateTimePicker
            // 
            this.tarihDateTimePicker.Location = new System.Drawing.Point(74, 30);
            this.tarihDateTimePicker.Name = "tarihDateTimePicker";
            this.tarihDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.tarihDateTimePicker.TabIndex = 7;
            // 
            // kategoriLabel
            // 
            kategoriLabel.AutoSize = true;
            kategoriLabel.Location = new System.Drawing.Point(19, 59);
            kategoriLabel.Name = "kategoriLabel";
            kategoriLabel.Size = new System.Drawing.Size(49, 13);
            kategoriLabel.TabIndex = 7;
            kategoriLabel.Text = "Kategori:";
            // 
            // kategoriComboBox
            // 
            this.kategoriComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kategoriComboBox.FormattingEnabled = true;
            this.kategoriComboBox.Location = new System.Drawing.Point(74, 56);
            this.kategoriComboBox.Name = "kategoriComboBox";
            this.kategoriComboBox.Size = new System.Drawing.Size(121, 21);
            this.kategoriComboBox.TabIndex = 8;
            // 
            // tutarLabel
            // 
            tutarLabel.AutoSize = true;
            tutarLabel.Location = new System.Drawing.Point(33, 86);
            tutarLabel.Name = "tutarLabel";
            tutarLabel.Size = new System.Drawing.Size(35, 13);
            tutarLabel.TabIndex = 8;
            tutarLabel.Text = "Tutar:";
            // 
            // tutarTextBox
            // 
            this.tutarTextBox.Location = new System.Drawing.Point(74, 83);
            this.tutarTextBox.Name = "tutarTextBox";
            this.tutarTextBox.Size = new System.Drawing.Size(121, 20);
            this.tutarTextBox.TabIndex = 9;
            // 
            // aciklamaLabel
            // 
            aciklamaLabel.AutoSize = true;
            aciklamaLabel.Location = new System.Drawing.Point(15, 112);
            aciklamaLabel.Name = "aciklamaLabel";
            aciklamaLabel.Size = new System.Drawing.Size(53, 13);
            aciklamaLabel.TabIndex = 9;
            aciklamaLabel.Text = "Aciklama:";
            // 
            // aciklamaTextBox
            // 
            this.aciklamaTextBox.Location = new System.Drawing.Point(74, 109);
            this.aciklamaTextBox.Multiline = true;
            this.aciklamaTextBox.Name = "aciklamaTextBox";
            this.aciklamaTextBox.Size = new System.Drawing.Size(223, 53);
            this.aciklamaTextBox.TabIndex = 10;
            // 
            // FrmHarcamaDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 236);
            this.ControlBox = false;
            this.Controls.Add(aciklamaLabel);
            this.Controls.Add(this.aciklamaTextBox);
            this.Controls.Add(tutarLabel);
            this.Controls.Add(this.tutarTextBox);
            this.Controls.Add(kategoriLabel);
            this.Controls.Add(this.kategoriComboBox);
            this.Controls.Add(tarihLabel);
            this.Controls.Add(this.tarihDateTimePicker);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnIptal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmHarcamaDetay";
            this.Text = "Harcama Detay";
            this.Load += new System.EventHandler(this.FrmHarcamaDetay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.DateTimePicker tarihDateTimePicker;
        private System.Windows.Forms.ComboBox kategoriComboBox;
        private System.Windows.Forms.TextBox tutarTextBox;
        private System.Windows.Forms.TextBox aciklamaTextBox;
    }
}