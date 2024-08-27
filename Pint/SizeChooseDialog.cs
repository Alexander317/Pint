using System.Configuration;
using System.Runtime.InteropServices;

namespace Pint
{
    public partial class SizeChooseDialog : Form
    {
        public event EventHandler<Size> SizeChanged;
        public SizeChooseDialog()
        {
            InitializeComponent();
            SetUITheme();
        }

        #region Button Handlers

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            Size size = new Size((int)widthNumeric.Value, (int)heightNumeric.Value);
            SizeChanged?.Invoke(this, size);
            Close();
        }

        #endregion

        #region Theme Handlers

        private void SetUITheme()
        {
            if (ConfigurationManager.AppSettings["UIMode"] == "light")
                SetLightTheme();
            else
                SetDarkTheme();
            GC.Collect();
        }

        private void SetLightTheme()
        {
            BackColor = Color.FromArgb(205, 205, 205);

            panel1.BackColor = Color.FromArgb(245, 245, 245);
            panel1.ForeColor = Color.Black;

            applyButton.BackColor = Color.FromArgb(245, 245, 245);
            applyButton.ForeColor = Color.Black;
            applyButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 235, 235);
            widthNumeric.BackColor = Color.FromArgb(245, 245, 245);
            widthNumeric.ForeColor = Color.Black;
            heightNumeric.BackColor = Color.FromArgb(245, 245, 245);
            heightNumeric.ForeColor = Color.Black;

            SetWindowTheme(false);
        }

        private void SetDarkTheme()
        {
            BackColor = Color.FromArgb(24, 24, 24);

            panel1.BackColor = Color.FromArgb(42, 42, 42);
            panel1.ForeColor = Color.WhiteSmoke;

            applyButton.BackColor = Color.FromArgb(42, 42, 42);
            applyButton.ForeColor = Color.WhiteSmoke;
            applyButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 52, 52);
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
            SetWindowTheme(ConfigurationManager.AppSettings["UIMode"] != "light");
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
