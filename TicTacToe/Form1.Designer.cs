namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblResult = new Label();
            btnStart = new Button();
            lblXScore = new Label();
            lblOScore = new Label();
            SuspendLayout();
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(12, 19);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(45, 20);
            lblResult.TabIndex = 0;
            lblResult.Text = "result";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(138, 29);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 29);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // lblXScore
            // 
            lblXScore.AutoSize = true;
            lblXScore.Location = new Point(12, 107);
            lblXScore.Name = "lblXScore";
            lblXScore.Size = new Size(21, 20);
            lblXScore.TabIndex = 2;
            lblXScore.Text = "X:";
            // 
            // lblOScore
            // 
            lblOScore.AutoSize = true;
            lblOScore.Location = new Point(321, 107);
            lblOScore.Name = "lblOScore";
            lblOScore.Size = new Size(23, 20);
            lblOScore.TabIndex = 3;
            lblOScore.Text = "O:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 384);
            Controls.Add(lblOScore);
            Controls.Add(lblXScore);
            Controls.Add(btnStart);
            Controls.Add(lblResult);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResult;
        private Button btnStart;
        private Label lblXScore;
        private Label lblOScore;
    }
}
