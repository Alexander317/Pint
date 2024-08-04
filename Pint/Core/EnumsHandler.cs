using Pint.Core.Enums;
using Pint.Core.Pencils;
using Pint.Core.Figures;
using Pint.Core.Misc;

namespace Pint.Core
{
    public static class EnumsHandler
    {
        public static MainFigure getFigure(FiguresEnum figuresEnum) {
            switch (figuresEnum)
            {
                case FiguresEnum.Circle: return new Circle();
                case FiguresEnum.Square: return new Square();
                case FiguresEnum.Line: return new Line();
                case FiguresEnum.RightTriangle: return new RightTriangle();
                case FiguresEnum.RegularTriangle: return new RegularTriangle();
                case FiguresEnum.StarFive: return new StarFive();
                case FiguresEnum.StarSix: return new StarSix();
                case FiguresEnum.StarEight: return new StarEight();
                case FiguresEnum.Rhombus: return new Rhombus();
                case FiguresEnum.Hexagon: return new Hexagon();
            }
            return null;
        }
        public static MainPencil getPensil(PensilsEnum pensilsEnum)
        {
            switch (pensilsEnum)
            {
                case PensilsEnum.Pencil: return new Pencil();
                case PensilsEnum.Eraser: return new Eraser();
            }
            return null;
        }
        public static MainMisc getMisc(MiscEnum miscEnum) {
            switch (miscEnum)
            {
                case MiscEnum.Filler: return new Filler();
                case MiscEnum.TextLabel: return new TextLabel();
                case MiscEnum.ColorPicker: return new ColorPicker();
             }
            return null;
        }
    }
}
