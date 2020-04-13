namespace AdditionalTask
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
            this.IsCompleteButton = new System.Windows.Forms.Button();
            this.EndButton = new System.Windows.Forms.Button();
            this.CallbacButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // IsCompleteButton
            // 
            this.IsCompleteButton.Location = new System.Drawing.Point(12, 287);
            this.IsCompleteButton.Name = "IsCompleteButton";
            this.IsCompleteButton.Size = new System.Drawing.Size(75, 23);
            this.IsCompleteButton.TabIndex = 0;
            this.IsCompleteButton.Text = "IsComplete";
            this.IsCompleteButton.UseVisualStyleBackColor = true;
            this.IsCompleteButton.Click += new System.EventHandler(this.IsCompleteButton_Click);
            // 
            // EndButton
            // 
            this.EndButton.Location = new System.Drawing.Point(140, 286);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(75, 23);
            this.EndButton.TabIndex = 1;
            this.EndButton.Text = "End";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // CallbacButton
            // 
            this.CallbacButton.Location = new System.Drawing.Point(294, 286);
            this.CallbacButton.Name = "CallbacButton";
            this.CallbacButton.Size = new System.Drawing.Size(75, 23);
            this.CallbacButton.TabIndex = 2;
            this.CallbacButton.Text = "Callback";
            this.CallbacButton.UseVisualStyleBackColor = true;
            this.CallbacButton.Click += new System.EventHandler(this.CallbacButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(357, 249);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 362);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.CallbacButton);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.IsCompleteButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button IsCompleteButton;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.Button CallbacButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

