using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)

        {
            //Console.WriteLine("Question 1");
            //int[] series = { 5, 6, 6, 9, 9, 12 };

            //int target = 9;
            //string q1 = string.Join(",", targetRange(series, target));

            //Console.WriteLine(q1);


            Console.WriteLine("Question 2");
            string s = "University of South Florida";
            string rs = StringReverse(s);
            Console.WriteLine(rs);


            //Console.WriteLine("Question 3");
            //int[] l2 = new int[] { 40, 40 };
            //int sum = MinimumSum(l2);
            //Console.WriteLine(sum);

        }

        static int[] targetRange(int[] series, int target)
        {
            int[] arr = new int[2] { -1, -1 };

            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    if (arr[0] == -1)
                    {
                        arr[0] = i;
                        arr[1] = i;
                    }
                    else
                    {
                        arr[1] = i;
                    }
                }
            }
            return arr;
        }


        public static string StringReverse(string s)
        {
            string rs = "";
            string tmp = "";
            string ltr = "";                // we add this variable to save the value of s


            for (int i = 0; i < s.Length; i++)
            {
                ltr = s[i].ToString();
                // Here the letters of the string s are saved and transformed into a string, with that we can add the other letters inside the rs





                if (ltr == " ")
                {
                    rs += tmp + " ";
                    tmp = "";
                   
                }
                else
                {
                    tmp = ltr + tmp;



                }
            }


            return rs;

        }




        public static int MinimumSum(int[] l2)
        {
            int sum = 0;
            for (int i = 0; i < l2.Length; i++) //Here we wanted to create a loop that will growth till i was less than l2
            {
                if (i + 1 < l2.Length) //the if condition here will help us to determine if we increase the value of our parameter or not
                {
                    if (l2[1] == l2[i + 1])
                    {
                        l2[i + 1]++;// Here we are saying that if the parameters inside the array are equal then we add 1 to the following one
                    }
                }
                sum += l2[i];// Finally, here we just add all the elements from the array

            }
            return sum;
        }
    }
}
    

