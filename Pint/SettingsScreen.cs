using System.Configuration;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Pint
{
    public partial class SettingsScreen : Form
    {
        public event OnThemeChanged ThemeChanged;
        public SettingsScreen()
        {
            InitializeComponent();

            if (ConfigurationManager.AppSettings["UIMode"] == "dark")
                darkTheme.Checked = true;
            else
                lightTheme.Checked = true;

            if (ConfigurationManager.AppSettings["AgressiveFilling"] == "use")
                useAgressiveFilling.Checked = true;
            else
                dontUseAgressiveFilling.Checked = true;

            if (ConfigurationManager.AppSettings["Anti-Aliasing"] == "use")
                useAntiAliasing.Checked = true;
            else
                dontUseAntiAliasing.Checked = true;
        }

        #region Radiobuttons
        private void lightTheme_CheckedChanged(object sender, EventArgs e)
        {
            ConfigurationManager.AppSettings["UIMode"] = "light";
            SetUITheme();
            ThemeChanged?.Invoke();
        }

        private void darkTheme_CheckedChanged(object sender, EventArgs e)
        {
            ConfigurationManager.AppSettings["UIMode"] = "dark";
            SetUITheme();
            ThemeChanged?.Invoke();
        }

        private void useAgressiveFilling_CheckedChanged(object sender, EventArgs e) => ConfigurationManager.AppSettings["AgressiveFilling"] = "use";

        private void dontUseAgressiveFilling_CheckedChanged(object sender, EventArgs e) => ConfigurationManager.AppSettings["AgressiveFilling"] = "dontUse";

        private void useAntiAliasing_CheckedChanged(object sender, EventArgs e) => ConfigurationManager.AppSettings["Anti-Aliasing"] = "use";

        private void dontUseAntiAliasing_CheckedChanged(object sender, EventArgs e) => ConfigurationManager.AppSettings["Anti-Aliasing"] = "dontUse";

        #endregion

        #region WINDOW_THEME_CONTROL

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
            ForeColor = Color.Black;
            BackColor = Color.FromArgb(205, 205, 205);
            groupBox1.BackColor = Color.FromArgb(245, 245, 245);
            groupBox1.ForeColor = Color.Black;
            groupBox2.BackColor = Color.FromArgb(245, 245, 245);
            groupBox2.ForeColor = Color.Black;
            groupBox3.BackColor = Color.FromArgb(245, 245, 245);
            groupBox3.ForeColor = Color.Black;

            SetWindowTheme(false);
        }

        private void SetDarkTheme()
        {
            BackColor = Color.FromArgb(24, 24, 24);
            ForeColor = Color.WhiteSmoke;
            groupBox1.BackColor = Color.FromArgb(42, 42, 42);
            groupBox1.ForeColor = Color.WhiteSmoke;
            groupBox2.BackColor = Color.FromArgb(42, 42, 42);
            groupBox2.ForeColor = Color.WhiteSmoke;
            groupBox3.BackColor = Color.FromArgb(42, 42, 42);
            groupBox3.ForeColor = Color.WhiteSmoke;

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
