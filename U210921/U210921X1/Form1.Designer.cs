
namespace U210921X1
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
            this.CarListBox = new System.Windows.Forms.ListBox();
            this.CarListBoxFunction = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CarListBox
            // 
            this.CarListBox.FormattingEnabled = true;
            this.CarListBox.ItemHeight = 16;
            this.CarListBox.Location = new System.Drawing.Point(12, 18);
            this.CarListBox.Name = "CarListBox";
            this.CarListBox.Size = new System.Drawing.Size(255, 420);
            this.CarListBox.TabIndex = 0;
            // 
            // CarListBoxFunction
            // 
            this.CarListBoxFunction.FormattingEnabled = true;
            this.CarListBoxFunction.ItemHeight = 16;
            this.CarListBoxFunction.Location = new System.Drawing.Point(315, 18);
            this.CarListBoxFunction.Name = "CarListBoxFunction";
            this.CarListBoxFunction.Size = new System.Drawing.Size(218, 420);
            this.CarListBoxFunction.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 450);
            this.Controls.Add(this.CarListBoxFunction);
            this.Controls.Add(this.CarListBox);
            this.Name = "Form1";
            this.Text = "Car List";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox CarListBox;
        private System.Windows.Forms.ListBox CarListBoxFunction;
    }
}

