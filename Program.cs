namespace _1037._Valid_Boomerang
{
    internal class Program
    {
        static public bool IsBoomerang(int[][] points)
        {
            if (points[0][0] == points[1][0] && points[0][1] == points[1][1]) return false;
            if (points[0][0] == points[1][0]) return !(points[1][0] == points[2][0]);
            if (points[0][1] == points[1][1]) return !(points[1][1] == points[2][1]);
            if ((double)(points[2][0] - points[0][0]) / (double)(points[1][0] - points[0][0]) == (double)(points[2][1] - points[0][1]) / (double)(points[1][1] - points[0][1])) return false ;
            return true;

        }
        static void Main(string[] args)
        {
            int[][] points =
            {
                
                new int[] { 0 ,1 },
                new int[] { 1, 1},
                new int[] { 2, 1 }
            };
            Console.WriteLine(IsBoomerang(points));

        }
            
    }
}
