namespace Notepad
{
    partial class Notepad
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notepad));
            this._statusStrip = new System.Windows.Forms.StatusStrip();
            this._cursorPositionLnStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this._cursorPositionLnStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this._cursorPositionColStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this._cursorPositionColStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this._linesAmountStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this._linesAmountStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this._menuStrip = new System.Windows.Forms.MenuStrip();
            this._menuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemSaveAsDOCX = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemSaveAsTxt = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemRemove = new System.Windows.Forms.ToolStripMenuItem();
            this._toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemPaste = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemCut = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this._toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this._menuItemReplace = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemViewHelp = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemSendHelp = new System.Windows.Forms.ToolStripMenuItem();
            this._toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this._menuItemAboutNotepad = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemAboutCurrentTab = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemRussian = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemUkrainian = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemGerman = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemFrench = new System.Windows.Forms.ToolStripMenuItem();
            this._richTextBox = new System.Windows.Forms.RichTextBox();
            this._tabControl = new System.Windows.Forms.TabControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this._aboutButton = new System.Windows.Forms.Button();
            this._replaceButton = new System.Windows.Forms.Button();
            this._removeButton = new System.Windows.Forms.Button();
            this._saveButton = new System.Windows.Forms.Button();
            this._openButton = new System.Windows.Forms.Button();
            this._newButton = new System.Windows.Forms.Button();
            this._statusStrip.SuspendLayout();
            this._menuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _statusStrip
            // 
            this._statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._cursorPositionLnStatusLabel1,
            this._cursorPositionLnStatusLabel2,
            this._cursorPositionColStatusLabel1,
            this._cursorPositionColStatusLabel2,
            this._linesAmountStatusLabel1,
            this._linesAmountStatusLabel2});
            this._statusStrip.Location = new System.Drawing.Point(0, 420);
            this._statusStrip.Name = "_statusStrip";
            this._statusStrip.Size = new System.Drawing.Size(802, 26);
            this._statusStrip.TabIndex = 0;
            this._statusStrip.Text = "statusStrip1";
            // 
            // _cursorPositionLnStatusLabel1
            // 
            this._cursorPositionLnStatusLabel1.Name = "_cursorPositionLnStatusLabel1";
            this._cursorPositionLnStatusLabel1.Size = new System.Drawing.Size(39, 20);
            this._cursorPositionLnStatusLabel1.Text = "Line:";
            // 
            // _cursorPositionLnStatusLabel2
            // 
            this._cursorPositionLnStatusLabel2.Name = "_cursorPositionLnStatusLabel2";
            this._cursorPositionLnStatusLabel2.Size = new System.Drawing.Size(17, 20);
            this._cursorPositionLnStatusLabel2.Text = "1";
            // 
            // _cursorPositionColStatusLabel1
            // 
            this._cursorPositionColStatusLabel1.Name = "_cursorPositionColStatusLabel1";
            this._cursorPositionColStatusLabel1.Size = new System.Drawing.Size(63, 20);
            this._cursorPositionColStatusLabel1.Text = "Column:";
            // 
            // _cursorPositionColStatusLabel2
            // 
            this._cursorPositionColStatusLabel2.Name = "_cursorPositionColStatusLabel2";
            this._cursorPositionColStatusLabel2.Size = new System.Drawing.Size(17, 20);
            this._cursorPositionColStatusLabel2.Text = "1";
            // 
            // _linesAmountStatusLabel1
            // 
            this._linesAmountStatusLabel1.Name = "_linesAmountStatusLabel1";
            this._linesAmountStatusLabel1.Size = new System.Drawing.Size(100, 20);
            this._linesAmountStatusLabel1.Text = "Lines amount:";
            // 
            // _linesAmountStatusLabel2
            // 
            this._linesAmountStatusLabel2.Name = "_linesAmountStatusLabel2";
            this._linesAmountStatusLabel2.Size = new System.Drawing.Size(17, 20);
            this._linesAmountStatusLabel2.Text = "1";
            // 
            // _menuStrip
            // 
            this._menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuItemFile,
            this._menuItemEdit,
            this._menuItemHelp,
            this._menuItemLanguage});
            this._menuStrip.Location = new System.Drawing.Point(0, 0);
            this._menuStrip.Name = "_menuStrip";
            this._menuStrip.Size = new System.Drawing.Size(802, 28);
            this._menuStrip.TabIndex = 2;
            this._menuStrip.Text = "menuStrip1";
            // 
            // _menuItemFile
            // 
            this._menuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuItemNew,
            this._menuItemOpen,
            this._menuItemSave,
            this._menuItemSaveAs,
            this._menuItemRemove,
            this._toolStripSeparator1,
            this._menuItemExit});
            this._menuItemFile.Name = "_menuItemFile";
            this._menuItemFile.Size = new System.Drawing.Size(46, 24);
            this._menuItemFile.Text = "File";
            // 
            // _menuItemNew
            // 
            this._menuItemNew.Image = global::Notepad.Properties.Resources.document_9_91088;
            this._menuItemNew.Name = "_menuItemNew";
            this._menuItemNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this._menuItemNew.Size = new System.Drawing.Size(224, 26);
            this._menuItemNew.Text = "New";
            this._menuItemNew.Click += new System.EventHandler(this.NewClick);
            // 
            // _menuItemOpen
            // 
            this._menuItemOpen.Image = global::Notepad.Properties.Resources.Open_icon_icons_com_73704;
            this._menuItemOpen.Name = "_menuItemOpen";
            this._menuItemOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this._menuItemOpen.Size = new System.Drawing.Size(224, 26);
            this._menuItemOpen.Text = "Open";
            this._menuItemOpen.Click += new System.EventHandler(this.OpenClick);
            // 
            // _menuItemSave
            // 
            this._menuItemSave.Image = global::Notepad.Properties.Resources.savetheapplication_guardar_2958;
            this._menuItemSave.Name = "_menuItemSave";
            this._menuItemSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this._menuItemSave.Size = new System.Drawing.Size(224, 26);
            this._menuItemSave.Text = "Save";
            this._menuItemSave.Click += new System.EventHandler(this.SaveClick);
            // 
            // _menuItemSaveAs
            // 
            this._menuItemSaveAs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuItemSaveAsDOCX,
            this._menuItemSaveAsTxt});
            this._menuItemSaveAs.Image = global::Notepad.Properties.Resources.Save_Icon_icon_icons_com_69139;
            this._menuItemSaveAs.Name = "_menuItemSaveAs";
            this._menuItemSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this._menuItemSaveAs.Size = new System.Drawing.Size(224, 26);
            this._menuItemSaveAs.Text = "Save as";
            // 
            // _menuItemSaveAsDOCX
            // 
            this._menuItemSaveAsDOCX.Image = global::Notepad.Properties.Resources.ext_docx_filetype_icon_176235;
            this._menuItemSaveAsDOCX.Name = "_menuItemSaveAsDOCX";
            this._menuItemSaveAsDOCX.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this._menuItemSaveAsDOCX.Size = new System.Drawing.Size(177, 26);
            this._menuItemSaveAsDOCX.Text = "docx";
            this._menuItemSaveAsDOCX.Click += new System.EventHandler(this.SaveAsDocxClick);
            // 
            // _menuItemSaveAsTxt
            // 
            this._menuItemSaveAsTxt.Image = global::Notepad.Properties.Resources._1497548411_12_84811;
            this._menuItemSaveAsTxt.Name = "_menuItemSaveAsTxt";
            this._menuItemSaveAsTxt.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this._menuItemSaveAsTxt.Size = new System.Drawing.Size(177, 26);
            this._menuItemSaveAsTxt.Text = "txt";
            this._menuItemSaveAsTxt.Click += new System.EventHandler(this.SaveAsTxtClick);
            // 
            // _menuItemRemove
            // 
            this._menuItemRemove.Image = global::Notepad.Properties.Resources.Delete_80_icon_icons_com_57340;
            this._menuItemRemove.Name = "_menuItemRemove";
            this._menuItemRemove.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this._menuItemRemove.Size = new System.Drawing.Size(224, 26);
            this._menuItemRemove.Text = "Remove";
            this._menuItemRemove.Click += new System.EventHandler(this.RemoveClick);
            // 
            // _toolStripSeparator1
            // 
            this._toolStripSeparator1.Name = "_toolStripSeparator1";
            this._toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // _menuItemExit
            // 
            this._menuItemExit.Image = global::Notepad.Properties.Resources.Exit_41038;
            this._menuItemExit.Name = "_menuItemExit";
            this._menuItemExit.Size = new System.Drawing.Size(224, 26);
            this._menuItemExit.Text = "Exit";
            this._menuItemExit.Click += new System.EventHandler(this.ExitClick);
            // 
            // _menuItemEdit
            // 
            this._menuItemEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuItemCopy,
            this._menuItemPaste,
            this._menuItemCut,
            this._menuItemSelectAll,
            this._toolStripSeparator3,
            this._menuItemReplace});
            this._menuItemEdit.Name = "_menuItemEdit";
            this._menuItemEdit.Size = new System.Drawing.Size(49, 24);
            this._menuItemEdit.Text = "Edit";
            // 
            // _menuItemCopy
            // 
            this._menuItemCopy.Image = global::Notepad.Properties.Resources.copy_two_paper_sheets_interface_symbol_icon_icons_com_73283;
            this._menuItemCopy.Name = "_menuItemCopy";
            this._menuItemCopy.Size = new System.Drawing.Size(304, 26);
            this._menuItemCopy.Text = "Copy";
            this._menuItemCopy.Click += new System.EventHandler(this.CopyMenuItemClick);
            // 
            // _menuItemPaste
            // 
            this._menuItemPaste.Image = global::Notepad.Properties.Resources.paste_from_clipboard_icon_icons_com_73466;
            this._menuItemPaste.Name = "_menuItemPaste";
            this._menuItemPaste.Size = new System.Drawing.Size(304, 26);
            this._menuItemPaste.Text = "Paste";
            this._menuItemPaste.Click += new System.EventHandler(this.MenuItemPasteClick);
            // 
            // _menuItemCut
            // 
            this._menuItemCut.Image = global::Notepad.Properties.Resources.fullcut_cut_scissors_4720;
            this._menuItemCut.Name = "_menuItemCut";
            this._menuItemCut.Size = new System.Drawing.Size(304, 26);
            this._menuItemCut.Text = "Cut";
            this._menuItemCut.Click += new System.EventHandler(this.CutMenuItemClick);
            // 
            // _menuItemSelectAll
            // 
            this._menuItemSelectAll.Image = global::Notepad.Properties.Resources.select_all_empty_icon_132746;
            this._menuItemSelectAll.Name = "_menuItemSelectAll";
            this._menuItemSelectAll.Size = new System.Drawing.Size(304, 26);
            this._menuItemSelectAll.Text = "Select All";
            this._menuItemSelectAll.Click += new System.EventHandler(this.SelectAllMenuItemClick);
            // 
            // _toolStripSeparator3
            // 
            this._toolStripSeparator3.Name = "_toolStripSeparator3";
            this._toolStripSeparator3.Size = new System.Drawing.Size(301, 6);
            // 
            // _menuItemReplace
            // 
            this._menuItemReplace.Image = global::Notepad.Properties.Resources.file_replace_icon_136634;
            this._menuItemReplace.Name = "_menuItemReplace";
            this._menuItemReplace.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.R)));
            this._menuItemReplace.Size = new System.Drawing.Size(304, 26);
            this._menuItemReplace.Text = "Replace Current Tab";
            this._menuItemReplace.Click += new System.EventHandler(this.ReplaceClick);
            // 
            // _menuItemHelp
            // 
            this._menuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuItemViewHelp,
            this._menuItemSendHelp,
            this._toolStripSeparator2,
            this._menuItemAboutNotepad,
            this._menuItemAboutCurrentTab});
            this._menuItemHelp.Name = "_menuItemHelp";
            this._menuItemHelp.Size = new System.Drawing.Size(55, 24);
            this._menuItemHelp.Text = "Help";
            // 
            // _menuItemViewHelp
            // 
            this._menuItemViewHelp.Image = global::Notepad.Properties.Resources.Help_icon_icons_com_73700;
            this._menuItemViewHelp.Name = "_menuItemViewHelp";
            this._menuItemViewHelp.Size = new System.Drawing.Size(258, 26);
            this._menuItemViewHelp.Text = "View Help";
            this._menuItemViewHelp.Click += new System.EventHandler(this.ViewHelppMenuItemClick);
            // 
            // _menuItemSendHelp
            // 
            this._menuItemSendHelp.Image = global::Notepad.Properties.Resources.ic_send_128_28719;
            this._menuItemSendHelp.Name = "_menuItemSendHelp";
            this._menuItemSendHelp.Size = new System.Drawing.Size(258, 26);
            this._menuItemSendHelp.Text = "Send Help";
            this._menuItemSendHelp.Click += new System.EventHandler(this.SendHelpMenuItemClick);
            // 
            // _toolStripSeparator2
            // 
            this._toolStripSeparator2.Name = "_toolStripSeparator2";
            this._toolStripSeparator2.Size = new System.Drawing.Size(255, 6);
            // 
            // _menuItemAboutNotepad
            // 
            this._menuItemAboutNotepad.Image = global::Notepad.Properties.Resources.about_3697;
            this._menuItemAboutNotepad.Name = "_menuItemAboutNotepad";
            this._menuItemAboutNotepad.Size = new System.Drawing.Size(258, 26);
            this._menuItemAboutNotepad.Text = "About Notepad";
            this._menuItemAboutNotepad.Click += new System.EventHandler(this.AboutNotepadMenuItemClick);
            // 
            // _menuItemAboutCurrentTab
            // 
            this._menuItemAboutCurrentTab.Image = global::Notepad.Properties.Resources.file_info_40446;
            this._menuItemAboutCurrentTab.Name = "_menuItemAboutCurrentTab";
            this._menuItemAboutCurrentTab.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this._menuItemAboutCurrentTab.Size = new System.Drawing.Size(258, 26);
            this._menuItemAboutCurrentTab.Text = "About Current Tab";
            this._menuItemAboutCurrentTab.Click += new System.EventHandler(this.AboutCurrentTabClick);
            // 
            // _menuItemLanguage
            // 
            this._menuItemLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuItemEnglish,
            this._menuItemRussian,
            this._menuItemUkrainian,
            this._menuItemGerman,
            this._menuItemFrench});
            this._menuItemLanguage.Name = "_menuItemLanguage";
            this._menuItemLanguage.Size = new System.Drawing.Size(88, 24);
            this._menuItemLanguage.Text = "Language";
            // 
            // _menuItemEnglish
            // 
            this._menuItemEnglish.CheckOnClick = true;
            this._menuItemEnglish.Name = "_menuItemEnglish";
            this._menuItemEnglish.Size = new System.Drawing.Size(168, 26);
            this._menuItemEnglish.Text = "English";
            this._menuItemEnglish.Click += new System.EventHandler(this.UILanguageChanged);
            // 
            // _menuItemRussian
            // 
            this._menuItemRussian.Name = "_menuItemRussian";
            this._menuItemRussian.Size = new System.Drawing.Size(168, 26);
            this._menuItemRussian.Text = "Русский";
            this._menuItemRussian.Click += new System.EventHandler(this.UILanguageChanged);
            // 
            // _menuItemUkrainian
            // 
            this._menuItemUkrainian.Name = "_menuItemUkrainian";
            this._menuItemUkrainian.Size = new System.Drawing.Size(168, 26);
            this._menuItemUkrainian.Text = "Українська";
            this._menuItemUkrainian.Click += new System.EventHandler(this.UILanguageChanged);
            // 
            // _menuItemGerman
            // 
            this._menuItemGerman.Name = "_menuItemGerman";
            this._menuItemGerman.Size = new System.Drawing.Size(168, 26);
            this._menuItemGerman.Text = "Deutsch";
            this._menuItemGerman.Click += new System.EventHandler(this.UILanguageChanged);
            // 
            // _menuItemFrench
            // 
            this._menuItemFrench.Name = "_menuItemFrench";
            this._menuItemFrench.Size = new System.Drawing.Size(168, 26);
            this._menuItemFrench.Text = "Françias";
            this._menuItemFrench.Click += new System.EventHandler(this.UILanguageChanged);
            // 
            // _richTextBox
            // 
            this._richTextBox.Location = new System.Drawing.Point(0, 107);
            this._richTextBox.Name = "_richTextBox";
            this._richTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this._richTextBox.Size = new System.Drawing.Size(800, 310);
            this._richTextBox.TabIndex = 3;
            this._richTextBox.Text = "";
            this._richTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RichTextBoxMouseClick);
            this._richTextBox.TextChanged += new System.EventHandler(this.RichTextBoxTextChanged);
            this._richTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RichTextBoxKeyDown);
            this._richTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RichTextBoxTextChanged);
            this._richTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RichTextBoxKeyUp);
            // 
            // _tabControl
            // 
            this._tabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this._tabControl.Location = new System.Drawing.Point(0, 28);
            this._tabControl.Name = "_tabControl";
            this._tabControl.SelectedIndex = 0;
            this._tabControl.Size = new System.Drawing.Size(802, 30);
            this._tabControl.TabIndex = 1;
            this._tabControl.SelectedIndexChanged += new System.EventHandler(this.TabPageChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this._aboutButton);
            this.panel1.Controls.Add(this._replaceButton);
            this.panel1.Controls.Add(this._removeButton);
            this.panel1.Controls.Add(this._saveButton);
            this.panel1.Controls.Add(this._openButton);
            this.panel1.Controls.Add(this._newButton);
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 43);
            this.panel1.TabIndex = 4;
            // 
            // _aboutButton
            // 
            this._aboutButton.Image = global::Notepad.Properties.Resources.New_Project__6_;
            this._aboutButton.Location = new System.Drawing.Point(261, 8);
            this._aboutButton.Name = "_aboutButton";
            this._aboutButton.Size = new System.Drawing.Size(42, 29);
            this._aboutButton.TabIndex = 6;
            this._aboutButton.UseVisualStyleBackColor = true;
            this._aboutButton.Click += new System.EventHandler(this.AboutCurrentTabClick);
            // 
            // _replaceButton
            // 
            this._replaceButton.Image = global::Notepad.Properties.Resources.New_Project__5_;
            this._replaceButton.Location = new System.Drawing.Point(213, 8);
            this._replaceButton.Name = "_replaceButton";
            this._replaceButton.Size = new System.Drawing.Size(42, 29);
            this._replaceButton.TabIndex = 5;
            this._replaceButton.UseVisualStyleBackColor = true;
            this._replaceButton.Click += new System.EventHandler(this.ReplaceClick);
            // 
            // _removeButton
            // 
            this._removeButton.Image = global::Notepad.Properties.Resources.New_Project__4_;
            this._removeButton.Location = new System.Drawing.Point(165, 8);
            this._removeButton.Name = "_removeButton";
            this._removeButton.Size = new System.Drawing.Size(42, 29);
            this._removeButton.TabIndex = 4;
            this._removeButton.UseVisualStyleBackColor = true;
            this._removeButton.Click += new System.EventHandler(this.RemoveClick);
            // 
            // _saveButton
            // 
            this._saveButton.Image = global::Notepad.Properties.Resources.New_Project__3_;
            this._saveButton.Location = new System.Drawing.Point(108, 4);
            this._saveButton.Name = "_saveButton";
            this._saveButton.Size = new System.Drawing.Size(42, 36);
            this._saveButton.TabIndex = 2;
            this._saveButton.UseVisualStyleBackColor = true;
            this._saveButton.Click += new System.EventHandler(this.SaveClick);
            // 
            // _openButton
            // 
            this._openButton.Image = global::Notepad.Properties.Resources.New_Project__2_;
            this._openButton.Location = new System.Drawing.Point(60, 4);
            this._openButton.Name = "_openButton";
            this._openButton.Size = new System.Drawing.Size(42, 36);
            this._openButton.TabIndex = 1;
            this._openButton.UseVisualStyleBackColor = true;
            this._openButton.Click += new System.EventHandler(this.OpenClick);
            // 
            // _newButton
            // 
            this._newButton.ForeColor = System.Drawing.Color.Transparent;
            this._newButton.Image = global::Notepad.Properties.Resources.New_Project__1_;
            this._newButton.Location = new System.Drawing.Point(12, 4);
            this._newButton.Name = "_newButton";
            this._newButton.Size = new System.Drawing.Size(42, 36);
            this._newButton.TabIndex = 0;
            this._newButton.UseVisualStyleBackColor = true;
            this._newButton.Click += new System.EventHandler(this.NewClick);
            // 
            // Notepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 446);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._richTextBox);
            this.Controls.Add(this._tabControl);
            this.Controls.Add(this._statusStrip);
            this.Controls.Add(this._menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this._menuStrip;
            this.MinimumSize = new System.Drawing.Size(374, 185);
            this.Name = "Notepad";
            this.Text = "Notepad";
            this.SizeChanged += new System.EventHandler(this.NotePadSizeChanged);
            this._statusStrip.ResumeLayout(false);
            this._statusStrip.PerformLayout();
            this._menuStrip.ResumeLayout(false);
            this._menuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatusStrip _statusStrip;
        private ToolStripStatusLabel _cursorPositionColStatusLabel1;
        private ToolStripStatusLabel _cursorPositionColStatusLabel2;
        private ToolStripStatusLabel _linesAmountStatusLabel1;
        private ToolStripStatusLabel _linesAmountStatusLabel2;
        private MenuStrip _menuStrip;
        private ToolStripMenuItem _menuItemFile;
        private ToolStripMenuItem _menuItemNew;
        private ToolStripMenuItem _menuItemOpen;
        private ToolStripMenuItem _menuItemSave;
        private ToolStripMenuItem _menuItemSaveAs;
        private ToolStripMenuItem _menuItemSaveAsDOCX;
        private ToolStripMenuItem _menuItemExit;
        private ToolStripMenuItem _menuItemEdit;
        private ToolStripMenuItem _menuItemPaste;
        private ToolStripMenuItem _menuItemReplace;
        private ToolStripMenuItem _menuItemSelectAll;
        private ToolStripMenuItem _menuItemHelp;
        private ToolStripMenuItem _menuItemViewHelp;
        private ToolStripMenuItem _menuItemSendHelp;
        private ToolStripMenuItem _menuItemAboutNotepad;
        private RichTextBox _richTextBox;
        private ToolStripMenuItem _menuItemSaveAsTxt;
        private ToolStripMenuItem _menuItemRemove;
        private ToolStripStatusLabel _cursorPositionLnStatusLabel1;
        private ToolStripStatusLabel _cursorPositionLnStatusLabel2;
        private ToolStripMenuItem _menuItemAboutCurrentTab;
        private ToolStripMenuItem _menuItemCopy;
        private ToolStripMenuItem _menuItemCut;
        private ToolStripSeparator _toolStripSeparator1;
        private ToolStripSeparator _toolStripSeparator2;
        private ToolStripSeparator _toolStripSeparator3;
        private TabControl _tabControl;
        private Panel panel1;
        private Button _removeButton;
        private Button _saveButton;
        private Button _openButton;
        private Button _newButton;
        private Button _aboutButton;
        private Button _replaceButton;
        private ToolStripMenuItem _menuItemLanguage;
        private ToolStripMenuItem _menuItemEnglish;
        private ToolStripMenuItem _menuItemRussian;
        private ToolStripMenuItem _menuItemUkrainian;
        private ToolStripMenuItem _menuItemGerman;
        private ToolStripMenuItem _menuItemFrench;
    }
}