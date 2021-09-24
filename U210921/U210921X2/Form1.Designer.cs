
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
            this.listBoxCarProperty = new System.Windows.Forms.ListBox();
            this.lblEditCar = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblKm = new System.Windows.Forms.Label();
            this.tbxKm = new System.Windows.Forms.TextBox();
            this.cmbChooseProperty = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxMake = new System.Windows.Forms.TextBox();
            this.tbxModel = new System.Windows.Forms.TextBox();
            this.tbxColor = new System.Windows.Forms.TextBox();
            this.tbxYear = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNewCar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxAllCars
            // 
            this.listBoxAllCars.FormattingEnabled = true;
            this.listBoxAllCars.ItemHeight = 16;
            this.listBoxAllCars.Location = new System.Drawing.Point(13, 39);
            this.listBoxAllCars.Name = "listBoxAllCars";
            this.listBoxAllCars.Size = new System.Drawing.Size(165, 292);
            this.listBoxAllCars.TabIndex = 0;
            this.listBoxAllCars.SelectedIndexChanged += new System.EventHandler(this.listBoxAllCars_SelectedIndexChanged);
            // 
            // listBoxCarProperty
            // 
            this.listBoxCarProperty.FormattingEnabled = true;
            this.listBoxCarProperty.ItemHeight = 16;
            this.listBoxCarProperty.Location = new System.Drawing.Point(378, 103);
            this.listBoxCarProperty.Name = "listBoxCarProperty";
            this.listBoxCarProperty.Size = new System.Drawing.Size(137, 228);
            this.listBoxCarProperty.TabIndex = 4;
            this.listBoxCarProperty.SelectedIndexChanged += new System.EventHandler(this.listBoxCarProperty_SelectedIndexChanged);
            // 
            // lblEditCar
            // 
            this.lblEditCar.AutoSize = true;
            this.lblEditCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCar.Location = new System.Drawing.Point(209, 8);
            this.lblEditCar.Name = "lblEditCar";
            this.lblEditCar.Size = new System.Drawing.Size(119, 25);
            this.lblEditCar.TabIndex = 6;
            this.lblEditCar.Text = "Edit Car Info";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(278, 233);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 46);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbxId
            // 
            this.tbxId.Location = new System.Drawing.Point(255, 36);
            this.tbxId.Multiline = true;
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(100, 22);
            this.tbxId.TabIndex = 8;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(182, 38);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(26, 20);
            this.lblId.TabIndex = 9;
            this.lblId.Text = "ID";
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(255, 149);
            this.tbxPrice.Multiline = true;
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(100, 22);
            this.tbxPrice.TabIndex = 10;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(182, 149);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(48, 20);
            this.lblPrice.TabIndex = 11;
            this.lblPrice.Text = "Price";
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKm.Location = new System.Drawing.Point(182, 179);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(67, 20);
            this.lblKm.TabIndex = 12;
            this.lblKm.Text = "Mileage";
            // 
            // tbxKm
            // 
            this.tbxKm.Location = new System.Drawing.Point(255, 177);
            this.tbxKm.Multiline = true;
            this.tbxKm.Name = "tbxKm";
            this.tbxKm.Size = new System.Drawing.Size(100, 22);
            this.tbxKm.TabIndex = 13;
            // 
            // cmbChooseProperty
            // 
            this.cmbChooseProperty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbChooseProperty.FormattingEnabled = true;
            this.cmbChooseProperty.Location = new System.Drawing.Point(378, 40);
            this.cmbChooseProperty.Name = "cmbChooseProperty";
            this.cmbChooseProperty.Size = new System.Drawing.Size(137, 24);
            this.cmbChooseProperty.TabIndex = 16;
            this.cmbChooseProperty.SelectedIndexChanged += new System.EventHandler(this.cmbChooseProperty_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "All Cars";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Make";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(184, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(182, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(184, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Year";
            // 
            // tbxMake
            // 
            this.tbxMake.Location = new System.Drawing.Point(255, 65);
            this.tbxMake.Multiline = true;
            this.tbxMake.Name = "tbxMake";
            this.tbxMake.Size = new System.Drawing.Size(100, 22);
            this.tbxMake.TabIndex = 22;
            // 
            // tbxModel
            // 
            this.tbxModel.Location = new System.Drawing.Point(255, 94);
            this.tbxModel.Multiline = true;
            this.tbxModel.Name = "tbxModel";
            this.tbxModel.Size = new System.Drawing.Size(100, 22);
            this.tbxModel.TabIndex = 23;
            // 
            // tbxColor
            // 
            this.tbxColor.Location = new System.Drawing.Point(255, 121);
            this.tbxColor.Multiline = true;
            this.tbxColor.Name = "tbxColor";
            this.tbxColor.Size = new System.Drawing.Size(100, 22);
            this.tbxColor.TabIndex = 24;
            // 
            // tbxYear
            // 
            this.tbxYear.Location = new System.Drawing.Point(255, 205);
            this.tbxYear.Multiline = true;
            this.tbxYear.Name = "tbxYear";
            this.tbxYear.Size = new System.Drawing.Size(100, 22);
            this.tbxYear.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(356, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 31);
            this.label6.TabIndex = 26;
            this.label6.Text = "Search by Property";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(183, 233);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 46);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete Car";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(278, 285);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 46);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Add New Car";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNewCar
            // 
            this.btnNewCar.Location = new System.Drawing.Point(183, 285);
            this.btnNewCar.Name = "btnNewCar";
            this.btnNewCar.Size = new System.Drawing.Size(74, 46);
            this.btnNewCar.TabIndex = 29;
            this.btnNewCar.Text = "New Car";
            this.btnNewCar.UseVisualStyleBackColor = true;
            this.btnNewCar.Click += new System.EventHandler(this.btnNewCar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 348);
            this.Controls.Add(this.btnNewCar);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxYear);
            this.Controls.Add(this.tbxColor);
            this.Controls.Add(this.tbxModel);
            this.Controls.Add(this.tbxMake);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbChooseProperty);
            this.Controls.Add(this.tbxKm);
            this.Controls.Add(this.lblKm);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.tbxPrice);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.tbxId);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblEditCar);
            this.Controls.Add(this.listBoxCarProperty);
            this.Controls.Add(this.listBoxAllCars);
            this.Name = "Form1";
            this.Text = "Car";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAllCars;
        private System.Windows.Forms.ListBox listBoxCarProperty;
        private System.Windows.Forms.Label lblEditCar;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.TextBox tbxKm;
        private System.Windows.Forms.ComboBox cmbChooseProperty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxMake;
        private System.Windows.Forms.TextBox tbxModel;
        private System.Windows.Forms.TextBox tbxColor;
        private System.Windows.Forms.TextBox tbxYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNewCar;
    }
}

