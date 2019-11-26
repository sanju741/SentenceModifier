namespace SentenceModifier
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
            this.paragraphTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.generateResultButton = new System.Windows.Forms.Button();
            this.mixingCharacterTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.appendBackCheckBox = new System.Windows.Forms.CheckBox();
            this.appendFrontCheckBox = new System.Windows.Forms.CheckBox();
            this.append1CheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.append2CheckBox = new System.Windows.Forms.CheckBox();
            this.append3CheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // paragraphTextBox
            // 
            this.paragraphTextBox.Location = new System.Drawing.Point(89, 67);
            this.paragraphTextBox.Multiline = true;
            this.paragraphTextBox.Name = "paragraphTextBox";
            this.paragraphTextBox.Size = new System.Drawing.Size(533, 247);
            this.paragraphTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Paragraph";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(89, 483);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(533, 252);
            this.resultTextBox.TabIndex = 2;
            // 
            // generateResultButton
            // 
            this.generateResultButton.Location = new System.Drawing.Point(278, 393);
            this.generateResultButton.Name = "generateResultButton";
            this.generateResultButton.Size = new System.Drawing.Size(157, 53);
            this.generateResultButton.TabIndex = 3;
            this.generateResultButton.Text = "Randomly Mix It";
            this.generateResultButton.UseVisualStyleBackColor = true;
            this.generateResultButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // mixingCharacterTextBox
            // 
            this.mixingCharacterTextBox.Location = new System.Drawing.Point(767, 94);
            this.mixingCharacterTextBox.Multiline = true;
            this.mixingCharacterTextBox.Name = "mixingCharacterTextBox";
            this.mixingCharacterTextBox.Size = new System.Drawing.Size(240, 53);
            this.mixingCharacterTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(811, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mixing Character";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 15;
            // 
            // appendBackCheckBox
            // 
            this.appendBackCheckBox.AutoSize = true;
            this.appendBackCheckBox.Location = new System.Drawing.Point(814, 238);
            this.appendBackCheckBox.Name = "appendBackCheckBox";
            this.appendBackCheckBox.Size = new System.Drawing.Size(114, 21);
            this.appendBackCheckBox.TabIndex = 16;
            this.appendBackCheckBox.Text = "Append Back";
            this.appendBackCheckBox.UseVisualStyleBackColor = true;
            // 
            // appendFrontCheckBox
            // 
            this.appendFrontCheckBox.AutoSize = true;
            this.appendFrontCheckBox.Location = new System.Drawing.Point(814, 274);
            this.appendFrontCheckBox.Name = "appendFrontCheckBox";
            this.appendFrontCheckBox.Size = new System.Drawing.Size(116, 21);
            this.appendFrontCheckBox.TabIndex = 17;
            this.appendFrontCheckBox.Text = "Append Front";
            this.appendFrontCheckBox.UseVisualStyleBackColor = true;
            // 
            // append1CheckBox
            // 
            this.append1CheckBox.AutoSize = true;
            this.append1CheckBox.Location = new System.Drawing.Point(814, 445);
            this.append1CheckBox.Name = "append1CheckBox";
            this.append1CheckBox.Size = new System.Drawing.Size(179, 21);
            this.append1CheckBox.TabIndex = 18;
            this.append1CheckBox.Text = "Append 1 random letter";
            this.append1CheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(811, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Select One";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(811, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Select One";
            // 
            // append2CheckBox
            // 
            this.append2CheckBox.AutoSize = true;
            this.append2CheckBox.Location = new System.Drawing.Point(814, 485);
            this.append2CheckBox.Name = "append2CheckBox";
            this.append2CheckBox.Size = new System.Drawing.Size(179, 21);
            this.append2CheckBox.TabIndex = 21;
            this.append2CheckBox.Text = "Append 2 random letter";
            this.append2CheckBox.UseVisualStyleBackColor = true;
            // 
            // append3CheckBox
            // 
            this.append3CheckBox.AutoSize = true;
            this.append3CheckBox.Location = new System.Drawing.Point(814, 525);
            this.append3CheckBox.Name = "append3CheckBox";
            this.append3CheckBox.Size = new System.Drawing.Size(179, 21);
            this.append3CheckBox.TabIndex = 22;
            this.append3CheckBox.Text = "Append 3 random letter";
            this.append3CheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 816);
            this.Controls.Add(this.append3CheckBox);
            this.Controls.Add(this.append2CheckBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.append1CheckBox);
            this.Controls.Add(this.appendFrontCheckBox);
            this.Controls.Add(this.appendBackCheckBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mixingCharacterTextBox);
            this.Controls.Add(this.generateResultButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paragraphTextBox);
            this.Name = "Form1";
            this.Text = "Random Text Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox paragraphTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button generateResultButton;
        private System.Windows.Forms.TextBox mixingCharacterTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox appendBackCheckBox;
        private System.Windows.Forms.CheckBox appendFrontCheckBox;
        private System.Windows.Forms.CheckBox append1CheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox append2CheckBox;
        private System.Windows.Forms.CheckBox append3CheckBox;
    }
}

