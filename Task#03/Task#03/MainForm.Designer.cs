
namespace Task_03
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
            checkBox1 = new System.Windows.Forms.CheckBox();
            numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            radioButton3 = new System.Windows.Forms.RadioButton();
            radioButton1 = new System.Windows.Forms.RadioButton();
            radioButton2 = new System.Windows.Forms.RadioButton();
            panel2 = new System.Windows.Forms.Panel();
            renderControl1 = new RenderControl();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
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
            panel1.Size = new System.Drawing.Size(728, 527);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            panel3.Controls.Add(checkBox1);
            panel3.Controls.Add(numericUpDown4);
            panel3.Controls.Add(numericUpDown5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(numericUpDown3);
            panel3.Controls.Add(numericUpDown2);
            panel3.Controls.Add(numericUpDown1);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(radioButton3);
            panel3.Controls.Add(radioButton1);
            panel3.Controls.Add(radioButton2);
            panel3.Location = new System.Drawing.Point(528, 12);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(188, 503);
            panel3.TabIndex = 14;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new System.Drawing.Point(3, 154);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(125, 19);
            checkBox1.TabIndex = 25;
            checkBox1.Text = "second function f2";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // numericUpDown4
            // 
            numericUpDown4.DecimalPlaces = 1;
            numericUpDown4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            numericUpDown4.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown4.Location = new System.Drawing.Point(74, 110);
            numericUpDown4.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new System.Drawing.Size(111, 29);
            numericUpDown4.TabIndex = 24;
            // 
            // numericUpDown5
            // 
            numericUpDown5.DecimalPlaces = 1;
            numericUpDown5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            numericUpDown5.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown5.Location = new System.Drawing.Point(74, 75);
            numericUpDown5.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new System.Drawing.Size(111, 29);
            numericUpDown5.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(3, 113);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(45, 20);
            label4.TabIndex = 22;
            label4.Text = "yMax";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(3, 78);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(41, 20);
            label5.TabIndex = 21;
            label5.Text = "yMin";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(3, 466);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(182, 23);
            button1.TabIndex = 20;
            button1.Text = "Create graph";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            numericUpDown3.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown3.Location = new System.Drawing.Point(74, 410);
            numericUpDown3.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });

            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new System.Drawing.Size(111, 29);
            numericUpDown3.TabIndex = 19;
            // 
            // numericUpDown2
            // 
            numericUpDown2.DecimalPlaces = 1;
            numericUpDown2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            numericUpDown2.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown2.Location = new System.Drawing.Point(74, 41);
            numericUpDown2.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new System.Drawing.Size(111, 29);
            numericUpDown2.TabIndex = 18;
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 1;
            numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            numericUpDown1.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown1.Location = new System.Drawing.Point(74, 6);
            numericUpDown1.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(111, 29);
            numericUpDown1.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(3, 413);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(53, 20);
            label3.TabIndex = 16;
            label3.Text = "Points";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(3, 44);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(45, 20);
            label2.TabIndex = 15;
            label2.Text = "xMax";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(3, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(41, 20);
            label1.TabIndex = 14;
            label1.Text = "xMin";
            // 
            // radioButton3
            // 
            radioButton3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            radioButton3.AutoSize = true;
            radioButton3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            radioButton3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            radioButton3.Location = new System.Drawing.Point(3, 899);
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
            radioButton1.Location = new System.Drawing.Point(3, 837);
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
            radioButton2.Location = new System.Drawing.Point(3, 868);
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
            panel2.Controls.Add(renderControl1);
            panel2.Location = new System.Drawing.Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(503, 503);
            panel2.TabIndex = 7;
            panel2.Resize += panel2_Resize;
            // 
            // renderControl1
            // 
            renderControl1.BackColor = System.Drawing.Color.White;
            renderControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            renderControl1.ForeColor = System.Drawing.Color.White;
            renderControl1.Location = new System.Drawing.Point(0, 0);
            renderControl1.Name = "renderControl1";
            renderControl1.Size = new System.Drawing.Size(503, 503);
            renderControl1.TabIndex = 0;
            renderControl1.TextCodePage = 1251;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(728, 527);
            Controls.Add(panel1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Main Form";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private RenderControl renderControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

