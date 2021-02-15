using System;

namespace SumNbrsOneToSeventyDivisibleBySeven {
    class Program {
        static void Main(string[] args) {

            var sum = 0;

            for(var idx = 1; idx <= 70; idx++) {

                if(idx % 7 == 0) {
                    sum += idx;
                }

            }

            Console.WriteLine($"The sum is {sum}");
        }
    }
}
