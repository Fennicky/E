using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Eden
{
    public static class RandomNumberGenerator
    {
        private static readonly RNGCryptoServiceProvider _generator =
            new RNGCryptoServiceProvider();

        public static int NumberBetween(int minimumValue, int maximumValue)
        {
            byte[] randomNumber = new byte[1];

            _generator.GetBytes(randomNumber);

            double asciiValueofRandomCharacter = Convert.ToDouble(randomNumber[0]);

            //Using Math.Max, and subtracting 0.00000000001, to ensure 'multiplier' will
            //allways be between 0.0 and .99999999999
            //otherwise, it's possible for it to be "1", which causes problems in rounding
            double multplier = Math.Max(0, (asciiValueofRandomCharacter / 255d) - 0.00000000001d);

            //Need to add one to the range, to allow for the rounding done with Math.Floor
            int range = maximumValue - minimumValue + 1;

            double randomValueInRange = Math.Floor(multplier * range);

            return (int)(minimumValue + randomValueInRange);
        }
    }
}
