using System;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using Be.HexEditor.Properties;
using Be.Windows.Forms;

namespace Be.HexEditor
{
    class Program
    {
        public const string SoftwareName = "Be.HexEditor";

        public static FormHexEditor ApplictionForm;

        [STAThread()]
        static void Main(string[] args)
        {
            Application.CurrentCulture       = new CultureInfo("en-US", false);
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-US", false));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ApplictionForm = new FormHexEditor();
            if (args.Length > 0 && System.IO.File.Exists(args[0]))
            {
                ApplictionForm.OpenFile(args[0]);
            }
                
            Application.Run(ApplictionForm);
        }

        public static DialogResult ShowError(Exception ex)
        {
            return ShowError(ex.Message);
        }


        internal static DialogResult ShowError(string text)
        {
            return MessageBox.Show
            (
                text, SoftwareName,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }

        public static void ShowMessage(string text)
        {
            MessageBox.Show
            (
                text, SoftwareName,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        public static DialogResult ShowQuestion(string text)
        {
            return MessageBox.Show
            (
                text, SoftwareName,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
        }
    }
}