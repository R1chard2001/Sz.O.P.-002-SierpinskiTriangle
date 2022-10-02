namespace SierpinskiTriangle
{
    partial class CanvasForm
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
            this.CanvasPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CanvasPB)).BeginInit();
            this.SuspendLayout();
            // 
            // CanvasPB
            // 
            this.CanvasPB.BackColor = System.Drawing.Color.Black;
            this.CanvasPB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CanvasPB.Location = new System.Drawing.Point(0, 0);
            this.CanvasPB.Name = "CanvasPB";
            this.CanvasPB.Size = new System.Drawing.Size(982, 953);
            this.CanvasPB.TabIndex = 0;
            this.CanvasPB.TabStop = false;
            this.CanvasPB.Paint += new System.Windows.Forms.PaintEventHandler(this.CanvasPB_Paint);
            // 
            // CanvasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(982, 953);
            this.Controls.Add(this.CanvasPB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CanvasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sierpinski Triangle - Canvas";
            ((System.ComponentModel.ISupportInitialize)(this.CanvasPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox CanvasPB;
    }
}