/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode() {}
 *     TreeNode(int val) { this.val = val; }
 *     TreeNode(int val, TreeNode left, TreeNode right) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
class Solution {
    public int rangeSumBST(TreeNode root, int low, int high) {
        if (root == null) {
            return 0;
        }
        
        int sum = 0;
        // 如果当前节点的值在范围内，则加入总和
        if (root.val >= low && root.val <= high) {
            sum += root.val;
        }
        // 递归检查左子树，范围仍然是[low, high]
        sum += rangeSumBST(root.left, low, high);
        // 递归检查右子树，范围仍然是[low, high]
        sum += rangeSumBST(root.right, low, high);
        
        return sum;
    }
}