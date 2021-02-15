namespace MobileDirectoryEtinty
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
            this.dgwDirectory = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxFirstNameAdd = new System.Windows.Forms.TextBox();
            this.tbxLastNameAdd = new System.Windows.Forms.TextBox();
            this.tbxNumberAdd = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.btnPesonAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPersonUpdate = new System.Windows.Forms.Button();
            this.lblNumberUpdate = new System.Windows.Forms.Label();
            this.lblFirstNameUpdate = new System.Windows.Forms.Label();
            this.lblLastNameUpdate = new System.Windows.Forms.Label();
            this.tbxNumberUpdate = new System.Windows.Forms.TextBox();
            this.tbxLastNameUpdate = new System.Windows.Forms.TextBox();
            this.tbxFirstNameUpdate = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDirectory)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwDirectory
            // 
            this.dgwDirectory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwDirectory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDirectory.Location = new System.Drawing.Point(98, 29);
            this.dgwDirectory.Name = "dgwDirectory";
            this.dgwDirectory.Size = new System.Drawing.Size(550, 172);
            this.dgwDirectory.TabIndex = 0;
            this.dgwDirectory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwDirectory_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPesonAdd);
            this.groupBox1.Controls.Add(this.lblNumber);
            this.groupBox1.Controls.Add(this.lblFirstName);
            this.groupBox1.Controls.Add(this.lblLastName);
            this.groupBox1.Controls.Add(this.tbxNumberAdd);
            this.groupBox1.Controls.Add(this.tbxLastNameAdd);
            this.groupBox1.Controls.Add(this.tbxFirstNameAdd);
            this.groupBox1.Location = new System.Drawing.Point(98, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 154);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Person";
            // 
            // tbxFirstNameAdd
            // 
            this.tbxFirstNameAdd.Location = new System.Drawing.Point(106, 28);
            this.tbxFirstNameAdd.Name = "tbxFirstNameAdd";
            this.tbxFirstNameAdd.Size = new System.Drawing.Size(115, 20);
            this.tbxFirstNameAdd.TabIndex = 2;
            // 
            // tbxLastNameAdd
            // 
            this.tbxLastNameAdd.Location = new System.Drawing.Point(106, 54);
            this.tbxLastNameAdd.Name = "tbxLastNameAdd";
            this.tbxLastNameAdd.Size = new System.Drawing.Size(115, 20);
            this.tbxLastNameAdd.TabIndex = 3;
            // 
            // tbxNumberAdd
            // 
            this.tbxNumberAdd.Location = new System.Drawing.Point(106, 80);
            this.tbxNumberAdd.Name = "tbxNumberAdd";
            this.tbxNumberAdd.Size = new System.Drawing.Size(115, 20);
            this.tbxNumberAdd.TabIndex = 3;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(43, 35);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(42, 61);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(29, 87);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(71, 13);
            this.lblNumber.TabIndex = 4;
            this.lblNumber.Text = "GSM Number";
            // 
            // btnPesonAdd
            // 
            this.btnPesonAdd.Location = new System.Drawing.Point(106, 106);
            this.btnPesonAdd.Name = "btnPesonAdd";
            this.btnPesonAdd.Size = new System.Drawing.Size(115, 31);
            this.btnPesonAdd.TabIndex = 2;
            this.btnPesonAdd.Text = "Add Person";
            this.btnPesonAdd.UseVisualStyleBackColor = true;
            this.btnPesonAdd.Click += new System.EventHandler(this.btnPesonAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPersonUpdate);
            this.groupBox2.Controls.Add(this.lblNumberUpdate);
            this.groupBox2.Controls.Add(this.lblFirstNameUpdate);
            this.groupBox2.Controls.Add(this.lblLastNameUpdate);
            this.groupBox2.Controls.Add(this.tbxNumberUpdate);
            this.groupBox2.Controls.Add(this.tbxLastNameUpdate);
            this.groupBox2.Controls.Add(this.tbxFirstNameUpdate);
            this.groupBox2.Location = new System.Drawing.Point(411, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 154);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Person";
            // 
            // btnPersonUpdate
            // 
            this.btnPersonUpdate.Location = new System.Drawing.Point(106, 106);
            this.btnPersonUpdate.Name = "btnPersonUpdate";
            this.btnPersonUpdate.Size = new System.Drawing.Size(115, 31);
            this.btnPersonUpdate.TabIndex = 2;
            this.btnPersonUpdate.Text = "Update Person";
            this.btnPersonUpdate.UseVisualStyleBackColor = true;
            this.btnPersonUpdate.Click += new System.EventHandler(this.btnPersonUpdate_Click);
            // 
            // lblNumberUpdate
            // 
            this.lblNumberUpdate.AutoSize = true;
            this.lblNumberUpdate.Location = new System.Drawing.Point(29, 87);
            this.lblNumberUpdate.Name = "lblNumberUpdate";
            this.lblNumberUpdate.Size = new System.Drawing.Size(71, 13);
            this.lblNumberUpdate.TabIndex = 4;
            this.lblNumberUpdate.Text = "GSM Number";
            // 
            // lblFirstNameUpdate
            // 
            this.lblFirstNameUpdate.AutoSize = true;
            this.lblFirstNameUpdate.Location = new System.Drawing.Point(43, 35);
            this.lblFirstNameUpdate.Name = "lblFirstNameUpdate";
            this.lblFirstNameUpdate.Size = new System.Drawing.Size(57, 13);
            this.lblFirstNameUpdate.TabIndex = 2;
            this.lblFirstNameUpdate.Text = "First Name";
            // 
            // lblLastNameUpdate
            // 
            this.lblLastNameUpdate.AutoSize = true;
            this.lblLastNameUpdate.Location = new System.Drawing.Point(42, 61);
            this.lblLastNameUpdate.Name = "lblLastNameUpdate";
            this.lblLastNameUpdate.Size = new System.Drawing.Size(58, 13);
            this.lblLastNameUpdate.TabIndex = 3;
            this.lblLastNameUpdate.Text = "Last Name";
            // 
            // tbxNumberUpdate
            // 
            this.tbxNumberUpdate.Location = new System.Drawing.Point(106, 80);
            this.tbxNumberUpdate.Name = "tbxNumberUpdate";
            this.tbxNumberUpdate.Size = new System.Drawing.Size(115, 20);
            this.tbxNumberUpdate.TabIndex = 3;
            // 
            // tbxLastNameUpdate
            // 
            this.tbxLastNameUpdate.Location = new System.Drawing.Point(106, 54);
            this.tbxLastNameUpdate.Name = "tbxLastNameUpdate";
            this.tbxLastNameUpdate.Size = new System.Drawing.Size(115, 20);
            this.tbxLastNameUpdate.TabIndex = 3;
            // 
            // tbxFirstNameUpdate
            // 
            this.tbxFirstNameUpdate.Location = new System.Drawing.Point(106, 28);
            this.tbxFirstNameUpdate.Name = "tbxFirstNameUpdate";
            this.tbxFirstNameUpdate.Size = new System.Drawing.Size(115, 20);
            this.tbxFirstNameUpdate.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(318, 207);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Remove";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwDirectory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwDirectory)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwDirectory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPesonAdd;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox tbxNumberAdd;
        private System.Windows.Forms.TextBox tbxLastNameAdd;
        private System.Windows.Forms.TextBox tbxFirstNameAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPersonUpdate;
        private System.Windows.Forms.Label lblNumberUpdate;
        private System.Windows.Forms.Label lblFirstNameUpdate;
        private System.Windows.Forms.Label lblLastNameUpdate;
        private System.Windows.Forms.TextBox tbxNumberUpdate;
        private System.Windows.Forms.TextBox tbxLastNameUpdate;
        private System.Windows.Forms.TextBox tbxFirstNameUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}

