
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
            this.listBoxAllCars = new System.Windows.Forms.ListBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.listBoxColors = new System.Windows.Forms.ListBox();
            this.lblCarInfo = new System.Windows.Forms.Label();
            this.btnEditCar = new System.Windows.Forms.Button();
            this.lblEditCar = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblKm = new System.Windows.Forms.Label();
            this.tbxKm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxAllCars
            // 
            this.listBoxAllCars.FormattingEnabled = true;
            this.listBoxAllCars.ItemHeight = 16;
            this.listBoxAllCars.Location = new System.Drawing.Point(12, 12);
            this.listBoxAllCars.Name = "listBoxAllCars";
            this.listBoxAllCars.Size = new System.Drawing.Size(163, 228);
            this.listBoxAllCars.TabIndex = 0;
            this.listBoxAllCars.SelectedIndexChanged += new System.EventHandler(this.listBoxAllCars_SelectedIndexChanged);
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(281, 16);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(120, 24);
            this.cmbColor.TabIndex = 3;
            // 
            // listBoxColors
            // 
            this.listBoxColors.FormattingEnabled = true;
            this.listBoxColors.ItemHeight = 16;
            this.listBoxColors.Location = new System.Drawing.Point(281, 46);
            this.listBoxColors.Name = "listBoxColors";
            this.listBoxColors.Size = new System.Drawing.Size(120, 132);
            this.listBoxColors.TabIndex = 4;
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
            this.btnEditCar.Location = new System.Drawing.Point(521, 81);
            this.btnEditCar.Name = "btnEditCar";
            this.btnEditCar.Size = new System.Drawing.Size(70, 25);
            this.btnEditCar.TabIndex = 5;
            this.btnEditCar.Text = "Edit";
            this.btnEditCar.UseVisualStyleBackColor = true;
            // 
            // lblEditCar
            // 
            this.lblEditCar.AutoSize = true;
            this.lblEditCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCar.Location = new System.Drawing.Point(419, 12);
            this.lblEditCar.Name = "lblEditCar";
            this.lblEditCar.Size = new System.Drawing.Size(149, 31);
            this.lblEditCar.TabIndex = 6;
            this.lblEditCar.Text = "Edit Car Info";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(521, 171);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 25);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // tbxId
            // 
            this.tbxId.Location = new System.Drawing.Point(491, 46);
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
            this.tbxPrice.Location = new System.Drawing.Point(491, 112);
            this.tbxPrice.Multiline = true;
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(100, 22);
            this.tbxPrice.TabIndex = 10;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(421, 112);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 17);
            this.lblPrice.TabIndex = 11;
            this.lblPrice.Text = "Price";
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.Location = new System.Drawing.Point(421, 143);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(57, 17);
            this.lblKm.TabIndex = 12;
            this.lblKm.Text = "Mileage";
            // 
            // tbxKm
            // 
            this.tbxKm.Location = new System.Drawing.Point(491, 143);
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
            this.Controls.Add(this.lblEditCar);
            this.Controls.Add(this.btnEditCar);
            this.Controls.Add(this.listBoxColors);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.lblCarInfo);
            this.Controls.Add(this.listBoxAllCars);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAllCars;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.ListBox listBoxColors;
        private System.Windows.Forms.Label lblCarInfo;
        private System.Windows.Forms.Button btnEditCar;
        private System.Windows.Forms.Label lblEditCar;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.TextBox tbxKm;
    }
}

