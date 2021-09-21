
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
            this.SuspendLayout();
            // 
            // CarListBox
            // 
            this.CarListBox.FormattingEnabled = true;
            this.CarListBox.ItemHeight = 16;
            this.CarListBox.Location = new System.Drawing.Point(176, 162);
            this.CarListBox.Name = "CarListBox";
            this.CarListBox.Size = new System.Drawing.Size(477, 276);
            this.CarListBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CarListBox);
            this.Name = "Form1";
            this.Text = "Car List";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox CarListBox;
    }
}

