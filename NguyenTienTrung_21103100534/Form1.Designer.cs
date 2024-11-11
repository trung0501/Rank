namespace NguyenTienTrung_21103100534
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
            this.btndocfile_0534 = new System.Windows.Forms.Button();
            this.btnsua_0534 = new System.Windows.Forms.Button();
            this.btnthongke_0534 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btndocfile_0534
            // 
            this.btndocfile_0534.Location = new System.Drawing.Point(65, 47);
            this.btndocfile_0534.Name = "btndocfile_0534";
            this.btndocfile_0534.Size = new System.Drawing.Size(93, 42);
            this.btndocfile_0534.TabIndex = 0;
            this.btndocfile_0534.Text = "Đọc file";
            this.btndocfile_0534.UseVisualStyleBackColor = true;
            this.btndocfile_0534.Click += new System.EventHandler(this.btndocfile_0534_Click);
            // 
            // btnsua_0534
            // 
            this.btnsua_0534.Location = new System.Drawing.Point(309, 47);
            this.btnsua_0534.Name = "btnsua_0534";
            this.btnsua_0534.Size = new System.Drawing.Size(102, 43);
            this.btnsua_0534.TabIndex = 1;
            this.btnsua_0534.Text = "Sửa";
            this.btnsua_0534.UseVisualStyleBackColor = true;
            this.btnsua_0534.Click += new System.EventHandler(this.btnsua_0534_Click);
            // 
            // btnthongke_0534
            // 
            this.btnthongke_0534.Location = new System.Drawing.Point(543, 47);
            this.btnthongke_0534.Name = "btnthongke_0534";
            this.btnthongke_0534.Size = new System.Drawing.Size(132, 43);
            this.btnthongke_0534.TabIndex = 2;
            this.btnthongke_0534.Text = "Thống kê và hiển thị";
            this.btnthongke_0534.UseVisualStyleBackColor = true;
            this.btnthongke_0534.Click += new System.EventHandler(this.btnthongke_0534_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(288, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 62);
            this.button1.TabIndex = 3;
            this.button1.Text = "Xin mời chọn";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhấn 3 ô trên cùng nha";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 384);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnthongke_0534);
            this.Controls.Add(this.btnsua_0534);
            this.Controls.Add(this.btndocfile_0534);
            this.Name = "Form1";
            this.Text = "NguyenTienTrung_21103100534";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndocfile_0534;
        private System.Windows.Forms.Button btnsua_0534;
        private System.Windows.Forms.Button btnthongke_0534;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

