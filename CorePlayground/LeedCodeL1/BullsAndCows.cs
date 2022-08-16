using System;
using System.Collections;
using System.Collections.Generic;

namespace LeedCodeLove.LeedCodeL1
{
    public static class BullsAndCows
    {
        public static string GetHint(string secret, string guess)
        {
            var secretValueIndex = new HashSet<string>();
            var secretValue = new Dictionary<char, int>();
            int bull = 0;
            int cow = 0;
            for (int i = 0; i < secret.Length; i++)
            {
                secretValueIndex.Add($"{secret[i]},{i}");
                if (secretValue.ContainsKey(secret[i]))
                {
                    secretValue[secret[i]] +=  1;
                }
                else
                {
                    secretValue.Add(secret[i], 1);
                }
            }
            for (int i = 0; i < guess.Length; i++)
            {
                if (secretValueIndex.Contains($"{guess[i]},{i}"))
                {
                    bull++;
                    secretValueIndex.Remove($"{guess[i]},{i}");
                    if (secretValue.ContainsKey(guess[i]))
                    {
                        secretValue[guess[i]] -= 1;
                        if (secretValue[guess[i]] <= 0)
                        {
                            secretValue.Remove(guess[i]);
                        }
                    }
                    
                }
                else if(secretValue.ContainsKey(guess[i]))
                {
                    cow++;
                    secretValue[guess[i]] -=  1;
                    if(secretValue[guess[i]] <= 0)
                    {
                        secretValue.Remove(guess[i]);
                    }
                    
                }
            }
            return $"{bull}A{cow}B";
        }
    }
}
