namespace TBA.Forms
{
    partial class frmMain
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
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.itmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.itmOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.itmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.itmReports = new System.Windows.Forms.ToolStripMenuItem();
            this.itmAnalysisReport = new System.Windows.Forms.ToolStripMenuItem();
            this.itmNoteReport = new System.Windows.Forms.ToolStripMenuItem();
            this.itmStatisticsReport = new System.Windows.Forms.ToolStripMenuItem();
            this.itmNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.itmAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.btnUpload = new System.Windows.Forms.Button();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblSizePrefix = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.lblImagePrefix = new System.Windows.Forms.Label();
            this.lblExecutable = new System.Windows.Forms.Label();
            this.lblExecutablePrefix = new System.Windows.Forms.Label();
            this.lblExtension = new System.Windows.Forms.Label();
            this.lblExtensionPrefix = new System.Windows.Forms.Label();
            this.lblFilename = new System.Windows.Forms.Label();
            this.lblFilenamePrefix = new System.Windows.Forms.Label();
            this.lblSpecificInfo = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblDrag = new System.Windows.Forms.Label();
            this.lblNothing = new System.Windows.Forms.Label();
            this.editor = new TBA.Controls.TBAEditor();
            this.pnlExecutable = new TBA.Controls.TBAExecutablePanel();
            this.pnlImage = new TBA.Controls.TBAImagePanel();
            this.mnuMain.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmFile,
            this.itmReports,
            this.itmNotes,
            this.itmAbout});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(1050, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // itmFile
            // 
            this.itmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmOpenFile,
            this.itmExit});
            this.itmFile.Name = "itmFile";
            this.itmFile.Size = new System.Drawing.Size(37, 20);
            this.itmFile.Text = "File";
            // 
            // itmOpenFile
            // 
            this.itmOpenFile.Name = "itmOpenFile";
            this.itmOpenFile.Size = new System.Drawing.Size(124, 22);
            this.itmOpenFile.Text = "Open File";
            this.itmOpenFile.Click += new System.EventHandler(this.itmOpenFile_Click);
            // 
            // itmExit
            // 
            this.itmExit.Name = "itmExit";
            this.itmExit.Size = new System.Drawing.Size(124, 22);
            this.itmExit.Text = "Exit";
            this.itmExit.Click += new System.EventHandler(this.itmExit_Click);
            // 
            // itmReports
            // 
            this.itmReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmAnalysisReport,
            this.itmNoteReport,
            this.itmStatisticsReport});
            this.itmReports.Name = "itmReports";
            this.itmReports.Size = new System.Drawing.Size(59, 20);
            this.itmReports.Text = "Reports";
            // 
            // itmAnalysisReport
            // 
            this.itmAnalysisReport.Name = "itmAnalysisReport";
            this.itmAnalysisReport.Size = new System.Drawing.Size(176, 22);
            this.itmAnalysisReport.Text = "File Analysis Report";
            this.itmAnalysisReport.Click += new System.EventHandler(this.itmAnalysisReport_Click);
            // 
            // itmNoteReport
            // 
            this.itmNoteReport.Name = "itmNoteReport";
            this.itmNoteReport.Size = new System.Drawing.Size(176, 22);
            this.itmNoteReport.Text = "Note Report";
            this.itmNoteReport.Click += new System.EventHandler(this.itmNoteReport_Click);
            // 
            // itmStatisticsReport
            // 
            this.itmStatisticsReport.Name = "itmStatisticsReport";
            this.itmStatisticsReport.Size = new System.Drawing.Size(176, 22);
            this.itmStatisticsReport.Text = "Statistics Report";
            this.itmStatisticsReport.Click += new System.EventHandler(this.itmStatisticsReport_Click);
            // 
            // itmNotes
            // 
            this.itmNotes.Name = "itmNotes";
            this.itmNotes.Size = new System.Drawing.Size(50, 20);
            this.itmNotes.Text = "Notes";
            this.itmNotes.Click += new System.EventHandler(this.itmNotes_Click);
            // 
            // itmAbout
            // 
            this.itmAbout.Name = "itmAbout";
            this.itmAbout.Size = new System.Drawing.Size(52, 20);
            this.itmAbout.Text = "About";
            this.itmAbout.Click += new System.EventHandler(this.itmAbout_Click);
            // 
            // pnlInfo
            // 
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfo.Controls.Add(this.btnUpload);
            this.pnlInfo.Controls.Add(this.pnlExecutable);
            this.pnlInfo.Controls.Add(this.lblSize);
            this.pnlInfo.Controls.Add(this.lblSizePrefix);
            this.pnlInfo.Controls.Add(this.lblImage);
            this.pnlInfo.Controls.Add(this.lblImagePrefix);
            this.pnlInfo.Controls.Add(this.lblExecutable);
            this.pnlInfo.Controls.Add(this.lblExecutablePrefix);
            this.pnlInfo.Controls.Add(this.lblExtension);
            this.pnlInfo.Controls.Add(this.lblExtensionPrefix);
            this.pnlInfo.Controls.Add(this.lblFilename);
            this.pnlInfo.Controls.Add(this.lblFilenamePrefix);
            this.pnlInfo.Controls.Add(this.lblSpecificInfo);
            this.pnlInfo.Controls.Add(this.lblHeader);
            this.pnlInfo.Controls.Add(this.pnlImage);
            this.pnlInfo.Location = new System.Drawing.Point(12, 65);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(591, 740);
            this.pnlInfo.TabIndex = 1;
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(40, 280);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(117, 45);
            this.btnUpload.TabIndex = 14;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(87, 222);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(41, 30);
            this.lblSize.TabIndex = 11;
            this.lblSize.Text = "No";
            // 
            // lblSizePrefix
            // 
            this.lblSizePrefix.AutoSize = true;
            this.lblSizePrefix.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSizePrefix.Location = new System.Drawing.Point(35, 222);
            this.lblSizePrefix.Name = "lblSizePrefix";
            this.lblSizePrefix.Size = new System.Drawing.Size(55, 30);
            this.lblSizePrefix.TabIndex = 10;
            this.lblSizePrefix.Text = "Size:";
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImage.Location = new System.Drawing.Point(131, 187);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(41, 30);
            this.lblImage.TabIndex = 9;
            this.lblImage.Text = "No";
            // 
            // lblImagePrefix
            // 
            this.lblImagePrefix.AutoSize = true;
            this.lblImagePrefix.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagePrefix.Location = new System.Drawing.Point(35, 187);
            this.lblImagePrefix.Name = "lblImagePrefix";
            this.lblImagePrefix.Size = new System.Drawing.Size(99, 30);
            this.lblImagePrefix.TabIndex = 8;
            this.lblImagePrefix.Text = "Is Image:";
            // 
            // lblExecutable
            // 
            this.lblExecutable.AutoSize = true;
            this.lblExecutable.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExecutable.Location = new System.Drawing.Point(175, 152);
            this.lblExecutable.Name = "lblExecutable";
            this.lblExecutable.Size = new System.Drawing.Size(41, 30);
            this.lblExecutable.TabIndex = 7;
            this.lblExecutable.Text = "No";
            // 
            // lblExecutablePrefix
            // 
            this.lblExecutablePrefix.AutoSize = true;
            this.lblExecutablePrefix.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExecutablePrefix.Location = new System.Drawing.Point(35, 152);
            this.lblExecutablePrefix.Name = "lblExecutablePrefix";
            this.lblExecutablePrefix.Size = new System.Drawing.Size(142, 30);
            this.lblExecutablePrefix.TabIndex = 6;
            this.lblExecutablePrefix.Text = "Is Executable:";
            // 
            // lblExtension
            // 
            this.lblExtension.AutoSize = true;
            this.lblExtension.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtension.Location = new System.Drawing.Point(141, 117);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(50, 30);
            this.lblExtension.TabIndex = 5;
            this.lblExtension.Text = ".exe";
            // 
            // lblExtensionPrefix
            // 
            this.lblExtensionPrefix.AutoSize = true;
            this.lblExtensionPrefix.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtensionPrefix.Location = new System.Drawing.Point(35, 117);
            this.lblExtensionPrefix.Name = "lblExtensionPrefix";
            this.lblExtensionPrefix.Size = new System.Drawing.Size(110, 30);
            this.lblExtensionPrefix.TabIndex = 4;
            this.lblExtensionPrefix.Text = "Extension:";
            // 
            // lblFilename
            // 
            this.lblFilename.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilename.Location = new System.Drawing.Point(88, 86);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(483, 30);
            this.lblFilename.TabIndex = 3;
            this.lblFilename.Text = "C:/Users/test/folder/other folder/testfile.docx";
            // 
            // lblFilenamePrefix
            // 
            this.lblFilenamePrefix.AutoSize = true;
            this.lblFilenamePrefix.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilenamePrefix.Location = new System.Drawing.Point(35, 82);
            this.lblFilenamePrefix.Name = "lblFilenamePrefix";
            this.lblFilenamePrefix.Size = new System.Drawing.Size(60, 30);
            this.lblFilenamePrefix.TabIndex = 2;
            this.lblFilenamePrefix.Text = "Path:";
            // 
            // lblSpecificInfo
            // 
            this.lblSpecificInfo.AutoSize = true;
            this.lblSpecificInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecificInfo.Location = new System.Drawing.Point(19, 369);
            this.lblSpecificInfo.Name = "lblSpecificInfo";
            this.lblSpecificInfo.Size = new System.Drawing.Size(264, 37);
            this.lblSpecificInfo.TabIndex = 1;
            this.lblSpecificInfo.Text = "Specific Information";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(19, 16);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(264, 37);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "General Information";
            // 
            // lblDrag
            // 
            this.lblDrag.AutoSize = true;
            this.lblDrag.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrag.Location = new System.Drawing.Point(228, 375);
            this.lblDrag.Name = "lblDrag";
            this.lblDrag.Size = new System.Drawing.Size(585, 50);
            this.lblDrag.TabIndex = 1;
            this.lblDrag.Text = "Drag and drop a file to get started";
            // 
            // lblNothing
            // 
            this.lblNothing.AutoSize = true;
            this.lblNothing.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNothing.Location = new System.Drawing.Point(206, 617);
            this.lblNothing.Name = "lblNothing";
            this.lblNothing.Size = new System.Drawing.Size(201, 32);
            this.lblNothing.TabIndex = 3;
            this.lblNothing.Text = "Nothing to show...";
            // 
            // editor
            // 
            this.editor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.editor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.editor.Location = new System.Drawing.Point(609, 65);
            this.editor.Name = "editor";
            this.editor.Size = new System.Drawing.Size(429, 740);
            this.editor.TabIndex = 2;
            // 
            // pnlExecutable
            // 
            this.pnlExecutable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.pnlExecutable.Location = new System.Drawing.Point(21, 421);
            this.pnlExecutable.Name = "pnlExecutable";
            this.pnlExecutable.Size = new System.Drawing.Size(550, 289);
            this.pnlExecutable.TabIndex = 12;
            // 
            // pnlImage
            // 
            this.pnlImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.pnlImage.Location = new System.Drawing.Point(21, 421);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(550, 289);
            this.pnlImage.TabIndex = 13;
            // 
            // frmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 817);
            this.Controls.Add(this.lblNothing);
            this.Controls.Add(this.editor);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.lblDrag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TBA";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmMain_DragEnter);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem itmFile;
        private System.Windows.Forms.ToolStripMenuItem itmExit;
        private System.Windows.Forms.Panel pnlInfo;
        private Controls.TBAEditor editor;
        private System.Windows.Forms.ToolStripMenuItem itmOpenFile;
        private System.Windows.Forms.ToolStripMenuItem itmReports;
        private System.Windows.Forms.ToolStripMenuItem itmAbout;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblDrag;
        private System.Windows.Forms.Label lblSpecificInfo;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.Label lblFilenamePrefix;
        private System.Windows.Forms.Label lblExtension;
        private System.Windows.Forms.Label lblExtensionPrefix;
        private System.Windows.Forms.Label lblExecutable;
        private System.Windows.Forms.Label lblExecutablePrefix;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Label lblImagePrefix;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblSizePrefix;
        private Controls.TBAExecutablePanel pnlExecutable;
        private Controls.TBAImagePanel pnlImage;
        private System.Windows.Forms.ToolStripMenuItem itmNotes;
        private System.Windows.Forms.ToolStripMenuItem itmAnalysisReport;
        private System.Windows.Forms.ToolStripMenuItem itmNoteReport;
        private System.Windows.Forms.ToolStripMenuItem itmStatisticsReport;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label lblNothing;
    }
}

