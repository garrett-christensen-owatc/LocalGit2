namespace LocalGit
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
            this.btnhello = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnhello
            // 
            this.btnhello.Location = new System.Drawing.Point(12, 21);
            this.btnhello.Name = "btnhello";
            this.btnhello.Size = new System.Drawing.Size(75, 23);
            this.btnhello.TabIndex = 0;
            this.btnhello.Text = "hello";
            this.btnhello.UseVisualStyleBackColor = true;
            this.btnhello.Click += new System.EventHandler(this.btnhello_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnhello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnhello;
    }
}

