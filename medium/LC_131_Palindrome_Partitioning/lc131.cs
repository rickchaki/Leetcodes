public class Solution {
    int n;
    List<IList<string>> result;
    List<string> current;
    bool isPalindrome(string s, int l, int r){
        while(l < r){
            if(s[l] != s[r]) return false;
            l++; r--;
        }
        return true;
    }
    void backtrack(string s, int idx, List<string> current, List<IList<string>> result){
        if(idx == n){
            result.Add(current.ToList());
            return;
        }
        for(int i = idx; i < n; i++){
            if(isPalindrome(s, idx, i)){
                current.Add(s.Substring(idx, i-idx+1));
                backtrack(s, i+1, current, result);
                current.RemoveAt(current.Count - 1);
            }
        }
    }
    public IList<IList<string>> Partition(string s) {
        n = s.Length;
        result = new List<IList<string>>();
        current = new List<string>();
        backtrack(s, 0, current, result);
        return result;
    }
}
