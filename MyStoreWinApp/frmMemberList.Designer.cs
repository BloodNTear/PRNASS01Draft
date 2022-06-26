namespace MyStoreWinApp
{
    partial class frmMemberList
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
            this.lbMemListTitle = new System.Windows.Forms.Label();
            this.lbMemberName = new System.Windows.Forms.Label();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lbCountry = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMemListTitle
            // 
            this.lbMemListTitle.AutoSize = true;
            this.lbMemListTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMemListTitle.Location = new System.Drawing.Point(256, 9);
            this.lbMemListTitle.Name = "lbMemListTitle";
            this.lbMemListTitle.Size = new System.Drawing.Size(207, 46);
            this.lbMemListTitle.TabIndex = 0;
            this.lbMemListTitle.Text = "Member List";
            // 
            // lbMemberName
            // 
            this.lbMemberName.AutoSize = true;
            this.lbMemberName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMemberName.Location = new System.Drawing.Point(12, 71);
            this.lbMemberName.Name = "lbMemberName";
            this.lbMemberName.Size = new System.Drawing.Size(143, 28);
            this.lbMemberName.TabIndex = 1;
            this.lbMemberName.Text = "Member Name";
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(174, 72);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.PlaceholderText = "MemberName";
            this.txtMemberName.Size = new System.Drawing.Size(188, 27);
            this.txtMemberName.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(502, 71);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.Size = new System.Drawing.Size(217, 27);
            this.txtEmail.TabIndex = 3;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(105, 372);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(94, 29);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEmail.Location = new System.Drawing.Point(404, 72);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(59, 28);
            this.lbEmail.TabIndex = 5;
            this.lbEmail.Text = "Email";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCity.Location = new System.Drawing.Point(12, 121);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(46, 28);
            this.lbCity.TabIndex = 6;
            this.lbCity.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(174, 121);
            this.txtCity.Name = "txtCity";
            this.txtCity.PlaceholderText = "City";
            this.txtCity.Size = new System.Drawing.Size(188, 27);
            this.txtCity.TabIndex = 7;
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCountry.Location = new System.Drawing.Point(404, 121);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(82, 28);
            this.lbCountry.TabIndex = 8;
            this.lbCountry.Text = "Country";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(502, 122);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.PlaceholderText = "Country";
            this.txtCountry.Size = new System.Drawing.Size(217, 27);
            this.txtCountry.TabIndex = 9;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(502, 372);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(315, 372);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add New Member";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(707, 188);
            this.dataGridView1.TabIndex = 12;
            // 
            // frmMemberList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.lbMemberName);
            this.Controls.Add(this.lbMemListTitle);
            this.Name = "frmMemberList";
            this.Text = "frmMemberList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbMemListTitle;
        private Label lbMemberName;
        private TextBox txtMemberName;
        private TextBox txtEmail;
        private Button btnLoad;
        private Label lbEmail;
        private Label lbCity;
        private TextBox txtCity;
        private Label lbCountry;
        private TextBox txtCountry;
        private Button btnDelete;
        private Button btnAdd;
        private DataGridView dataGridView1;
    }
}