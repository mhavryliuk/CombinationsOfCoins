using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// In England currency are pound sterling £ and pence.
// There are eight coins in circulation: 1p, 2p, 5p, 10p, 20p, 50p, £ 1 (100p) and £ 2 (200p). 
// £ 2 can be represented as follows: 1×£1 + 1×50p + 2×20p + 1×5p + 1×2p + 3×1p.
// In how many different ways it is possible to make £2, using any quantity of coins?

// В Англии валютой являются фунты стерлингов £ и пенсы.
// В обращении есть восемь монет: 1p, 2p, 5p, 10p, 20p, 50p, £1 (100p) и £2 (200p). 
// £2 возможно составить следующим образом: 1×£1 + 1×50p + 2×20p + 1×5p + 1×2p + 3×1p
// Сколькими разными способами можно составить £2, используя любое количество монет? 

namespace CombinationsOfCoins
{
    class Program
    {
        static void Main()
        {
            Combinations ways = new Combinations();
            int answer = ways.ChangePossibilities(200, new int[] { 1, 2, 5, 10, 20, 50, 100, 200 });
            Console.WriteLine("There are {0} ways to make 2 sterling, using any number of coins of a given denominations.", answer);

            Console.ReadKey();
        }
    }
}