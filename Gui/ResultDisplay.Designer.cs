﻿
namespace Vsite.CSharp.KvadratnaJednadzba.Gui
{
    partial class ResultDisplay
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownC = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownB = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownA = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDiscriminant = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxRoot2 = new System.Windows.Forms.TextBox();
            this.textBoxRoot1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownC);
            this.groupBox1.Controls.Add(this.numericUpDownB);
            this.groupBox1.Controls.Add(this.numericUpDownA);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coeficients";
            // 
            // numericUpDownC
            // 
            this.numericUpDownC.DecimalPlaces = 2;
            this.numericUpDownC.Location = new System.Drawing.Point(72, 87);
            this.numericUpDownC.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.numericUpDownC.Minimum = new decimal(new int[] {
            32000,
            0,
            0,
            -2147483648});
            this.numericUpDownC.Name = "numericUpDownC";
            this.numericUpDownC.Size = new System.Drawing.Size(101, 22);
            this.numericUpDownC.TabIndex = 5;
            this.numericUpDownC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownC.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDownB
            // 
            this.numericUpDownB.DecimalPlaces = 2;
            this.numericUpDownB.Location = new System.Drawing.Point(72, 59);
            this.numericUpDownB.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.numericUpDownB.Minimum = new decimal(new int[] {
            32000,
            0,
            0,
            -2147483648});
            this.numericUpDownB.Name = "numericUpDownB";
            this.numericUpDownB.Size = new System.Drawing.Size(101, 22);
            this.numericUpDownB.TabIndex = 4;
            this.numericUpDownB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownB.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDownA
            // 
            this.numericUpDownA.DecimalPlaces = 2;
            this.numericUpDownA.Location = new System.Drawing.Point(72, 30);
            this.numericUpDownA.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.numericUpDownA.Minimum = new decimal(new int[] {
            32000,
            0,
            0,
            -2147483648});
            this.numericUpDownA.Name = "numericUpDownA";
            this.numericUpDownA.Size = new System.Drawing.Size(101, 22);
            this.numericUpDownA.TabIndex = 3;
            this.numericUpDownA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownA.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "&c:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "&b:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "&a:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "&Discriminant:";
            // 
            // textBoxDiscriminant
            // 
            this.textBoxDiscriminant.Location = new System.Drawing.Point(122, 190);
            this.textBoxDiscriminant.Name = "textBoxDiscriminant";
            this.textBoxDiscriminant.ReadOnly = true;
            this.textBoxDiscriminant.Size = new System.Drawing.Size(100, 22);
            this.textBoxDiscriminant.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxRoot2);
            this.groupBox2.Controls.Add(this.textBoxRoot1);
            this.groupBox2.Location = new System.Drawing.Point(21, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 130);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Roots";
            // 
            // textBoxRoot2
            // 
            this.textBoxRoot2.Location = new System.Drawing.Point(18, 79);
            this.textBoxRoot2.Name = "textBoxRoot2";
            this.textBoxRoot2.Size = new System.Drawing.Size(158, 22);
            this.textBoxRoot2.TabIndex = 1;
            // 
            // textBoxRoot1
            // 
            this.textBoxRoot1.Location = new System.Drawing.Point(18, 37);
            this.textBoxRoot1.Name = "textBoxRoot1";
            this.textBoxRoot1.Size = new System.Drawing.Size(158, 22);
            this.textBoxRoot1.TabIndex = 0;
            // 
            // ResultDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBoxDiscriminant);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "ResultDisplay";
            this.Size = new System.Drawing.Size(241, 383);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownC;
        private System.Windows.Forms.NumericUpDown numericUpDownB;
        private System.Windows.Forms.NumericUpDown numericUpDownA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDiscriminant;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxRoot2;
        private System.Windows.Forms.TextBox textBoxRoot1;
    }
}
