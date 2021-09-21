
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
            this.btnRedCars = new System.Windows.Forms.Button();
            this.btnAvgMileBMW = new System.Windows.Forms.Button();
            this.btnCarsOld2003 = new System.Windows.Forms.Button();
            this.btnGreyVolvo = new System.Windows.Forms.Button();
            this.btnExpCar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CarListBox
            // 
            this.CarListBox.FormattingEnabled = true;
            this.CarListBox.ItemHeight = 16;
            this.CarListBox.Location = new System.Drawing.Point(12, 82);
            this.CarListBox.Name = "CarListBox";
            this.CarListBox.Size = new System.Drawing.Size(308, 388);
            this.CarListBox.TabIndex = 0;
            // 
            // CarListBoxFunction
            // 
            this.CarListBoxFunction.FormattingEnabled = true;
            this.CarListBoxFunction.ItemHeight = 16;
            this.CarListBoxFunction.Location = new System.Drawing.Point(326, 328);
            this.CarListBoxFunction.Name = "CarListBoxFunction";
            this.CarListBoxFunction.Size = new System.Drawing.Size(439, 148);
            this.CarListBoxFunction.TabIndex = 1;
            // 
            // btnRedCars
            // 
            this.btnRedCars.Location = new System.Drawing.Point(327, 18);
            this.btnRedCars.Name = "btnRedCars";
            this.btnRedCars.Size = new System.Drawing.Size(148, 94);
            this.btnRedCars.TabIndex = 2;
            this.btnRedCars.Text = "Amount of red cars";
            this.btnRedCars.UseVisualStyleBackColor = true;
            this.btnRedCars.Click += new System.EventHandler(this.btnRedCars_Click);
            // 
            // btnAvgMileBMW
            // 
            this.btnAvgMileBMW.Location = new System.Drawing.Point(542, 128);
            this.btnAvgMileBMW.Name = "btnAvgMileBMW";
            this.btnAvgMileBMW.Size = new System.Drawing.Size(147, 94);
            this.btnAvgMileBMW.TabIndex = 3;
            this.btnAvgMileBMW.Text = "Average mileage for BMW cars";
            this.btnAvgMileBMW.UseVisualStyleBackColor = true;
            this.btnAvgMileBMW.Click += new System.EventHandler(this.btnAvgMileBMW_Click);
            // 
            // btnCarsOld2003
            // 
            this.btnCarsOld2003.Location = new System.Drawing.Point(542, 18);
            this.btnCarsOld2003.Name = "btnCarsOld2003";
            this.btnCarsOld2003.Size = new System.Drawing.Size(148, 94);
            this.btnCarsOld2003.TabIndex = 4;
            this.btnCarsOld2003.Text = "Amount of cars older than 2003";
            this.btnCarsOld2003.UseVisualStyleBackColor = true;
            this.btnCarsOld2003.Click += new System.EventHandler(this.btnCarsOld2003_Click);
            // 
            // btnGreyVolvo
            // 
            this.btnGreyVolvo.Location = new System.Drawing.Point(327, 128);
            this.btnGreyVolvo.Name = "btnGreyVolvo";
            this.btnGreyVolvo.Size = new System.Drawing.Size(147, 94);
            this.btnGreyVolvo.TabIndex = 5;
            this.btnGreyVolvo.Text = "Amount of grey Volvos";
            this.btnGreyVolvo.UseVisualStyleBackColor = true;
            this.btnGreyVolvo.Click += new System.EventHandler(this.btnGreyVolvo_Click);
            // 
            // btnExpCar
            // 
            this.btnExpCar.Location = new System.Drawing.Point(434, 228);
            this.btnExpCar.Name = "btnExpCar";
            this.btnExpCar.Size = new System.Drawing.Size(147, 94);
            this.btnExpCar.TabIndex = 6;
            this.btnExpCar.Text = "Most expensive car";
            this.btnExpCar.UseVisualStyleBackColor = true;
            this.btnExpCar.Click += new System.EventHandler(this.btnExpCar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "All cars in storage";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 490);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExpCar);
            this.Controls.Add(this.btnGreyVolvo);
            this.Controls.Add(this.btnCarsOld2003);
            this.Controls.Add(this.btnAvgMileBMW);
            this.Controls.Add(this.btnRedCars);
            this.Controls.Add(this.CarListBoxFunction);
            this.Controls.Add(this.CarListBox);
            this.Name = "Form1";
            this.Text = "Car List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CarListBox;
        private System.Windows.Forms.ListBox CarListBoxFunction;
        private System.Windows.Forms.Button btnRedCars;
        private System.Windows.Forms.Button btnAvgMileBMW;
        private System.Windows.Forms.Button btnCarsOld2003;
        private System.Windows.Forms.Button btnGreyVolvo;
        private System.Windows.Forms.Button btnExpCar;
        private System.Windows.Forms.Label label1;
    }
}

