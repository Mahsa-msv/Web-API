
namespace APItask
{
    partial class APIvalues
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
            this.fetchBTN = new System.Windows.Forms.Button();
            this.fetchDatabaseBTN = new System.Windows.Forms.Button();
            this.cloudTable = new System.Windows.Forms.DataGridView();
            this.FetchandInsertintoLocalDB = new System.Windows.Forms.Button();
            this.searchTerm = new System.Windows.Forms.TextBox();
            this.filterBTN = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.previousPageBTN = new System.Windows.Forms.Button();
            this.nextPageBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtComment = new System.Windows.Forms.TextBox();
            this.TxtDate = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.Countdrp = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ResetTxt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cloudTable)).BeginInit();
            this.SuspendLayout();
            // 
            // fetchBTN
            // 
            this.fetchBTN.Location = new System.Drawing.Point(45, 27);
            this.fetchBTN.Name = "fetchBTN";
            this.fetchBTN.Size = new System.Drawing.Size(118, 29);
            this.fetchBTN.TabIndex = 0;
            this.fetchBTN.Text = "Fetch from API";
            this.fetchBTN.UseVisualStyleBackColor = true;
            this.fetchBTN.Click += new System.EventHandler(this.fetchBTN_Click);
            // 
            // fetchDatabaseBTN
            // 
            this.fetchDatabaseBTN.Location = new System.Drawing.Point(208, 27);
            this.fetchDatabaseBTN.Name = "fetchDatabaseBTN";
            this.fetchDatabaseBTN.Size = new System.Drawing.Size(126, 29);
            this.fetchDatabaseBTN.TabIndex = 1;
            this.fetchDatabaseBTN.Text = "Fetch from database";
            this.fetchDatabaseBTN.UseVisualStyleBackColor = true;
            this.fetchDatabaseBTN.Click += new System.EventHandler(this.fetchDatabaseBTN_Click);
            // 
            // cloudTable
            // 
            this.cloudTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cloudTable.Location = new System.Drawing.Point(45, 75);
            this.cloudTable.Name = "cloudTable";
            this.cloudTable.Size = new System.Drawing.Size(461, 331);
            this.cloudTable.TabIndex = 2;
            // 
            // FetchandInsertintoLocalDB
            // 
            this.FetchandInsertintoLocalDB.Location = new System.Drawing.Point(384, 27);
            this.FetchandInsertintoLocalDB.Name = "FetchandInsertintoLocalDB";
            this.FetchandInsertintoLocalDB.Size = new System.Drawing.Size(129, 29);
            this.FetchandInsertintoLocalDB.TabIndex = 3;
            this.FetchandInsertintoLocalDB.Text = "Fetch API and Insert";
            this.FetchandInsertintoLocalDB.UseVisualStyleBackColor = true;
            this.FetchandInsertintoLocalDB.Click += new System.EventHandler(this.FetchandInsertintoLocalDB_Click);
            // 
            // searchTerm
            // 
            this.searchTerm.Location = new System.Drawing.Point(538, 32);
            this.searchTerm.Name = "searchTerm";
            this.searchTerm.Size = new System.Drawing.Size(140, 20);
            this.searchTerm.TabIndex = 4;
            // 
            // filterBTN
            // 
            this.filterBTN.Location = new System.Drawing.Point(693, 27);
            this.filterBTN.Name = "filterBTN";
            this.filterBTN.Size = new System.Drawing.Size(75, 29);
            this.filterBTN.TabIndex = 5;
            this.filterBTN.Text = "Filter";
            this.filterBTN.UseVisualStyleBackColor = true;
            this.filterBTN.Click += new System.EventHandler(this.filterBTN_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(786, 27);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 29);
            this.Reset.TabIndex = 6;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // previousPageBTN
            // 
            this.previousPageBTN.Location = new System.Drawing.Point(197, 412);
            this.previousPageBTN.Name = "previousPageBTN";
            this.previousPageBTN.Size = new System.Drawing.Size(75, 23);
            this.previousPageBTN.TabIndex = 7;
            this.previousPageBTN.Text = "Previous";
            this.previousPageBTN.UseVisualStyleBackColor = true;
            this.previousPageBTN.Click += new System.EventHandler(this.previousPageBTN_Click);
            // 
            // nextPageBTN
            // 
            this.nextPageBTN.Location = new System.Drawing.Point(278, 412);
            this.nextPageBTN.Name = "nextPageBTN";
            this.nextPageBTN.Size = new System.Drawing.Size(75, 23);
            this.nextPageBTN.TabIndex = 8;
            this.nextPageBTN.Text = "Next";
            this.nextPageBTN.UseVisualStyleBackColor = true;
            this.nextPageBTN.Click += new System.EventHandler(this.nextPageBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(595, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(595, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(595, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(595, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Comment";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(673, 109);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(159, 20);
            this.TxtId.TabIndex = 13;
            // 
            // TxtComment
            // 
            this.TxtComment.Location = new System.Drawing.Point(673, 276);
            this.TxtComment.Name = "TxtComment";
            this.TxtComment.Size = new System.Drawing.Size(159, 20);
            this.TxtComment.TabIndex = 14;
            // 
            // TxtDate
            // 
            this.TxtDate.Location = new System.Drawing.Point(673, 216);
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.Size = new System.Drawing.Size(159, 20);
            this.TxtDate.TabIndex = 15;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(673, 164);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(159, 20);
            this.TxtName.TabIndex = 16;
            // 
            // Countdrp
            // 
            this.Countdrp.FormattingEnabled = true;
            this.Countdrp.Items.AddRange(new object[] {
            "10",
            "20",
            "50",
            "100"});
            this.Countdrp.Location = new System.Drawing.Point(464, 414);
            this.Countdrp.Name = "Countdrp";
            this.Countdrp.Size = new System.Drawing.Size(49, 21);
            this.Countdrp.TabIndex = 17;
            this.Countdrp.Text = "20";
            this.Countdrp.SelectedIndexChanged += new System.EventHandler(this.Countdrp_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(670, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 29);
            this.button1.TabIndex = 18;
            this.button1.Text = "Insert Into API";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.InsertIntoAPI_Click);
            // 
            // ResetTxt
            // 
            this.ResetTxt.Location = new System.Drawing.Point(774, 341);
            this.ResetTxt.Name = "ResetTxt";
            this.ResetTxt.Size = new System.Drawing.Size(75, 29);
            this.ResetTxt.TabIndex = 19;
            this.ResetTxt.Text = "Reset";
            this.ResetTxt.UseVisualStyleBackColor = true;
            this.ResetTxt.Click += new System.EventHandler(this.ResetTxt_Click);
            // 
            // APIvalues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 481);
            this.Controls.Add(this.ResetTxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Countdrp);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtDate);
            this.Controls.Add(this.TxtComment);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nextPageBTN);
            this.Controls.Add(this.previousPageBTN);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.filterBTN);
            this.Controls.Add(this.searchTerm);
            this.Controls.Add(this.FetchandInsertintoLocalDB);
            this.Controls.Add(this.cloudTable);
            this.Controls.Add(this.fetchDatabaseBTN);
            this.Controls.Add(this.fetchBTN);
            this.Name = "APIvalues";
            this.Text = "APIvalues";
            ((System.ComponentModel.ISupportInitialize)(this.cloudTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fetchBTN;
        private System.Windows.Forms.Button fetchDatabaseBTN;
        private System.Windows.Forms.DataGridView cloudTable;
        private System.Windows.Forms.Button FetchandInsertintoLocalDB;
        private System.Windows.Forms.TextBox searchTerm;
        private System.Windows.Forms.Button filterBTN;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button previousPageBTN;
        private System.Windows.Forms.Button nextPageBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtComment;
        private System.Windows.Forms.TextBox TxtDate;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.ComboBox Countdrp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ResetTxt;
    }
}

