using Pint.AdditionalToolbox;
using Pint.Properties;
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

        #region Theme Handlers

        private void SetUITheme()
        {
            bool isLightTheme = ConfigurationManager.AppSettings["UIMode"] == "light";
            SetTheme(isLightTheme);
            GC.Collect();
        }

        Color groupBoxColor_Light = Color.FromArgb(245, 245, 245);
        Color formColor_Light = Color.FromArgb(205, 205, 205);

        Color groupBoxColor_Dark = Color.FromArgb(42, 42, 42);
        Color formColor_Dark = Color.FromArgb(24, 24, 24);

        private void SetTheme(bool isLightTheme)
        {
            Color foreColor = isLightTheme ? Color.Black : Color.WhiteSmoke;
            Color backColor = isLightTheme ? formColor_Light : formColor_Dark;
            Color groupBoxBackColor = isLightTheme ? groupBoxColor_Light : groupBoxColor_Dark;

            ForeColor = foreColor;
            BackColor = backColor;

            RoundGroupBox[] groupBoxes = { groupBox1, groupBox2, groupBox3 };
            foreach (var groupBox in groupBoxes)
            {
                groupBox.BackColor = groupBoxBackColor;
                groupBox.ForeColor = foreColor;
            }

            SetWindowTheme(!isLightTheme);
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
