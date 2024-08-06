/**
 * Definition for a binary tree node.
 * type TreeNode struct {
 *     Val int
 *     Left *TreeNode
 *     Right *TreeNode
 * }
 */
func rangeSumBST(root *TreeNode, low int, high int) int {
	if root == nil {
		return 0
	}

	sum := 0
	// 如果当前节点的值在范围内，则加入总和
	if root.Val >= low && root.Val <= high {
		sum += root.Val
	}
	// 递归检查左子树，范围仍然是[low, high]
	sum += rangeSumBST(root.Left, low, high)
	// 递归检查右子树，范围仍然是[low, high]
	sum += rangeSumBST(root.Right, low, high)

	return sum
}