using System;

class StringDecode
{
    /* Please implement this method.
    * 
    * int CountDecodings(string s)
    * 
    * input: string s
    *        contains only digits 0-9
    * return: an integer that is the number of possible ways to decode the string
    * 
    * Decoding rule:
    * 1  -> 'a'
    * 2  -> 'b'
    * 3  -> 'c'
    * 4  -> 'd'  
    * 5  -> 'e'
    * 6  -> 'f'
    * 7  -> 'g'
    * 8  -> 'h'
    * 9  -> 'i'
    * 10 -> 'j'
    * 11 -> 'k'
    * 12 -> 'l'
    * ...
    * 26 -> 'z'
    * 
    * Examples:
    * 
    * CountDecodings("345") should return 1
    *      because "345" can only be decoded as "cde"
    *      
    * CountDecodings("123") should return 3
    *      because "123" can only be decoded as 
    *          "abc" (1 - 2 - 3)
    *          "aw" (1 - 23)
    *          "lc" (12 - 3)
    */
    public static int CountDecodings(string s)
    {
        if (s.Length == 0)
        {
            return 1;
        }

        int decodings = 0;
        if (s[0] > '0')
        {
            decodings += CountDecodings(s.Substring(1));
        }
        if (s.Length >= 2 && (s[0] == '1' || (s[0] == '2' && s[1] <= '6')))
        {
            decodings += CountDecodings(s.Substring(2));
        }
        return decodings;
    }
}