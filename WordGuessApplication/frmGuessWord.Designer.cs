namespace WordGuessApplication
{
    partial class frmGuessWord
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
            this.GuessBox = new System.Windows.Forms.TextBox();
            this.GuessWord = new System.Windows.Forms.Button();
            this.WordGuess = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GuessBox
            // 
            this.GuessBox.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuessBox.Location = new System.Drawing.Point(18, 132);
            this.GuessBox.Name = "GuessBox";
            this.GuessBox.Size = new System.Drawing.Size(289, 26);
            this.GuessBox.TabIndex = 0;
            // 
            // GuessWord
            // 
            this.GuessWord.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GuessWord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GuessWord.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuessWord.Location = new System.Drawing.Point(113, 175);
            this.GuessWord.Name = "GuessWord";
            this.GuessWord.Size = new System.Drawing.Size(106, 40);
            this.GuessWord.TabIndex = 1;
            this.GuessWord.Text = "Guess";
            this.GuessWord.UseVisualStyleBackColor = false;
            this.GuessWord.Click += new System.EventHandler(this.Guess_Click);
            // 
            // WordGuess
            // 
            this.WordGuess.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.WordGuess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WordGuess.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WordGuess.Location = new System.Drawing.Point(18, 21);
            this.WordGuess.Name = "WordGuess";
            this.WordGuess.Size = new System.Drawing.Size(289, 77);
            this.WordGuess.TabIndex = 2;
            this.WordGuess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WordGuess.Click += new System.EventHandler(this.WordGuess_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(326, 81);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(187, 99);
            this.listBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(326, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 41);
            this.label2.TabIndex = 4;
            this.label2.Text = "Guess Word";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "hint: Sanrio";
            // 
            // frmGuessWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 238);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.WordGuess);
            this.Controls.Add(this.GuessWord);
            this.Controls.Add(this.GuessBox);
            this.Name = "frmGuessWord";
            this.Text = "Guess the Word";
            this.Load += new System.EventHandler(this.frmGuessWord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox GuessBox;
        private System.Windows.Forms.Button GuessWord;
        private System.Windows.Forms.Label WordGuess;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

