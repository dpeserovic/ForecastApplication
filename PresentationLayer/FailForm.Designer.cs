namespace PresentationLayer
{
    partial class FailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FailForm));
            this.labelFail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFail
            // 
            this.labelFail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFail.Location = new System.Drawing.Point(0, 0);
            this.labelFail.Name = "labelFail";
            this.labelFail.Size = new System.Drawing.Size(234, 211);
            this.labelFail.TabIndex = 0;
            this.labelFail.Text = "Fail!";
            this.labelFail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 211);
            this.Controls.Add(this.labelFail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FailForm";
            this.Text = "Fail";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelFail;
    }
}