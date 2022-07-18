namespace paw_project2._0
{
    partial class MainForm
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
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lvContracts = new System.Windows.Forms.ListView();
            this.colProvider = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSigningDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colValidity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addContract = new System.Windows.Forms.Button();
            this.lvProviders = new System.Windows.Forms.ListView();
            this.clName2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clFounded = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clMaterials = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addProvider = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lvMaterials = new System.Windows.Forms.ListView();
            this.clName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.addMaterial = new System.Windows.Forms.Button();
            this.btnSeeMaterials = new System.Windows.Forms.Button();
            this.btnSeeProviders = new System.Windows.Forms.Button();
            this.btnSeeContracts = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveBinaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            label1.Location = new System.Drawing.Point(191, 47);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(141, 31);
            label1.TabIndex = 1;
            label1.Text = "Contracts";
            // 
            // lvContracts
            // 
            this.lvContracts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(107)))), ((int)(((byte)(14)))));
            this.lvContracts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvContracts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colProvider,
            this.clSigningDate,
            this.colValidity,
            this.colValue});
            this.lvContracts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lvContracts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.lvContracts.GridLines = true;
            this.lvContracts.HideSelection = false;
            this.lvContracts.Location = new System.Drawing.Point(29, 101);
            this.lvContracts.Name = "lvContracts";
            this.lvContracts.Size = new System.Drawing.Size(479, 346);
            this.lvContracts.TabIndex = 0;
            this.lvContracts.UseCompatibleStateImageBehavior = false;
            this.lvContracts.View = System.Windows.Forms.View.Details;
            // 
            // colProvider
            // 
            this.colProvider.Text = "Provider";
            this.colProvider.Width = 96;
            // 
            // clSigningDate
            // 
            this.clSigningDate.Text = "Signing Date";
            this.clSigningDate.Width = 170;
            // 
            // colValidity
            // 
            this.colValidity.Text = "Validity(years)";
            this.colValidity.Width = 117;
            // 
            // colValue
            // 
            this.colValue.Text = "Value(USD)";
            this.colValue.Width = 312;
            // 
            // addContract
            // 
            this.addContract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(107)))), ((int)(((byte)(14)))));
            this.addContract.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addContract.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.addContract.Location = new System.Drawing.Point(219, 538);
            this.addContract.Name = "addContract";
            this.addContract.Size = new System.Drawing.Size(79, 62);
            this.addContract.TabIndex = 2;
            this.addContract.Text = "Add Contract";
            this.addContract.UseVisualStyleBackColor = false;
            this.addContract.Click += new System.EventHandler(this.addContract_Click);
            // 
            // lvProviders
            // 
            this.lvProviders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(107)))), ((int)(((byte)(14)))));
            this.lvProviders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clName2,
            this.clFounded,
            this.clMaterials});
            this.lvProviders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lvProviders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.lvProviders.GridLines = true;
            this.lvProviders.HideSelection = false;
            this.lvProviders.Location = new System.Drawing.Point(552, 101);
            this.lvProviders.Name = "lvProviders";
            this.lvProviders.Size = new System.Drawing.Size(588, 346);
            this.lvProviders.TabIndex = 3;
            this.lvProviders.UseCompatibleStateImageBehavior = false;
            this.lvProviders.View = System.Windows.Forms.View.Details;
            // 
            // clName2
            // 
            this.clName2.Text = "Name";
            this.clName2.Width = 156;
            // 
            // clFounded
            // 
            this.clFounded.Text = "Founded";
            this.clFounded.Width = 206;
            // 
            // clMaterials
            // 
            this.clMaterials.Text = "Materials";
            this.clMaterials.Width = 397;
            // 
            // addProvider
            // 
            this.addProvider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(107)))), ((int)(((byte)(14)))));
            this.addProvider.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addProvider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.addProvider.Location = new System.Drawing.Point(790, 538);
            this.addProvider.Name = "addProvider";
            this.addProvider.Size = new System.Drawing.Size(79, 62);
            this.addProvider.TabIndex = 4;
            this.addProvider.Text = "Add Provider";
            this.addProvider.UseVisualStyleBackColor = false;
            this.addProvider.Click += new System.EventHandler(this.addProvider_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.label2.Location = new System.Drawing.Point(770, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Providers";
            // 
            // lvMaterials
            // 
            this.lvMaterials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(107)))), ((int)(((byte)(14)))));
            this.lvMaterials.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clName,
            this.clPrice});
            this.lvMaterials.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lvMaterials.GridLines = true;
            this.lvMaterials.HideSelection = false;
            this.lvMaterials.Location = new System.Drawing.Point(1185, 101);
            this.lvMaterials.Name = "lvMaterials";
            this.lvMaterials.Size = new System.Drawing.Size(366, 346);
            this.lvMaterials.TabIndex = 6;
            this.lvMaterials.UseCompatibleStateImageBehavior = false;
            this.lvMaterials.View = System.Windows.Forms.View.Details;
            // 
            // clName
            // 
            this.clName.Text = "Name";
            this.clName.Width = 180;
            // 
            // clPrice
            // 
            this.clPrice.Text = "Price";
            this.clPrice.Width = 288;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.label3.Location = new System.Drawing.Point(1288, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Materials";
            // 
            // addMaterial
            // 
            this.addMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(107)))), ((int)(((byte)(14)))));
            this.addMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addMaterial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.addMaterial.Location = new System.Drawing.Point(1312, 538);
            this.addMaterial.Name = "addMaterial";
            this.addMaterial.Size = new System.Drawing.Size(79, 62);
            this.addMaterial.TabIndex = 8;
            this.addMaterial.Text = "Add Material";
            this.addMaterial.UseVisualStyleBackColor = false;
            this.addMaterial.Click += new System.EventHandler(this.addMaterial_Click);
            // 
            // btnSeeMaterials
            // 
            this.btnSeeMaterials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(107)))), ((int)(((byte)(14)))));
            this.btnSeeMaterials.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeeMaterials.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSeeMaterials.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.btnSeeMaterials.Location = new System.Drawing.Point(1312, 623);
            this.btnSeeMaterials.Name = "btnSeeMaterials";
            this.btnSeeMaterials.Size = new System.Drawing.Size(79, 37);
            this.btnSeeMaterials.TabIndex = 9;
            this.btnSeeMaterials.Text = "See Materials";
            this.btnSeeMaterials.UseVisualStyleBackColor = false;
            this.btnSeeMaterials.Click += new System.EventHandler(this.btnSeeMaterials_Click);
            // 
            // btnSeeProviders
            // 
            this.btnSeeProviders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(107)))), ((int)(((byte)(14)))));
            this.btnSeeProviders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeeProviders.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSeeProviders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.btnSeeProviders.Location = new System.Drawing.Point(790, 623);
            this.btnSeeProviders.Name = "btnSeeProviders";
            this.btnSeeProviders.Size = new System.Drawing.Size(79, 37);
            this.btnSeeProviders.TabIndex = 10;
            this.btnSeeProviders.Text = "See Providers";
            this.btnSeeProviders.UseVisualStyleBackColor = false;
            this.btnSeeProviders.Click += new System.EventHandler(this.tbSeeProviders_Click);
            // 
            // btnSeeContracts
            // 
            this.btnSeeContracts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(107)))), ((int)(((byte)(14)))));
            this.btnSeeContracts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeeContracts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSeeContracts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.btnSeeContracts.Location = new System.Drawing.Point(219, 623);
            this.btnSeeContracts.Name = "btnSeeContracts";
            this.btnSeeContracts.Size = new System.Drawing.Size(79, 37);
            this.btnSeeContracts.TabIndex = 11;
            this.btnSeeContracts.Text = "See Contracts";
            this.btnSeeContracts.UseVisualStyleBackColor = false;
            this.btnSeeContracts.Click += new System.EventHandler(this.btnSeeContracts_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1579, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveTxtToolStripMenuItem,
            this.saveBinaryToolStripMenuItem,
            this.printToolStripMenuItem,
            this.pageSetupToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveTxtToolStripMenuItem
            // 
            this.saveTxtToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveTxtToolStripMenuItem.Name = "saveTxtToolStripMenuItem";
            this.saveTxtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveTxtToolStripMenuItem.Text = "Save Txt";
            this.saveTxtToolStripMenuItem.Click += new System.EventHandler(this.saveTxtToolStripMenuItem_Click);
            // 
            // saveBinaryToolStripMenuItem
            // 
            this.saveBinaryToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveBinaryToolStripMenuItem.Name = "saveBinaryToolStripMenuItem";
            this.saveBinaryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveBinaryToolStripMenuItem.Text = "Save Binary";
            this.saveBinaryToolStripMenuItem.Click += new System.EventHandler(this.saveBinaryToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // pageSetupToolStripMenuItem
            // 
            this.pageSetupToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pageSetupToolStripMenuItem.Name = "pageSetupToolStripMenuItem";
            this.pageSetupToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pageSetupToolStripMenuItem.Text = "Page Setup";
            this.pageSetupToolStripMenuItem.Click += new System.EventHandler(this.pageSetupToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
            this.exportToolStripMenuItem.Text = "Export (csv)";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog1";
            this.printPreviewDialog.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1579, 741);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnSeeContracts);
            this.Controls.Add(this.btnSeeProviders);
            this.Controls.Add(this.btnSeeMaterials);
            this.Controls.Add(this.addMaterial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lvMaterials);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addProvider);
            this.Controls.Add(this.lvProviders);
            this.Controls.Add(this.addContract);
            this.Controls.Add(label1);
            this.Controls.Add(this.lvContracts);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvContracts;
        private System.Windows.Forms.Button addContract;
        private System.Windows.Forms.ListView lvProviders;
        private System.Windows.Forms.Button addProvider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvMaterials;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addMaterial;
        private System.Windows.Forms.ColumnHeader clName;
        private System.Windows.Forms.ColumnHeader clPrice;
        private System.Windows.Forms.Button btnSeeMaterials;
        private System.Windows.Forms.Button btnSeeProviders;
        private System.Windows.Forms.Button btnSeeContracts;
        private System.Windows.Forms.ColumnHeader clName2;
        private System.Windows.Forms.ColumnHeader clFounded;
        private System.Windows.Forms.ColumnHeader clMaterials;
        private System.Windows.Forms.ColumnHeader colProvider;
        private System.Windows.Forms.ColumnHeader clSigningDate;
        private System.Windows.Forms.ColumnHeader colValidity;
        private System.Windows.Forms.ColumnHeader colValue;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveBinaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.ToolStripMenuItem pageSetupToolStripMenuItem;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
    }
}

