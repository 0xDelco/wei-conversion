using System;
using Nethereum.Web3;

namespace WeiConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".001        => " + Web3.Convert.ToWei(".001"));
            Console.WriteLine(".01         => " + Web3.Convert.ToWei(".01"));
            Console.WriteLine("1           => " + Web3.Convert.ToWei("1"));
            Console.WriteLine("100         => " + Web3.Convert.ToWei("100"));
            Console.WriteLine("1,000       => " + Web3.Convert.ToWei("1,000"));
            Console.WriteLine("10,000      => " + Web3.Convert.ToWei("10,000"));
            Console.WriteLine("10,123      => " + Web3.Convert.ToWei("10,123"));
            Console.WriteLine("100,000.456 => " + Web3.Convert.ToWei("100,000.456"));
            Console.WriteLine("100,001     => " + Web3.Convert.ToWei("100,001"));
        }
    }
}
