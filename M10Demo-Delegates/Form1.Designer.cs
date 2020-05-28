namespace M10Demo_Delegates
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.PlusButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.PlusMinusButton = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VD_textBox_Output = new System.Windows.Forms.TextBox();
            this.VD_PlusMinusBtn = new System.Windows.Forms.Button();
            this.VD_MinusBtn = new System.Windows.Forms.Button();
            this.VD_PlusBtn = new System.Windows.Forms.Button();
            this.VD_textBoxZ2 = new System.Windows.Forms.TextBox();
            this.VD_textBoxZ1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AD_FindBtn = new System.Windows.Forms.Button();
            this.AD_textBox_Output = new System.Windows.Forms.TextBox();
            this.UE_LengthBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.UE_textBox_Output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(52, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(17, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(49, 20);
            this.textBox2.TabIndex = 1;
            // 
            // PlusButton
            // 
            this.PlusButton.Location = new System.Drawing.Point(21, 124);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(55, 23);
            this.PlusButton.TabIndex = 2;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.Location = new System.Drawing.Point(21, 166);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(55, 23);
            this.MinusButton.TabIndex = 3;
            this.MinusButton.Text = "--";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // PlusMinusButton
            // 
            this.PlusMinusButton.Location = new System.Drawing.Point(21, 208);
            this.PlusMinusButton.Name = "PlusMinusButton";
            this.PlusMinusButton.Size = new System.Drawing.Size(55, 23);
            this.PlusMinusButton.TabIndex = 4;
            this.PlusMinusButton.Text = "+ --";
            this.PlusMinusButton.UseVisualStyleBackColor = true;
            this.PlusMinusButton.Click += new System.EventHandler(this.PlusMinusButton_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(19, 255);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(56, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "benutzerdefinierter Delegat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "vordefinierter Delegat";
            // 
            // VD_textBox_Output
            // 
            this.VD_textBox_Output.Location = new System.Drawing.Point(245, 255);
            this.VD_textBox_Output.Name = "VD_textBox_Output";
            this.VD_textBox_Output.Size = new System.Drawing.Size(56, 20);
            this.VD_textBox_Output.TabIndex = 13;
            // 
            // VD_PlusMinusBtn
            // 
            this.VD_PlusMinusBtn.Location = new System.Drawing.Point(247, 208);
            this.VD_PlusMinusBtn.Name = "VD_PlusMinusBtn";
            this.VD_PlusMinusBtn.Size = new System.Drawing.Size(55, 23);
            this.VD_PlusMinusBtn.TabIndex = 12;
            this.VD_PlusMinusBtn.Text = "+ --";
            this.VD_PlusMinusBtn.UseVisualStyleBackColor = true;
            this.VD_PlusMinusBtn.Click += new System.EventHandler(this.VD_PlusMinusBtn_Click);
            // 
            // VD_MinusBtn
            // 
            this.VD_MinusBtn.Location = new System.Drawing.Point(247, 166);
            this.VD_MinusBtn.Name = "VD_MinusBtn";
            this.VD_MinusBtn.Size = new System.Drawing.Size(55, 23);
            this.VD_MinusBtn.TabIndex = 11;
            this.VD_MinusBtn.Text = "--";
            this.VD_MinusBtn.UseVisualStyleBackColor = true;
            this.VD_MinusBtn.Click += new System.EventHandler(this.VD_MinusBtn_Click);
            // 
            // VD_PlusBtn
            // 
            this.VD_PlusBtn.Location = new System.Drawing.Point(247, 124);
            this.VD_PlusBtn.Name = "VD_PlusBtn";
            this.VD_PlusBtn.Size = new System.Drawing.Size(55, 23);
            this.VD_PlusBtn.TabIndex = 10;
            this.VD_PlusBtn.Text = "+";
            this.VD_PlusBtn.UseVisualStyleBackColor = true;
            this.VD_PlusBtn.Click += new System.EventHandler(this.VD_PlusBtn_Click);
            // 
            // VD_textBoxZ2
            // 
            this.VD_textBoxZ2.Location = new System.Drawing.Point(243, 74);
            this.VD_textBoxZ2.Name = "VD_textBoxZ2";
            this.VD_textBoxZ2.Size = new System.Drawing.Size(49, 20);
            this.VD_textBoxZ2.TabIndex = 9;
            // 
            // VD_textBoxZ1
            // 
            this.VD_textBoxZ1.Location = new System.Drawing.Point(241, 40);
            this.VD_textBoxZ1.Name = "VD_textBoxZ1";
            this.VD_textBoxZ1.Size = new System.Drawing.Size(52, 20);
            this.VD_textBoxZ1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "anonyme Delegaten";
            // 
            // AD_FindBtn
            // 
            this.AD_FindBtn.Location = new System.Drawing.Point(24, 350);
            this.AD_FindBtn.Name = "AD_FindBtn";
            this.AD_FindBtn.Size = new System.Drawing.Size(82, 35);
            this.AD_FindBtn.TabIndex = 15;
            this.AD_FindBtn.Text = "Find";
            this.AD_FindBtn.UseVisualStyleBackColor = true;
            this.AD_FindBtn.Click += new System.EventHandler(this.AD_FindBtn_Click);
            // 
            // AD_textBox_Output
            // 
            this.AD_textBox_Output.Location = new System.Drawing.Point(30, 409);
            this.AD_textBox_Output.Name = "AD_textBox_Output";
            this.AD_textBox_Output.Size = new System.Drawing.Size(75, 20);
            this.AD_textBox_Output.TabIndex = 16;
            // 
            // UE_LengthBtn
            // 
            this.UE_LengthBtn.Location = new System.Drawing.Point(229, 350);
            this.UE_LengthBtn.Name = "UE_LengthBtn";
            this.UE_LengthBtn.Size = new System.Drawing.Size(87, 38);
            this.UE_LengthBtn.TabIndex = 17;
            this.UE_LengthBtn.Text = "GiveLength";
            this.UE_LengthBtn.UseVisualStyleBackColor = true;
            this.UE_LengthBtn.Click += new System.EventHandler(this.UE_LengthBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Ü ForEach(Action)";
            // 
            // UE_textBox_Output
            // 
            this.UE_textBox_Output.Location = new System.Drawing.Point(229, 409);
            this.UE_textBox_Output.Name = "UE_textBox_Output";
            this.UE_textBox_Output.Size = new System.Drawing.Size(87, 20);
            this.UE_textBox_Output.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 450);
            this.Controls.Add(this.UE_textBox_Output);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UE_LengthBtn);
            this.Controls.Add(this.AD_textBox_Output);
            this.Controls.Add(this.AD_FindBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VD_textBox_Output);
            this.Controls.Add(this.VD_PlusMinusBtn);
            this.Controls.Add(this.VD_MinusBtn);
            this.Controls.Add(this.VD_PlusBtn);
            this.Controls.Add(this.VD_textBoxZ2);
            this.Controls.Add(this.VD_textBoxZ1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.PlusMinusButton);
            this.Controls.Add(this.MinusButton);
            this.Controls.Add(this.PlusButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button PlusMinusButton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox VD_textBox_Output;
        private System.Windows.Forms.Button VD_PlusMinusBtn;
        private System.Windows.Forms.Button VD_MinusBtn;
        private System.Windows.Forms.Button VD_PlusBtn;
        private System.Windows.Forms.TextBox VD_textBoxZ2;
        private System.Windows.Forms.TextBox VD_textBoxZ1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AD_FindBtn;
        private System.Windows.Forms.TextBox AD_textBox_Output;
        private System.Windows.Forms.Button UE_LengthBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UE_textBox_Output;
    }
}

