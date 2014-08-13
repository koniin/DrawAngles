namespace AngelCalculation
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
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.tbAngle = new System.Windows.Forms.TextBox();
            this.lblAngle = new System.Windows.Forms.Label();
            this.btnRandom = new System.Windows.Forms.Button();
            this.tbLower = new System.Windows.Forms.TextBox();
            this.tbUpper = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCanvas
            // 
            this.pbCanvas.Location = new System.Drawing.Point(12, 12);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(260, 204);
            this.pbCanvas.TabIndex = 0;
            this.pbCanvas.TabStop = false;
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(197, 227);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 1;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // tbAngle
            // 
            this.tbAngle.Location = new System.Drawing.Point(91, 230);
            this.tbAngle.Name = "tbAngle";
            this.tbAngle.Size = new System.Drawing.Size(100, 20);
            this.tbAngle.TabIndex = 2;
            // 
            // lblAngle
            // 
            this.lblAngle.AutoSize = true;
            this.lblAngle.Location = new System.Drawing.Point(9, 232);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(81, 13);
            this.lblAngle.TabIndex = 3;
            this.lblAngle.Text = "Angle (degrees)";
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(197, 257);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(75, 23);
            this.btnRandom.TabIndex = 4;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // tbLower
            // 
            this.tbLower.Location = new System.Drawing.Point(79, 259);
            this.tbLower.Name = "tbLower";
            this.tbLower.Size = new System.Drawing.Size(53, 20);
            this.tbLower.TabIndex = 5;
            // 
            // tbUpper
            // 
            this.tbUpper.Location = new System.Drawing.Point(138, 259);
            this.tbUpper.Name = "tbUpper";
            this.tbUpper.Size = new System.Drawing.Size(53, 20);
            this.tbUpper.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 285);
            this.Controls.Add(this.tbUpper);
            this.Controls.Add(this.tbLower);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.lblAngle);
            this.Controls.Add(this.tbAngle);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.pbCanvas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.TextBox tbAngle;
        private System.Windows.Forms.Label lblAngle;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.TextBox tbLower;
        private System.Windows.Forms.TextBox tbUpper;
    }
}

