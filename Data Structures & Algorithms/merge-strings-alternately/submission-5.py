class Solution:
    def mergeAlternately(self, word1: str, word2: str) -> str:
        n, m = len(word1), len(word2)
        l = r = 0
        res = []

        while l < n or r < m:
            if l < n:
                res.append(word1[l])
            if r < m:
                res.append(word2[r])
            l += 1
            r += 1
        return "".join(res)