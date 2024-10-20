namespace MergeSort
{
    internal class Program
    {
        public static List<T> MergeSort<T>(List<T> list)
            where T : IComparable<T>
        {
            if (list.Count < 2)
            {
                return list;
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


            Merge(list, list1, list2);

            return list;


       

        }

        public static void Merge<T>(List<T> originalList, List<T> list1, List<T> list2)
            where T : IComparable<T>
        {

            for (int c = 0, i = 0, j = 0; c < originalList.Count;)
            {
                if(i >= list1.Count)
                {
                    for(j = j; j < list2.Count; j++)
                    {
                        originalList.Add(list2[j]);
                    }
                    break;
                }
                else if(j >= list2.Count)
                {
                    for(i = i; i < list1.Count; i++)
                    {
                        originalList.Add(list1[i]);
                    }
                    break;
                }
                if (list1[i].CompareTo(list2[j]) < 0) 
                {
                    originalList[c] = list1[i];
                    i++;
                }
                else if(j < list2.Count)
                {
                    originalList[c] = list2[j];
                    j++;
                }
                c++;
            }
        }
        static void Main(string[] args)
        {
            List<int> list = new List<int>(new int[] { 10, 1, 2, 4, 3, 6, 5, 7, 8, 9 });
            
            list = MergeSort(list);

            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            
            
        }
    }
}
