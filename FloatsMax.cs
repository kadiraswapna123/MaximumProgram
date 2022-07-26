using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxProblem
{
    internal class FloatsMax
    {
            for(int i = 0; i<s.Length; i++)
            {
                 if (a.Contains(s[i]))
                 {
                    return false;
                 }
                     a.Add(s[i]);
            }
            return true;
            static ArrayList helper(ArrayList arr, int ind)
    {
        if (ind == arr.Count)
            return new ArrayList() { "" };
        ArrayList tmp = helper(arr, ind + 1);

        ArrayList ret = new ArrayList(tmp);

        for (int i = 0; i < tmp.Count; i++)
        {
            string test = (string)tmp[i] + (string)arr[ind];

            if (check(test))
                ret.Add(test);
        }
        return ret;
    }
    static int maxLength(ArrayList arr)
    {
        ArrayList tmp = helper(arr, 0);

        int len = 0;
        for (int i = 0; i < tmp.Count; i++)
        {
            len = len > ((string)tmp[i]).Length ? len : ((string)tmp[i]).Length;
        }
        return len;
    }
    public static void Main(string[] args)
    {
        ArrayList s = new ArrayList(); s.Add("abcdefgh");
        Console.Write(maxLength(s));
    }
}

 
    

