namespace Formulario_102A
{
    partial class FrmFormularios
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
            this.Img104 = new System.Windows.Forms.PictureBox();
            this.Img102A = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Img104)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img102A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Img104
            // 
            this.Img104.Image = global::Formulario_102A.Properties.Resources.logoformulario;
            this.Img104.Location = new System.Drawing.Point(310, 154);
            this.Img104.Name = "Img104";
            this.Img104.Size = new System.Drawing.Size(135, 134);
            this.Img104.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Img104.TabIndex = 3;
            this.Img104.TabStop = false;
            this.Img104.Click += new System.EventHandler(this.Img104_Click);
            // 
            // Img102A
            // 
            this.Img102A.Image = global::Formulario_102A.Properties.Resources.logoformulario;
            this.Img102A.Location = new System.Drawing.Point(93, 154);
            this.Img102A.Name = "Img102A";
            this.Img102A.Size = new System.Drawing.Size(120, 134);
            this.Img102A.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Img102A.TabIndex = 1;
            this.Img102A.TabStop = false;
            this.Img102A.Click += new System.EventHandler(this.Img102A_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Formulario_102A.Properties.Resources.Logo2;
            this.pictureBox1.Location = new System.Drawing.Point(26, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(504, 115);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Oswald", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "102-A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Oswald", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(357, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "104";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Oswald", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "FORMULARIOS";
            // 
            // FrmFormularios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 300);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Img104);
            this.Controls.Add(this.Img102A);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmFormularios";
            this.Text = "FrmFormularios";
            ((System.ComponentModel.ISupportInitialize)(this.Img104)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img102A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Img102A;
        private System.Windows.Forms.PictureBox Img104;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}