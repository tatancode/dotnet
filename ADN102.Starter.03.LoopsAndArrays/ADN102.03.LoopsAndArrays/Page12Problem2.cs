using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write, compile, and test a program named CountYourLetters that accepts input from a user
// and counts the number of each letter in the phrase. You will need to keep a dictionary
// of letters and counts (Dictionary<char,int>).
//
// Don 't forget the required using using System.Collections.Generic;
// to activate the dictionary class. At first make it count upper and lowercase characters differently.
//
// Extra credit: Ignore the case of letters.



//Enter a phrase on a single line:hello harold
//Processing: 'h'
//did not find 'h' setting count to 1
//Processing: 'e'
//did not find 'e' setting count to 1
//Processing: 'l'
//did not find 'l' setting count to 1
//Processing: 'l'
//Found 'l' count was: 1
//Processing: 'o'
//did not find 'o' setting count to 1
//Processing: ' '
//did not find ' ' setting count to 1
//Processing: 'h'
//Found 'h' count was: 1
//Processing: 'a'
//did not find 'a' setting count to 1
//Processing: 'r'
//did not find 'r' setting count to 1
//Processing: 'o'
//Found 'o' count was: 1
//Processing: 'l'
//Found 'l' count was: 2
//Processing: 'd'
//did not find 'd' setting count to 1
//-----------------
//Found h with a count of 2
//Found e with a count of 1
//Found l with a count of 3
//Found o with a count of 2
//Found   with a count of 1
//Found a with a count of 1
//Found r with a count of 1
//Found d with a count of 1
//Enter a phrase on a single line: ^C

// mixed case example


//Enter a phrase on a single line:Hello HAROLD
//Processing: 'H'
//did not find 'H' setting count to 1
//Processing: 'e'
//did not find 'e' setting count to 1
//Processing: 'l'
//did not find 'l' setting count to 1
//Processing: 'l'
//Found 'l' count was: 1
//Processing: 'o'
//did not find 'o' setting count to 1
//Processing: ' '
//did not find ' ' setting count to 1
//Processing: 'H'
//Found 'H' count was: 1
//Processing: 'A'
//did not find 'A' setting count to 1
//Processing: 'R'
//did not find 'R' setting count to 1
//Processing: 'O'
//did not find 'O' setting count to 1
//Processing: 'L'
//did not find 'L' setting count to 1
//Processing: 'D'
//did not find 'D' setting count to 1
//-----------------
//Found H with a count of 2
//Found e with a count of 1
//Found l with a count of 2
//Found o with a count of 1
//Found   with a count of 1
//Found A with a count of 1
//Found R with a count of 1
//Found O with a count of 1
//Found L with a count of 1
//Found D with a count of 1
//Enter a phrase on a single line: ^C


// ignore case example [harder: extra credit]

//Enter a phrase on a single line:hello HAROLD
//Processing: 'H'
//did not find 'H' setting count to 1
//Processing: 'E'
//did not find 'E' setting count to 1
//Processing: 'L'
//did not find 'L' setting count to 1
//Processing: 'L'
//Found 'L' count was: 1
//Processing: 'O'
//did not find 'O' setting count to 1
//Processing: ' '
//did not find ' ' setting count to 1
//Processing: 'H'
//Found 'H' count was: 1
//Processing: 'A'
//did not find 'A' setting count to 1
//Processing: 'R'
//did not find 'R' setting count to 1
//Processing: 'O'
//Found 'O' count was: 1
//Processing: 'L'
//Found 'L' count was: 2
//Processing: 'D'
//did not find 'D' setting count to 1
//-----------------
//Found H with a count of 2
//Found E with a count of 1
//Found L with a count of 3
//Found O with a count of 2
//Found   with a count of 1
//Found A with a count of 1
//Found R with a count of 1
//Found D with a count of 1
//Enter a phrase on a single line:  ^C

namespace Page12Problem2
{
    class Program
    {

        public static void Main()
        {

            // enter into an infinate loop
            // create an empty dictionary to hold the final counts
            // prompt the user to enter a pharase
            // loop over each letter in the phrase
            // look in the dictionary to see if the letter is present
            //     success:
            //         print success message: count found
            //         add one to the existing value in the dictionary
            //     failure:
            //         print not seen yet message: count set to 1
            //         put an entry of 1 into the dictionary with the letter as the key

            // now loop over all the elements in the dictionary
            //  print out the key and the value
            Dictionary<char, int> finalCounts = new Dictionary<char, int>();
            Console.WriteLine("Enter a phrase: ");
            string phrase = Console.ReadLine();

            foreach (char c in phrase)
            {
                char present;
                present = c;
                int last;
                if (finalCounts.TryGetValue(present, out last))
                {
                    finalCounts[present] = last + 1;
                    Console.WriteLine($"Already counted '{present}', {last} times, adding one more");
                }
                else
                {
                    finalCounts.Add(present, 1);
                    Console.WriteLine($"not found '{c}' before, adding 1");
                }


            }
            Console.WriteLine("--------------------------------- Done Processing ------------------------------");
            foreach (var item in finalCounts)
            {
                Console.WriteLine($"'{item.Key}' was found {item.Value} time(s)");
            }

        }
    }
}
