
namespace vd_web6
{
    partial class frmlistboxs
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
            this.lbsite = new System.Windows.Forms.ListBox();
            this.txtsite = new System.Windows.Forms.TextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbsite
            // 
            this.lbsite.FormattingEnabled = true;
            this.lbsite.Items.AddRange(new object[] {
            "www.dantri.com.vn",
            "www.dhhp.edu.vn",
            "www.24h.com.vn",
            "www.fit.dhhp.edu.vn"});
            this.lbsite.Location = new System.Drawing.Point(69, 145);
            this.lbsite.Name = "lbsite";
            this.lbsite.Size = new System.Drawing.Size(306, 147);
            this.lbsite.TabIndex = 0;
            // 
            // txtsite
            // 
            this.txtsite.Location = new System.Drawing.Point(425, 145);
            this.txtsite.Multiline = true;
            this.txtsite.Name = "txtsite";
            this.txtsite.ReadOnly = true;
            this.txtsite.Size = new System.Drawing.Size(306, 148);
            this.txtsite.TabIndex = 1;
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(158, 345);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 39);
            this.btnok.TabIndex = 2;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(363, 345);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 39);
            this.btnreset.TabIndex = 3;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(572, 345);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 39);
            this.btnthoat.TabIndex = 4;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(302, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Liên kết Website";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bạn hãy chọn site:";
            // 
            // frmlistboxs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txtsite);
            this.Controls.Add(this.lbsite);
            this.Name = "frmlistboxs";
            this.Text = "frmlistboxs";
            this.Load += new System.EventHandler(this.frmlistboxs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbsite;
        private System.Windows.Forms.TextBox txtsite;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}