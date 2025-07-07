using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using Be.Windows.Forms;


namespace Be.HexEditor
{
    public partial class FormHexEditor : Core.FormEx
    {
        #region Fields
        private FormFind    _FindsForm;
        private FindOptions _FindsOptions = new FindOptions();
        private FormGoTo    _GotoForm     = new FormGoTo();
        private string      _CurrentOpenedFile;
        private long        _LastSelStart = 0;
        private long        _LastSelLen   = 0;
        #endregion

        #region Form
        public FormHexEditor()
        {
            InitializeComponent();
            
            Init();
        }

        private void Init()
        {
            this.Tools.Renderer.RenderToolStripBorder += new ToolStripRenderEventHandler(RendererToolStripBorder);

            ToolsEncodingSelect.Items.Add(new AnsiByteCharConvertor());
            ToolsEncodingSelect.Items.Add(new AsciiByteCharConvertor());
            ToolsEncodingSelect.Items.Add(new Utf8ByteCharConvertor());
            ToolsEncodingSelect.Items.Add(new Cp1251ByteCharConvertor());
            ToolsEncodingSelect.SelectedIndex = 0;

            ToolsBytesPerLineSelect.SelectedIndex = 3;

            LoadTheme();

            DisplayText();
            ManageAbility();
            UpdateFormWidth();
        }

        void RendererToolStripBorder(object sender, ToolStripRenderEventArgs e)
        {
            if (e.ToolStrip == Tools)
            {
                Pen pen = new Pen(Tools.BackColor);

                e.Graphics.DrawLine(pen, Tools.Width-1, 0, Tools.Width-1, Tools.Height);
                e.Graphics.DrawLine(pen, Tools.Width-2, 0, Tools.Width-2, Tools.Height);
            }
            else if (e.ToolStrip == StatusBox)
            {
                e.Graphics.DrawLine
                (
                    new Pen(HexEditor.BorderColor),
                    new Point(0, 0),
                    new Point(Tools.Width - 1, 0)
                );
            }
        }
        #endregion

        #region Theme
        private void LoadTheme()
        {
            string path = Application.ExecutablePath;
            path = path.Substring(0, path.LastIndexOf("\\") + 1) + "theme.txt";

            try
            {
                Theme theme = new Theme(path);

                HexEditor.BackColor            = theme["hex-back-color"];
                HexEditor.HeaderForeColor      = theme["hex-header-color"];
                HexEditor.InfoForeColor        = theme["hex-offset-color"];
                HexEditor.AsciiForeColor       = theme["hex-ascii-color"];
                HexEditor.ForeColor            = theme["hex-fore-color"];
                HexEditor.SelectionBackColor   = theme["sel-back-color"];
                HexEditor.SelectionForeColor   = theme["sel-fore-color"];
                HexEditor.ShadowSelectionColor = theme["sel-shadow-color"];
            }
            catch (Exception ex)
            {
                Program.ShowMessage($"Theme form file \"{path}\" load error: {ex.Message}.");
            }

            /*
            Menu.BackColor      =
            MenuFile.BackColor  =
            StatusBox.BackColor = HexEditor.BackColor;

            BackColor              = 
            Tools.BackColor        =
            EditorPanel.BackColor  =
            InterpretBox.BackColor = Color.FromArgb(HexEditor.BackColor.A, HexEditor.BackColor.R+10, HexEditor.BackColor.G+10, HexEditor.BackColor.B+10);

            Menu.ForeColor      = 
            Tools.ForeColor     = 
            StatusBox.ForeColor = HexEditor.ForeColor;

            ToolsEncodingSelect.BackColor     =
            ToolsBytesPerLineSelect.BackColor = Tools.BackColor;
            ToolsEncodingSelect.ForeColor     =
            ToolsBytesPerLineSelect.ForeColor = HexEditor.ForeColor;

            

            foreach (ToolStripItem item in MenuFile.DropDownItems)
            {
                item.BackColor = Menu.BackColor;
                item.ForeColor = Menu.ForeColor;
            }
            foreach (ToolStripItem item in MenuEdit.DropDownItems)
            {
                item.BackColor = Menu.BackColor;
                item.ForeColor = Menu.ForeColor;
            }

            foreach (Control c in InterpretBox.Controls)
            {
                if (c is Label)
                {
                    c.ForeColor = HexEditor.InfoForeColor;
                }
                else if (c is TextBox)
                {
                    TextBox tb = c as TextBox;

                    tb.BorderStyle = BorderStyle.None;
                    tb.Margin      = new Padding(3, 7, 3, 3);

                    tb.BackColor = HexEditor.BackColor;
                    tb.ForeColor = HexEditor.ForeColor;
                }
                else
                {
                    c.ForeColor = HexEditor.HeaderForeColor;
                }
            }

            */
        }
        #endregion

        #region Manage
        private void UpdateFileSizeStatus()
        {
            if (HexEditor.ByteProvider == null)
            {
                StatusFileSize.Text = string.Empty;
            }
            else
            {
                if (HexEditor.ByteProvider.Length > 1023)
                {
                    double n = HexEditor.ByteProvider.Length;
                    int    p = 0;
                    while (n >= 1024.0)
                    {
                        n /= 1024.0;
                        p++;
                    }

                    string prefix = " kMG"[p].ToString();
                    StatusFileSize.Text = $"{n:f2}{prefix}B ({HexEditor.ByteProvider.Length:g} bytes)";
                }
                else
                {
                    StatusFileSize.Text = $"{HexEditor.ByteProvider.Length} bytes";
                }
            }   
        }

        private void DisplayText()
        {
            string caption = "";
            
            if (!String.IsNullOrEmpty(_CurrentOpenedFile))
            {
                caption += _CurrentOpenedFile;

                if ((HexEditor.ByteProvider as DynamicFileByteProvider).ReadOnly)
                {
                    caption += " [read only]";
                }

                caption += " - ";
            }

            Text = caption + Program.SoftwareName;
        }

        private void ManageAbility()
        {
            MenuFileSave.Enabled      = ToolsFileSave.Enabled      = HexEditor.ByteProvider != null && HexEditor.ByteProvider.HasChanges();
            MenuEditFind.Enabled      = ToolsEditFind.Enabled      =
            MenuEditFindNext.Enabled  = ToolsEditFindNext.Enabled  =
            MenuEditGoto.Enabled      = ToolsEditGoto.Enabled      =
            MenuEditSelectAll.Enabled = ToolsEditSelectAll.Enabled = HexEditor.ByteProvider != null;

            ManageAbilityForCopyAndPaste();
        }

        private void ManageAbilityForCopyAndPaste()
        {
            MenuEditCut.Enabled      = ToolsEditCut.Enabled      = HexEditor.CanCut();
            MenuEditCopy.Enabled     = ToolsEditCopy.Enabled     = 
            MenuEditCopyHex.Enabled  = ToolsEditCopyHex.Enabled  = HexEditor.CanCopy();
            MenuEditPaste.Enabled    = ToolsEditPaste.Enabled    = HexEditor.CanPaste();
            MenuEditPasteHex.Enabled = ToolsEditPasteHex.Enabled = HexEditor.CanPasteHex();
        }

        private void UpdateFormWidth()
        {
            Width = HexEditor.RequiredWidth + 35;
        }

        private void InterpretValue()
        {
            if (HexEditor.SelectionStart > -1)
            {
                bool bigend = InterpretBigEndian.Checked;
                long count  = Math.Min(8, HexEditor.ByteProvider.Length - HexEditor.SelectionStart);
                long offset = HexEditor.SelectionStart + (bigend ? count - 1 : 0);
                long step   = bigend ? -1 : 1;

                byte[] raw = new byte[8];
                for (int i = 0; i < count; i++, offset += step)
                {
                    raw[i] = HexEditor.ByteProvider.ReadByte(offset);
                }

                ulong  raw64 = BitConverter.ToUInt64(raw, 0);
                uint   raw32 = BitConverter.ToUInt32(raw, bigend ? 4 : 0);
                ushort raw16 = BitConverter.ToUInt16(raw, bigend ? 6 : 0);
                byte   raw8  = raw[bigend ? 7 : 0];

                InterpretRaw.Text = $"0x_{raw64:X16}".Insert(11, "_");

                InterpretInt8.Text  = ((sbyte)raw8).ToString();
                InterpretInt16.Text = ((short)raw16).ToString();
                InterpretInt32.Text = ((int)raw32).ToString();
                InterpretInt64.Text = ((long)raw64).ToString();

                InterpretUint8.Text  = raw8.ToString();
                InterpretUint16.Text = raw16.ToString();
                InterpretUint32.Text = raw32.ToString();
                InterpretUint64.Text = raw64.ToString();

                InterpretFloat.Text  = BitConverter.ToSingle(raw, bigend ? 4 : 0).ToString();
                InterpretDouble.Text = BitConverter.ToDouble(raw, 0).ToString();

                InterpretColor.Text      = $"#{raw32:x8}";
                InterpretColor.ForeColor = Color.FromArgb((int)raw32);

                long ticks = (long)raw64;
                try
                {
                    InterpretDateTime.Text = DateTime.FromBinary(ticks).ToString("yyyy-MM-dd HH:mm:ss.fff");
                }
                catch
                {
                    InterpretDateTime.Text = "not a time";
                }
            }
        }
        #endregion

        #region File
        private void OpenFile()
        {
            if (OpenDialog.ShowDialog() == DialogResult.OK)
            {
                OpenFile(OpenDialog.FileName);
            }
        }

        public void OpenFile(string FileName)
        {
            if (!File.Exists(FileName))
            {
                Program.ShowMessage("The file does not exist!");
                return;
            }

            if (CloseFile() == DialogResult.Cancel)
            {
                return;
            }  

            try
            {
                DynamicFileByteProvider FileByteProvider;

                try
                {
                    FileByteProvider                = new DynamicFileByteProvider(FileName);
                    FileByteProvider.Changed       += new EventHandler(FileByteProviderChanged);
                    FileByteProvider.LengthChanged += new EventHandler(FileByteProviderLengthChanged);
                }
                catch (IOException)
                {
                    try
                    {
                        FileByteProvider = new DynamicFileByteProvider(FileName, true);

                        if (Program.ShowQuestion("The file is locked. Do you want to open it in read-only mode?") == DialogResult.No)
                        {
                            FileByteProvider.Dispose();
                            return;
                        }
                    }
                    catch (IOException)
                    {
                        Program.ShowError("File is locked by another process and cannot be opened!");
                        return;
                    }
                }

                HexEditor.ByteProvider = FileByteProvider;
                _CurrentOpenedFile     = FileName;

                DisplayText();

                UpdateFileSizeStatus();

                StatusSep1.Text = "|";
                StatusSep2.Text = "|";
            }
            catch (Exception ex)
            {
                Program.ShowError(ex);
                return;
            }
            finally
            {
                ManageAbility();
            }
        }

        private void SaveFile()
        {
            if (HexEditor.ByteProvider != null)
            {
                try
                {
                    DynamicFileByteProvider FileByteProvider = HexEditor.ByteProvider as DynamicFileByteProvider;
                    FileByteProvider.ApplyChanges();
                }
                catch (Exception ex)
                {
                    Program.ShowError(ex);
                }
                finally
                {
                    ManageAbility();
                }
            }
        }

        private DialogResult CloseFile()
        {
            DialogResult result = DialogResult.OK;

            if (HexEditor.ByteProvider != null)
            {
                if (HexEditor.ByteProvider.HasChanges())
                {
                    result = MessageBox.Show
                    (
                        "Do you want to save changes?", Program.SoftwareName,
                        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning
                    );

                    if (result == DialogResult.Yes)
                    {
                        SaveFile();
                    }
                }

                if (result != DialogResult.Cancel)
                {
                    CleanUp();
                }
            }

            ManageAbility();

            return result;
        }

        private void CleanUp()
        {
            if (HexEditor.ByteProvider != null)
            {
                IDisposable ByteProvider = HexEditor.ByteProvider as IDisposable;
                ByteProvider?.Dispose();
                HexEditor.ByteProvider = null;

                StatusSep1.Text = "";
                StatusSep2.Text = "";
            }

            _CurrentOpenedFile = null;
            DisplayText();
        }

        private void FileByteProviderChanged(object sender, EventArgs e)
        {
            ManageAbility();
        }

        private void FileByteProviderLengthChanged(object sender, EventArgs e)
        {
            UpdateFileSizeStatus();
        }
        #endregion

        #region EditForms
        private FormFind ShowFind(bool next = false)
		{
			if (_FindsForm == null || _FindsForm.IsDisposed)
			{
				_FindsForm             = new FormFind();
				_FindsForm.HexBox      = HexEditor;
				_FindsForm.FindOptions = _FindsOptions;

                if (!next)
                {
                    _FindsForm.Show(this);
                }    
			}
			else
			{
                _FindsForm.Show(this);
                _FindsForm.Focus();
			}

			return _FindsForm;
		}
        #endregion

        #region Handlers
        private void FormHexEditorFormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseFile() == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void FileOpenClick(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void FileSaveClick(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void EditCutClick(object sender, EventArgs e)
        {
            HexEditor.Cut();
        }

        private void EditCopyClick(object sender, EventArgs e)
        {
            HexEditor.Copy();
        }

        private void EditPasteClick(object sender, EventArgs e)
        {
            HexEditor.Paste();
        }

        private void EditCopyHexClick(object sender, EventArgs e)
        {
            HexEditor.CopyHex();
        }

        private void EditPasteHexClick(object sender, EventArgs e)
        {
            HexEditor.PasteHex();
        }

        private void EditFindClick(object sender, EventArgs e)
        {
            ShowFind();
        }

        private void EditFindNextClick(object sender, EventArgs e)
        {
            ShowFind(true).FindNext();
        }

        private void EditGotoClick(object sender, EventArgs e)
        {
            _GotoForm.SetMaxByteIndex(HexEditor.ByteProvider.Length);
            _GotoForm.SetDefaultValue(HexEditor.SelectionStart);

            if (_GotoForm.ShowDialog() == DialogResult.OK)
            {
                HexEditor.SelectionStart = _GotoForm.GetByteIndex();
                HexEditor.SelectionLength = 1;
                HexEditor.Focus();
            }
        }

        private void EditSelectAllClick(object sender, EventArgs e)
        {
            if (HexEditor.SelectionLength != HexEditor.ByteProvider.Length)
            {
                _LastSelStart = HexEditor.SelectionStart;
                _LastSelLen   = HexEditor.SelectionLength;
                HexEditor.SelectAll();
            }
            else
            {
                HexEditor.Select(_LastSelStart, _LastSelLen);
            }
        }

		private void EncodingSelectSelectedIndexChanged(object sender, EventArgs e)
		{
			HexEditor.ByteCharConverter = ToolsEncodingSelect.SelectedItem as IByteCharConverter;
            HexEditor.Focus();
		}

        private void BytesPerLineSelectSelectedIndexChanged(object sender, EventArgs e)
        {
            HexEditor.BytesPerLine = Convert.ToInt32(ToolsBytesPerLineSelect.SelectedItem);
            HexEditor.Focus();
        }

        private void ToolInterpretShowClick(object sender, EventArgs e)
        {
            /*if (Util.DesignMode)
            {
                return;
            }*/

            HexEditor.Height    += (InterpretBox.Visible ? 1 : -1) * InterpretBox.Height;
            InterpretBox.Visible = !InterpretBox.Visible;
        }

        private void HexEditorRequiredWidthChanged(object sender, EventArgs e)
        {
            UpdateFormWidth();
        }

        private void HexEditorDragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void HexEditorDragDrop(object sender, DragEventArgs e)
        {
            string[] fileNames = e.Data.GetData(DataFormats.FileDrop) as string[];
            
            if (fileNames.Length > 0)
            {
                OpenFile(fileNames[0]);
            }
        }

        private void HexEditorCopied(object sender, EventArgs e)
        {
            ManageAbilityForCopyAndPaste();
        }

        private void HexBoxSelectionChanged(object sender, EventArgs e)
        {
            ManageAbilityForCopyAndPaste();

            if (HexEditor.SelectionLength > 0)
            {
                string status = $"Ln: {HexEditor.CurrentLine}  Col: {HexEditor.CurrentPositionInLine}  Sel: {HexEditor.SelectionLength}";

                if (HexEditor.SelectionLength > 1)
                {
                    status += $"[{HexEditor.SelectionStart}:{HexEditor.SelectionStart+HexEditor.SelectionLength-1}]";
                }

                StatusPosSel.Text = status;
            }
        }

        private void HexEditorPositionChanged(object sender, EventArgs e)
        {
            StatusPosSel.Text = $"Ln:{HexEditor.CurrentLine} Col:{HexEditor.CurrentPositionInLine}";

            if (HexEditor.ByteProvider?.Length > HexEditor.SelectionStart)
            {
                StatusBitsDesc.Text   = $"Bits of byte {HexEditor.SelectionStart}:";
                StatusBitsOfByte.Text = Convert.ToString(HexEditor.ByteProvider.ReadByte(HexEditor.SelectionStart), 2).PadLeft(8, '0');
            }

            InterpretValue();
        }

        private void InterpretEndianChanged(object sender, EventArgs e)
        {
            InterpretValue();
        }
        #endregion
    }
}