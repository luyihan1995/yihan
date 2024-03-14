namespace N09310011
{
    partial class 你按到人家了
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
            this.b2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(254, 110);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(218, 129);
            this.b2.TabIndex = 0;
            this.b2.Text = "你按到人家了";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.button1_Click);
            // 
            // 你按到人家了
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b2);
            this.Name = "你按到人家了";
            this.Text = "按我之後";
            this.Load += new System.EventHandler(this.Formbutton_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b2;
    }
}