namespace Pint.Core
{
    public class ButtonHandler
    {
        #region Fields

        private static List<Button> buttons = new();
        private static Color selectColor { get; set; }
        private static Button lastSelectedBtn;

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
            if (lastSelectedBtn != null) lastSelectedBtn.BackColor = Color.Transparent;
            lastSelectedBtn = btn;
            lastSelectedBtn.BackColor = selectColor;
        }
        public static void UpdateBtnColors() {
            UnselectAll();
            if (lastSelectedBtn != null) lastSelectedBtn.BackColor = selectColor;
        }

        #endregion
    }
}
