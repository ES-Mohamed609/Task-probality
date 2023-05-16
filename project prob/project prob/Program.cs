namespace project_prob
{
    internal class Program
    {
        public static void Median()
        {
            Console.WriteLine("Pleaze enter the number of elemments: ");

            int n = int.Parse(Console.ReadLine());
            float[] Elemments = new float[n];

            for (int i = 0; i < Elemments.Length; i++)
            {
                Console.Write("Enter Elemnt {0}: ", i + 1);
                Elemments[i] = int.Parse(Console.ReadLine());
            }

            float swap;


            for (int i = 0; i < Elemments.Length - 1; i++)
            {
                for (int j = 0; j < Elemments.Length - 1; j++)
                {
                    if (Elemments[j] > Elemments[j + 1])
                    {
                        swap = Elemments[j + 1];
                        Elemments[j + 1] = Elemments[j];
                        Elemments[j] = swap;
                    }
                }
            }
            if (n % 2 == 0)
            {

                Console.WriteLine($"The median is {(Elemments[n / 2] + Elemments[n / 2 - 1]) / 2}");
            }
            else if (n % 2 == 1)
            {
                Console.WriteLine($"The median is {Elemments[n / 2]}");
            }
        }
        public static void Range()
        {
            Console.WriteLine("enter the size of the Array : ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Entet the {i + 1} element :");
                arr[i] = int.Parse(Console.ReadLine());

            }
            int max, min, range;
            Array.Sort(arr);
            max = arr[0];
            min = arr[0];
            for (int i = 1; i < size; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }

            for (int i = 1; i < size; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }


            }
            range = max - min;
            Console.WriteLine($"the range is : {max} - {min} = {range}");
        }
        public static void P90()
        {
            Console.WriteLine("enter the size of the Array : ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Entet the {i + 1} element :");
                arr[i] = int.Parse(Console.ReadLine());

            }
            Array.Sort(arr);
            Console.WriteLine(size);
            float p90 = (float)(0.9 * size); // find the index of 
            Console.WriteLine($"the value of p90 is {(int)p90}");
            int p90Array = (int)p90 - 1; // as the array statred from idex 0
            Console.WriteLine($"the p90 of array is : {arr[p90Array]} ");
        }
        public static void Mode()
        {
            Console.WriteLine("enter the size of the Array : ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Entet the {i + 1} element :");
                arr[i] = int.Parse(Console.ReadLine());

            }
            // Array.Sort(arr);

            int count = 0;
            int maxCount = 0;
            int mode = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }

                }
                if (count > maxCount)
                {
                    maxCount = count;
                    mode = arr[i];

                }
                count = 0;
            }

            Console.WriteLine($"the mode is : {mode} ");
        }
        public static void interquartile()
        {
            Console.WriteLine("Pleaze enter the number of elemments: ");

            int n = int.Parse(Console.ReadLine());
            float[] Elemments = new float[n];

            for (int i = 0; i < Elemments.Length; i++)
            {
                Console.Write("Enter Elemnt {0}: ", i + 1);
                Elemments[i] = int.Parse(Console.ReadLine());
            }

            float swap;


            for (int i = 0; i < Elemments.Length - 1; i++)
            {
                for (int j = 0; j < Elemments.Length - 1; j++)
                {
                    if (Elemments[j] > Elemments[j + 1])
                    {
                        swap = Elemments[j + 1];
                        Elemments[j + 1] = Elemments[j];
                        Elemments[j] = swap;
                    }
                }
            }


            if (n % 2 == 0)
            {
                if (n % 4 == 0 || n % 4 == 2)
                {
                    double q1 = Elemments[(n / 4) - 1];
                    double q3 = (Elemments[(3 * n / 4)]);
                    Console.WriteLine($" q1 = {q1}"); //dn..dnnnnnn
                    Console.WriteLine($" q3 = {q3}");
                    Console.WriteLine($"interquartile of the values equle: q3-q1 = {q3 - q1}");
                    double iqr = q3 - q1;
                    double lowerBound = q1 - 1.5 * iqr;
                    double upperBound = q3 + 1.5 * iqr;
                    Console.WriteLine("Lower outlier boundary: " + lowerBound);
                    Console.WriteLine("Upper outlier boundary: " + upperBound);

                    int outlierCount = 0;
                    for (int i = 0; i < n; i++)
                    {
                        if (Elemments[i] < lowerBound || Elemments[i] > upperBound)
                        {
                            outlierCount++;
                            Console.WriteLine($"{Elemments[i]} is an outlier");
                        }
                    }
                }
                else if (n % 4 == 1 || n % 4 == 3)
                {
                    double q1 = (Elemments[(n / 4) - 1] + Elemments[n / 4]) / 2;
                    double q3 = (Elemments[(n / 4) * 3 / 4] + Elemments[n * 3 / 4]) / 2;
                    Console.WriteLine($" q1 = {q1}"); //dn
                    Console.WriteLine($"q3 = {q1}");
                    Console.WriteLine($"interquartile of the values equle: q3-q1 = {q3 - q1}");
                    double iqr = q3 - q1;
                    double lowerBound = q1 - 1.5 * iqr;
                    double upperBound = q3 + 1.5 * iqr;
                    Console.WriteLine("Lower outlier boundary: " + lowerBound);
                    Console.WriteLine("Upper outlier boundary: " + upperBound);

                    int outlierCount = 0;
                    for (int i = 0; i < n; i++)
                    {
                        if (Elemments[i] < lowerBound || Elemments[i] > upperBound)
                        {
                            outlierCount++;
                            Console.WriteLine($"{Elemments[i]} is an outlier");
                        }
                    }
                }
            }
            else if (n % 2 == 1)
            {
                if ((n - 1) % 4 == 0 || (n - 1) % 4 == 2)
                {
                    double q1 = (Elemments[n / 4] + Elemments[n / 4 - 1]) / 2;
                    double q3 = (Elemments[n * 3 / 4] + Elemments[(n * 3 / 4) + 1]) / 2;
                    Console.WriteLine($" q1 = {q1}"); //dn....dnnn
                    Console.WriteLine($"q3 = {q3}");
                    Console.WriteLine($"interquartile of the values equle: q3-q1 = {q3 - q1}");
                    double iqr = q3 - q1;
                    double lowerBound = q1 - 1.5 * iqr;
                    double upperBound = q3 + 1.5 * iqr;
                    Console.WriteLine("Lower outlier boundary: " + lowerBound);
                    Console.WriteLine("Upper outlier boundary: " + upperBound);
                    int outlierCount = 0;
                    for (int i = 0; i < n; i++)
                    {
                        if (Elemments[i] < lowerBound || Elemments[i] > upperBound)
                        {
                            outlierCount++;
                            Console.WriteLine($"{Elemments[i]} is an outlier");
                        }
                    }
                }
            }
            else if ((n - 1) == 1 || (n - 1) == 3)
            {
                double q1 = Elemments[(n - 1) / 4];
                double q3 = (Elemments[(3 * n - 1) / 4]);
                Console.WriteLine($" q1 = {q1}");
                Console.WriteLine($"q3 = {q3}");
                Console.WriteLine($"interquartile of the values equle: q3-q1 = {q3 - q1}");
                double iqr = q3 - q1;
                double lowerBound = q1 - 1.5 * iqr;
                double upperBound = q3 + 1.5 * iqr;

                Console.WriteLine("Lower outlier boundary: " + lowerBound);
                Console.WriteLine("Upper outlier boundary: " + upperBound);
                int outlierCount = 0;
                for (int i = 0; i < n; i++)
                {
                    if (Elemments[i] < lowerBound || Elemments[i] > upperBound)
                    {
                        outlierCount++;
                        Console.WriteLine($"{Elemments[i]} is an outlier");
                    }
                }
            }

        }


        static void Main(string[] args)
        {
            Median();
             Range();
             P90();
             Mode();
            interquartile();




        }


    }
}

   


   
