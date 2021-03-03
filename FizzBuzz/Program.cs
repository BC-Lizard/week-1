/*
a user should be able to enter the starting and ending count
a user should be able to enter these values in any order
a user should be able to get the number of times fizz, buzz and fizzbuzz appear
a user should be able to set new values for fizz, buzz and fizzbuzz
*/
using System;

namespace FizzyBuzzy { //scope, prevents name collusion
                    //Can contain class(reference type), struct(value type), interface(reference type), enum(value type)
    internal class Fizzy {
        private string _fizz = "fizz";
        private string _buzz = "buzz";
        private string _fizzbuzz = "fizzbuzz";
        public static void Main() {
            var f = new Fizzy();
            f.GetEntry();
        }

        private int GetInput() {
            return int.Parse(Console.ReadLine()); 
        }

        private int GetEndpoint() {
            Console.WriteLine("enter Number:\n");
            return GetInput();
        }

        private void GetEntry() {
            var endpoint1 = GetEndpoint();
            var endpoint2 = GetEndpoint();

            if(endpoint1 < endpoint2) {
                FizzBuzz(endpoint1, endpoint2);
            } else {
                FizzBuzz(endpoint2, endpoint1);
            }
        }

        private void FizzBuzz(int start, int end) {
            for (var i = start; i <= end; i += 1) {
                if (i % 3 == 0 && 1 % 5 == 0) {
                    Console.WriteLine(_fizzbuzz);
                } else if (i % 3 == 0) {
                    Console.WriteLine(_fizz);
                } else if (i % 5 == 0) {
                    Console.WriteLine(_buzz);
                } else {
                    Console.WriteLine(i);
                }
            }
        }
    }
}