namespace PRG_272
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAnimals = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAnimalId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSpecies = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.btnSummary = new System.Windows.Forms.Button();
            this.lblTotalAnimals = new System.Windows.Forms.Label();
            this.lblAvgAge = new System.Windows.Forms.Label();
            this.lblAvgScore = new System.Windows.Forms.Label();
            this.lblCritical = new System.Windows.Forms.Label();
            this.lblSerious = new System.Windows.Forms.Label();
            this.lblStable = new System.Windows.Forms.Label();
            this.lblRecovering = new System.Windows.Forms.Label();
            this.lblReleaseReady = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimals)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpSummary.SuspendLayout();
            this.SuspendLayout();

            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Baobab Ridge Wildlife Rehabilitation Records System";

            // dgvAnimals
            this.dgvAnimals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimals.Location = new System.Drawing.Point(54, 122);
            this.dgvAnimals.Name = "dgvAnimals";
            this.dgvAnimals.RowHeadersWidth = 51;
            this.dgvAnimals.Size = new System.Drawing.Size(850, 232);
            this.dgvAnimals.TabIndex = 1;
            this.dgvAnimals.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAnimals_CellContentClick);

            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search by Animal ID:";

            // txtSearch
            this.txtSearch.Location = new System.Drawing.Point(154, 69);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(121, 20);
            this.txtSearch.TabIndex = 3;

            // btnSearch
            this.btnSearch.Location = new System.Drawing.Point(307, 69);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(65, 22);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // groupBox1
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnSaveChanges);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtAnimalId);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtSpecies);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.txtScore);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(54, 380);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 272);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Animal Details";

            // btnDelete
            this.btnDelete.Location = new System.Drawing.Point(323, 213);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // btnClear
            this.btnClear.Location = new System.Drawing.Point(226, 213);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(56, 24);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // btnSaveChanges
            this.btnSaveChanges.Location = new System.Drawing.Point(101, 213);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(95, 24);
            this.btnSaveChanges.TabIndex = 13;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);

            // btnAdd
            this.btnAdd.Location = new System.Drawing.Point(15, 213);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 24);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // txtAnimalId
            this.txtAnimalId.Location = new System.Drawing.Point(100, 33);
            this.txtAnimalId.Name = "txtAnimalId";
            this.txtAnimalId.Size = new System.Drawing.Size(183, 20);
            this.txtAnimalId.TabIndex = 12;

            // txtName
            this.txtName.Location = new System.Drawing.Point(100, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(183, 20);
            this.txtName.TabIndex = 11;

            // txtSpecies
            this.txtSpecies.Location = new System.Drawing.Point(100, 93);
            this.txtSpecies.Name = "txtSpecies";
            this.txtSpecies.Size = new System.Drawing.Size(183, 20);
            this.txtSpecies.TabIndex = 10;

            // txtAge
            this.txtAge.Location = new System.Drawing.Point(100, 124);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(183, 20);
            this.txtAge.TabIndex = 9;

            // txtScore
            this.txtScore.Location = new System.Drawing.Point(100, 154);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(183, 20);
            this.txtScore.TabIndex = 8;

            // label7
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Recovery Score:";

            // label6
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Age:";

            // label5
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Species:";

            // label4
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name:";

            // label3
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Animal ID:";

            // grpSummary
            this.grpSummary.Controls.Add(this.btnSummary);
            this.grpSummary.Controls.Add(this.lblTotalAnimals);
            this.grpSummary.Controls.Add(this.lblAvgAge);
            this.grpSummary.Controls.Add(this.lblAvgScore);
            this.grpSummary.Controls.Add(this.lblCritical);
            this.grpSummary.Controls.Add(this.lblSerious);
            this.grpSummary.Controls.Add(this.lblStable);
            this.grpSummary.Controls.Add(this.lblRecovering);
            this.grpSummary.Controls.Add(this.lblReleaseReady);
            this.grpSummary.Location = new System.Drawing.Point(500, 380);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(404, 272);
            this.grpSummary.TabIndex = 6;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Summary Statistics";

            // btnSummary
            this.btnSummary.Location = new System.Drawing.Point(15, 230);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(140, 28);
            this.btnSummary.TabIndex = 0;
            this.btnSummary.Text = "Generate Summary";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);

            // lblTotalAnimals
            this.lblTotalAnimals.AutoSize = true;
            this.lblTotalAnimals.Location = new System.Drawing.Point(15, 30);
            this.lblTotalAnimals.Name = "lblTotalAnimals";
            this.lblTotalAnimals.Size = new System.Drawing.Size(83, 13);
            this.lblTotalAnimals.Text = "Total animals: 0";

            // lblAvgAge
            this.lblAvgAge.AutoSize = true;
            this.lblAvgAge.Location = new System.Drawing.Point(15, 50);
            this.lblAvgAge.Name = "lblAvgAge";
            this.lblAvgAge.Size = new System.Drawing.Size(117, 13);
            this.lblAvgAge.Text = "Average age (years): 0";

            // lblAvgScore
            this.lblAvgScore.AutoSize = true;
            this.lblAvgScore.Location = new System.Drawing.Point(15, 70);
            this.lblAvgScore.Name = "lblAvgScore";
            this.lblAvgScore.Size = new System.Drawing.Size(130, 13);
            this.lblAvgScore.Text = "Average recovery score: 0";

            // lblCritical
            this.lblCritical.AutoSize = true;
            this.lblCritical.Location = new System.Drawing.Point(15, 105);
            this.lblCritical.Name = "lblCritical";
            this.lblCritical.Size = new System.Drawing.Size(50, 13);
            this.lblCritical.TabIndex = 3;
            this.lblCritical.Text = "Critical: 0";

            // lblSerious
            this.lblSerious.AutoSize = true;
            this.lblSerious.Location = new System.Drawing.Point(15, 125);
            this.lblSerious.Name = "lblSerious";
            this.lblSerious.Size = new System.Drawing.Size(54, 13);
            this.lblSerious.TabIndex = 4;
            this.lblSerious.Text = "Serious: 0";

            // lblStable
            this.lblStable.AutoSize = true;
            this.lblStable.Location = new System.Drawing.Point(15, 145);
            this.lblStable.Name = "lblStable";
            this.lblStable.Size = new System.Drawing.Size(49, 13);
            this.lblStable.TabIndex = 5;
            this.lblStable.Text = "Stable: 0";

            // lblRecovering
            this.lblRecovering.AutoSize = true;
            this.lblRecovering.Location = new System.Drawing.Point(15, 165);
            this.lblRecovering.Name = "lblRecovering";
            this.lblRecovering.Size = new System.Drawing.Size(74, 13);
            this.lblRecovering.TabIndex = 6;
            this.lblRecovering.Text = "Recovering: 0";

            // lblReleaseReady
            this.lblReleaseReady.AutoSize = true;
            this.lblReleaseReady.Location = new System.Drawing.Point(15, 185);
            this.lblReleaseReady.Name = "lblReleaseReady";
            this.lblReleaseReady.Size = new System.Drawing.Size(89, 13);
            this.lblReleaseReady.TabIndex = 7;
            this.lblReleaseReady.Text = "Release-Ready: 0";

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 680);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvAnimals);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Baobab Ridge Wildlife Rehabilitation Records System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimals)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAnimals;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAnimalId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSpecies;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.Label lblTotalAnimals;
        private System.Windows.Forms.Label lblAvgAge;
        private System.Windows.Forms.Label lblAvgScore;
        private System.Windows.Forms.Label lblCritical;
        private System.Windows.Forms.Label lblSerious;
        private System.Windows.Forms.Label lblStable;
        private System.Windows.Forms.Label lblRecovering;
        private System.Windows.Forms.Label lblReleaseReady;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.Label lblTotalAnimals;
        private System.Windows.Forms.Label lblAvgAge;
        private System.Windows.Forms.Label lblAvgScore;
        private System.Windows.Forms.Label lblCritical;
        private System.Windows.Forms.Label lblSerious;
        private System.Windows.Forms.Label lblStable;
        private System.Windows.Forms.Label lblRecovering;
        private System.Windows.Forms.Label lblReleaseReady;
        private System.Windows.Forms.Button btnSummary;
    }  
}

