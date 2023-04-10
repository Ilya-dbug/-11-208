using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanAlgorithm
{
    public class GrahamAlgorithm
    {
        public static int iteration;
        
        // Функция вычисления векторного произведения
        static double CrossProduct(Point O, Point A, Point B)
        {
            return (A.X - O.X) * (B.Y - O.Y) - (A.Y - O.Y) * (B.X - O.X);
        }

        public static List<Point>? GAlgorithm(List<Point> points)
        {
            Point? p;
            double ymin = points[0].Y;
            int min = 0;

            // Находим самую левую и нижнюю точку
            for (int i = 1; i < points.Count; i++)
            {
                double y = points[i].Y;

                if ((y < ymin) || (ymin == y && points[i].X < points[min].X))
                {
                    ymin = points[i].Y;
                    min = i;
                }

                iteration++;
            }

            // Добавляем ее в начало          
            Point temp = points[0];
            points[0] = points[min];
            points[min] = temp;

            // Сортируем по меньшему углу
            p = points[0];
            points.Sort((p1, p2) =>
            {
                double angle1 = Math.Atan2(p1.Y - p.Y, p1.X - p.X);
                double angle2 = Math.Atan2(p2.Y - p.Y, p2.X - p.X);
                return angle1.CompareTo(angle2);
            });

            // Добавляем в стек первые две точки
            Stack<Point> stack = new Stack<Point>();
            stack.Push(points[0]);
            stack.Push(points[1]);

            // Находим все остальные точки оболочки
            for (int i = 2; i < points.Count; i++)
            {
                Point top = stack.Pop();
                while (CrossProduct(stack.Peek(), top, points[i]) > 0 && stack.Count >= 2)
                {
                    top = stack.Pop();
                    iteration++;
                }

                stack.Push(top);
                stack.Push(points[i]);
                iteration++;
            }

            return new(stack.ToArray());
        }
    }
}
