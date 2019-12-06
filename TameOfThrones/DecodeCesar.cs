using System;
using System.Collections.Generic;
using System.Text;

namespace TameOfThrones
{
    public class DecodeCesar
    {
        readonly string encodedString;
        readonly int cesarSkipLength;
        public DecodeCesar(string encodedString, int cesarSkipLength)
        {
            this.cesarSkipLength = cesarSkipLength;
            this.encodedString = encodedString;
        }

        public string Decoder()
        {
            char[] decodedString = encodedString.ToUpper().ToCharArray();
            
            for (int i =0; i < decodedString.Length;i++) 
            {
                if (decodedString[i] == 'A')
                {
                    decodedString[i] = (char)('Z'+1-cesarSkipLength);
                }
                else
                {
                    decodedString[i] = (char)(decodedString[i] - cesarSkipLength);
                }
            }
            return decodedString.ToString();
        }

    }
}
