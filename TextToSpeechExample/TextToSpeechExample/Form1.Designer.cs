namespace TextToSpeechExample
{
    partial class TextToSpeechExampleForm
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
            this.MessagetextBox = new System.Windows.Forms.TextBox();
            this.Listenbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MessagetextBox
            // 
            this.MessagetextBox.Location = new System.Drawing.Point(12, 25);
            this.MessagetextBox.Name = "MessagetextBox";
            this.MessagetextBox.Size = new System.Drawing.Size(260, 20);
            this.MessagetextBox.TabIndex = 0;
            // 
            // Listenbutton
            // 
            this.Listenbutton.Location = new System.Drawing.Point(12, 51);
            this.Listenbutton.Name = "Listenbutton";
            this.Listenbutton.Size = new System.Drawing.Size(75, 23);
            this.Listenbutton.TabIndex = 1;
            this.Listenbutton.Text = "Listen";
            this.Listenbutton.UseVisualStyleBackColor = true;
            this.Listenbutton.Click += new System.EventHandler(this.Listenbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Write the message you want to hear";
            // 
            // TextToSpeechExampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 89);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Listenbutton);
            this.Controls.Add(this.MessagetextBox);
            this.Name = "TextToSpeechExampleForm";
            this.Text = "Text to Speech Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MessagetextBox;
        private System.Windows.Forms.Button Listenbutton;
        private System.Windows.Forms.Label label1;
    }
}

