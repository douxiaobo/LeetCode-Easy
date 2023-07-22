# 1624. Largest Substring Between Two Equal Characters

Easy

Given a string `s`, return the length of the longest substring between two equal characters, excluding the two characters. If there is no such substring return `-1`.

A **substring** is a contiguous sequence of characters within a string.

 

**Example 1:**
```
Input: s = "aa"
Output: 0
Explanation: The optimal substring here is an empty substring between the two 'a's.
```
**Example 2:**
```
Input: s = "abca"
Output: 2
Explanation: The optimal substring here is "bc".
```
**Example 3:**
```
Input: s = "cbzxy"
Output: -1
Explanation: There are no characters that appear twice in s.
``` 

**Constraints:**

1 <= s.length <= 300
s contains only lowercase English letters.

**Related Topics**
- Hash Table
- String




我为您解释一下修改后的代码：



首先，我们创建两个数组firstIndex和lastIndex，分别用于存储每个字符在字符串s中首次出现和最后一次出现的位置。我们将这两个数组的所有元素初始化为-1，表示尚未找到相应字符。


接下来，我们遍历字符串s。对于s中的每个字符，我们计算其在字母表中的索引（s[i] - 'a'），然后检查firstIndex数组中该索引位置的值。如果值为-1，说明这是字符首次出现，我们将其位置i存储在firstIndex数组中。无论如何，我们都将字符的位置i存储在lastIndex数组中，这样lastIndex数组将始终包含字符的最后出现位置。


在完成字符串s的遍历后，我们遍历firstIndex和lastIndex数组，计算每个字符首次出现和最后一次出现之间的最大距离（lastIndex[i] - firstIndex[i] - 1）。我们使用一个变量maxLength来跟踪这个最大值。


最后，我们返回maxLength作为结果。



这个修改后的代码能够正确处理LeetCode的1624题，因为它能够找到字符串中每个字符首次出现和最后一次出现之间的最大距离。