public class TrieNode {
    public TrieNode[] children = new TrieNode[26];
    public bool endOfWord = false;
}
public class PrefixTree {
    private TrieNode root;

    public PrefixTree() {
        root = new TrieNode();    
    }
    
    public void Insert(string word) {
        TrieNode cur = root;
        foreach (char c in word) {
            if (cur.children[c - 'a'] == null) {
                cur.children[c - 'a'] = new TrieNode();
            }
            cur = cur.children[c - 'a'];
        }
        cur.endOfWord = true;
    }
    
    public bool Search(string word) {
        TrieNode cur = root;
        foreach (char c in word) {
            if (cur.children[c - 'a'] == null) {
                return false;
            }
            cur = cur.children[c - 'a'];
        }
        return cur.endOfWord;
    }
    
    public bool StartsWith(string prefix) {
        TrieNode cur = root;
        foreach (char c in prefix) {
            if (cur.children[c - 'a'] == null) {
                return false;
            }
            cur = cur.children[c - 'a'];
        }
        return true;
    }
}
