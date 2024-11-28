
namespace ParseGmapsData
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
            this.InputText = new System.Windows.Forms.TextBox();
            this.OutputText = new System.Windows.Forms.TextBox();
            this.ProcessButton = new System.Windows.Forms.Button();
            this.inputDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.inputDistance = new System.Windows.Forms.TextBox();
            this.inputMile1 = new System.Windows.Forms.TextBox();
            this.inputMile2 = new System.Windows.Forms.TextBox();
            this.inputMile3 = new System.Windows.Forms.TextBox();
            this.inputMile4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputText
            // 
            this.InputText.Location = new System.Drawing.Point(16, 275);
            this.InputText.Multiline = true;
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(1390, 254);
            this.InputText.TabIndex = 0;
            // 
            // OutputText
            // 
            this.OutputText.Location = new System.Drawing.Point(12, 535);
            this.OutputText.Multiline = true;
            this.OutputText.Name = "OutputText";
            this.OutputText.Size = new System.Drawing.Size(1390, 433);
            this.OutputText.TabIndex = 1;
            // 
            // ProcessButton
            // 
            this.ProcessButton.Location = new System.Drawing.Point(1220, 994);
            this.ProcessButton.Name = "ProcessButton";
            this.ProcessButton.Size = new System.Drawing.Size(182, 57);
            this.ProcessButton.TabIndex = 2;
            this.ProcessButton.Text = "Process";
            this.ProcessButton.UseVisualStyleBackColor = true;
            this.ProcessButton.Click += new System.EventHandler(this.ProcessButton_Click);
            // 
            // inputDate
            // 
            this.inputDate.Location = new System.Drawing.Point(143, 13);
            this.inputDate.Name = "inputDate";
            this.inputDate.Size = new System.Drawing.Size(100, 26);
            this.inputDate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Date (mm/dd)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Distance";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mile 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mile 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mile 3";
            // 
            // inputDistance
            // 
            this.inputDistance.Location = new System.Drawing.Point(143, 58);
            this.inputDistance.Name = "inputDistance";
            this.inputDistance.Size = new System.Drawing.Size(501, 26);
            this.inputDistance.TabIndex = 11;
            // 
            // inputMile1
            // 
            this.inputMile1.Location = new System.Drawing.Point(143, 97);
            this.inputMile1.Name = "inputMile1";
            this.inputMile1.Size = new System.Drawing.Size(501, 26);
            this.inputMile1.TabIndex = 12;
            // 
            // inputMile2
            // 
            this.inputMile2.Location = new System.Drawing.Point(143, 136);
            this.inputMile2.Name = "inputMile2";
            this.inputMile2.Size = new System.Drawing.Size(501, 26);
            this.inputMile2.TabIndex = 13;
            // 
            // inputMile3
            // 
            this.inputMile3.Location = new System.Drawing.Point(143, 172);
            this.inputMile3.Name = "inputMile3";
            this.inputMile3.Size = new System.Drawing.Size(501, 26);
            this.inputMile3.TabIndex = 14;
            // 
            // inputMile4
            // 
            this.inputMile4.Location = new System.Drawing.Point(143, 208);
            this.inputMile4.Name = "inputMile4";
            this.inputMile4.Size = new System.Drawing.Size(501, 26);
            this.inputMile4.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mile 4";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 1063);
            this.Controls.Add(this.inputMile4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputMile3);
            this.Controls.Add(this.inputMile2);
            this.Controls.Add(this.inputMile1);
            this.Controls.Add(this.inputDistance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputDate);
            this.Controls.Add(this.ProcessButton);
            this.Controls.Add(this.OutputText);
            this.Controls.Add(this.InputText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputText;
        private System.Windows.Forms.TextBox OutputText;
        private System.Windows.Forms.Button ProcessButton;
        private System.Windows.Forms.TextBox inputDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inputDistance;
        private System.Windows.Forms.TextBox inputMile1;
        private System.Windows.Forms.TextBox inputMile2;
        private System.Windows.Forms.TextBox inputMile3;
        private System.Windows.Forms.TextBox inputMile4;
        private System.Windows.Forms.Label label2;
    }
}

