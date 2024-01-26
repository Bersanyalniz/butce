
namespace Butce
{
    partial class FrmIlanDetay
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
            System.Windows.Forms.Label labeltxt;
            System.Windows.Forms.Label aciklamaLabel;
            System.Windows.Forms.Label label453135;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.tarihDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.aciklamaTextBox = new System.Windows.Forms.TextBox();
            this.txtIlanNo = new System.Windows.Forms.TextBox();
            this.txtM2 = new System.Windows.Forms.TextBox();
            tarihLabel = new System.Windows.Forms.Label();
            labeltxt = new System.Windows.Forms.Label();
            aciklamaLabel = new System.Windows.Forms.Label();
            label453135 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tarihLabel
            // 
            tarihLabel.AutoSize = true;
            tarihLabel.Location = new System.Drawing.Point(52, 58);
            tarihLabel.Name = "tarihLabel";
            tarihLabel.Size = new System.Drawing.Size(34, 13);
            tarihLabel.TabIndex = 6;
            tarihLabel.Text = "Tarih:";
            // 
            // labeltxt
            // 
            labeltxt.AutoSize = true;
            labeltxt.Location = new System.Drawing.Point(51, 172);
            labeltxt.Name = "labeltxt";
            labeltxt.Size = new System.Drawing.Size(0, 13);
            labeltxt.TabIndex = 15;
            // 
            // aciklamaLabel
            // 
            aciklamaLabel.AutoSize = true;
            aciklamaLabel.Location = new System.Drawing.Point(30, 87);
            aciklamaLabel.Name = "aciklamaLabel";
            aciklamaLabel.Size = new System.Drawing.Size(53, 13);
            aciklamaLabel.TabIndex = 9;
            aciklamaLabel.Text = "Aciklama:";
            // 
            // label453135
            // 
            label453135.AutoSize = true;
            label453135.Location = new System.Drawing.Point(48, 35);
            label453135.Name = "label453135";
            label453135.Size = new System.Drawing.Size(38, 13);
            label453135.TabIndex = 12;
            label453135.Text = "IlanNo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(30, 146);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(56, 13);
            label1.TabIndex = 14;
            label1.Text = "MetreKare";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKaydet.Location = new System.Drawing.Point(92, 206);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(90, 39);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIptal.Location = new System.Drawing.Point(188, 206);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(97, 39);
            this.btnIptal.TabIndex = 4;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // tarihDateTimePicker
            // 
            this.tarihDateTimePicker.Location = new System.Drawing.Point(92, 58);
            this.tarihDateTimePicker.Name = "tarihDateTimePicker";
            this.tarihDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.tarihDateTimePicker.TabIndex = 7;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(92, 169);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(200, 20);
            this.txtFiyat.TabIndex = 9;
            // 
            // aciklamaTextBox
            // 
            this.aciklamaTextBox.Location = new System.Drawing.Point(92, 84);
            this.aciklamaTextBox.Multiline = true;
            this.aciklamaTextBox.Name = "aciklamaTextBox";
            this.aciklamaTextBox.Size = new System.Drawing.Size(200, 53);
            this.aciklamaTextBox.TabIndex = 10;
            // 
            // txtIlanNo
            // 
            this.txtIlanNo.Location = new System.Drawing.Point(92, 32);
            this.txtIlanNo.Name = "txtIlanNo";
            this.txtIlanNo.Size = new System.Drawing.Size(200, 20);
            this.txtIlanNo.TabIndex = 11;
            // 
            // txtM2
            // 
            this.txtM2.Location = new System.Drawing.Point(92, 143);
            this.txtM2.Name = "txtM2";
            this.txtM2.Size = new System.Drawing.Size(200, 20);
            this.txtM2.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(34, 172);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(29, 13);
            label2.TabIndex = 16;
            label2.Text = "Fiyat";
            // 
            // FrmIlanDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 272);
            this.ControlBox = false;
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.txtM2);
            this.Controls.Add(label453135);
            this.Controls.Add(this.txtIlanNo);
            this.Controls.Add(aciklamaLabel);
            this.Controls.Add(this.aciklamaTextBox);
            this.Controls.Add(labeltxt);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(tarihLabel);
            this.Controls.Add(this.tarihDateTimePicker);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnIptal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmIlanDetay";
            this.Text = "İlan Detay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.DateTimePicker tarihDateTimePicker;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox aciklamaTextBox;
        private System.Windows.Forms.TextBox txtIlanNo;
        private System.Windows.Forms.TextBox txtM2;
    }
}