using Pint.Core.Enums;

namespace Pint.Core
{
    public static class ButtonHandler
    {
        public static List<Button> Allbuttons = new();
        public static Color UnselectColor { get; set; } = Color.WhiteSmoke;
        public static Color SelectColor { get; set; } = Color.FromArgb(185, 185, 185);
        static Button lastSelectedBtn;
        public static void UnselectAll() {
            foreach (var btn in Allbuttons) {
                btn.BackColor = UnselectColor;
            }
        }
        public static void Select(Button btn)
        {
            btn.BackColor = SelectColor;
            lastSelectedBtn = btn;
        }
        public static void UpdateBtnColors() {
            UnselectAll();
            lastSelectedBtn.BackColor = SelectColor;
        }
    }
}
