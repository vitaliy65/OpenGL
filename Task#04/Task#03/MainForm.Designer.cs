
namespace Task_04
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            label10 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label9 = new System.Windows.Forms.Label();
            numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            textBox2 = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            label8 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            textBox1 = new System.Windows.Forms.TextBox();
            numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            button1 = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            radioButton3 = new System.Windows.Forms.RadioButton();
            radioButton1 = new System.Windows.Forms.RadioButton();
            radioButton2 = new System.Windows.Forms.RadioButton();
            panel2 = new System.Windows.Forms.Panel();
            renderControl2 = new RenderControl();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown6).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(972, 717);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            panel3.Controls.Add(label10);
            panel3.Controls.Add(groupBox2);
            panel3.Controls.Add(groupBox1);
            panel3.Controls.Add(numericUpDown3);
            panel3.Controls.Add(numericUpDown4);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(numericUpDown2);
            panel3.Controls.Add(numericUpDown1);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(radioButton3);
            panel3.Controls.Add(radioButton1);
            panel3.Controls.Add(radioButton2);
            panel3.Location = new System.Drawing.Point(718, 12);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(242, 700);
            panel3.TabIndex = 14;
            // 
            // label10
            // 
            label10.Location = new System.Drawing.Point(22, 497);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(201, 135);
            label10.TabIndex = 27;
            label10.Text = "Що б створити лінію вам потірбно натиснути на LMB для першої точки і RMB для другої. \r\n\r\nПісля цього створиться лінія і якщо вона перетинає будь яку фігуру на цьому місці буде створена точка.";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(numericUpDown7);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(numericUpDown6);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new System.Drawing.Point(22, 294);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(201, 177);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            groupBox2.Text = "Elips";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(6, 124);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(52, 15);
            label9.TabIndex = 34;
            label9.Text = "Radius Y";
            // 
            // numericUpDown7
            // 
            numericUpDown7.DecimalPlaces = 1;
            numericUpDown7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            numericUpDown7.Location = new System.Drawing.Point(10, 142);
            numericUpDown7.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown7.Name = "numericUpDown7";
            numericUpDown7.Size = new System.Drawing.Size(182, 25);
            numericUpDown7.TabIndex = 35;
            numericUpDown7.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(10, 46);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(182, 23);
            textBox2.TabIndex = 33;
            textBox2.Text = "0,0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(6, 78);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(52, 15);
            label7.TabIndex = 31;
            label7.Text = "Radius X";
            // 
            // numericUpDown6
            // 
            numericUpDown6.DecimalPlaces = 1;
            numericUpDown6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            numericUpDown6.Location = new System.Drawing.Point(10, 96);
            numericUpDown6.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown6.Name = "numericUpDown6";
            numericUpDown6.Size = new System.Drawing.Size(182, 25);
            numericUpDown6.TabIndex = 32;
            numericUpDown6.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(6, 28);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(71, 15);
            label8.TabIndex = 30;
            label8.Text = "Center (0, 0)";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(numericUpDown5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new System.Drawing.Point(22, 156);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(201, 132);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Circle";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(10, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(182, 23);
            textBox1.TabIndex = 29;
            textBox1.Text = "0,0";
            // 
            // numericUpDown5
            // 
            numericUpDown5.DecimalPlaces = 1;
            numericUpDown5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            numericUpDown5.Location = new System.Drawing.Point(10, 95);
            numericUpDown5.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new System.Drawing.Size(182, 25);
            numericUpDown5.TabIndex = 27;
            numericUpDown5.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(6, 77);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(42, 15);
            label6.TabIndex = 1;
            label6.Text = "Radius";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(6, 27);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(71, 15);
            label5.TabIndex = 0;
            label5.Text = "Center (0, 0)";
            // 
            // numericUpDown3
            // 
            numericUpDown3.DecimalPlaces = 1;
            numericUpDown3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            numericUpDown3.Location = new System.Drawing.Point(103, 77);
            numericUpDown3.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new System.Drawing.Size(111, 29);
            numericUpDown3.TabIndex = 24;
            numericUpDown3.Value = new decimal(new int[] { 5, 0, 0, int.MinValue });
            numericUpDown3.ValueChanged += numericUpDown3_ValueChanged;
            // 
            // numericUpDown4
            // 
            numericUpDown4.DecimalPlaces = 1;
            numericUpDown4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            numericUpDown4.Location = new System.Drawing.Point(103, 112);
            numericUpDown4.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new System.Drawing.Size(111, 29);
            numericUpDown4.TabIndex = 23;
            numericUpDown4.Value = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown4.ValueChanged += numericUpDown4_ValueChanged;
            // 
            // button1
            // 
            button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            button1.Location = new System.Drawing.Point(0, 677);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(242, 23);
            button1.TabIndex = 20;
            button1.Text = "Create figures";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(32, 80);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(45, 20);
            label3.TabIndex = 22;
            label3.Text = "Ymin";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(32, 115);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(49, 20);
            label4.TabIndex = 21;
            label4.Text = "Ymax";
            // 
            // numericUpDown2
            // 
            numericUpDown2.DecimalPlaces = 1;
            numericUpDown2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            numericUpDown2.Location = new System.Drawing.Point(103, 42);
            numericUpDown2.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new System.Drawing.Size(111, 29);
            numericUpDown2.TabIndex = 18;
            numericUpDown2.Value = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 1;
            numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            numericUpDown1.Location = new System.Drawing.Point(103, 7);
            numericUpDown1.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(111, 29);
            numericUpDown1.TabIndex = 17;
            numericUpDown1.Value = new decimal(new int[] { 5, 0, 0, int.MinValue });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(32, 45);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(49, 20);
            label2.TabIndex = 15;
            label2.Text = "Xmax";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(32, 10);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(45, 20);
            label1.TabIndex = 14;
            label1.Text = "Xmin";
            // 
            // radioButton3
            // 
            radioButton3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            radioButton3.AutoSize = true;
            radioButton3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            radioButton3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            radioButton3.Location = new System.Drawing.Point(3, 1096);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new System.Drawing.Size(107, 25);
            radioButton3.TabIndex = 9;
            radioButton3.TabStop = true;
            radioButton3.Text = "Point mode";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            radioButton1.AutoSize = true;
            radioButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            radioButton1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            radioButton1.Location = new System.Drawing.Point(3, 1034);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(92, 25);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "Fill mode";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            radioButton2.AutoSize = true;
            radioButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            radioButton2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            radioButton2.Location = new System.Drawing.Point(3, 1065);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new System.Drawing.Size(101, 25);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "Line mode";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel2.BackColor = System.Drawing.Color.White;
            panel2.Controls.Add(renderControl2);
            panel2.Location = new System.Drawing.Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(700, 700);
            panel2.TabIndex = 7;
            panel2.Resize += panel2_Resize;
            // 
            // renderControl2
            // 
            renderControl2.BackColor = System.Drawing.SystemColors.Control;
            renderControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            renderControl2.ForeColor = System.Drawing.Color.White;
            renderControl2.Location = new System.Drawing.Point(0, 0);
            renderControl2.Name = "renderControl2";
            renderControl2.Size = new System.Drawing.Size(700, 700);
            renderControl2.TabIndex = 0;
            renderControl2.TextCodePage = 1251;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(972, 717);
            Controls.Add(panel1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Main Form";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown7).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown6).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private RenderControl renderControl2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
    }
}

