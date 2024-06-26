class Solution {
public:
    int n;
    vector<vector<string>> result;
    vector<string> current;
    bool isPalindrome(string& s, int l, int r){
        while(l < r){
            if(s[l] != s[r]) return false;
            l++; r--;
        }
        return true;
    }
    void backtrack(string& s, int idx, vector<string>& current, vector<vector<string>>& result){
        if(idx == n){
            result.push_back(current);
            return;
        }
        for(int i = idx; i < n; i++){
            if(isPalindrome(s, idx, i)){
                current.push_back(s.substr(idx, i-idx+1));
                backtrack(s, i+1, current, result);
                current.pop_back();
            }
        }
    }
    vector<vector<string>> partition(string s) {
        n = s.length();
        
        backtrack(s, 0, current, result);
        return result;
    }
};
