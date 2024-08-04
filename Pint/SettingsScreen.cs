using System.Configuration;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Pint
{
    public partial class SettingsScreen : Form
    {
        public event OnThemeChanged changed;
        public SettingsScreen(OnThemeChanged changed)
        {
            InitializeComponent();
            this.changed = changed;
            ChangeUITheme();

            if (ConfigurationManager.AppSettings["UIMode"] == "dark")
                lightTheme.Checked = true;
            else
                darkTheme.Checked = true;

            if (ConfigurationManager.AppSettings["AgressiveFilling"] == "use")
                useAgressiveFilling.Checked = true;
            else
                dontUseAgressiveFilling.Checked = true;
        }
        #region RADIOBUTTONS

        private void lightTheme_CheckedChanged(object sender, EventArgs e)
        {
            ConfigurationManager.AppSettings["UIMode"] = "light";
            changed.Invoke();
            ChangeUITheme();
        }

        private void darkTheme_CheckedChanged(object sender, EventArgs e)
        {
            ConfigurationManager.AppSettings["UIMode"] = "dark";
            changed.Invoke();
            ChangeUITheme();
        }

        private void useAgressiveFilling_CheckedChanged(object sender, EventArgs e) => ConfigurationManager.AppSettings["AgressiveFilling"] = "use";

        private void dontUseAgressiveFilling_CheckedChanged(object sender, EventArgs e) => ConfigurationManager.AppSettings["AgressiveFilling"] = "dontUse";

        #endregion

        #region WINDOW_THEME_CONTROL

        private void ChangeUITheme()
        {
            try
            {
                if (ConfigurationManager.AppSettings["UIMode"] == "dark")
                {
                    SetLightTheme();
                }
                else
                {
                    SetDarkTheme();
                }
            }
            catch (Exception e)
            {
                throw;
            }
            GC.Collect();
        }

        private void SetLightTheme()
        {
            ForeColor = Color.Black;
            BackColor = Color.FromArgb(195, 195, 195);
            groupBox1.BackColor = Color.FromArgb(245, 245, 245);
            groupBox1.ForeColor = Color.Black;
            groupBox2.BackColor = Color.FromArgb(245, 245, 245);
            groupBox2.ForeColor = Color.Black;

            SetWindowTheme(false);
        }

        private void SetDarkTheme()
        {
            BackColor = Color.FromArgb(17, 24, 34);
            ForeColor = Color.WhiteSmoke;
            groupBox1.BackColor = Color.FromArgb(32, 39, 49);
            groupBox1.ForeColor = Color.WhiteSmoke;
            groupBox2.BackColor = Color.FromArgb(32, 39, 49);
            groupBox2.ForeColor = Color.WhiteSmoke;

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
