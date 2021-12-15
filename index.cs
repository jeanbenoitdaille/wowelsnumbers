    using System;
    using System.Linq;
     
    namespace Coding.Exercise
    {
        public class Exercise
        {
           public static int HowManyVowels(string word)
            {
                var v = new char[] {'a','e','i','o','u','y'};
                int count = 0;
                for(var i = 0; i < word.Length; i ++){
                  if(v.Contains(word[i])){
                    count++;
                  }
                }
                return count;
            }
        }
    }