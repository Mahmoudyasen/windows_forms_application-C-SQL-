namespace Project
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.Addbtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.LMID = new System.Windows.Forms.Label();
            this.LMN = new System.Windows.Forms.Label();
            this.LMM = new System.Windows.Forms.Label();
            this.LPUR = new System.Windows.Forms.Label();
            this.LDOE = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMaker = new System.Windows.Forms.TextBox();
            this.txtPur = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.DOEE = new System.Windows.Forms.DateTimePicker();
            this.DtGVmed = new System.Windows.Forms.DataGridView();
            this.pharmaDataSet = new Project.pharmaDataSet();
            this.medBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medTableAdapter = new Project.pharmaDataSetTableAdapters.medTableAdapter();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Label();
            this.Clearr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtGVmed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(12, 591);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(75, 23);
            this.Addbtn.TabIndex = 0;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.Location = new System.Drawing.Point(93, 591);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(75, 23);
            this.Deletebtn.TabIndex = 1;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.Location = new System.Drawing.Point(174, 591);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(75, 23);
            this.Updatebtn.TabIndex = 2;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = true;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1214, 591);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Log Out";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // LMID
            // 
            this.LMID.AutoSize = true;
            this.LMID.Location = new System.Drawing.Point(9, 32);
            this.LMID.Name = "LMID";
            this.LMID.Size = new System.Drawing.Size(74, 16);
            this.LMID.TabIndex = 4;
            this.LMID.Text = "med name:";
            // 
            // LMN
            // 
            this.LMN.AutoSize = true;
            this.LMN.Location = new System.Drawing.Point(9, 60);
            this.LMN.Name = "LMN";
            this.LMN.Size = new System.Drawing.Size(45, 16);
            this.LMN.TabIndex = 5;
            this.LMN.Text = "maker";
            // 
            // LMM
            // 
            this.LMM.AutoSize = true;
            this.LMM.Location = new System.Drawing.Point(9, 88);
            this.LMM.Name = "LMM";
            this.LMM.Size = new System.Drawing.Size(57, 16);
            this.LMM.TabIndex = 6;
            this.LMM.Text = "purpose";
            // 
            // LPUR
            // 
            this.LPUR.AutoSize = true;
            this.LPUR.Location = new System.Drawing.Point(9, 116);
            this.LPUR.Name = "LPUR";
            this.LPUR.Size = new System.Drawing.Size(37, 16);
            this.LPUR.TabIndex = 7;
            this.LPUR.Text = "price";
            this.LPUR.Click += new System.EventHandler(this.label4_Click);
            // 
            // LDOE
            // 
            this.LDOE.AutoSize = true;
            this.LDOE.Location = new System.Drawing.Point(9, 144);
            this.LDOE.Name = "LDOE";
            this.LDOE.Size = new System.Drawing.Size(36, 16);
            this.LDOE.TabIndex = 8;
            this.LDOE.Text = "DOE";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(135, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 22);
            this.txtName.TabIndex = 9;
            // 
            // txtMaker
            // 
            this.txtMaker.Location = new System.Drawing.Point(135, 54);
            this.txtMaker.Name = "txtMaker";
            this.txtMaker.Size = new System.Drawing.Size(200, 22);
            this.txtMaker.TabIndex = 10;
            // 
            // txtPur
            // 
            this.txtPur.Location = new System.Drawing.Point(135, 82);
            this.txtPur.Name = "txtPur";
            this.txtPur.Size = new System.Drawing.Size(200, 22);
            this.txtPur.TabIndex = 11;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(135, 110);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 22);
            this.txtPrice.TabIndex = 12;
            // 
            // DOEE
            // 
            this.DOEE.Location = new System.Drawing.Point(135, 138);
            this.DOEE.Name = "DOEE";
            this.DOEE.Size = new System.Drawing.Size(200, 22);
            this.DOEE.TabIndex = 13;
            // 
            // DtGVmed
            // 
            this.DtGVmed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGVmed.Location = new System.Drawing.Point(341, 82);
            this.DtGVmed.Name = "DtGVmed";
            this.DtGVmed.RowHeadersWidth = 51;
            this.DtGVmed.RowTemplate.Height = 24;
            this.DtGVmed.Size = new System.Drawing.Size(932, 426);
            this.DtGVmed.TabIndex = 14;
            this.DtGVmed.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DtGVmed_RowHeaderMouseDoubleClick);
            // 
            // pharmaDataSet
            // 
            this.pharmaDataSet.DataSetName = "pharmaDataSet";
            this.pharmaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medBindingSource
            // 
            this.medBindingSource.DataMember = "med";
            this.medBindingSource.DataSource = this.pharmaDataSet;
            // 
            // medTableAdapter
            // 
            this.medTableAdapter.ClearBeforeFill = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(464, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(783, 22);
            this.txtSearch.TabIndex = 16;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // search
            // 
            this.search.AutoSize = true;
            this.search.Location = new System.Drawing.Point(377, 33);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(48, 16);
            this.search.TabIndex = 17;
            this.search.Text = "search";
            // 
            // Clearr
            // 
            this.Clearr.Location = new System.Drawing.Point(260, 591);
            this.Clearr.Name = "Clearr";
            this.Clearr.Size = new System.Drawing.Size(75, 23);
            this.Clearr.TabIndex = 18;
            this.Clearr.Text = "clear";
            this.Clearr.UseVisualStyleBackColor = true;
            this.Clearr.Click += new System.EventHandler(this.Clearr_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 626);
            this.Controls.Add(this.Clearr);
            this.Controls.Add(this.search);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.DtGVmed);
            this.Controls.Add(this.DOEE);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtPur);
            this.Controls.Add(this.txtMaker);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.LDOE);
            this.Controls.Add(this.LPUR);
            this.Controls.Add(this.LMM);
            this.Controls.Add(this.LMN);
            this.Controls.Add(this.LMID);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Addbtn);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtGVmed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label LMID;
        private System.Windows.Forms.Label LMN;
        private System.Windows.Forms.Label LMM;
        private System.Windows.Forms.Label LPUR;
        private System.Windows.Forms.Label LDOE;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMaker;
        private System.Windows.Forms.TextBox txtPur;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.DateTimePicker DOEE;
        private System.Windows.Forms.DataGridView DtGVmed;
        private pharmaDataSet pharmaDataSet;
        private System.Windows.Forms.BindingSource medBindingSource;
        private pharmaDataSetTableAdapters.medTableAdapter medTableAdapter;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label search;
        private System.Windows.Forms.Button Clearr;
    }
}