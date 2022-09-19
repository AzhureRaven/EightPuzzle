
namespace EightPuzzle
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBoxStart = new System.Windows.Forms.RichTextBox();
            this.richTextBoxGoal = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBoxOpen = new System.Windows.Forms.RichTextBox();
            this.richTextBoxClose = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(13, 41);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(219, 369);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nodes Expanded: 0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Recurring State: 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Depth of Solution: 0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Renegade State: 0";
            // 
            // richTextBoxStart
            // 
            this.richTextBoxStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.richTextBoxStart.Location = new System.Drawing.Point(238, 58);
            this.richTextBoxStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBoxStart.Name = "richTextBoxStart";
            this.richTextBoxStart.Size = new System.Drawing.Size(222, 197);
            this.richTextBoxStart.TabIndex = 6;
            this.richTextBoxStart.Text = "";
            // 
            // richTextBoxGoal
            // 
            this.richTextBoxGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.richTextBoxGoal.Location = new System.Drawing.Point(238, 283);
            this.richTextBoxGoal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBoxGoal.Name = "richTextBoxGoal";
            this.richTextBoxGoal.Size = new System.Drawing.Size(222, 197);
            this.richTextBoxGoal.TabIndex = 7;
            this.richTextBoxGoal.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Start State";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Goal State";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(240, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(685, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBoxOpen
            // 
            this.richTextBoxOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.richTextBoxOpen.Location = new System.Drawing.Point(471, 58);
            this.richTextBoxOpen.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxOpen.Name = "richTextBoxOpen";
            this.richTextBoxOpen.ReadOnly = true;
            this.richTextBoxOpen.Size = new System.Drawing.Size(222, 422);
            this.richTextBoxOpen.TabIndex = 11;
            this.richTextBoxOpen.Text = "";
            // 
            // richTextBoxClose
            // 
            this.richTextBoxClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.richTextBoxClose.Location = new System.Drawing.Point(706, 58);
            this.richTextBoxClose.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxClose.Name = "richTextBoxClose";
            this.richTextBoxClose.ReadOnly = true;
            this.richTextBoxClose.Size = new System.Drawing.Size(222, 422);
            this.richTextBoxClose.TabIndex = 12;
            this.richTextBoxClose.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(468, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Open Log";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(703, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Close Log";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 488);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.richTextBoxClose);
            this.Controls.Add(this.richTextBoxOpen);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTextBoxGoal);
            this.Controls.Add(this.richTextBoxStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "8-Puzzle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBoxStart;
        private System.Windows.Forms.RichTextBox richTextBoxGoal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBoxOpen;
        private System.Windows.Forms.RichTextBox richTextBoxClose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

