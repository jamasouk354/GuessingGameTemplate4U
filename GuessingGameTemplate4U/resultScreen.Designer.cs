namespace GuessingGameTemplate4U
{
    partial class resultScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.guessTakenLabel = new System.Windows.Forms.Label();
            this.origOrder = new System.Windows.Forms.Label();
            this.sortOrder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(75, 46);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(144, 37);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "You got it!";
            // 
            // guessTakenLabel
            // 
            this.guessTakenLabel.AutoSize = true;
            this.guessTakenLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessTakenLabel.ForeColor = System.Drawing.Color.White;
            this.guessTakenLabel.Location = new System.Drawing.Point(21, 106);
            this.guessTakenLabel.Name = "guessTakenLabel";
            this.guessTakenLabel.Size = new System.Drawing.Size(117, 21);
            this.guessTakenLabel.TabIndex = 7;
            this.guessTakenLabel.Text = "Guesses made: ";
            // 
            // origOrder
            // 
            this.origOrder.AutoSize = true;
            this.origOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.origOrder.ForeColor = System.Drawing.Color.White;
            this.origOrder.Location = new System.Drawing.Point(21, 156);
            this.origOrder.Name = "origOrder";
            this.origOrder.Size = new System.Drawing.Size(118, 21);
            this.origOrder.TabIndex = 8;
            this.origOrder.Text = "Original Order: \r\n";
            // 
            // sortOrder
            // 
            this.sortOrder.AutoSize = true;
            this.sortOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortOrder.ForeColor = System.Drawing.Color.White;
            this.sortOrder.Location = new System.Drawing.Point(21, 216);
            this.sortOrder.Name = "sortOrder";
            this.sortOrder.Size = new System.Drawing.Size(108, 21);
            this.sortOrder.TabIndex = 9;
            this.sortOrder.Text = "Sorted Order: \r\n";
            // 
            // resultScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.sortOrder);
            this.Controls.Add(this.origOrder);
            this.Controls.Add(this.guessTakenLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "resultScreen";
            this.Size = new System.Drawing.Size(300, 300);
            this.Load += new System.EventHandler(this.resultScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label guessTakenLabel;
        private System.Windows.Forms.Label origOrder;
        private System.Windows.Forms.Label sortOrder;
    }
}
