using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)

        {
            //Console.WriteLine("Question 1");
            //int[] l1 = { 5, 6, 6, 9, 9, 12 };
            //int target = 9;
            //int[] r = TargetRange(l1, target);
            //Console.WriteLine("[{0},{1}]", r[0],r[1]);   //this prints each array bucket at 0 and 1 respectively

            //note 1 of the assignment said we were not allowed to adjust the method's declaration...this includes return
            //I changed it back to what prof had and re-adjusted the write so that it would work with an int array
            //string q1 = string.Join(",", targetRange(, target));



            //Console.WriteLine("Question 2");
            //string s = "University of South Florida";
            //string rs = StringReverse(s);
            //Console.WriteLine(rs);


            Console.WriteLine("Question 3");
            int[] l2 = new int[] {4,5,6,9};  // this should be 24, instead it is 26 because we are adding 1 to 5 & 6 when we dont' need to
            int sum = MinimumSum(l2);
            Console.WriteLine(sum);

        }

        static int[] TargetRange(int[] l1, int target)
        {
            int[] arr = new int[2] { -1, -1 };

            for (int i = 0; i < l1.Length; i++)
            {
                if (l1[i] == target)
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
            rs +=tmp;  //this needs to be in here otherwise last word never gets put into rs
            return tmp;
        }




        public static int MinimumSum(int[] l2)
        {

            //needs something along the line of
            //    check first position to see if it is equal to next position
            //    if it is equal, then increment next position by 1
            //    if it is not equal then add current position to sum
            //    move on to the next array position.

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
    

