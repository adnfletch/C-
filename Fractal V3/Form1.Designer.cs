
namespace Fractal_V2
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
            this.pbFractal = new System.Windows.Forms.PictureBox();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFractal)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFractal
            // 
            this.pbFractal.Location = new System.Drawing.Point(53, 45);
            this.pbFractal.Name = "pbFractal";
            this.pbFractal.Size = new System.Drawing.Size(600, 600);
            this.pbFractal.TabIndex = 0;
            this.pbFractal.TabStop = false;
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(712, 141);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(174, 20);
            this.txtLevel.TabIndex = 2;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(712, 178);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(174, 69);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 683);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.pbFractal);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbFractal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFractal;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.Button btnGenerate;
    }
}

