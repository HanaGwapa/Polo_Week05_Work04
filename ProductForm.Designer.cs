namespace Polo_Week05_Work04
{
    partial class ProductForm
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
            this.lblBarCode = new System.Windows.Forms.Label();
            this.txtBoxBarcode = new System.Windows.Forms.TextBox();
            this.lblBarCodeAvailable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblOrigin = new System.Windows.Forms.Label();
            this.grpManufactured = new System.Windows.Forms.GroupBox();
            this.rdbAbroad = new System.Windows.Forms.RadioButton();
            this.rdbLocal = new System.Windows.Forms.RadioButton();
            this.txtBoxDesc = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.ckbActive = new System.Windows.Forms.CheckBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblMarkup = new System.Windows.Forms.Label();
            this.txtBoxCost = new System.Windows.Forms.TextBox();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.txtBoxMarkup = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpManufactured.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBarCode
            // 
            this.lblBarCode.AutoSize = true;
            this.lblBarCode.Location = new System.Drawing.Point(27, 21);
            this.lblBarCode.Name = "lblBarCode";
            this.lblBarCode.Size = new System.Drawing.Size(59, 16);
            this.lblBarCode.TabIndex = 0;
            this.lblBarCode.Text = "Barcode";
            // 
            // txtBoxBarcode
            // 
            this.txtBoxBarcode.Location = new System.Drawing.Point(127, 15);
            this.txtBoxBarcode.Name = "txtBoxBarcode";
            this.txtBoxBarcode.Size = new System.Drawing.Size(272, 22);
            this.txtBoxBarcode.TabIndex = 1;
            this.txtBoxBarcode.TextChanged += new System.EventHandler(this.txtBoxBarcode_TextChanged);
            // 
            // lblBarCodeAvailable
            // 
            this.lblBarCodeAvailable.AutoSize = true;
            this.lblBarCodeAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarCodeAvailable.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblBarCodeAvailable.Location = new System.Drawing.Point(124, 40);
            this.lblBarCodeAvailable.Name = "lblBarCodeAvailable";
            this.lblBarCodeAvailable.Size = new System.Drawing.Size(134, 16);
            this.lblBarCodeAvailable.TabIndex = 2;
            this.lblBarCodeAvailable.Text = "Barcode is available.";
            this.lblBarCodeAvailable.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(127, 69);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(272, 22);
            this.txtBoxName.TabIndex = 4;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(27, 97);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(75, 16);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(27, 213);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 16);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Category";
            this.lblName.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblOrigin
            // 
            this.lblOrigin.AutoSize = true;
            this.lblOrigin.Location = new System.Drawing.Point(27, 247);
            this.lblOrigin.Name = "lblOrigin";
            this.lblOrigin.Size = new System.Drawing.Size(42, 16);
            this.lblOrigin.TabIndex = 7;
            this.lblOrigin.Text = "Origin";
            // 
            // grpManufactured
            // 
            this.grpManufactured.Controls.Add(this.rdbAbroad);
            this.grpManufactured.Controls.Add(this.rdbLocal);
            this.grpManufactured.Location = new System.Drawing.Point(127, 247);
            this.grpManufactured.Name = "grpManufactured";
            this.grpManufactured.Size = new System.Drawing.Size(272, 62);
            this.grpManufactured.TabIndex = 8;
            this.grpManufactured.TabStop = false;
            this.grpManufactured.Text = "Manufactured";
            // 
            // rdbAbroad
            // 
            this.rdbAbroad.AutoSize = true;
            this.rdbAbroad.Location = new System.Drawing.Point(148, 30);
            this.rdbAbroad.Name = "rdbAbroad";
            this.rdbAbroad.Size = new System.Drawing.Size(73, 20);
            this.rdbAbroad.TabIndex = 13;
            this.rdbAbroad.TabStop = true;
            this.rdbAbroad.Text = "Abroad";
            this.rdbAbroad.UseVisualStyleBackColor = true;
            // 
            // rdbLocal
            // 
            this.rdbLocal.AutoSize = true;
            this.rdbLocal.Location = new System.Drawing.Point(17, 30);
            this.rdbLocal.Name = "rdbLocal";
            this.rdbLocal.Size = new System.Drawing.Size(61, 20);
            this.rdbLocal.TabIndex = 12;
            this.rdbLocal.TabStop = true;
            this.rdbLocal.Text = "Local";
            this.rdbLocal.UseVisualStyleBackColor = true;
            // 
            // txtBoxDesc
            // 
            this.txtBoxDesc.Location = new System.Drawing.Point(127, 97);
            this.txtBoxDesc.Multiline = true;
            this.txtBoxDesc.Name = "txtBoxDesc";
            this.txtBoxDesc.Size = new System.Drawing.Size(272, 93);
            this.txtBoxDesc.TabIndex = 9;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(127, 205);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(272, 24);
            this.cmbCategory.TabIndex = 11;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(27, 321);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 16);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Status";
            this.lblStatus.Click += new System.EventHandler(this.label5_Click);
            // 
            // ckbActive
            // 
            this.ckbActive.AutoSize = true;
            this.ckbActive.Location = new System.Drawing.Point(127, 320);
            this.ckbActive.Name = "ckbActive";
            this.ckbActive.Size = new System.Drawing.Size(66, 20);
            this.ckbActive.TabIndex = 13;
            this.ckbActive.Text = "Active";
            this.ckbActive.UseVisualStyleBackColor = true;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(27, 355);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(34, 16);
            this.lblCost.TabIndex = 14;
            this.lblCost.Text = "Cost";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(141, 355);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(38, 16);
            this.lblPrice.TabIndex = 15;
            this.lblPrice.Text = "Price";
            // 
            // lblMarkup
            // 
            this.lblMarkup.AutoSize = true;
            this.lblMarkup.Location = new System.Drawing.Point(286, 355);
            this.lblMarkup.Name = "lblMarkup";
            this.lblMarkup.Size = new System.Drawing.Size(75, 16);
            this.lblMarkup.TabIndex = 16;
            this.lblMarkup.Text = "Markup (%)";
            this.lblMarkup.Click += new System.EventHandler(this.lblMarkup_Click);
            // 
            // txtBoxCost
            // 
            this.txtBoxCost.Location = new System.Drawing.Point(30, 374);
            this.txtBoxCost.Name = "txtBoxCost";
            this.txtBoxCost.Size = new System.Drawing.Size(105, 22);
            this.txtBoxCost.TabIndex = 17;
            this.txtBoxCost.TextChanged += new System.EventHandler(this.txtBoxCost_TextChanged);
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.Location = new System.Drawing.Point(144, 374);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(105, 22);
            this.txtBoxPrice.TabIndex = 18;
            this.txtBoxPrice.TextChanged += new System.EventHandler(this.txtBoxPrice_TextChanged);
            // 
            // txtBoxMarkup
            // 
            this.txtBoxMarkup.Location = new System.Drawing.Point(289, 374);
            this.txtBoxMarkup.Name = "txtBoxMarkup";
            this.txtBoxMarkup.Size = new System.Drawing.Size(105, 22);
            this.txtBoxMarkup.TabIndex = 19;
            this.txtBoxMarkup.TextChanged += new System.EventHandler(this.txtBoxMarkup_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(30, 423);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 34);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(144, 423);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 34);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(289, 423);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 34);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 487);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtBoxMarkup);
            this.Controls.Add(this.txtBoxPrice);
            this.Controls.Add(this.txtBoxCost);
            this.Controls.Add(this.lblMarkup);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.ckbActive);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.txtBoxDesc);
            this.Controls.Add(this.grpManufactured);
            this.Controls.Add(this.lblOrigin);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBarCodeAvailable);
            this.Controls.Add(this.txtBoxBarcode);
            this.Controls.Add(this.lblBarCode);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpManufactured.ResumeLayout(false);
            this.grpManufactured.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBarCode;
        private System.Windows.Forms.TextBox txtBoxBarcode;
        private System.Windows.Forms.Label lblBarCodeAvailable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblOrigin;
        private System.Windows.Forms.GroupBox grpManufactured;
        private System.Windows.Forms.TextBox txtBoxDesc;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.RadioButton rdbAbroad;
        private System.Windows.Forms.RadioButton rdbLocal;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox ckbActive;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblMarkup;
        private System.Windows.Forms.TextBox txtBoxCost;
        private System.Windows.Forms.TextBox txtBoxPrice;
        private System.Windows.Forms.TextBox txtBoxMarkup;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
    }
}

