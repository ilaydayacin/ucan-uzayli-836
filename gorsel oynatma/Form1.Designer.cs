namespace gorsel_oynatma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbUzayli = new System.Windows.Forms.PictureBox();
            this.btnİlerle = new System.Windows.Forms.Button();
            this.btnDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbUzayli)).BeginInit();
            this.SuspendLayout();
            // 
            // pbUzayli
            // 
            this.pbUzayli.BackgroundImage = global::gorsel_oynatma.Properties.Resources.images;
            this.pbUzayli.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbUzayli.ErrorImage")));
            this.pbUzayli.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbUzayli.InitialImage")));
            this.pbUzayli.Location = new System.Drawing.Point(12, 12);
            this.pbUzayli.Name = "pbUzayli";
            this.pbUzayli.Size = new System.Drawing.Size(297, 156);
            this.pbUzayli.TabIndex = 0;
            this.pbUzayli.TabStop = false;
            // 
            // btnİlerle
            // 
            this.btnİlerle.Location = new System.Drawing.Point(691, 12);
            this.btnİlerle.Name = "btnİlerle";
            this.btnİlerle.Size = new System.Drawing.Size(97, 40);
            this.btnİlerle.TabIndex = 1;
            this.btnİlerle.Text = "İlerle";
            this.btnİlerle.UseVisualStyleBackColor = true;
            this.btnİlerle.Click += new System.EventHandler(this.btnİlerle_Click);
            // 
            // btnDon
            // 
            this.btnDon.Location = new System.Drawing.Point(691, 59);
            this.btnDon.Name = "btnDon";
            this.btnDon.Size = new System.Drawing.Size(97, 40);
            this.btnDon.TabIndex = 2;
            this.btnDon.Text = "Dön";
            this.btnDon.UseVisualStyleBackColor = true;
            this.btnDon.Click += new System.EventHandler(this.btnDon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDon);
            this.Controls.Add(this.btnİlerle);
            this.Controls.Add(this.pbUzayli);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbUzayli)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbUzayli;
        private System.Windows.Forms.Button btnİlerle;
        private System.Windows.Forms.Button btnDon;
    }
}

