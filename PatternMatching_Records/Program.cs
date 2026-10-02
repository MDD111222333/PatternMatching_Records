using System;

namespace PatternMatching_Records
{
    class Program
    {
        static string Classify(object shape) => shape switch
        {
            Circle { Center: { X: 0, Y: 0 } } => "окружность в начале координат",
            Circle { Radius: 0 } => "вырожденная окружность (точка)",
            Circle c => $"строка с радиусом {c.Radius}",
            Rectangle r when r.TopLeft == r.BottomRight => "вырожденный прямоугольник (точка)",
            Rectangle r => "строка с размерами",
            _ => "неизвестная фигура"
        };

        static void Main(string[] args)
        {
            object s1 = new Circle(new Point(0, 0), 5);
            object s2 = new Circle(new Point(3, 4), 0);
            object s3 = new Circle(new Point(3, 4), 5);
            object s4 = new Rectangle(new Point(1, 1), new Point(1, 1));
            object s5 = new Rectangle(new Point(0, 0), new Point(4, 3));

            Console.WriteLine(Classify(s1));
            Console.WriteLine(Classify(s2));
            Console.WriteLine(Classify(s3));
            Console.WriteLine(Classify(s4));
            Console.WriteLine(Classify(s5));
        }
    }
}