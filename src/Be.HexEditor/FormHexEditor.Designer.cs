namespace Be.HexEditor
{
    partial class FormHexEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHexEditor));
            this.Menu = new Be.HexEditor.Core.MenuStripEx();
            this.MenuFile = new Be.HexEditor.Core.ToolStripMenuItemEx();
            this.MenuFileOpen = new Be.HexEditor.Core.ToolStripMenuItemEx();
            this.MenuFileSave = new Be.HexEditor.Core.ToolStripMenuItemEx();
            this.MenuEdit = new Be.HexEditor.Core.ToolStripMenuItemEx();
            this.MenuEditCut = new Be.HexEditor.Core.ToolStripMenuItemEx();
            this.MenuEditCopy = new Be.HexEditor.Core.ToolStripMenuItemEx();
            this.MenuEditPaste = new Be.HexEditor.Core.ToolStripMenuItemEx();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuEditCopyHex = new Be.HexEditor.Core.ToolStripMenuItemEx();
            this.MenuEditPasteHex = new Be.HexEditor.Core.ToolStripMenuItemEx();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuEditFind = new Be.HexEditor.Core.ToolStripMenuItemEx();
            this.MenuEditFindNext = new Be.HexEditor.Core.ToolStripMenuItemEx();
            this.MenuEditGoto = new Be.HexEditor.Core.ToolStripMenuItemEx();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuEditSelectAll = new Be.HexEditor.Core.ToolStripMenuItemEx();
            this.Tools = new Be.HexEditor.Core.ToolStripEx();
            this.ToolsFileOpen = new Be.HexEditor.Core.ToolStripButtonEx();
            this.ToolsFileSave = new Be.HexEditor.Core.ToolStripButtonEx();
            this.ToolsEditCut = new Be.HexEditor.Core.ToolStripButtonEx();
            this.ToolsEditCopy = new Be.HexEditor.Core.ToolStripSplitButtonEx();
            this.ToolsEditCopyText = new Be.HexEditor.Core.ToolStripMenuItemEx();
            this.ToolsEditCopyHex = new Be.HexEditor.Core.ToolStripMenuItemEx();
            this.ToolsEditPaste = new Be.HexEditor.Core.ToolStripSplitButtonEx();
            this.ToolsEditPasteText = new Be.HexEditor.Core.ToolStripMenuItemEx();
            this.ToolsEditPasteHex = new Be.HexEditor.Core.ToolStripMenuItemEx();
            this.ToolsEditFind = new System.Windows.Forms.ToolStripButton();
            this.ToolsEditFindNext = new System.Windows.Forms.ToolStripButton();
            this.ToolsEditGoto = new System.Windows.Forms.ToolStripButton();
            this.ToolsEditSelectAll = new System.Windows.Forms.ToolStripButton();
            this.ToolsEncodingSelect = new System.Windows.Forms.ToolStripComboBox();
            this.ToolsBytesPerLineSelect = new System.Windows.Forms.ToolStripComboBox();
            this.ToolInterpretShow = new System.Windows.Forms.ToolStripButton();
            this.StatusBox = new System.Windows.Forms.StatusStrip();
            this.StatusPosSel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusSep1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusFileSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusSep2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusBitsDesc = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusBitsOfByte = new System.Windows.Forms.ToolStripStatusLabel();
            this.OpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.HexEditor = new Be.Windows.Forms.HexBox();
            this.EditorPanel = new System.Windows.Forms.Panel();
            this.InterpretBox = new System.Windows.Forms.TableLayoutPanel();
            this.InterpretColor = new System.Windows.Forms.TextBox();
            this.InterpretDateTime = new System.Windows.Forms.TextBox();
            this.InterpretDescArgb = new System.Windows.Forms.Label();
            this.InterpretEndian = new System.Windows.Forms.GroupBox();
            this.InterpretBigEndian = new System.Windows.Forms.RadioButton();
            this.InterpretLittleEndian = new System.Windows.Forms.RadioButton();
            this.InterpretFloat = new System.Windows.Forms.TextBox();
            this.InterpretDescFloat = new System.Windows.Forms.Label();
            this.InterpretDescInt64 = new System.Windows.Forms.Label();
            this.InterpretDescInt32 = new System.Windows.Forms.Label();
            this.InterpretDescInt16 = new System.Windows.Forms.Label();
            this.InterpretDescInt8 = new System.Windows.Forms.Label();
            this.InterpretInt64 = new System.Windows.Forms.TextBox();
            this.InterpretInt32 = new System.Windows.Forms.TextBox();
            this.InterpretInt16 = new System.Windows.Forms.TextBox();
            this.InterpretInt8 = new System.Windows.Forms.TextBox();
            this.InterpretDescRaw = new System.Windows.Forms.Label();
            this.InterpretRaw = new System.Windows.Forms.TextBox();
            this.InterpretDouble = new System.Windows.Forms.TextBox();
            this.InterpretUint64 = new System.Windows.Forms.TextBox();
            this.InterpretUint32 = new System.Windows.Forms.TextBox();
            this.InterpretUint16 = new System.Windows.Forms.TextBox();
            this.InterpretUint8 = new System.Windows.Forms.TextBox();
            this.InterpretDescDouble = new System.Windows.Forms.Label();
            this.InterpretDescUint64 = new System.Windows.Forms.Label();
            this.InterpretDescUint32 = new System.Windows.Forms.Label();
            this.InterpretDescUint16 = new System.Windows.Forms.Label();
            this.InterpretDescUint8 = new System.Windows.Forms.Label();
            this.InterpretDescDateTime = new System.Windows.Forms.Label();
            this.ToolsSep1 = new System.Windows.Forms.ToolStripLabel();
            this.ToolsSep2 = new System.Windows.Forms.ToolStripLabel();
            this.ToolsSep3 = new System.Windows.Forms.ToolStripLabel();
            this.ToolsSep4 = new System.Windows.Forms.ToolStripLabel();
            this.ToolsSep5 = new System.Windows.Forms.ToolStripLabel();
            this.ToolsSep6 = new System.Windows.Forms.ToolStripLabel();
            this.ToolSpan1 = new System.Windows.Forms.ToolStripLabel();
            this.Menu.SuspendLayout();
            this.Tools.SuspendLayout();
            this.StatusBox.SuspendLayout();
            this.EditorPanel.SuspendLayout();
            this.InterpretBox.SuspendLayout();
            this.InterpretEndian.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.SystemColors.Control;
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuEdit});
            resources.ApplyResources(this.Menu, "Menu");
            this.Menu.Name = "Menu";
            // 
            // MenuFile
            // 
            this.MenuFile.BackColor = System.Drawing.SystemColors.Control;
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFileOpen,
            this.MenuFileSave});
            this.MenuFile.Name = "MenuFile";
            resources.ApplyResources(this.MenuFile, "MenuFile");
            // 
            // MenuFileOpen
            // 
            this.MenuFileOpen.BackColor = System.Drawing.SystemColors.Control;
            this.MenuFileOpen.Image = global::Be.HexEditor.ScalingImages.FolderOpen_16;
            this.MenuFileOpen.Image16 = global::Be.HexEditor.ScalingImages.FolderOpen_16;
            this.MenuFileOpen.Image24 = global::Be.HexEditor.ScalingImages.FolderOpen_24;
            this.MenuFileOpen.Image32 = global::Be.HexEditor.ScalingImages.FolderOpen_32;
            resources.ApplyResources(this.MenuFileOpen, "MenuFileOpen");
            this.MenuFileOpen.Name = "MenuFileOpen";
            this.MenuFileOpen.Click += new System.EventHandler(this.FileOpenClick);
            // 
            // MenuFileSave
            // 
            this.MenuFileSave.Image = global::Be.HexEditor.ScalingImages.save16;
            this.MenuFileSave.Image16 = global::Be.HexEditor.ScalingImages.save16;
            this.MenuFileSave.Image24 = global::Be.HexEditor.ScalingImages.Save24;
            this.MenuFileSave.Image32 = global::Be.HexEditor.ScalingImages.Save32;
            resources.ApplyResources(this.MenuFileSave, "MenuFileSave");
            this.MenuFileSave.Name = "MenuFileSave";
            this.MenuFileSave.Click += new System.EventHandler(this.FileSaveClick);
            // 
            // MenuEdit
            // 
            this.MenuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuEditCut,
            this.MenuEditCopy,
            this.MenuEditPaste,
            this.toolStripSeparator3,
            this.MenuEditCopyHex,
            this.MenuEditPasteHex,
            this.toolStripSeparator4,
            this.MenuEditFind,
            this.MenuEditFindNext,
            this.MenuEditGoto,
            this.toolStripSeparator5,
            this.MenuEditSelectAll});
            this.MenuEdit.Name = "MenuEdit";
            resources.ApplyResources(this.MenuEdit, "MenuEdit");
            // 
            // MenuEditCut
            // 
            this.MenuEditCut.Image = global::Be.HexEditor.ScalingImages.Cut16;
            this.MenuEditCut.Image16 = global::Be.HexEditor.ScalingImages.Copy16;
            this.MenuEditCut.Image24 = global::Be.HexEditor.ScalingImages.Copy24;
            this.MenuEditCut.Image32 = global::Be.HexEditor.ScalingImages.Copy32;
            resources.ApplyResources(this.MenuEditCut, "MenuEditCut");
            this.MenuEditCut.Name = "MenuEditCut";
            this.MenuEditCut.Click += new System.EventHandler(this.EditCutClick);
            // 
            // MenuEditCopy
            // 
            this.MenuEditCopy.Image = global::Be.HexEditor.ScalingImages.Copy16;
            this.MenuEditCopy.Image16 = global::Be.HexEditor.ScalingImages.Copy16;
            this.MenuEditCopy.Image24 = global::Be.HexEditor.ScalingImages.Copy24;
            this.MenuEditCopy.Image32 = global::Be.HexEditor.ScalingImages.Copy32;
            resources.ApplyResources(this.MenuEditCopy, "MenuEditCopy");
            this.MenuEditCopy.Name = "MenuEditCopy";
            this.MenuEditCopy.Click += new System.EventHandler(this.EditCopyClick);
            // 
            // MenuEditPaste
            // 
            this.MenuEditPaste.Image = global::Be.HexEditor.ScalingImages.Paste16;
            this.MenuEditPaste.Image16 = global::Be.HexEditor.ScalingImages.Paste16;
            this.MenuEditPaste.Image24 = global::Be.HexEditor.ScalingImages.Paste24;
            this.MenuEditPaste.Image32 = global::Be.HexEditor.ScalingImages.Paste32;
            resources.ApplyResources(this.MenuEditPaste, "MenuEditPaste");
            this.MenuEditPaste.Name = "MenuEditPaste";
            this.MenuEditPaste.Click += new System.EventHandler(this.EditPasteClick);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // MenuEditCopyHex
            // 
            this.MenuEditCopyHex.Name = "MenuEditCopyHex";
            resources.ApplyResources(this.MenuEditCopyHex, "MenuEditCopyHex");
            this.MenuEditCopyHex.Click += new System.EventHandler(this.EditCopyHexClick);
            // 
            // MenuEditPasteHex
            // 
            this.MenuEditPasteHex.Name = "MenuEditPasteHex";
            resources.ApplyResources(this.MenuEditPasteHex, "MenuEditPasteHex");
            this.MenuEditPasteHex.Click += new System.EventHandler(this.EditPasteHexClick);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // MenuEditFind
            // 
            this.MenuEditFind.Image = global::Be.HexEditor.ScalingImages.Find16;
            this.MenuEditFind.Image16 = global::Be.HexEditor.ScalingImages.Find16;
            this.MenuEditFind.Image24 = global::Be.HexEditor.ScalingImages.Find24;
            this.MenuEditFind.Image32 = global::Be.HexEditor.ScalingImages.Find32;
            this.MenuEditFind.Name = "MenuEditFind";
            resources.ApplyResources(this.MenuEditFind, "MenuEditFind");
            this.MenuEditFind.Click += new System.EventHandler(this.EditFindClick);
            // 
            // MenuEditFindNext
            // 
            this.MenuEditFindNext.Image = global::Be.HexEditor.ScalingImages.FindNext16;
            this.MenuEditFindNext.Image16 = global::Be.HexEditor.ScalingImages.FindNext16;
            this.MenuEditFindNext.Image24 = global::Be.HexEditor.ScalingImages.FindNext24;
            this.MenuEditFindNext.Image32 = global::Be.HexEditor.ScalingImages.FindNext32;
            this.MenuEditFindNext.Name = "MenuEditFindNext";
            resources.ApplyResources(this.MenuEditFindNext, "MenuEditFindNext");
            this.MenuEditFindNext.Click += new System.EventHandler(this.EditFindNextClick);
            // 
            // MenuEditGoto
            // 
            this.MenuEditGoto.Image = global::Be.HexEditor.images.Goto;
            this.MenuEditGoto.Name = "MenuEditGoto";
            resources.ApplyResources(this.MenuEditGoto, "MenuEditGoto");
            this.MenuEditGoto.Click += new System.EventHandler(this.EditGotoClick);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // MenuEditSelectAll
            // 
            this.MenuEditSelectAll.Image = global::Be.HexEditor.images.selectall;
            this.MenuEditSelectAll.Name = "MenuEditSelectAll";
            resources.ApplyResources(this.MenuEditSelectAll, "MenuEditSelectAll");
            this.MenuEditSelectAll.Click += new System.EventHandler(this.EditSelectAllClick);
            // 
            // Tools
            // 
            this.Tools.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Tools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolsSep1,
            this.ToolsFileOpen,
            this.ToolsFileSave,
            this.ToolsSep2,
            this.ToolsEditCut,
            this.ToolsEditCopy,
            this.ToolsEditPaste,
            this.ToolsSep3,
            this.ToolsEditFind,
            this.ToolsEditFindNext,
            this.ToolsEditGoto,
            this.ToolsEditSelectAll,
            this.ToolsSep4,
            this.ToolsEncodingSelect,
            this.ToolSpan1,
            this.ToolsBytesPerLineSelect,
            this.ToolsSep5,
            this.ToolInterpretShow,
            this.ToolsSep6});
            resources.ApplyResources(this.Tools, "Tools");
            this.Tools.Name = "Tools";
            // 
            // ToolsFileOpen
            // 
            this.ToolsFileOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolsFileOpen.Image = global::Be.HexEditor.images.openHS;
            this.ToolsFileOpen.Image16 = global::Be.HexEditor.ScalingImages.FolderOpen_16;
            this.ToolsFileOpen.Image24 = global::Be.HexEditor.ScalingImages.FolderOpen_24;
            this.ToolsFileOpen.Image32 = global::Be.HexEditor.ScalingImages.FolderOpen_32;
            resources.ApplyResources(this.ToolsFileOpen, "ToolsFileOpen");
            this.ToolsFileOpen.Name = "ToolsFileOpen";
            this.ToolsFileOpen.Click += new System.EventHandler(this.FileOpenClick);
            // 
            // ToolsFileSave
            // 
            this.ToolsFileSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolsFileSave.Image = global::Be.HexEditor.images.saveHS;
            this.ToolsFileSave.Image16 = global::Be.HexEditor.ScalingImages.save16;
            this.ToolsFileSave.Image24 = global::Be.HexEditor.ScalingImages.Save24;
            this.ToolsFileSave.Image32 = global::Be.HexEditor.ScalingImages.Save32;
            resources.ApplyResources(this.ToolsFileSave, "ToolsFileSave");
            this.ToolsFileSave.Name = "ToolsFileSave";
            this.ToolsFileSave.Click += new System.EventHandler(this.FileSaveClick);
            // 
            // ToolsEditCut
            // 
            this.ToolsEditCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolsEditCut.Image = global::Be.HexEditor.images.CutHS;
            this.ToolsEditCut.Image16 = global::Be.HexEditor.ScalingImages.Cut16;
            this.ToolsEditCut.Image24 = global::Be.HexEditor.ScalingImages.Copy24;
            this.ToolsEditCut.Image32 = global::Be.HexEditor.ScalingImages.Copy32;
            resources.ApplyResources(this.ToolsEditCut, "ToolsEditCut");
            this.ToolsEditCut.Name = "ToolsEditCut";
            this.ToolsEditCut.Click += new System.EventHandler(this.EditCutClick);
            // 
            // ToolsEditCopy
            // 
            this.ToolsEditCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolsEditCopy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolsEditCopyText,
            this.ToolsEditCopyHex});
            this.ToolsEditCopy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ToolsEditCopy.Image = global::Be.HexEditor.ScalingImages.Copy16;
            this.ToolsEditCopy.Image16 = global::Be.HexEditor.ScalingImages.Copy16;
            this.ToolsEditCopy.Image24 = global::Be.HexEditor.ScalingImages.Copy24;
            this.ToolsEditCopy.Image32 = global::Be.HexEditor.ScalingImages.Copy32;
            resources.ApplyResources(this.ToolsEditCopy, "ToolsEditCopy");
            this.ToolsEditCopy.Name = "ToolsEditCopy";
            this.ToolsEditCopy.ButtonClick += new System.EventHandler(this.EditCopyClick);
            // 
            // ToolsEditCopyText
            // 
            this.ToolsEditCopyText.Image = global::Be.HexEditor.images.CopyHS;
            this.ToolsEditCopyText.Name = "ToolsEditCopyText";
            resources.ApplyResources(this.ToolsEditCopyText, "ToolsEditCopyText");
            this.ToolsEditCopyText.Click += new System.EventHandler(this.EditCopyClick);
            // 
            // ToolsEditCopyHex
            // 
            this.ToolsEditCopyHex.Image = global::Be.HexEditor.images.CopyHS;
            this.ToolsEditCopyHex.Name = "ToolsEditCopyHex";
            resources.ApplyResources(this.ToolsEditCopyHex, "ToolsEditCopyHex");
            this.ToolsEditCopyHex.Click += new System.EventHandler(this.EditCopyHexClick);
            // 
            // ToolsEditPaste
            // 
            this.ToolsEditPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolsEditPaste.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolsEditPasteText,
            this.ToolsEditPasteHex});
            this.ToolsEditPaste.Image = global::Be.HexEditor.ScalingImages.Paste16;
            this.ToolsEditPaste.Image16 = global::Be.HexEditor.ScalingImages.Paste16;
            this.ToolsEditPaste.Image24 = global::Be.HexEditor.ScalingImages.Paste24;
            this.ToolsEditPaste.Image32 = global::Be.HexEditor.ScalingImages.Paste32;
            resources.ApplyResources(this.ToolsEditPaste, "ToolsEditPaste");
            this.ToolsEditPaste.Name = "ToolsEditPaste";
            this.ToolsEditPaste.ButtonClick += new System.EventHandler(this.EditPasteClick);
            // 
            // ToolsEditPasteText
            // 
            this.ToolsEditPasteText.Image = global::Be.HexEditor.images.PasteHS;
            this.ToolsEditPasteText.Name = "ToolsEditPasteText";
            resources.ApplyResources(this.ToolsEditPasteText, "ToolsEditPasteText");
            this.ToolsEditPasteText.Click += new System.EventHandler(this.EditPasteClick);
            // 
            // ToolsEditPasteHex
            // 
            this.ToolsEditPasteHex.Image = global::Be.HexEditor.images.PasteHS;
            this.ToolsEditPasteHex.Name = "ToolsEditPasteHex";
            resources.ApplyResources(this.ToolsEditPasteHex, "ToolsEditPasteHex");
            this.ToolsEditPasteHex.Click += new System.EventHandler(this.EditPasteHexClick);
            // 
            // ToolsEditFind
            // 
            this.ToolsEditFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolsEditFind.Image = global::Be.HexEditor.images.FindHS;
            resources.ApplyResources(this.ToolsEditFind, "ToolsEditFind");
            this.ToolsEditFind.Name = "ToolsEditFind";
            this.ToolsEditFind.Click += new System.EventHandler(this.EditFindClick);
            // 
            // ToolsEditFindNext
            // 
            this.ToolsEditFindNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolsEditFindNext.Image = global::Be.HexEditor.images.FindNextHS;
            resources.ApplyResources(this.ToolsEditFindNext, "ToolsEditFindNext");
            this.ToolsEditFindNext.Name = "ToolsEditFindNext";
            this.ToolsEditFindNext.Click += new System.EventHandler(this.EditFindNextClick);
            // 
            // ToolsEditGoto
            // 
            this.ToolsEditGoto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolsEditGoto.Image = global::Be.HexEditor.images.Goto;
            resources.ApplyResources(this.ToolsEditGoto, "ToolsEditGoto");
            this.ToolsEditGoto.Name = "ToolsEditGoto";
            this.ToolsEditGoto.Click += new System.EventHandler(this.EditGotoClick);
            // 
            // ToolsEditSelectAll
            // 
            this.ToolsEditSelectAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolsEditSelectAll.Image = global::Be.HexEditor.images.selectall;
            resources.ApplyResources(this.ToolsEditSelectAll, "ToolsEditSelectAll");
            this.ToolsEditSelectAll.Name = "ToolsEditSelectAll";
            this.ToolsEditSelectAll.Click += new System.EventHandler(this.EditSelectAllClick);
            // 
            // ToolsEncodingSelect
            // 
            this.ToolsEncodingSelect.BackColor = System.Drawing.SystemColors.Control;
            this.ToolsEncodingSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ToolsEncodingSelect.DropDownWidth = 180;
            resources.ApplyResources(this.ToolsEncodingSelect, "ToolsEncodingSelect");
            this.ToolsEncodingSelect.Name = "ToolsEncodingSelect";
            this.ToolsEncodingSelect.SelectedIndexChanged += new System.EventHandler(this.EncodingSelectSelectedIndexChanged);
            // 
            // ToolsBytesPerLineSelect
            // 
            resources.ApplyResources(this.ToolsBytesPerLineSelect, "ToolsBytesPerLineSelect");
            this.ToolsBytesPerLineSelect.BackColor = System.Drawing.SystemColors.Control;
            this.ToolsBytesPerLineSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ToolsBytesPerLineSelect.Items.AddRange(new object[] {
            resources.GetString("ToolsBytesPerLineSelect.Items"),
            resources.GetString("ToolsBytesPerLineSelect.Items1"),
            resources.GetString("ToolsBytesPerLineSelect.Items2"),
            resources.GetString("ToolsBytesPerLineSelect.Items3"),
            resources.GetString("ToolsBytesPerLineSelect.Items4"),
            resources.GetString("ToolsBytesPerLineSelect.Items5"),
            resources.GetString("ToolsBytesPerLineSelect.Items6"),
            resources.GetString("ToolsBytesPerLineSelect.Items7"),
            resources.GetString("ToolsBytesPerLineSelect.Items8")});
            this.ToolsBytesPerLineSelect.Name = "ToolsBytesPerLineSelect";
            this.ToolsBytesPerLineSelect.SelectedIndexChanged += new System.EventHandler(this.BytesPerLineSelectSelectedIndexChanged);
            // 
            // ToolInterpretShow
            // 
            this.ToolInterpretShow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolInterpretShow.Image = global::Be.HexEditor.images.types;
            resources.ApplyResources(this.ToolInterpretShow, "ToolInterpretShow");
            this.ToolInterpretShow.Name = "ToolInterpretShow";
            this.ToolInterpretShow.Click += new System.EventHandler(this.ToolInterpretShowClick);
            // 
            // StatusBox
            // 
            this.StatusBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.StatusBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusPosSel,
            this.StatusSep1,
            this.StatusFileSize,
            this.StatusSep2,
            this.StatusBitsDesc,
            this.StatusBitsOfByte});
            resources.ApplyResources(this.StatusBox, "StatusBox");
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.StatusBox.SizingGrip = false;
            // 
            // StatusPosSel
            // 
            this.StatusPosSel.Margin = new System.Windows.Forms.Padding(5, 3, 0, 2);
            this.StatusPosSel.Name = "StatusPosSel";
            this.StatusPosSel.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            resources.ApplyResources(this.StatusPosSel, "StatusPosSel");
            // 
            // StatusSep1
            // 
            resources.ApplyResources(this.StatusSep1, "StatusSep1");
            this.StatusSep1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.StatusSep1.Name = "StatusSep1";
            // 
            // StatusFileSize
            // 
            this.StatusFileSize.Name = "StatusFileSize";
            this.StatusFileSize.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            resources.ApplyResources(this.StatusFileSize, "StatusFileSize");
            // 
            // StatusSep2
            // 
            resources.ApplyResources(this.StatusSep2, "StatusSep2");
            this.StatusSep2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.StatusSep2.Name = "StatusSep2";
            // 
            // StatusBitsDesc
            // 
            this.StatusBitsDesc.Name = "StatusBitsDesc";
            resources.ApplyResources(this.StatusBitsDesc, "StatusBitsDesc");
            // 
            // StatusBitsOfByte
            // 
            resources.ApplyResources(this.StatusBitsOfByte, "StatusBitsOfByte");
            this.StatusBitsOfByte.Name = "StatusBitsOfByte";
            // 
            // HexEditor
            // 
            this.HexEditor.AllowDrop = true;
            resources.ApplyResources(this.HexEditor, "HexEditor");
            this.HexEditor.AsciiForeColor = System.Drawing.Color.DarkMagenta;
            this.HexEditor.BorderColor = System.Drawing.Color.Gray;
            this.HexEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this.HexEditor.BuiltInContextMenu.CopyMenuItemImage = global::Be.HexEditor.images.CopyHS;
            this.HexEditor.BuiltInContextMenu.CopyMenuItemText = resources.GetString("HexEditor.BuiltInContextMenu.CopyMenuItemText");
            this.HexEditor.BuiltInContextMenu.CutMenuItemImage = global::Be.HexEditor.images.CutHS;
            this.HexEditor.BuiltInContextMenu.CutMenuItemText = resources.GetString("HexEditor.BuiltInContextMenu.CutMenuItemText");
            this.HexEditor.BuiltInContextMenu.PasteMenuItemImage = global::Be.HexEditor.images.PasteHS;
            this.HexEditor.BuiltInContextMenu.PasteMenuItemText = resources.GetString("HexEditor.BuiltInContextMenu.PasteMenuItemText");
            this.HexEditor.BuiltInContextMenu.SelectAllMenuItemImage = global::Be.HexEditor.images.selectall;
            this.HexEditor.BuiltInContextMenu.SelectAllMenuItemText = resources.GetString("HexEditor.BuiltInContextMenu.SelectAllMenuItemText");
            this.HexEditor.ColumnInfoVisible = true;
            this.HexEditor.HeaderForeColor = System.Drawing.Color.Gray;
            this.HexEditor.InfoForeColor = System.Drawing.Color.Blue;
            this.HexEditor.LineInfoVisible = true;
            this.HexEditor.Name = "HexEditor";
            this.HexEditor.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.HexEditor.SelectionForeColor = System.Drawing.Color.DimGray;
            this.HexEditor.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HexEditor.StringViewVisible = true;
            this.HexEditor.UseFixedBytesPerLine = true;
            this.HexEditor.VScrollBarVisible = true;
            this.HexEditor.SelectionStartChanged += new System.EventHandler(this.HexBoxSelectionChanged);
            this.HexEditor.SelectionLengthChanged += new System.EventHandler(this.HexBoxSelectionChanged);
            this.HexEditor.CurrentLineChanged += new System.EventHandler(this.HexEditorPositionChanged);
            this.HexEditor.CurrentPositionInLineChanged += new System.EventHandler(this.HexEditorPositionChanged);
            this.HexEditor.Copied += new System.EventHandler(this.HexEditorCopied);
            this.HexEditor.CopiedHex += new System.EventHandler(this.HexEditorCopied);
            this.HexEditor.RequiredWidthChanged += new System.EventHandler(this.HexEditorRequiredWidthChanged);
            this.HexEditor.DragDrop += new System.Windows.Forms.DragEventHandler(this.HexEditorDragDrop);
            this.HexEditor.DragEnter += new System.Windows.Forms.DragEventHandler(this.HexEditorDragEnter);
            // 
            // EditorPanel
            // 
            resources.ApplyResources(this.EditorPanel, "EditorPanel");
            this.EditorPanel.Controls.Add(this.InterpretBox);
            this.EditorPanel.Controls.Add(this.HexEditor);
            this.EditorPanel.Name = "EditorPanel";
            // 
            // InterpretBox
            // 
            resources.ApplyResources(this.InterpretBox, "InterpretBox");
            this.InterpretBox.BackColor = System.Drawing.SystemColors.Control;
            this.InterpretBox.Controls.Add(this.InterpretColor, 0, 6);
            this.InterpretBox.Controls.Add(this.InterpretDateTime, 3, 6);
            this.InterpretBox.Controls.Add(this.InterpretDescArgb, 0, 6);
            this.InterpretBox.Controls.Add(this.InterpretEndian, 3, 0);
            this.InterpretBox.Controls.Add(this.InterpretFloat, 1, 5);
            this.InterpretBox.Controls.Add(this.InterpretDescFloat, 0, 5);
            this.InterpretBox.Controls.Add(this.InterpretDescInt64, 0, 4);
            this.InterpretBox.Controls.Add(this.InterpretDescInt32, 0, 3);
            this.InterpretBox.Controls.Add(this.InterpretDescInt16, 0, 2);
            this.InterpretBox.Controls.Add(this.InterpretDescInt8, 0, 1);
            this.InterpretBox.Controls.Add(this.InterpretInt64, 1, 4);
            this.InterpretBox.Controls.Add(this.InterpretInt32, 1, 3);
            this.InterpretBox.Controls.Add(this.InterpretInt16, 1, 2);
            this.InterpretBox.Controls.Add(this.InterpretInt8, 1, 1);
            this.InterpretBox.Controls.Add(this.InterpretDescRaw, 0, 0);
            this.InterpretBox.Controls.Add(this.InterpretRaw, 1, 0);
            this.InterpretBox.Controls.Add(this.InterpretDouble, 3, 5);
            this.InterpretBox.Controls.Add(this.InterpretUint64, 3, 4);
            this.InterpretBox.Controls.Add(this.InterpretUint32, 3, 3);
            this.InterpretBox.Controls.Add(this.InterpretUint16, 3, 2);
            this.InterpretBox.Controls.Add(this.InterpretUint8, 3, 1);
            this.InterpretBox.Controls.Add(this.InterpretDescDouble, 2, 5);
            this.InterpretBox.Controls.Add(this.InterpretDescUint64, 2, 4);
            this.InterpretBox.Controls.Add(this.InterpretDescUint32, 2, 3);
            this.InterpretBox.Controls.Add(this.InterpretDescUint16, 2, 2);
            this.InterpretBox.Controls.Add(this.InterpretDescUint8, 2, 1);
            this.InterpretBox.Controls.Add(this.InterpretDescDateTime, 2, 6);
            this.InterpretBox.Name = "InterpretBox";
            // 
            // InterpretColor
            // 
            resources.ApplyResources(this.InterpretColor, "InterpretColor");
            this.InterpretColor.BackColor = System.Drawing.Color.White;
            this.InterpretColor.Name = "InterpretColor";
            this.InterpretColor.ReadOnly = true;
            // 
            // InterpretDateTime
            // 
            resources.ApplyResources(this.InterpretDateTime, "InterpretDateTime");
            this.InterpretDateTime.BackColor = System.Drawing.Color.White;
            this.InterpretDateTime.Name = "InterpretDateTime";
            this.InterpretDateTime.ReadOnly = true;
            // 
            // InterpretDescArgb
            // 
            resources.ApplyResources(this.InterpretDescArgb, "InterpretDescArgb");
            this.InterpretDescArgb.Name = "InterpretDescArgb";
            // 
            // InterpretEndian
            // 
            resources.ApplyResources(this.InterpretEndian, "InterpretEndian");
            this.InterpretEndian.Controls.Add(this.InterpretBigEndian);
            this.InterpretEndian.Controls.Add(this.InterpretLittleEndian);
            this.InterpretEndian.Name = "InterpretEndian";
            this.InterpretEndian.TabStop = false;
            // 
            // InterpretBigEndian
            // 
            resources.ApplyResources(this.InterpretBigEndian, "InterpretBigEndian");
            this.InterpretBigEndian.Name = "InterpretBigEndian";
            this.InterpretBigEndian.UseVisualStyleBackColor = true;
            this.InterpretBigEndian.CheckedChanged += new System.EventHandler(this.InterpretEndianChanged);
            // 
            // InterpretLittleEndian
            // 
            resources.ApplyResources(this.InterpretLittleEndian, "InterpretLittleEndian");
            this.InterpretLittleEndian.Checked = true;
            this.InterpretLittleEndian.Name = "InterpretLittleEndian";
            this.InterpretLittleEndian.TabStop = true;
            this.InterpretLittleEndian.UseVisualStyleBackColor = true;
            this.InterpretLittleEndian.CheckedChanged += new System.EventHandler(this.InterpretEndianChanged);
            // 
            // InterpretFloat
            // 
            resources.ApplyResources(this.InterpretFloat, "InterpretFloat");
            this.InterpretFloat.BackColor = System.Drawing.Color.White;
            this.InterpretFloat.Name = "InterpretFloat";
            this.InterpretFloat.ReadOnly = true;
            // 
            // InterpretDescFloat
            // 
            resources.ApplyResources(this.InterpretDescFloat, "InterpretDescFloat");
            this.InterpretDescFloat.Name = "InterpretDescFloat";
            // 
            // InterpretDescInt64
            // 
            resources.ApplyResources(this.InterpretDescInt64, "InterpretDescInt64");
            this.InterpretDescInt64.Name = "InterpretDescInt64";
            // 
            // InterpretDescInt32
            // 
            resources.ApplyResources(this.InterpretDescInt32, "InterpretDescInt32");
            this.InterpretDescInt32.Name = "InterpretDescInt32";
            // 
            // InterpretDescInt16
            // 
            resources.ApplyResources(this.InterpretDescInt16, "InterpretDescInt16");
            this.InterpretDescInt16.Name = "InterpretDescInt16";
            // 
            // InterpretDescInt8
            // 
            resources.ApplyResources(this.InterpretDescInt8, "InterpretDescInt8");
            this.InterpretDescInt8.Name = "InterpretDescInt8";
            // 
            // InterpretInt64
            // 
            resources.ApplyResources(this.InterpretInt64, "InterpretInt64");
            this.InterpretInt64.BackColor = System.Drawing.Color.White;
            this.InterpretInt64.Name = "InterpretInt64";
            this.InterpretInt64.ReadOnly = true;
            // 
            // InterpretInt32
            // 
            resources.ApplyResources(this.InterpretInt32, "InterpretInt32");
            this.InterpretInt32.BackColor = System.Drawing.Color.White;
            this.InterpretInt32.Name = "InterpretInt32";
            this.InterpretInt32.ReadOnly = true;
            // 
            // InterpretInt16
            // 
            this.InterpretInt16.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.InterpretInt16, "InterpretInt16");
            this.InterpretInt16.Name = "InterpretInt16";
            this.InterpretInt16.ReadOnly = true;
            // 
            // InterpretInt8
            // 
            resources.ApplyResources(this.InterpretInt8, "InterpretInt8");
            this.InterpretInt8.BackColor = System.Drawing.Color.White;
            this.InterpretInt8.Name = "InterpretInt8";
            this.InterpretInt8.ReadOnly = true;
            // 
            // InterpretDescRaw
            // 
            resources.ApplyResources(this.InterpretDescRaw, "InterpretDescRaw");
            this.InterpretDescRaw.Name = "InterpretDescRaw";
            // 
            // InterpretRaw
            // 
            resources.ApplyResources(this.InterpretRaw, "InterpretRaw");
            this.InterpretRaw.BackColor = System.Drawing.Color.White;
            this.InterpretRaw.Name = "InterpretRaw";
            this.InterpretRaw.ReadOnly = true;
            // 
            // InterpretDouble
            // 
            resources.ApplyResources(this.InterpretDouble, "InterpretDouble");
            this.InterpretDouble.BackColor = System.Drawing.Color.White;
            this.InterpretDouble.Name = "InterpretDouble";
            this.InterpretDouble.ReadOnly = true;
            // 
            // InterpretUint64
            // 
            resources.ApplyResources(this.InterpretUint64, "InterpretUint64");
            this.InterpretUint64.BackColor = System.Drawing.Color.White;
            this.InterpretUint64.Name = "InterpretUint64";
            this.InterpretUint64.ReadOnly = true;
            // 
            // InterpretUint32
            // 
            resources.ApplyResources(this.InterpretUint32, "InterpretUint32");
            this.InterpretUint32.BackColor = System.Drawing.Color.White;
            this.InterpretUint32.Name = "InterpretUint32";
            this.InterpretUint32.ReadOnly = true;
            // 
            // InterpretUint16
            // 
            resources.ApplyResources(this.InterpretUint16, "InterpretUint16");
            this.InterpretUint16.BackColor = System.Drawing.Color.White;
            this.InterpretUint16.Name = "InterpretUint16";
            this.InterpretUint16.ReadOnly = true;
            // 
            // InterpretUint8
            // 
            resources.ApplyResources(this.InterpretUint8, "InterpretUint8");
            this.InterpretUint8.BackColor = System.Drawing.Color.White;
            this.InterpretUint8.Name = "InterpretUint8";
            this.InterpretUint8.ReadOnly = true;
            // 
            // InterpretDescDouble
            // 
            resources.ApplyResources(this.InterpretDescDouble, "InterpretDescDouble");
            this.InterpretDescDouble.Name = "InterpretDescDouble";
            // 
            // InterpretDescUint64
            // 
            resources.ApplyResources(this.InterpretDescUint64, "InterpretDescUint64");
            this.InterpretDescUint64.Name = "InterpretDescUint64";
            // 
            // InterpretDescUint32
            // 
            resources.ApplyResources(this.InterpretDescUint32, "InterpretDescUint32");
            this.InterpretDescUint32.Name = "InterpretDescUint32";
            // 
            // InterpretDescUint16
            // 
            resources.ApplyResources(this.InterpretDescUint16, "InterpretDescUint16");
            this.InterpretDescUint16.Name = "InterpretDescUint16";
            // 
            // InterpretDescUint8
            // 
            resources.ApplyResources(this.InterpretDescUint8, "InterpretDescUint8");
            this.InterpretDescUint8.Name = "InterpretDescUint8";
            // 
            // InterpretDescDateTime
            // 
            resources.ApplyResources(this.InterpretDescDateTime, "InterpretDescDateTime");
            this.InterpretDescDateTime.Name = "InterpretDescDateTime";
            // 
            // ToolsSep1
            // 
            resources.ApplyResources(this.ToolsSep1, "ToolsSep1");
            this.ToolsSep1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ToolsSep1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ToolsSep1.Name = "ToolsSep1";
            // 
            // ToolsSep2
            // 
            this.ToolsSep2.BackColor = System.Drawing.SystemColors.ControlDark;
            resources.ApplyResources(this.ToolsSep2, "ToolsSep2");
            this.ToolsSep2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ToolsSep2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ToolsSep2.Name = "ToolsSep2";
            // 
            // ToolsSep3
            // 
            resources.ApplyResources(this.ToolsSep3, "ToolsSep3");
            this.ToolsSep3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ToolsSep3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ToolsSep3.Name = "ToolsSep3";
            // 
            // ToolsSep4
            // 
            resources.ApplyResources(this.ToolsSep4, "ToolsSep4");
            this.ToolsSep4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ToolsSep4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ToolsSep4.Name = "ToolsSep4";
            // 
            // ToolsSep5
            // 
            resources.ApplyResources(this.ToolsSep5, "ToolsSep5");
            this.ToolsSep5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ToolsSep5.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ToolsSep5.Name = "ToolsSep5";
            // 
            // ToolsSep6
            // 
            resources.ApplyResources(this.ToolsSep6, "ToolsSep6");
            this.ToolsSep6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ToolsSep6.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ToolsSep6.Name = "ToolsSep6";
            // 
            // ToolSpan1
            // 
            resources.ApplyResources(this.ToolSpan1, "ToolSpan1");
            this.ToolSpan1.Name = "ToolSpan1";
            // 
            // FormHexEditor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.EditorPanel);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.Tools);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "FormHexEditor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHexEditorFormClosing);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.Tools.ResumeLayout(false);
            this.Tools.PerformLayout();
            this.StatusBox.ResumeLayout(false);
            this.StatusBox.PerformLayout();
            this.EditorPanel.ResumeLayout(false);
            this.InterpretBox.ResumeLayout(false);
            this.InterpretBox.PerformLayout();
            this.InterpretEndian.ResumeLayout(false);
            this.InterpretEndian.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.MenuStripEx Menu;
        private Core.ToolStripMenuItemEx MenuFile;
        private Core.ToolStripMenuItemEx MenuFileOpen;
        private Core.ToolStripMenuItemEx MenuFileSave;
        private Core.ToolStripMenuItemEx MenuEdit;
        private Core.ToolStripMenuItemEx MenuEditCut;
        private Core.ToolStripMenuItemEx MenuEditCopy;
        private Core.ToolStripMenuItemEx MenuEditPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private Core.ToolStripMenuItemEx MenuEditFind;
        private Core.ToolStripEx Tools;
        private Core.ToolStripButtonEx ToolsFileOpen;
        private Core.ToolStripButtonEx ToolsFileSave;
        private Core.ToolStripButtonEx ToolsEditCut;
        private System.Windows.Forms.StatusStrip StatusBox;
        private Core.ToolStripMenuItemEx MenuEditFindNext;
        private Core.ToolStripMenuItemEx MenuEditGoto;
        private System.Windows.Forms.OpenFileDialog OpenDialog;
        private System.Windows.Forms.ToolStripStatusLabel StatusPosSel;
        private System.Windows.Forms.ToolStripStatusLabel StatusFileSize;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private Core.ToolStripMenuItemEx MenuEditCopyHex;
        private Core.ToolStripMenuItemEx MenuEditPasteHex;
        private Core.ToolStripSplitButtonEx ToolsEditCopy;
        private Core.ToolStripMenuItemEx ToolsEditCopyText;
        private Core.ToolStripMenuItemEx ToolsEditCopyHex;
        private Core.ToolStripSplitButtonEx ToolsEditPaste;
        private Core.ToolStripMenuItemEx ToolsEditPasteText;
        private Core.ToolStripMenuItemEx ToolsEditPasteHex;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private Core.ToolStripMenuItemEx MenuEditSelectAll;
        private System.Windows.Forms.ToolStripStatusLabel StatusBitsOfByte;
        private System.Windows.Forms.ToolStripComboBox ToolsEncodingSelect;
        private System.Windows.Forms.ToolStripComboBox ToolsBytesPerLineSelect;
        private System.Windows.Forms.ToolStripButton ToolsEditFind;
        private System.Windows.Forms.ToolStripButton ToolsEditFindNext;
        private System.Windows.Forms.ToolStripButton ToolsEditGoto;
        private System.Windows.Forms.ToolStripButton ToolsEditSelectAll;
        private System.Windows.Forms.ToolStripStatusLabel StatusSep1;
        private System.Windows.Forms.ToolStripStatusLabel StatusSep2;
        private System.Windows.Forms.ToolStripStatusLabel StatusBitsDesc;
        private Windows.Forms.HexBox HexEditor;
        private System.Windows.Forms.Panel EditorPanel;
        private System.Windows.Forms.TableLayoutPanel InterpretBox;
        private System.Windows.Forms.Label InterpretDescInt8;
        private System.Windows.Forms.TextBox InterpretInt8;
        private System.Windows.Forms.Label InterpretDescUint8;
        private System.Windows.Forms.TextBox InterpretUint8;
        private System.Windows.Forms.Label InterpretDescInt16;
        private System.Windows.Forms.Label InterpretDescInt32;
        private System.Windows.Forms.Label InterpretDescInt64;
        private System.Windows.Forms.Label InterpretDescDouble;
        private System.Windows.Forms.TextBox InterpretFloat;
        private System.Windows.Forms.Label InterpretDescFloat;
        private System.Windows.Forms.Label InterpretDescUint16;
        private System.Windows.Forms.Label InterpretDescUint32;
        private System.Windows.Forms.Label InterpretDescUint64;
        private System.Windows.Forms.TextBox InterpretInt16;
        private System.Windows.Forms.TextBox InterpretInt32;
        private System.Windows.Forms.TextBox InterpretInt64;
        private System.Windows.Forms.TextBox InterpretUint16;
        private System.Windows.Forms.TextBox InterpretUint32;
        private System.Windows.Forms.TextBox InterpretUint64;
        private System.Windows.Forms.TextBox InterpretDouble;
        private System.Windows.Forms.Label InterpretDescRaw;
        private System.Windows.Forms.TextBox InterpretRaw;
        private System.Windows.Forms.GroupBox InterpretEndian;
        private System.Windows.Forms.RadioButton InterpretBigEndian;
        private System.Windows.Forms.RadioButton InterpretLittleEndian;
        private System.Windows.Forms.ToolStripButton ToolInterpretShow;
        private System.Windows.Forms.TextBox InterpretColor;
        private System.Windows.Forms.TextBox InterpretDateTime;
        private System.Windows.Forms.Label InterpretDescArgb;
        private System.Windows.Forms.Label InterpretDescDateTime;
        private System.Windows.Forms.ToolStripLabel ToolsSep1;
        private System.Windows.Forms.ToolStripLabel ToolsSep2;
        private System.Windows.Forms.ToolStripLabel ToolsSep3;
        private System.Windows.Forms.ToolStripLabel ToolsSep4;
        private System.Windows.Forms.ToolStripLabel ToolsSep5;
        private System.Windows.Forms.ToolStripLabel ToolsSep6;
        private System.Windows.Forms.ToolStripLabel ToolSpan1;
    }
}