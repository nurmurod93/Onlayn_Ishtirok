//namespace CollectionDavomi
//{
//    public class Program
//    {
//        public static void Main(string[] args) 
//        {
//            int[] array = new int[10];
//            array = Funksiya(2, 10);
//            for (int i = 0; i < 10; i++) 
//            {
//                Console.WriteLine(array[i]);
//            }
//            Console.WriteLine();
//            foreach(var item in Method(2,20))
//            {
//                Console.WriteLine(item);
//            }
//            Console.Read();
//        }
//        public static int[] Funksiya(int boshi, int oxiri)
//        {
//            int[] massiv = new int[oxiri];
//            for(int i =0; i < oxiri; i++) 
//            {
//                massiv[i] = boshi +2*i;
//            }
//            return massiv;
//        }
//        public static IEnumerable<int> Method(int boshi, int oxiri)
//        {
//            for(int i = 0; i < oxiri; i++)
//            {
//                yield return boshi + 2 * i;
//            }
//        }
//    }
//} 