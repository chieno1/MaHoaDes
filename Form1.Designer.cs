namespace DES
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
            this.txt_ban_ro = new System.Windows.Forms.TextBox();
            this.txt_khoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ban_ma = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_giai_thich = new System.Windows.Forms.TextBox();
            this.btn_ma_hoa = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_giai_ma = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_ban_ro
            // 
            this.txt_ban_ro.Location = new System.Drawing.Point(127, 68);
            this.txt_ban_ro.Name = "txt_ban_ro";
            this.txt_ban_ro.Size = new System.Drawing.Size(213, 22);
            this.txt_ban_ro.TabIndex = 0;
            this.txt_ban_ro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_khoa
            // 
            this.txt_khoa.Location = new System.Drawing.Point(127, 131);
            this.txt_khoa.Name = "txt_khoa";
            this.txt_khoa.Size = new System.Drawing.Size(213, 22);
            this.txt_khoa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bản rõ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Khóa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bản mã";
            // 
            // txt_ban_ma
            // 
            this.txt_ban_ma.Location = new System.Drawing.Point(127, 194);
            this.txt_ban_ma.Name = "txt_ban_ma";
            this.txt_ban_ma.Size = new System.Drawing.Size(213, 22);
            this.txt_ban_ma.TabIndex = 3;
            this.txt_ban_ma.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_giai_thich);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(395, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 739);
            this.panel1.TabIndex = 4;
            // 
            // txt_giai_thich
            // 
            this.txt_giai_thich.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_giai_thich.Location = new System.Drawing.Point(0, 0);
            this.txt_giai_thich.Multiline = true;
            this.txt_giai_thich.Name = "txt_giai_thich";
            this.txt_giai_thich.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_giai_thich.Size = new System.Drawing.Size(777, 739);
            this.txt_giai_thich.TabIndex = 0;
            // 
            // btn_ma_hoa
            // 
            this.btn_ma_hoa.Location = new System.Drawing.Point(74, 249);
            this.btn_ma_hoa.Name = "btn_ma_hoa";
            this.btn_ma_hoa.Size = new System.Drawing.Size(254, 48);
            this.btn_ma_hoa.TabIndex = 5;
            this.btn_ma_hoa.Text = "Mã hóa";
            this.btn_ma_hoa.UseVisualStyleBackColor = true;
            this.btn_ma_hoa.Click += new System.EventHandler(this.btn_ma_hoa_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(74, 385);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(254, 48);
            this.btn_xoa.TabIndex = 5;
            this.btn_xoa.Text = "Clear";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_giai_ma
            // 
            this.btn_giai_ma.Location = new System.Drawing.Point(74, 314);
            this.btn_giai_ma.Name = "btn_giai_ma";
            this.btn_giai_ma.Size = new System.Drawing.Size(254, 48);
            this.btn_giai_ma.TabIndex = 5;
            this.btn_giai_ma.Text = "Giải mã";
            this.btn_giai_ma.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 739);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_giai_ma);
            this.Controls.Add(this.btn_ma_hoa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_ban_ma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_khoa);
            this.Controls.Add(this.txt_ban_ro);
            this.Name = "Form1";
            this.Text = "Sinh khóa DES code_BY_Chiendz";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ban_ro;
        private System.Windows.Forms.TextBox txt_khoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ban_ma;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_giai_thich;
        private System.Windows.Forms.Button btn_ma_hoa;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_giai_ma;
    }
}

