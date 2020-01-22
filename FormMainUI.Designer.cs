namespace LoadTrackingToMagentoAPI
{
    partial class FormMainUI
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
            this.ButtonApiPost = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonApiPost
            // 
            this.ButtonApiPost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonApiPost.Location = new System.Drawing.Point(13, 13);
            this.ButtonApiPost.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonApiPost.Name = "ButtonApiPost";
            this.ButtonApiPost.Size = new System.Drawing.Size(424, 75);
            this.ButtonApiPost.TabIndex = 0;
            this.ButtonApiPost.Text = "Validate | Post Tracking";
            this.ButtonApiPost.UseVisualStyleBackColor = true;
            this.ButtonApiPost.Click += new System.EventHandler(this.ButtonApiPost_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 1;
            // 
            // FormMainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 140);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonApiPost);
            this.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormMainUI";
            this.Text = "API Post Tracking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonApiPost;
        private System.Windows.Forms.Label label1;
    }
}

