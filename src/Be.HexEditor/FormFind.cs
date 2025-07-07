using System;
using System.Globalization;
using System.ComponentModel;
using System.Windows.Forms;
using Be.Windows.Forms;


namespace Be.HexEditor
{
    public class FormFind : Core.FormEx
    {
        #region Fields
        private IContainer      components;
        private FlowLayoutPanel CaptionContainer;
        private Label           CaptionText;
        private Panel           CaptionLine;
        private RadioButton     FindTextSelect;
        private CheckBox        FindTextMatchCase;
        private TextBox         FindTextValue;
        private RadioButton     FindHexSelect;
        private HexBox          FindHexValue;
        private FlowLayoutPanel FooterContainer;
        private Label           FindInfo;
        private Label           FindInfoPercent;
        private Button          ButtonOK;
        private Button          ButtonCancel;
        private Timer           _TimerInfoPercent;
        private Timer           _TimerInfo;
        private FindOptions     _FindOptions;
        private bool            _Finding;
        #endregion

        #region Windows Form Designer generated code
        public FormFind()
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFind));
            this.FindTextValue = new System.Windows.Forms.TextBox();
            this.FindTextSelect = new System.Windows.Forms.RadioButton();
            this.FindHexSelect = new System.Windows.Forms.RadioButton();
            this.CaptionText = new System.Windows.Forms.Label();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.FindInfoPercent = new System.Windows.Forms.Label();
            this.FindInfo = new System.Windows.Forms.Label();
            this.FindTextMatchCase = new System.Windows.Forms.CheckBox();
            this._TimerInfoPercent = new System.Windows.Forms.Timer(this.components);
            this._TimerInfo = new System.Windows.Forms.Timer(this.components);
            this.FindHexValue = new Be.Windows.Forms.HexBox();
            this.CaptionContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.CaptionLine = new System.Windows.Forms.Panel();
            this.FooterContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.CaptionContainer.SuspendLayout();
            this.FooterContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // FindTextValue
            // 
            resources.ApplyResources(this.FindTextValue, "FindTextValue");
            this.FindTextValue.Name = "FindTextValue";
            this.FindTextValue.TextChanged += new System.EventHandler(this.FindTextValueChanged);
            // 
            // FindTextSelect
            // 
            resources.ApplyResources(this.FindTextSelect, "FindTextSelect");
            this.FindTextSelect.Checked = true;
            this.FindTextSelect.Name = "FindTextSelect";
            this.FindTextSelect.TabStop = true;
            this.FindTextSelect.CheckedChanged += new System.EventHandler(this.FindSwitchCheckedChanged);
            // 
            // FindHexSelect
            // 
            resources.ApplyResources(this.FindHexSelect, "FindHexSelect");
            this.FindHexSelect.Name = "FindHexSelect";
            this.FindHexSelect.CheckedChanged += new System.EventHandler(this.FindSwitchCheckedChanged);
            // 
            // CaptionText
            // 
            resources.ApplyResources(this.CaptionText, "CaptionText");
            this.CaptionText.ForeColor = System.Drawing.Color.Blue;
            this.CaptionText.Name = "CaptionText";
            // 
            // ButtonOK
            // 
            resources.ApplyResources(this.ButtonOK, "ButtonOK");
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOkClick);
            // 
            // ButtonCancel
            // 
            resources.ApplyResources(this.ButtonCancel, "ButtonCancel");
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
            // 
            // FindInfoPercent
            // 
            resources.ApplyResources(this.FindInfoPercent, "FindInfoPercent");
            this.FindInfoPercent.Name = "FindInfoPercent";
            // 
            // FindInfo
            // 
            resources.ApplyResources(this.FindInfo, "FindInfo");
            this.FindInfo.ForeColor = System.Drawing.Color.Blue;
            this.FindInfo.Name = "FindInfo";
            // 
            // FindTextMatchCase
            // 
            resources.ApplyResources(this.FindTextMatchCase, "FindTextMatchCase");
            this.FindTextMatchCase.Name = "FindTextMatchCase";
            this.FindTextMatchCase.UseVisualStyleBackColor = true;
            // 
            // _TimerInfoPercent
            // 
            this._TimerInfoPercent.Tick += new System.EventHandler(this.TimerInfoPercentTick);
            // 
            // _TimerInfo
            // 
            this._TimerInfo.Interval = 50;
            this._TimerInfo.Tick += new System.EventHandler(this.TimerInfoTick);
            // 
            // FindHexValue
            // 
            resources.ApplyResources(this.FindHexValue, "FindHexValue");
            // 
            // 
            // 
            this.FindHexValue.BuiltInContextMenu.CopyMenuItemImage = global::Be.HexEditor.images.CopyHS;
            this.FindHexValue.BuiltInContextMenu.CopyMenuItemText = resources.GetString("FindHexValue.BuiltInContextMenu.CopyMenuItemText");
            this.FindHexValue.BuiltInContextMenu.CutMenuItemImage = global::Be.HexEditor.images.CutHS;
            this.FindHexValue.BuiltInContextMenu.CutMenuItemText = resources.GetString("FindHexValue.BuiltInContextMenu.CutMenuItemText");
            this.FindHexValue.BuiltInContextMenu.PasteMenuItemImage = global::Be.HexEditor.images.PasteHS;
            this.FindHexValue.BuiltInContextMenu.PasteMenuItemText = resources.GetString("FindHexValue.BuiltInContextMenu.PasteMenuItemText");
            this.FindHexValue.BuiltInContextMenu.SelectAllMenuItemText = resources.GetString("FindHexValue.BuiltInContextMenu.SelectAllMenuItemText");
            this.FindHexValue.InfoForeColor = System.Drawing.Color.Empty;
            this.FindHexValue.Name = "FindHexValue";
            this.FindHexValue.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            // 
            // CaptionContainer
            // 
            this.CaptionContainer.Controls.Add(this.CaptionText);
            this.CaptionContainer.Controls.Add(this.CaptionLine);
            resources.ApplyResources(this.CaptionContainer, "CaptionContainer");
            this.CaptionContainer.Name = "CaptionContainer";
            // 
            // CaptionLine
            // 
            resources.ApplyResources(this.CaptionLine, "CaptionLine");
            this.CaptionLine.BackColor = System.Drawing.Color.LightGray;
            this.CaptionLine.Name = "CaptionLine";
            // 
            // FooterContainer
            // 
            resources.ApplyResources(this.FooterContainer, "FooterContainer");
            this.FooterContainer.Controls.Add(this.ButtonCancel);
            this.FooterContainer.Controls.Add(this.ButtonOK);
            this.FooterContainer.Controls.Add(this.FindInfo);
            this.FooterContainer.Controls.Add(this.FindInfoPercent);
            this.FooterContainer.Name = "FooterContainer";
            // 
            // FormFind
            // 
            this.AcceptButton = this.ButtonOK;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.ButtonCancel;
            this.Controls.Add(this.FooterContainer);
            this.Controls.Add(this.CaptionContainer);
            this.Controls.Add(this.FindTextMatchCase);
            this.Controls.Add(this.FindHexSelect);
            this.Controls.Add(this.FindTextSelect);
            this.Controls.Add(this.FindTextValue);
            this.Controls.Add(this.FindHexValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFind";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Activated += new System.EventHandler(this.FormFindActivated);
            this.CaptionContainer.ResumeLayout(false);
            this.CaptionContainer.PerformLayout();
            this.FooterContainer.ResumeLayout(false);
            this.FooterContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        #region Properties
        public FindOptions FindOptions
        {
            get => _FindOptions;

            set
            {
                _FindOptions = value;
                Reinitialize();
            }
        }

        public HexBox HexBox { get; set; }
        #endregion

        #region Routines
        private void Reinitialize()
        {
            FindTextSelect.Checked    = _FindOptions.Type == FindType.Text;
            FindTextValue.Text        = _FindOptions.Text;
            FindTextMatchCase.Checked = _FindOptions.MatchCase;

            FindHexSelect.Checked = _FindOptions.Type == FindType.Hex;

            if (FindHexValue.ByteProvider != null)
            {
                FindHexValue.ByteProvider.Changed -= new EventHandler(FindHexValueByteProviderChanged);
            }

            var hex = this._FindOptions.Hex != null ? _FindOptions.Hex : new byte[0];

            FindHexValue.ByteProvider          = new DynamicByteProvider(hex);
            FindHexValue.ByteProvider.Changed += new EventHandler(FindHexValueByteProviderChanged);
        }

        private void ValidateFind()
        {
            ButtonOK.Enabled = (FindTextSelect.Checked && FindTextValue.Text.Length > 0) ||
                               (FindHexSelect.Checked && FindHexValue.ByteProvider.Length > 0);
        }

        private void UpdateUIToFindingState()
        {
            _Finding = true;

            _TimerInfo.Start();
            _TimerInfoPercent.Start();

            FindTextValue.Enabled     =
            FindTextMatchCase.Enabled =
            FindHexSelect.Enabled     =
            FindTextSelect.Enabled    =
            FindHexValue.Enabled      =
            ButtonOK.Enabled          = false;
        }

        private void UpdateUIToNormalState()
        {
            _TimerInfo.Stop();
            _TimerInfoPercent.Stop();

            _Finding = false;

            FindTextValue.Enabled     =
            FindTextMatchCase.Enabled =
            FindHexSelect.Enabled     =
            FindTextSelect.Enabled    =
            FindHexValue.Enabled      =
            ButtonOK.Enabled          = true;
        }

        public void FindNext()
        {
            if (!_FindOptions.IsValid)
            {
                return;
            }

            UpdateUIToFindingState();

            // start find process
            long result = HexBox.Find(_FindOptions);

            UpdateUIToNormalState();

            Application.DoEvents();

            if (result == -1) // -1 = no match
            {
                Program.ShowMessage("Find reached end of file!");
            }
            else if (result != -2) // -2 = find was aborted
            {
                Close();

                Application.DoEvents();

                if (!HexBox.Focused)
                {
                    HexBox.Focus();
                }
            }
        }
        #endregion

        #region Handlers
        private void FindHexValueByteProviderChanged(object sender, EventArgs e)
        {
            ValidateFind();
        }

        private void FindSwitchCheckedChanged(object sender, EventArgs e)
        {
            FindTextValue.Enabled = FindTextSelect.Checked;
            FindHexValue.Enabled  = !FindTextValue.Enabled;

            if (FindTextValue.Enabled)
            {
                FindTextValue.Focus();
            }
            else
            {
                FindHexValue.Focus();
            }    
        }

        private void FormFindActivated(object sender, EventArgs e)
        {
            if (FindTextSelect.Checked)
            {
                FindTextValue.Focus();
            }
            else
            {
                FindHexValue.Focus();
            }
        }

        private void ButtonOkClick(object sender, EventArgs e)
        {
            _FindOptions.MatchCase = FindTextMatchCase.Checked;

            var provider           = this.FindHexValue.ByteProvider as DynamicByteProvider;
            _FindOptions.Hex       = provider.Bytes.ToArray();
            _FindOptions.Text      = FindTextValue.Text;
            _FindOptions.Type      = FindHexSelect.Checked ? FindType.Hex : FindType.Text;
            _FindOptions.MatchCase = FindTextMatchCase.Checked;
            _FindOptions.IsValid   = true;

            FindNext();
        }

        private void ButtonCancelClick(object sender, EventArgs e)
        {
            if (_Finding)
            {
                this.HexBox.AbortFind();
            }
            else
            {
                this.Close();
            }
        }

        private void FindTextValueChanged(object sender, EventArgs e)
        {
            ValidateFind();
        }

        private void TimerInfoTick(object sender, EventArgs e)
        {
            if (FindInfo.Text.Length == 15)
            {
                FindInfo.Text = "";
            }
            else
            {
                FindInfo.Text += ".";
            }
        }

        private void TimerInfoPercentTick(object sender, EventArgs e)
        {
            long   pos     = HexBox.CurrentFindingPosition;
            long   length  = HexBox.ByteProvider.Length;
            double percent = 100.0 * pos / length;

            NumberFormatInfo nfi = new CultureInfo("en-US").NumberFormat;

            FindInfoPercent.Text = percent.ToString("0.00", nfi) + " %";
        }
        #endregion
    }
}