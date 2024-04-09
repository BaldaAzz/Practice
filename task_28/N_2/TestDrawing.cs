using System;
using System.Windows.Media;
using System.Windows;
using System.Windows.Controls;

namespace N_2
{
    public class TestDrawing : Control
    {
        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);

            // Треугольник
            drawingContext.DrawLine(new Pen(Brushes.Red, 2),
                                    new Point(50, 50),
                                    new Point(100, 100));
            drawingContext.DrawLine(new Pen(Brushes.Red, 2),
                                    new Point(100, 100),
                                    new Point(0, 100));
            drawingContext.DrawLine(new Pen(Brushes.Red, 2),
                                    new Point(0, 100),
                                    new Point(50, 50));

            // Элипс
            drawingContext.DrawEllipse(null , new Pen(Brushes.Red, 2),
                                       new Point(150, 50),
                                       100, 50);

            // Круг
            drawingContext.DrawEllipse(null, new Pen(Brushes.Black, 3),
                                       new Point(50, 150),
                                       80, 80);

            // Закрашенный прямоугольник
            Color color = new Color();
            color.R = 12;
            color.G = 200;
            color.B = 150;
            color.A = 123;
            drawingContext.DrawRectangle(new SolidColorBrush(color), 
                                         new Pen(Brushes.Black, 3), 
                                         new Rect(new Point(10, 10), 
                                                  new Point(100, 100)));

            base.OnRender(drawingContext);
        }
    }
}
