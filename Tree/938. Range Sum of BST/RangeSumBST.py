# Definition for a binary tree node.
class TreeNode:
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right

class Solution:
    def rangeSumBST(self, root: Optional[TreeNode], low: int, high: int) -> int:
        if not root:
            return 0
        
        sum = 0
        # 如果当前节点的值在范围内，则加入总和
        if low <= root.val <= high:
            sum += root.val
        # 递归检查左子树，范围仍然是[low, high]
        sum += self.rangeSumBST(root.left, low, high)
        # 递归检查右子树，范围仍然是[low, high]
        sum += self.rangeSumBST(root.right, low, high)
        
        return sum