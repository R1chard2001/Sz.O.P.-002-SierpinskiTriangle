namespace SierpinskiTriangle
{
    partial class ConfigForm
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
            this.NORNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NORLbl = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NORNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // NORNumericUpDown
            // 
            this.NORNumericUpDown.Location = new System.Drawing.Point(83, 49);
            this.NORNumericUpDown.Name = "NORNumericUpDown";
            this.NORNumericUpDown.Size = new System.Drawing.Size(107, 22);
            this.NORNumericUpDown.TabIndex = 0;
            // 
            // NORLbl
            // 
            this.NORLbl.AutoSize = true;
            this.NORLbl.Location = new System.Drawing.Point(63, 9);
            this.NORLbl.Name = "NORLbl";
            this.NORLbl.Size = new System.Drawing.Size(127, 16);
            this.NORLbl.TabIndex = 1;
            this.NORLbl.Text = "Number of recursion";
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(281, 8);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(162, 103);
            this.StartBtn.TabIndex = 2;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 123);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.NORLbl);
            this.Controls.Add(this.NORNumericUpDown);
            this.Name = "ConfigForm";
            this.Text = "Sierpinski Triangle - Config";
            ((System.ComponentModel.ISupportInitialize)(this.NORNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NORNumericUpDown;
        private System.Windows.Forms.Label NORLbl;
        private System.Windows.Forms.Button StartBtn;
    }
}

