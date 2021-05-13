using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static int solution(string A, string B)
        {
            int turns = 0; //number of turns alec will win

            //convert the string into character arrays
            char[] arrA = A.ToCharArray();
            char[] arrB = B.ToCharArray();

            //value of the cards to be thrown in each iteration of the loop
            string convert = "";
            string convertB = "";

            //even though the problem statement assums that there are the same number of cards for each player, better to check if they both have, otherwise return -1
            if (arrA.Length == arrB.Length)
            {
                //the limit of the loop can be from either the first or second array since they are the same anyway.
                for (int i = 0; i <= arrA.Length - 1; i++)
                {
                    //do a switch case for the lettered cards.
                    switch (Convert.ToString(arrA[i]).ToLowerInvariant())
                    {
                        case "t": convert = "10"; break;
                        case "j": convert = "11"; break;
                        case "q": convert = "12"; break;
                        case "k": convert = "13"; break;
                        case "a": convert = "14"; break;
                        default: convert = arrA[i].ToString(); break;
                    } //convert is the variable for the card that Alec has thrown

                    switch (Convert.ToString(arrB[i]).ToLowerInvariant())
                    {
                        case "t": convertB = "10"; break;
                        case "j": convertB = "11"; break;
                        case "q": convertB = "12"; break;
                        case "k": convertB = "13"; break;
                        case "a": convertB = "14"; break;
                        default: convertB = arrB[i].ToString(); break;
                    } //convertB is the variable for the card that Bob has thrown

                    //have the value covnverted to int
                    int valA = Convert.ToInt32(convert);
                    int valB = Convert.ToInt32(convertB);

                    //increase the number of turns of Alec if his card is greater than Bob's
                    if (valA > valB)
                    {
                        turns++;
                    }
                }
            }
            else
            {
                turns = -1;
            }

            return turns;
        }

       
        static void Main(string[] args)
        {
            int turns = solution("23A84Q", "K2Q25J");
            Console.WriteLine(turns);
            Console.ReadLine();
        }
    }
}
