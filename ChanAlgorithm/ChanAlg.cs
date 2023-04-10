using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanAlgorithm
{
    public class ChanAlg
    {
        public static int iteration;
        public static List<Point> ChanAlgorithm(List<Point> points)
        {

            List<Point> list1 = new List<Point>();
            List<Point> list2 = new List<Point>();
            List<Point> list3 = new List<Point>();
            List<Point> list4 = new List<Point>();
            List<Point> list5 = new List<Point>();

            int n = 0;
            int m = 0;
            for (int i = 0; i < points.Count/5; i++)
            {
                list1.Add(points[i]);
                n = i;
                iteration++;
                
            }
            var res1 = GrahamAlgorithm.GAlgorithm(list1);
            m = n;

            for (int i = n; i < (points.Count / 5) + m; i++)
            {
                list2.Add(points[i]);
                n = i;
                iteration++;
                
            }
            var res2 = GrahamAlgorithm.GAlgorithm(list2);
            m = n;

            for (int i = n; i < points.Count / 5 + m; i++)
            {
                list3.Add(points[i]);
                n = i;
                iteration++;
                
            }
            var res3 = GrahamAlgorithm.GAlgorithm(list3);
            m = n;

            for (int i = n; i < points.Count / 5 + m; i++)
            {
                list4.Add(points[i]);
                n = i;
                iteration++;
                
            }
            var res4 = GrahamAlgorithm.GAlgorithm(list4);
            m = n;

            for (int i = n; i < points.Count / 5 + m; i++)
            {
                list5.Add(points[i]);
                n = i;
                iteration++;
                
            }
            var res5 = GrahamAlgorithm.GAlgorithm(list5);

            List<Point> result = new List<Point>();
            result.AddRange(res1);
            result.AddRange(res2);
            result.AddRange(res3);
            result.AddRange(res4);
            result.AddRange(res5);

            var hull = JarvisAlgorithm.JAlgorithm(result);

            return hull;
        }
    }
}
