
namespace Vsite.CSharp.KvadratnaJednadzba.Gui
{
    partial class KvadratnaJednadzba
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
            this.resultDisplay = new Vsite.CSharp.KvadratnaJednadzba.Gui.ResultDisplay();
            this.functionPanel1 = new Vsite.CSharp.KvadratnaJednadzba.Gui.FunctionPanel();
            ((System.ComponentModel.ISupportInitialize)(this.functionPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // resultDisplay
            // 
            this.resultDisplay.Location = new System.Drawing.Point(12, 12);
            this.resultDisplay.Name = "resultDisplay";
            this.resultDisplay.Size = new System.Drawing.Size(241, 383);
            this.resultDisplay.TabIndex = 1;
            // 
            // functionPanel1
            // 
            this.functionPanel1.Location = new System.Drawing.Point(290, 37);
            this.functionPanel1.Name = "functionPanel1";
            this.functionPanel1.Size = new System.Drawing.Size(621, 336);
            this.functionPanel1.TabIndex = 2;
            this.functionPanel1.TabStop = false;
            // 
            // KvadratnaJednadzba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 511);
            this.Controls.Add(this.functionPanel1);
            this.Controls.Add(this.resultDisplay);
            this.Name = "KvadratnaJednadzba";
            this.Text = "Kvadratna Jednadzba";
            ((System.ComponentModel.ISupportInitialize)(this.functionPanel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ResultDisplay resultDisplay;
        private FunctionPanel functionPanel1;
    }
}

