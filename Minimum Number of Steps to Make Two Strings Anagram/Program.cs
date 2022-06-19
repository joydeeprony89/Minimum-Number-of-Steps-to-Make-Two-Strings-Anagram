using System;
using System.Collections.Generic;

namespace Minimum_Number_of_Steps_to_Make_Two_Strings_Anagram
{
  class Program
  {
    static void Main(string[] args)
    {
      Solution s = new Solution();
      var answer = s.MinSteps("leetcode", "practice");
      Console.WriteLine(answer);
    }
  }

  public class Solution
  {
    public int MinSteps(string s, string t)
    {
      Dictionary<char, int> frequency = new Dictionary<char, int>();
      for(int i = 0; i < s.Length; i++)
      {
        char skey = s[i];
        char tkey = t[i];
        if (!frequency.ContainsKey(skey))
        {
          frequency.Add(skey, 0);
        }
        if (!frequency.ContainsKey(tkey))
        {
          frequency.Add(tkey, 0);
        }
        frequency[skey]++;
        frequency[tkey]--;
      }

      int count = 0;
      foreach(var val in frequency.Values)
      {
        if (val > 0) count += val;
      }

      return count;
    }
  }
}
