namespace Pint.Core
{
    public class DrawingSettinngs
    {
        private Color _currentColor = Color.Black;
        public event Action<Color> ColorChanged;

        public Color CurrentColor
        {
            get => _currentColor;
            set
            {
                if (_currentColor != value)
                {
                    _currentColor = value;
                    ColorChanged?.Invoke(_currentColor);
                }
            }
        }

        public float PenWidth { get; set; } = 1f;
    }
}
