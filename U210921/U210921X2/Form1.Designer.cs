
namespace U210921X2
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
            this.listAllCars = new System.Windows.Forms.ListBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.listColors = new System.Windows.Forms.ListBox();
            this.lblCarInfo = new System.Windows.Forms.Label();
            this.btnEditCar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblKm = new System.Windows.Forms.Label();
            this.tbxKm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listAllCars
            // 
            this.listAllCars.FormattingEnabled = true;
            this.listAllCars.ItemHeight = 16;
            this.listAllCars.Location = new System.Drawing.Point(12, 12);
            this.listAllCars.Name = "listAllCars";
            this.listAllCars.Size = new System.Drawing.Size(163, 228);
            this.listAllCars.TabIndex = 0;
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(281, 16);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(121, 24);
            this.cmbColor.TabIndex = 3;
            // 
            // listColors
            // 
            this.listColors.FormattingEnabled = true;
            this.listColors.ItemHeight = 16;
            this.listColors.Location = new System.Drawing.Point(281, 46);
            this.listColors.Name = "listColors";
            this.listColors.Size = new System.Drawing.Size(120, 132);
            this.listColors.TabIndex = 4;
            // 
            // lblCarInfo
            // 
            this.lblCarInfo.AutoSize = true;
            this.lblCarInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarInfo.Location = new System.Drawing.Point(181, 12);
            this.lblCarInfo.Name = "lblCarInfo";
            this.lblCarInfo.Size = new System.Drawing.Size(81, 25);
            this.lblCarInfo.TabIndex = 2;
            this.lblCarInfo.Text = "Car Info";
            // 
            // btnEditCar
            // 
            this.btnEditCar.Location = new System.Drawing.Point(518, 74);
            this.btnEditCar.Name = "btnEditCar";
            this.btnEditCar.Size = new System.Drawing.Size(70, 22);
            this.btnEditCar.TabIndex = 5;
            this.btnEditCar.Text = "Edit";
            this.btnEditCar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(419, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Edit Car Info";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(518, 156);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 22);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // tbxId
            // 
            this.tbxId.Location = new System.Drawing.Point(488, 46);
            this.tbxId.Multiline = true;
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(100, 22);
            this.tbxId.TabIndex = 8;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(421, 46);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(47, 17);
            this.lblId.TabIndex = 9;
            this.lblId.Text = "Car ID";
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(488, 99);
            this.tbxPrice.Multiline = true;
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(100, 22);
            this.tbxPrice.TabIndex = 10;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(421, 99);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 17);
            this.lblPrice.TabIndex = 11;
            this.lblPrice.Text = "Price";
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.Location = new System.Drawing.Point(421, 128);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(71, 21);
            this.lblKm.TabIndex = 12;
            this.lblKm.Text = "Mileage";
            // 
            // tbxKm
            // 
            this.tbxKm.Location = new System.Drawing.Point(488, 128);
            this.tbxKm.Multiline = true;
            this.tbxKm.Name = "tbxKm";
            this.tbxKm.Size = new System.Drawing.Size(100, 22);
            this.tbxKm.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 253);
            this.Controls.Add(this.tbxKm);
            this.Controls.Add(this.lblKm);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.tbxPrice);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.tbxId);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditCar);
            this.Controls.Add(this.listColors);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.lblCarInfo);
            this.Controls.Add(this.listAllCars);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listAllCars;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.ListBox listColors;
        private System.Windows.Forms.Label lblCarInfo;
        private System.Windows.Forms.Button btnEditCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.TextBox tbxKm;
    }
}

