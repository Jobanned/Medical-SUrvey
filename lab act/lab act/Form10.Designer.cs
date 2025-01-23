namespace lab_act
{
    partial class Form10
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
            label6 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label6.Location = new Point(300, 171);
            label6.Name = "label6";
            label6.Size = new Size(162, 32);
            label6.TabIndex = 69;
            label6.Text = "THANK YOU!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(286, 212);
            label2.Name = "label2";
            label2.Size = new Size(196, 21);
            label2.TabIndex = 70;
            label2.Text = "We will contact you shortly";
            // 
            // button1
            // 
            button1.Location = new Point(320, 312);
            button1.Name = "button1";
            button1.Size = new Size(142, 38);
            button1.TabIndex = 71;
            button1.Text = "Send Answer";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 463);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label6);
            Name = "Form10";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form10";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label2;
        private Button button1;
    }
}