namespace Most_Frequent_Character
{
    partial class frmMostFrequentCharacter
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
            this.tboxEntryWord = new System.Windows.Forms.TextBox();
            this.lblOutMostFreqChar = new System.Windows.Forms.Label();
            this.btnSeeMostFreqChar = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arsenal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a Word:";
            // 
            // tboxEntryWord
            // 
            this.tboxEntryWord.Font = new System.Drawing.Font("Arsenal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxEntryWord.Location = new System.Drawing.Point(203, 56);
            this.tboxEntryWord.Name = "tboxEntryWord";
            this.tboxEntryWord.Size = new System.Drawing.Size(485, 31);
            this.tboxEntryWord.TabIndex = 1;
            // 
            // lblOutMostFreqChar
            // 
            this.lblOutMostFreqChar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutMostFreqChar.Font = new System.Drawing.Font("Arsenal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutMostFreqChar.Location = new System.Drawing.Point(83, 112);
            this.lblOutMostFreqChar.Name = "lblOutMostFreqChar";
            this.lblOutMostFreqChar.Size = new System.Drawing.Size(605, 62);
            this.lblOutMostFreqChar.TabIndex = 2;
            this.lblOutMostFreqChar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSeeMostFreqChar
            // 
            this.btnSeeMostFreqChar.Font = new System.Drawing.Font("Arsenal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeMostFreqChar.Location = new System.Drawing.Point(83, 191);
            this.btnSeeMostFreqChar.Name = "btnSeeMostFreqChar";
            this.btnSeeMostFreqChar.Size = new System.Drawing.Size(306, 39);
            this.btnSeeMostFreqChar.TabIndex = 3;
            this.btnSeeMostFreqChar.Text = "See Most Frequent Character";
            this.btnSeeMostFreqChar.UseVisualStyleBackColor = true;
            this.btnSeeMostFreqChar.Click += new System.EventHandler(this.btnSeeMostFreqChar_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arsenal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(395, 191);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 39);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arsenal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(561, 191);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(127, 39);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMostFrequentCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 259);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSeeMostFreqChar);
            this.Controls.Add(this.lblOutMostFreqChar);
            this.Controls.Add(this.tboxEntryWord);
            this.Controls.Add(this.label1);
            this.Name = "frmMostFrequentCharacter";
            this.Text = "Most Frequent Character";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxEntryWord;
        private System.Windows.Forms.Label lblOutMostFreqChar;
        private System.Windows.Forms.Button btnSeeMostFreqChar;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

