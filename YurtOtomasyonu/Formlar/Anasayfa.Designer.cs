namespace YurtOtomasyonu
{
    partial class Anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.gbMenu = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btnOgrenciIsleri = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.gbMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMenu
            // 
            this.gbMenu.Controls.Add(this.button5);
            this.gbMenu.Controls.Add(this.btnOgrenciIsleri);
            this.gbMenu.Controls.Add(this.button2);
            this.gbMenu.Controls.Add(this.button4);
            this.gbMenu.Controls.Add(this.button3);
            this.gbMenu.Location = new System.Drawing.Point(12, 12);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Size = new System.Drawing.Size(683, 71);
            this.gbMenu.TabIndex = 2;
            this.gbMenu.TabStop = false;
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(272, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 47);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnOgrenciIsleri
            // 
            this.btnOgrenciIsleri.Image = ((System.Drawing.Image)(resources.GetObject("btnOgrenciIsleri.Image")));
            this.btnOgrenciIsleri.Location = new System.Drawing.Point(6, 19);
            this.btnOgrenciIsleri.Name = "btnOgrenciIsleri";
            this.btnOgrenciIsleri.Size = new System.Drawing.Size(47, 47);
            this.btnOgrenciIsleri.TabIndex = 0;
            this.btnOgrenciIsleri.UseVisualStyleBackColor = true;
            this.btnOgrenciIsleri.Click += new System.EventHandler(this.btnOgrenciIsleri_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(71, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 47);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(207, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(47, 47);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(138, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(47, 47);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 389);
            this.Controls.Add(this.gbMenu);
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.gbMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMenu;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnOgrenciIsleri;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;

    }
}