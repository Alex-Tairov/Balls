namespace Billyards_WindowsFormsApp
{
    partial class BillyardsForm
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
            this.leftLabel = new System.Windows.Forms.Label();
            this.topLabel = new System.Windows.Forms.Label();
            this.rightLabel = new System.Windows.Forms.Label();
            this.downLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // leftLabel
            // 
            this.leftLabel.AutoSize = true;
            this.leftLabel.Location = new System.Drawing.Point(12, 205);
            this.leftLabel.Name = "leftLabel";
            this.leftLabel.Size = new System.Drawing.Size(16, 17);
            this.leftLabel.TabIndex = 0;
            this.leftLabel.Text = "0";
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Location = new System.Drawing.Point(385, 18);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(16, 17);
            this.topLabel.TabIndex = 1;
            this.topLabel.Text = "0";
            // 
            // rightLabel
            // 
            this.rightLabel.AutoSize = true;
            this.rightLabel.Location = new System.Drawing.Point(720, 205);
            this.rightLabel.Name = "rightLabel";
            this.rightLabel.Size = new System.Drawing.Size(16, 17);
            this.rightLabel.TabIndex = 2;
            this.rightLabel.Text = "0";
            // 
            // downLabel
            // 
            this.downLabel.AutoSize = true;
            this.downLabel.Location = new System.Drawing.Point(385, 396);
            this.downLabel.Name = "downLabel";
            this.downLabel.Size = new System.Drawing.Size(16, 17);
            this.downLabel.TabIndex = 3;
            this.downLabel.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(678, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Рисовать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(678, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Двигать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BillyardsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(861, 498);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.downLabel);
            this.Controls.Add(this.rightLabel);
            this.Controls.Add(this.topLabel);
            this.Controls.Add(this.leftLabel);
            this.Name = "BillyardsForm";
            this.Text = "Бильярдные шарики";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label leftLabel;
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Label rightLabel;
        private System.Windows.Forms.Label downLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

