using System.Configuration;
using System.Runtime.InteropServices;

namespace CustomPaint
{
    public partial class SizeChooseDialog : Form
    {
        public event EventHandler<Size> SizeChanged;
        public event EventHandler FormClosed; 
        public SizeChooseDialog()
        {
            InitializeComponent();
            SetUITheme();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            Size size = new Size((int)widthNumeric.Value, (int)heightNumeric.Value);
            SizeChanged?.Invoke(this, size);
            FormClosed?.Invoke(this, null);
            Close();
        }

        #region WINDOW_THEME_CONTROL

        private void SetUITheme()
        {
            if (ConfigurationManager.AppSettings["UIMode"] == "dark")
                SetLightTheme();
            else
                SetDarkTheme();
            GC.Collect();
        }

        private void SetLightTheme()
        {
            ForeColor = Color.Black;
            BackColor = Color.FromArgb(195, 195, 195);

            applyButton.BackColor = Color.FromArgb(245, 245, 245);
            applyButton.ForeColor = Color.Black;
            widthNumeric.BackColor = Color.FromArgb(245, 245, 245);
            widthNumeric.ForeColor = Color.Black;
            heightNumeric.BackColor = Color.FromArgb(245, 245, 245);
            heightNumeric.ForeColor = Color.Black;

            SetWindowTheme(false);
        }

        private void SetDarkTheme()
        {
            BackColor = Color.FromArgb(24, 24, 24);
            ForeColor = Color.WhiteSmoke;

            applyButton.BackColor = Color.FromArgb(42, 42, 42);
            applyButton.ForeColor = Color.WhiteSmoke;
            widthNumeric.BackColor = Color.FromArgb(42, 42, 42);
            widthNumeric.ForeColor = Color.WhiteSmoke;
            heightNumeric.BackColor = Color.FromArgb(42, 42, 42);
            heightNumeric.ForeColor = Color.WhiteSmoke;

            SetWindowTheme(true);
        }

        [DllImport("DwmApi")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            var uiMode = ConfigurationManager.AppSettings["UIMode"];
            SetWindowTheme(uiMode != "light");
        }
        private void SetWindowTheme(bool dark)
        {
            int[] useDarkMode = dark ? new[] { 1 } : new[] { 0 };
            DwmSetWindowAttribute(Handle, 19, useDarkMode, sizeof(int));
            DwmSetWindowAttribute(Handle, 20, useDarkMode, sizeof(int));
        }

        #endregion
    }
}
