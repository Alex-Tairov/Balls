namespace Billyards_WindowsFormsApp
{
    partial class DiffusionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Restartbutton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Произошла диффузия";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Restartbutton
            // 
            this.Restartbutton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Restartbutton.Location = new System.Drawing.Point(41, 269);
            this.Restartbutton.Name = "Restartbutton";
            this.Restartbutton.Size = new System.Drawing.Size(75, 23);
            this.Restartbutton.TabIndex = 1;
            this.Restartbutton.Text = "Заново";
            this.Restartbutton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Location = new System.Drawing.Point(209, 269);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Выход";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // DiffusionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 450);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.Restartbutton);
            this.Controls.Add(this.label1);
            this.Name = "DiffusionForm";
            this.Text = "DiffusionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Restartbutton;
        private System.Windows.Forms.Button closeButton;
    }
}