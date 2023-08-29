public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> result = new List<IList<int>>();
            for(int i = 1;i <= numRows; i++)
             {
                if (i == 1)
                {
                     result.Add(new List<int>() { 1 });
                     continue;
                }
 
                 List<int> temp = new List<int>();
                 for (int j = 1; j <= i; j++)
                 {
                     if (j == 1 || j == i)
                     {
                         temp.Add(1);
                         continue;
                     }
 
                     temp.Add(result[i - 1 -1][j - 1 -1] + result[i - 1 -1][j -1]);
                 }
 
                 result.Add(temp);
             }
 
             return result;
    }
}