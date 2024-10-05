using Pint.Core.Enums;
using Pint.Core.Figures;
using System.Drawing.Drawing2D;

namespace Pint.Core
{
    public class ButtonHandler
    {
        #region Fields

        private static List<Button> buttons = new();
        private static Color selectColor { get; set; }
        private static Button lastSelectedBtn;
        private static ArrayPoint buttonAP = new(2);
        private static Bitmap buttonBitmap;

        #endregion

        #region Properties

        public static List<Button> Buttons { get => buttons; }
        public static Color SelectColor { set => selectColor = value; }
        
        #endregion

        #region Button Handlers

        public static void UnselectAll() {
            foreach (var btn in Buttons) {
                btn.BackColor = Color.Transparent;
            }
        }
        public static void Select(Button btn)
        {
            btn.BackColor = selectColor;
            lastSelectedBtn = btn;
        }
        public static void UpdateBtnColors() {
            UnselectAll();
            lastSelectedBtn.BackColor = selectColor;
        }

        #endregion

        #region Button Drawing

        public static void SetArrayPoint()
        {
            buttonAP.SetPoint(18, 18);
            buttonAP.SetPoint(44, 44);
        }

        public static void DrawOnButton(Button button, Color color)
        {
            buttonBitmap = new Bitmap(64, 64);
            using (Graphics g = Graphics.FromImage(buttonBitmap))
            {
                MainFigure currentFigure = EnumsHandler.getFigure((FiguresEnum)button.Tag);
                currentFigure.UseFigure(buttonBitmap, new Pen(color, 2), buttonAP, SmoothingMode.AntiAlias);
                button.Image = buttonBitmap;
            }
        }

        #endregion
    }
}
