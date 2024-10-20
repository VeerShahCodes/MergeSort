namespace MergeSort
{
    internal class Program
    {
        public static void MergeSort<T>(List<T> list)
        {
            if (list.Count < 2)
            {
                Console.WriteLine(list[0]);
                return;
            }


            List<T> list1 = new List<T>();
            List<T> list2 = new List<T>();

            for(int i = 0; i < list.Count / 2; i++)
            {
                list1.Add(list[i]);
            }

            for(int i = list.Count / 2; i< list.Count; i++)
            {
                list2.Add(list[i]);
            }

            MergeSort(list1);
            MergeSort(list2);

            

       

        }

        public static void Merge()
        {

        }
        static void Main(string[] args)
        {
            List<int> list = new List<int>(new int[] { 10, 1, 2, 4, 3, 6, 5, 7, 8, 9 });
            
            MergeSort(list);
            
            
        }
    }
}
