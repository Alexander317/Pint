using Pint.Core.Enums;

namespace Pint.Core
{
    public static class ButtonHandler
    {
        #region Fields

        private static List<Button> allbuttons = new();
        private static Color selectColor { get; set; }
        private static Button lastSelectedBtn;
        
        #endregion

        #region Properties

        public static List<Button> Allbuttons { get => allbuttons; }
        public static Color SelectColor { set => selectColor = value; }
        
        #endregion

        #region Button Handlers

        public static void UnselectAll() {
            foreach (var btn in Allbuttons) {
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
    }
}
