using System.Text;
namespace ChanAlgorithm
{
    class Program
    {
        public static void Main()
        {
            //FileInfo file;
            //int pcount = 0;
            //var r = new Random();
            //for (int i = 0; i < 100; i++)
            //{
            //    pcount += 100;
            //    file = new FileInfo($@"C:\MySet\Set{i + 1}.txt");
            //    var stringpoint = new StringBuilder();
            //    for (int j = 0; j < pcount; j++)
            //    {
            //        stringpoint.AppendLine($"{r.Next(-100, 100)}, {r.Next(-100, 100)}");
            //    }

            //    using (var sw = file.AppendText())
            //    {
            //        sw.WriteLine(stringpoint.ToString().Trim());
            //    }
            //}

            string[] Points;
            List<string[]> listofsets = new List<string[]>();

            for (int i = 0; i < 100; i++)
            {
                Points = File.ReadAllLines($@"C:\MySet\Set{i + 1}.txt");
                listofsets.Add(Points);
                var set1 = listofsets[i];
                List<Point> points = new();
                foreach (var p in set1)
                {
                    if (p != "")
                    {
                        points.Add(new Point(Convert.ToInt32((p.Split(",")[0])), Convert.ToInt32((p.Split(",")[1]))));
                    }
                    else break;
                }


                var list = ChanAlg.ChanAlgorithm(points);
                Console.WriteLine(ChanAlg.iteration + GrahamAlgorithm.iteration + JarvisAlgorithm.iteration);
                foreach (var item in list)
                    Console.WriteLine($"({item.X},{item.Y})");
                Console.WriteLine("-------------");
            }
        }
    }
}