namespace FirstWeekTasks;

public class LeetCodeProblem
{
    private string ReverseWords(string s)
    {
        string[] words = s.Split(' ');
        var resultList = new List<string>();

        foreach (string word in words)
        {
            var arr = word.ToCharArray();
            Array.Reverse(arr);
            string reversedWord = new string(arr);
            resultList.Add(reversedWord);
        }

        return string.Join(" ", resultList.ToArray());
    }
}