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
            bool isLightTheme = ConfigurationManager.AppSettings["UIMode"] == "light";
            SetTheme(isLightTheme);
            GC.Collect();
        }

        Color panelsColor_Light = Color.FromArgb(245, 245, 245);
        Color formColor_Light = Color.FromArgb(205, 205, 205);
        Color mouseOverBackColor_Light = Color.FromArgb(230, 230, 230);

        Color panelsColor_Dark = Color.FromArgb(42, 42, 42);
        Color formColor_Dark = Color.FromArgb(24, 24, 24);
        Color mouseOverBackColor_Dark = Color.FromArgb(57, 57, 57);

        private void SetTheme(bool isLightTheme)
        {
            Color foreColor = isLightTheme ? Color.Black : Color.WhiteSmoke;
            Color backColor = isLightTheme ? formColor_Light : formColor_Dark;
            Color panelsBackColor = isLightTheme ? panelsColor_Light : panelsColor_Dark;
            Color mouseOverColor = isLightTheme ? mouseOverBackColor_Light : mouseOverBackColor_Dark;

            BackColor = backColor;
            ForeColor = foreColor;

            Control[] controls = { panel1, applyButton, widthNumeric, heightNumeric };
            foreach(var control in controls)
            {
                control.BackColor = panelsBackColor;
                control.ForeColor = foreColor;
            }
            applyButton.FlatAppearance.MouseOverBackColor = mouseOverColor;
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
