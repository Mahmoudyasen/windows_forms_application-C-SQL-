
namespace GymProject99
{
    partial class CRUD
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gYMDataSet = new GymProject99.GYMDataSet();
            this.gMembersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gMembersTableAdapter = new GymProject99.GYMDataSetTableAdapters.GMembersTableAdapter();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.cbHeight = new System.Windows.Forms.ComboBox();
            this.cbWeight = new System.Windows.Forms.ComboBox();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.gbProgram = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.cbLosingWeight = new System.Windows.Forms.CheckBox();
            this.cbGainingMuscle = new System.Windows.Forms.CheckBox();
            this.cbFitness = new System.Windows.Forms.CheckBox();
            this.cbPilates = new System.Windows.Forms.CheckBox();
            this.cbSwimming = new System.Windows.Forms.CheckBox();
            this.cbLiftingWeights = new System.Windows.Forms.CheckBox();
            this.cbBasketball = new System.Windows.Forms.CheckBox();
            this.cbRunning = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gMembersBindingSource)).BeginInit();
            this.gbGender.SuspendLayout();
            this.gbProgram.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.heightDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.programDataGridViewTextBoxColumn,
            this.sportDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gMembersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 247);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1047, 195);
            this.dataGridView1.TabIndex = 0;
            // 
            // gYMDataSet
            // 
            this.gYMDataSet.DataSetName = "GYMDataSet";
            this.gYMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gMembersBindingSource
            // 
            this.gMembersBindingSource.DataMember = "GMembers";
            this.gMembersBindingSource.DataSource = this.gYMDataSet;
            // 
            // gMembersTableAdapter
            // 
            this.gMembersTableAdapter.ClearBeforeFill = true;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            // 
            // heightDataGridViewTextBoxColumn
            // 
            this.heightDataGridViewTextBoxColumn.DataPropertyName = "Height";
            this.heightDataGridViewTextBoxColumn.HeaderText = "Height";
            this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            // 
            // programDataGridViewTextBoxColumn
            // 
            this.programDataGridViewTextBoxColumn.DataPropertyName = "Program";
            this.programDataGridViewTextBoxColumn.HeaderText = "Program";
            this.programDataGridViewTextBoxColumn.Name = "programDataGridViewTextBoxColumn";
            // 
            // sportDataGridViewTextBoxColumn
            // 
            this.sportDataGridViewTextBoxColumn.DataPropertyName = "Sport";
            this.sportDataGridViewTextBoxColumn.HeaderText = "Sport";
            this.sportDataGridViewTextBoxColumn.Name = "sportDataGridViewTextBoxColumn";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(12, 38);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(157, 38);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(316, 38);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(475, 38);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNumber.TabIndex = 4;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(641, 38);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 20);
            this.dtpDOB.TabIndex = 5;
            // 
            // cbHeight
            // 
            this.cbHeight.FormattingEnabled = true;
            this.cbHeight.Location = new System.Drawing.Point(12, 98);
            this.cbHeight.Name = "cbHeight";
            this.cbHeight.Size = new System.Drawing.Size(121, 21);
            this.cbHeight.TabIndex = 6;
            // 
            // cbWeight
            // 
            this.cbWeight.FormattingEnabled = true;
            this.cbWeight.Location = new System.Drawing.Point(193, 98);
            this.cbWeight.Name = "cbWeight";
            this.cbWeight.Size = new System.Drawing.Size(121, 21);
            this.cbWeight.TabIndex = 7;
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rbFemale);
            this.gbGender.Controls.Add(this.rbMale);
            this.gbGender.Location = new System.Drawing.Point(347, 122);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(200, 100);
            this.gbGender.TabIndex = 8;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Gender";
            // 
            // gbProgram
            // 
            this.gbProgram.Controls.Add(this.cbPilates);
            this.gbProgram.Controls.Add(this.cbFitness);
            this.gbProgram.Controls.Add(this.cbGainingMuscle);
            this.gbProgram.Controls.Add(this.cbLosingWeight);
            this.gbProgram.Location = new System.Drawing.Point(585, 122);
            this.gbProgram.Name = "gbProgram";
            this.gbProgram.Size = new System.Drawing.Size(200, 100);
            this.gbProgram.TabIndex = 0;
            this.gbProgram.TabStop = false;
            this.gbProgram.Text = "Program";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbSwimming);
            this.groupBox3.Controls.Add(this.cbLiftingWeights);
            this.groupBox3.Controls.Add(this.cbBasketball);
            this.groupBox3.Controls.Add(this.cbRunning);
            this.groupBox3.Location = new System.Drawing.Point(832, 122);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sport";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(6, 19);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 9;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(6, 42);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 10;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // cbLosingWeight
            // 
            this.cbLosingWeight.AutoSize = true;
            this.cbLosingWeight.Location = new System.Drawing.Point(6, 20);
            this.cbLosingWeight.Name = "cbLosingWeight";
            this.cbLosingWeight.Size = new System.Drawing.Size(94, 17);
            this.cbLosingWeight.TabIndex = 11;
            this.cbLosingWeight.Text = "Losing Weight";
            this.cbLosingWeight.UseVisualStyleBackColor = true;
            // 
            // cbGainingMuscle
            // 
            this.cbGainingMuscle.AutoSize = true;
            this.cbGainingMuscle.Location = new System.Drawing.Point(6, 42);
            this.cbGainingMuscle.Name = "cbGainingMuscle";
            this.cbGainingMuscle.Size = new System.Drawing.Size(104, 17);
            this.cbGainingMuscle.TabIndex = 12;
            this.cbGainingMuscle.Text = "Gaining Muscles";
            this.cbGainingMuscle.UseVisualStyleBackColor = true;
            // 
            // cbFitness
            // 
            this.cbFitness.AutoSize = true;
            this.cbFitness.Location = new System.Drawing.Point(6, 65);
            this.cbFitness.Name = "cbFitness";
            this.cbFitness.Size = new System.Drawing.Size(59, 17);
            this.cbFitness.TabIndex = 13;
            this.cbFitness.Text = "Fitness";
            this.cbFitness.UseVisualStyleBackColor = true;
            // 
            // cbPilates
            // 
            this.cbPilates.AutoSize = true;
            this.cbPilates.Location = new System.Drawing.Point(106, 19);
            this.cbPilates.Name = "cbPilates";
            this.cbPilates.Size = new System.Drawing.Size(57, 17);
            this.cbPilates.TabIndex = 14;
            this.cbPilates.Text = "Pilates";
            this.cbPilates.UseVisualStyleBackColor = true;
            // 
            // cbSwimming
            // 
            this.cbSwimming.AutoSize = true;
            this.cbSwimming.Location = new System.Drawing.Point(6, 19);
            this.cbSwimming.Name = "cbSwimming";
            this.cbSwimming.Size = new System.Drawing.Size(73, 17);
            this.cbSwimming.TabIndex = 12;
            this.cbSwimming.Text = "Swimming";
            this.cbSwimming.UseVisualStyleBackColor = true;
            // 
            // cbLiftingWeights
            // 
            this.cbLiftingWeights.AutoSize = true;
            this.cbLiftingWeights.Location = new System.Drawing.Point(6, 42);
            this.cbLiftingWeights.Name = "cbLiftingWeights";
            this.cbLiftingWeights.Size = new System.Drawing.Size(96, 17);
            this.cbLiftingWeights.TabIndex = 13;
            this.cbLiftingWeights.Text = "Lifting Weights";
            this.cbLiftingWeights.UseVisualStyleBackColor = true;
            // 
            // cbBasketball
            // 
            this.cbBasketball.AutoSize = true;
            this.cbBasketball.Location = new System.Drawing.Point(6, 65);
            this.cbBasketball.Name = "cbBasketball";
            this.cbBasketball.Size = new System.Drawing.Size(75, 17);
            this.cbBasketball.TabIndex = 14;
            this.cbBasketball.Text = "Basketball";
            this.cbBasketball.UseVisualStyleBackColor = true;
            // 
            // cbRunning
            // 
            this.cbRunning.AutoSize = true;
            this.cbRunning.Location = new System.Drawing.Point(94, 19);
            this.cbRunning.Name = "cbRunning";
            this.cbRunning.Size = new System.Drawing.Size(66, 17);
            this.cbRunning.TabIndex = 15;
            this.cbRunning.Text = "Running";
            this.cbRunning.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(484, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Height";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(705, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "DOB";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(232, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Weight";
            // 
            // CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 483);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbProgram);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbGender);
            this.Controls.Add(this.cbWeight);
            this.Controls.Add(this.cbHeight);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CRUD";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.CRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gMembersBindingSource)).EndInit();
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.gbProgram.ResumeLayout(false);
            this.gbProgram.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GYMDataSet gYMDataSet;
        private System.Windows.Forms.BindingSource gMembersBindingSource;
        private GYMDataSetTableAdapters.GMembersTableAdapter gMembersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn programDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sportDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.ComboBox cbHeight;
        private System.Windows.Forms.ComboBox cbWeight;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.GroupBox gbProgram;
        private System.Windows.Forms.CheckBox cbPilates;
        private System.Windows.Forms.CheckBox cbFitness;
        private System.Windows.Forms.CheckBox cbGainingMuscle;
        private System.Windows.Forms.CheckBox cbLosingWeight;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbSwimming;
        private System.Windows.Forms.CheckBox cbLiftingWeights;
        private System.Windows.Forms.CheckBox cbBasketball;
        private System.Windows.Forms.CheckBox cbRunning;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
    }
}