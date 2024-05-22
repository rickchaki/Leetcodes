class Solution {
    int n;
    List<List<String>> result;
    List<String> current;
    boolean isPalindrome(String s, int l, int r){
        while(l < r){
            if(s.charAt(l) != s.charAt(r)) return false;
            l++; r--;
        }
        return true;
    }
    void backtrack(String s, int idx, List<String> current, List<List<String>> result){
        if(idx == n){
            result.add(new ArrayList(current));
            return;
        }
        for(int i = idx; i < n; i++){
            if(isPalindrome(s, idx, i)){
                current.add(s.substring(idx, i+1));
                backtrack(s, i+1, current, result);
                current.remove(current.size() - 1);
            }
        }
    }
    public List<List<String>> partition(String s) {
        n = s.length();
        result = new ArrayList();
        current = new ArrayList();
        backtrack(s, 0, current, result);
        return result;
    }
}
