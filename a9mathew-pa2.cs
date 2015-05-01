// -------------------------------------------------------------------
// Department of Electrical and Computer Engineering
// University of Waterloo
//
// Student Name:     Anand Mathew
// Userid:           a9mathew
//
// Assignment:       PA2
// Submission Date:  2014-10-10
// 
// I declare that, other than the acknowledgements listed below, 
// this program is my original work.
//
// Acknowledgements:
// Leonardo Passos' help tips.
// -------------------------------------------------------------------

using System;
class BitSequences
{
	static uint NbrOfBits(uint n) // Method that returns the number of bits of a 
								  // user inputted unsigned integer argument  
	{
		if (Math.Ceiling(Math.Log(n,2)) - Math.Log(n,2) == 0) 
		{
			return (uint)(Math.Log(n,2) + 1);
		}
		else
		{	
			return (uint)(Math.Ceiling(Math.Log(n,2)));
		}
	}
	
	static bool ExtractTheBit(uint n,uint idx) // Method that returns a boolean binary value c
	                                           // which indicates whether its binary value
	                                           // at a particular index is 1 or 0. Its arguments
											   // are n and idx.
	{	
		bool c = true;
		for(uint i=0; i< idx +1; i++)// Divides n/2 idx +1 times and then compares the remainder
		{
			n = (n/ (uint)2);
		}
		if (n%2 == 0) 
		{
			c = false;
		}
		else if (n%2 == 1)
		{
			c = true;
		}
		return c;
	}	
	static void Main()
	{
		Console.WriteLine ("Binary Encoder"); // Title
		Console.WriteLine();
		Console.Write("Enter an unsigned integer: ");// User Prompt
		uint n = uint.Parse(Console.ReadLine()); // User inputs uint here.
		Console.Write("The encoding of n is ");
		for (uint j= 32; j>0; j--)// Extracts all 32 bits individually and outputs 1 to the
                                  // console if the binary value is 1 or 0 to the 
								  // console if the binary value is 0
		{
			if (ExtractTheBit(n,j-2))
			{	
				Console.Write(1);
			}
			else
			{
				Console.Write(0);
			}
		}
	}
}

		