using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanAlgorithm
{
    public class JarvisAlgorithm
    {
        public static int iteration;
        public static List<Point> JAlgorithm(List<Point> points)
        {
            // Находим самую левую точку
            Point leftmost = points[0];
            foreach (Point p in points)
            {
                if (p.X < leftmost.X)
                {
                    leftmost = p;
                }
                iteration++;
            }

            // Создаем список точек выпуклой оболочки и добавляем в него самую левую точку
            List<Point> hull = new List<Point>();
            hull.Add(leftmost);

            // Находим следующую точку выпуклой оболочки
            Point current = leftmost;
            Point next;
            do
            {
                next = points[0];
                foreach (Point p in points)
                {
                    if (p == current)
                    {
                        continue;
                    }
                    double cross = CrossProduct(current, next, p);
                    if (next == current || cross > 0 || (cross == 0 && Distance(current, p) > Distance(current, next)))
                    {
                        next = p;
                    }
                    iteration++;
                }
                hull.Add(next);
                current = next;
                iteration++;
            } while (current != leftmost);

            return hull;
        }

        // Функция вычисления векторного произведения
        static double CrossProduct(Point O, Point A, Point B)
        {
            return (A.X - O.X) * (B.Y - O.Y) - (A.Y - O.Y) * (B.X - O.X);
        }

        // Функция вычисления расстояния между двумя точками
        static double Distance(Point A, Point B)
        {
            double dx = A.X - B.X;
            double dy = A.Y - B.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
