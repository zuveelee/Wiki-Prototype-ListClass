namespace Wiki_Prototype_ListClass
{
    partial class WikiForm
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
            this.lstViewWiki = new System.Windows.Forms.ListView();
            this.clmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cboxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.grpBoxStructure = new System.Windows.Forms.GroupBox();
            this.rdoBtnNonLinear = new System.Windows.Forms.RadioButton();
            this.rdoBtnLinear = new System.Windows.Forms.RadioButton();
            this.txtDefinition = new System.Windows.Forms.TextBox();
            this.lblDefinition = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpBoxStructure.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstViewWiki
            // 
            this.lstViewWiki.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmName,
            this.clmCategory});
            this.lstViewWiki.HideSelection = false;
            this.lstViewWiki.Location = new System.Drawing.Point(363, 12);
            this.lstViewWiki.Name = "lstViewWiki";
            this.lstViewWiki.Size = new System.Drawing.Size(212, 406);
            this.lstViewWiki.TabIndex = 0;
            this.lstViewWiki.UseCompatibleStateImageBehavior = false;
            this.lstViewWiki.View = System.Windows.Forms.View.Details;
            // 
            // clmName
            // 
            this.clmName.Text = "Name";
            this.clmName.Width = 109;
            // 
            // clmCategory
            // 
            this.clmCategory.Text = "Category";
            this.clmCategory.Width = 99;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(94, 59);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(176, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(36, 59);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // cboxCategory
            // 
            this.cboxCategory.FormattingEnabled = true;
            this.cboxCategory.Location = new System.Drawing.Point(94, 107);
            this.cboxCategory.Name = "cboxCategory";
            this.cboxCategory.Size = new System.Drawing.Size(176, 21);
            this.cboxCategory.TabIndex = 3;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(36, 110);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Category:";
            // 
            // grpBoxStructure
            // 
            this.grpBoxStructure.Controls.Add(this.rdoBtnNonLinear);
            this.grpBoxStructure.Controls.Add(this.rdoBtnLinear);
            this.grpBoxStructure.Location = new System.Drawing.Point(94, 147);
            this.grpBoxStructure.Name = "grpBoxStructure";
            this.grpBoxStructure.Size = new System.Drawing.Size(176, 117);
            this.grpBoxStructure.TabIndex = 5;
            this.grpBoxStructure.TabStop = false;
            this.grpBoxStructure.Text = "Structure";
            // 
            // rdoBtnNonLinear
            // 
            this.rdoBtnNonLinear.AutoSize = true;
            this.rdoBtnNonLinear.Location = new System.Drawing.Point(20, 65);
            this.rdoBtnNonLinear.Name = "rdoBtnNonLinear";
            this.rdoBtnNonLinear.Size = new System.Drawing.Size(77, 17);
            this.rdoBtnNonLinear.TabIndex = 1;
            this.rdoBtnNonLinear.TabStop = true;
            this.rdoBtnNonLinear.Text = "Non-Linear";
            this.rdoBtnNonLinear.UseVisualStyleBackColor = true;
            // 
            // rdoBtnLinear
            // 
            this.rdoBtnLinear.AutoSize = true;
            this.rdoBtnLinear.Location = new System.Drawing.Point(20, 29);
            this.rdoBtnLinear.Name = "rdoBtnLinear";
            this.rdoBtnLinear.Size = new System.Drawing.Size(54, 17);
            this.rdoBtnLinear.TabIndex = 0;
            this.rdoBtnLinear.TabStop = true;
            this.rdoBtnLinear.Text = "Linear";
            this.rdoBtnLinear.UseVisualStyleBackColor = true;
            // 
            // txtDefinition
            // 
            this.txtDefinition.Location = new System.Drawing.Point(94, 282);
            this.txtDefinition.Multiline = true;
            this.txtDefinition.Name = "txtDefinition";
            this.txtDefinition.Size = new System.Drawing.Size(176, 136);
            this.txtDefinition.TabIndex = 6;
            // 
            // lblDefinition
            // 
            this.lblDefinition.AutoSize = true;
            this.lblDefinition.Location = new System.Drawing.Point(29, 282);
            this.lblDefinition.Name = "lblDefinition";
            this.lblDefinition.Size = new System.Drawing.Size(59, 13);
            this.lblDefinition.TabIndex = 7;
            this.lblDefinition.Text = "Definitions:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(32, 424);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(114, 424);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(195, 424);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(13, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(94, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(176, 20);
            this.txtSearch.TabIndex = 12;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(363, 423);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 13;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(499, 423);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 453);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(607, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // WikiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 475);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblDefinition);
            this.Controls.Add(this.txtDefinition);
            this.Controls.Add(this.grpBoxStructure);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cboxCategory);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lstViewWiki);
            this.Name = "WikiForm";
            this.Text = "Wiki Prototype ListClass";
            this.grpBoxStructure.ResumeLayout(false);
            this.grpBoxStructure.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstViewWiki;
        private System.Windows.Forms.ColumnHeader clmName;
        private System.Windows.Forms.ColumnHeader clmCategory;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cboxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox grpBoxStructure;
        private System.Windows.Forms.RadioButton rdoBtnNonLinear;
        private System.Windows.Forms.RadioButton rdoBtnLinear;
        private System.Windows.Forms.TextBox txtDefinition;
        private System.Windows.Forms.Label lblDefinition;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

