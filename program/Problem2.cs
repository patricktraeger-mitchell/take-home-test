using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using program.entities;
using program.factories;

namespace program
{
    public class ProblemSet2
    {
        /// <summary>
        /// PROBLEM #2:
        /// You are given a set of strings that are product codes. Each product code has two main parts:
        /// A) its alpha code (string)  and B) its version code (string of 1, 2, 3, 4 or 5)
        /// Each product code has a value that is encoded inside its alpha code that tells us its unit price.
        /// The value of the string can be found by the sum of its index in the alphabet.
        /// For example: The product code "ACD3" has the value of 5. This is because A = 0,  C = 2, D = 3.
        /// The value 3 in this product code has no meaning for its unit price. 
        /// and the sum of those values is 5
        /// Given two product codes return to us the string with the highest value
        /// If two product codes are equal in value then return the product code with the highest version code
        /// </summary>        
        public string FindHighestValue(string productCode1, string productCode2)
        {
            return null;
        }      
    }
}