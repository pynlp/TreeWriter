﻿namespace TreeWriterWF
{
    partial class ManuscriptDocumentEditor
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
            System.Windows.Forms.Panel filterPanel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManuscriptDocumentEditor));
            this.filterBox = new System.Windows.Forms.TextBox();
            this.clearFilterButton = new System.Windows.Forms.Button();
            this.refreshFilterButton = new System.Windows.Forms.Button();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newSceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listView = new System.Windows.Forms.ListView();
            this.columnTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTags = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnWordCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tagBox = new System.Windows.Forms.TextBox();
            this.openSceneLabel = new System.Windows.Forms.Label();
            this.textEditor = new TreeWriterWF.TextEditor();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.duplicateViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            filterPanel = new System.Windows.Forms.Panel();
            filterPanel.SuspendLayout();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // filterPanel
            // 
            filterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            filterPanel.Controls.Add(this.filterBox);
            filterPanel.Controls.Add(this.clearFilterButton);
            filterPanel.Controls.Add(this.refreshFilterButton);
            filterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            filterPanel.Location = new System.Drawing.Point(0, 0);
            filterPanel.Name = "filterPanel";
            filterPanel.Padding = new System.Windows.Forms.Padding(3);
            filterPanel.Size = new System.Drawing.Size(285, 28);
            filterPanel.TabIndex = 2;
            // 
            // filterBox
            // 
            this.filterBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterBox.Location = new System.Drawing.Point(3, 3);
            this.filterBox.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(237, 20);
            this.filterBox.TabIndex = 1;
            this.filterBox.TextChanged += new System.EventHandler(this.filterBox_TextChanged);
            // 
            // clearFilterButton
            // 
            this.clearFilterButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clearFilterButton.BackgroundImage")));
            this.clearFilterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearFilterButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.clearFilterButton.FlatAppearance.BorderSize = 0;
            this.clearFilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearFilterButton.Location = new System.Drawing.Point(240, 3);
            this.clearFilterButton.Name = "clearFilterButton";
            this.clearFilterButton.Size = new System.Drawing.Size(20, 20);
            this.clearFilterButton.TabIndex = 2;
            this.clearFilterButton.UseVisualStyleBackColor = true;
            this.clearFilterButton.Click += new System.EventHandler(this.clearFilterButton_Click);
            // 
            // refreshFilterButton
            // 
            this.refreshFilterButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshFilterButton.BackgroundImage")));
            this.refreshFilterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshFilterButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.refreshFilterButton.FlatAppearance.BorderSize = 0;
            this.refreshFilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshFilterButton.Location = new System.Drawing.Point(260, 3);
            this.refreshFilterButton.Name = "refreshFilterButton";
            this.refreshFilterButton.Size = new System.Drawing.Size(20, 20);
            this.refreshFilterButton.TabIndex = 3;
            this.refreshFilterButton.UseVisualStyleBackColor = true;
            this.refreshFilterButton.Click += new System.EventHandler(this.refreshFilterButton_Click);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSceneToolStripMenuItem,
            this.deleteSceneToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(142, 48);
            // 
            // newSceneToolStripMenuItem
            // 
            this.newSceneToolStripMenuItem.Name = "newSceneToolStripMenuItem";
            this.newSceneToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.newSceneToolStripMenuItem.Text = "New Scene";
            this.newSceneToolStripMenuItem.Click += new System.EventHandler(this.newSceneToolStripMenuItem_Click);
            // 
            // deleteSceneToolStripMenuItem
            // 
            this.deleteSceneToolStripMenuItem.Name = "deleteSceneToolStripMenuItem";
            this.deleteSceneToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.deleteSceneToolStripMenuItem.Text = "Delete Scene";
            this.deleteSceneToolStripMenuItem.Click += new System.EventHandler(this.deleteSceneToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listView);
            this.splitContainer1.Panel1.Controls.Add(filterPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(859, 430);
            this.splitContainer1.SplitterDistance = 285;
            this.splitContainer1.TabIndex = 1;
            // 
            // listView
            // 
            this.listView.AllowDrop = true;
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTitle,
            this.columnColor,
            this.columnTags,
            this.columnWordCount});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.LabelEdit = true;
            this.listView.Location = new System.Drawing.Point(0, 28);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(285, 402);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listView_AfterLabelEdit);
            this.listView.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listView_ItemDrag);
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            this.listView.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView_DragDrop);
            this.listView.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView_DragEnter);
            this.listView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DocumentEditor_KeyDown);
            this.listView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseClick);
            this.listView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listView_MouseUp);
            // 
            // columnTitle
            // 
            this.columnTitle.Text = "Name";
            this.columnTitle.Width = 200;
            // 
            // columnColor
            // 
            this.columnColor.Width = 20;
            // 
            // columnTags
            // 
            this.columnTags.Text = "Tags";
            this.columnTags.Width = 180;
            // 
            // columnWordCount
            // 
            this.columnWordCount.Text = "Words";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tagBox);
            this.splitContainer2.Panel1.Controls.Add(this.openSceneLabel);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.textEditor);
            this.splitContainer2.Size = new System.Drawing.Size(570, 430);
            this.splitContainer2.SplitterDistance = 40;
            this.splitContainer2.TabIndex = 1;
            // 
            // tagBox
            // 
            this.tagBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tagBox.Location = new System.Drawing.Point(0, 19);
            this.tagBox.Multiline = true;
            this.tagBox.Name = "tagBox";
            this.tagBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tagBox.Size = new System.Drawing.Size(570, 21);
            this.tagBox.TabIndex = 0;
            this.tagBox.TextChanged += new System.EventHandler(this.tagBox_TextChanged);
            // 
            // openSceneLabel
            // 
            this.openSceneLabel.AutoSize = true;
            this.openSceneLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.openSceneLabel.Location = new System.Drawing.Point(0, 0);
            this.openSceneLabel.Name = "openSceneLabel";
            this.openSceneLabel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.openSceneLabel.Size = new System.Drawing.Size(177, 19);
            this.openSceneLabel.TabIndex = 1;
            this.openSceneLabel.Text = "THE NAME OF THE OPEN SCENE";
            // 
            // textEditor
            // 
            this.textEditor.AnnotationVisible = ScintillaNET.Annotation.Boxed;
            this.textEditor.AutomaticFold = ((ScintillaNET.AutomaticFold)(((ScintillaNET.AutomaticFold.Show | ScintillaNET.AutomaticFold.Click) 
            | ScintillaNET.AutomaticFold.Change)));
            this.textEditor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEditor.IdleStyling = ScintillaNET.IdleStyling.ToVisible;
            this.textEditor.Location = new System.Drawing.Point(0, 0);
            this.textEditor.Name = "textEditor";
            this.textEditor.Size = new System.Drawing.Size(570, 386);
            this.textEditor.TabIndex = 0;
            this.textEditor.WrapMode = ScintillaNET.WrapMode.Word;
            this.textEditor.Zoom = 5;
            this.textEditor.TextChanged += new System.EventHandler(this.textEditor_TextChanged);
            this.textEditor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DocumentEditor_KeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.duplicateViewToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 26);
            // 
            // duplicateViewToolStripMenuItem
            // 
            this.duplicateViewToolStripMenuItem.Name = "duplicateViewToolStripMenuItem";
            this.duplicateViewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.duplicateViewToolStripMenuItem.Text = "Duplicate View";
            this.duplicateViewToolStripMenuItem.Click += new System.EventHandler(this.duplicateViewToolStripMenuItem_Click);
            // 
            // ManuscriptDocumentEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 430);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ManuscriptDocumentEditor";
            this.TabPageContextMenuStrip = this.contextMenuStrip1;
            this.Text = "SceneListing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this._FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DocumentEditor_KeyDown);
            filterPanel.ResumeLayout(false);
            filterPanel.PerformLayout();
            this.contextMenu.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private TextEditor textEditor;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem newSceneToolStripMenuItem;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnTags;
        private System.Windows.Forms.ColumnHeader columnTitle;
        private System.Windows.Forms.ToolStripMenuItem deleteSceneToolStripMenuItem;
        private System.Windows.Forms.TextBox filterBox;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox tagBox;
        private System.Windows.Forms.Label openSceneLabel;
        private System.Windows.Forms.Button clearFilterButton;
        private System.Windows.Forms.Button refreshFilterButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem duplicateViewToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnWordCount;
        private System.Windows.Forms.ColumnHeader columnColor;

        
    }
}