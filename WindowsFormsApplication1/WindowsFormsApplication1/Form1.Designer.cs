namespace WindowsFormsApplication1
{
    partial class NQueensGUI
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
            this.tbNumOfQueens = new System.Windows.Forms.TextBox();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.tbSolutions = new System.Windows.Forms.TextBox();
            this.tbRunningTime = new System.Windows.Forms.TextBox();
            this.tbAttempts = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rbGUIOutput = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNumOfQueens
            // 
            this.tbNumOfQueens.Location = new System.Drawing.Point(124, 36);
            this.tbNumOfQueens.Name = "tbNumOfQueens";
            this.tbNumOfQueens.Size = new System.Drawing.Size(136, 20);
            this.tbNumOfQueens.TabIndex = 0;
            // 
            // tbStatus
            // 
            this.tbStatus.Location = new System.Drawing.Point(124, 60);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(136, 20);
            this.tbStatus.TabIndex = 1;
            // 
            // tbSolutions
            // 
            this.tbSolutions.Location = new System.Drawing.Point(124, 84);
            this.tbSolutions.Name = "tbSolutions";
            this.tbSolutions.Size = new System.Drawing.Size(136, 20);
            this.tbSolutions.TabIndex = 2;
            // 
            // tbRunningTime
            // 
            this.tbRunningTime.Location = new System.Drawing.Point(123, 133);
            this.tbRunningTime.Name = "tbRunningTime";
            this.tbRunningTime.Size = new System.Drawing.Size(137, 20);
            this.tbRunningTime.TabIndex = 3;
            // 
            // tbAttempts
            // 
            this.tbAttempts.Location = new System.Drawing.Point(124, 109);
            this.tbAttempts.Name = "tbAttempts";
            this.tbAttempts.Size = new System.Drawing.Size(136, 20);
            this.tbAttempts.TabIndex = 4;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(13, 43);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(96, 13);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Number of Queens";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(13, 67);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(37, 13);
            this.Label2.TabIndex = 6;
            this.Label2.Text = "Status";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(13, 91);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(50, 13);
            this.Label3.TabIndex = 7;
            this.Label3.Text = "Solutions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Running Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Attempts";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 105);
            this.button1.TabIndex = 10;
            this.button1.Text = "Solve";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbGUIOutput
            // 
            this.rbGUIOutput.Location = new System.Drawing.Point(299, 36);
            this.rbGUIOutput.Name = "rbGUIOutput";
            this.rbGUIOutput.Size = new System.Drawing.Size(277, 498);
            this.rbGUIOutput.TabIndex = 12;
            this.rbGUIOutput.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "HH:MM:SS:MS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label7.Location = new System.Drawing.Point(356, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 31);
            this.label7.TabIndex = 14;
            this.label7.Text = "Solution GUI";
            // 
            // NQueensGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 552);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rbGUIOutput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.tbAttempts);
            this.Controls.Add(this.tbRunningTime);
            this.Controls.Add(this.tbSolutions);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.tbNumOfQueens);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NQueensGUI";
            this.Text = "NQueens Solver by Christopher Cunningham";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNumOfQueens;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.TextBox tbSolutions;
        private System.Windows.Forms.TextBox tbRunningTime;
        private System.Windows.Forms.TextBox tbAttempts;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rbGUIOutput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

