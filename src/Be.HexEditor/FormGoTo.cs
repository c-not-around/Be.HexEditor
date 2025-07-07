using System;
using System.ComponentModel;
using System.Windows.Forms;


namespace Be.HexEditor
{
    public class FormGoTo : Core.FormEx
	{
        #region Fields
        private Container       Components = null;
        private Label           CaptionText;
        private Panel           CaptionLine;
        private RadioButton     FormatDec;
        private RadioButton     FormatHex;
        private Label           IndexSelectCaption;
        private NumericUpDown   IndexSelectValue;
        private FlowLayoutPanel ButtonsContainer;
        private Button          ButtonCancel;
        private Button          ButtonOK;
        #endregion

        #region Windows Form Designer generated code
        public FormGoTo()
		{
			InitializeComponent();
        }

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (Components != null)
				{
					Components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGoTo));
            this.ButtonsContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.CaptionLine = new System.Windows.Forms.Panel();
            this.CaptionText = new System.Windows.Forms.Label();
            this.IndexSelectValue = new System.Windows.Forms.NumericUpDown();
            this.IndexSelectCaption = new System.Windows.Forms.Label();
            this.FormatDec = new System.Windows.Forms.RadioButton();
            this.FormatHex = new System.Windows.Forms.RadioButton();
            this.ButtonsContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IndexSelectValue)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonsContainer
            // 
            resources.ApplyResources(this.ButtonsContainer, "ButtonsContainer");
            this.ButtonsContainer.Controls.Add(this.ButtonCancel);
            this.ButtonsContainer.Controls.Add(this.ButtonOK);
            this.ButtonsContainer.Name = "ButtonsContainer";
            // 
            // ButtonCancel
            // 
            resources.ApplyResources(this.ButtonCancel, "ButtonCancel");
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // ButtonOK
            // 
            resources.ApplyResources(this.ButtonOK, "ButtonOK");
            this.ButtonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // CaptionLine
            // 
            resources.ApplyResources(this.CaptionLine, "CaptionLine");
            this.CaptionLine.BackColor = System.Drawing.Color.LightGray;
            this.CaptionLine.Name = "CaptionLine";
            // 
            // CaptionText
            // 
            this.CaptionText.ForeColor = System.Drawing.Color.Blue;
            resources.ApplyResources(this.CaptionText, "CaptionText");
            this.CaptionText.Name = "CaptionText";
            // 
            // IndexSelectValue
            // 
            resources.ApplyResources(this.IndexSelectValue, "IndexSelectValue");
            this.IndexSelectValue.Hexadecimal = true;
            this.IndexSelectValue.Name = "IndexSelectValue";
            this.IndexSelectValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // IndexSelectCaption
            // 
            resources.ApplyResources(this.IndexSelectCaption, "IndexSelectCaption");
            this.IndexSelectCaption.Name = "IndexSelectCaption";
            // 
            // FormatDec
            // 
            resources.ApplyResources(this.FormatDec, "FormatDec");
            this.FormatDec.Name = "FormatDec";
            this.FormatDec.UseVisualStyleBackColor = true;
            this.FormatDec.CheckedChanged += new System.EventHandler(this.FormatCheckedChanged);
            // 
            // FormatHex
            // 
            resources.ApplyResources(this.FormatHex, "FormatHex");
            this.FormatHex.Checked = true;
            this.FormatHex.Name = "FormatHex";
            this.FormatHex.TabStop = true;
            this.FormatHex.UseVisualStyleBackColor = true;
            this.FormatHex.CheckedChanged += new System.EventHandler(this.FormatCheckedChanged);
            // 
            // FormGoTo
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.FormatHex);
            this.Controls.Add(this.FormatDec);
            this.Controls.Add(this.ButtonsContainer);
            this.Controls.Add(this.CaptionLine);
            this.Controls.Add(this.CaptionText);
            this.Controls.Add(this.IndexSelectValue);
            this.Controls.Add(this.IndexSelectCaption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGoTo";
            this.ShowInTaskbar = false;
            this.Activated += new System.EventHandler(this.FormGoToActivated);
            this.ButtonsContainer.ResumeLayout(false);
            this.ButtonsContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IndexSelectValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
        #endregion

        #region Routines
        public void SetDefaultValue(long index)
		{
            IndexSelectValue.Value = index;
		}

		public void SetMaxByteIndex(long index)
		{
            IndexSelectValue.Maximum = index;
		}

		public long GetByteIndex() => Convert.ToInt64(IndexSelectValue.Value);
        #endregion

        #region Handlers
        private void FormGoToActivated(object sender, EventArgs e)
		{
			IndexSelectValue.Focus();
			IndexSelectValue.Select(0, IndexSelectValue.Value.ToString().Length);
		}

        private void FormatCheckedChanged(object sender, EventArgs e)
        {
            IndexSelectValue.Hexadecimal = FormatHex.Checked;
        }

        private void ButtonsClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
        #endregion
    }
}