package main

// TreeNode 定义二叉树节点结构
type TreeNode struct {
	Val   int
	Left  *TreeNode
	Right *TreeNode
}

// mergeTrees 合并两棵二叉树
func mergeTrees(root1 *TreeNode, root2 *TreeNode) *TreeNode {
	if root1 != nil && root2 != nil {
		result := &TreeNode{Val: root1.Val + root2.Val}
		result.Left = mergeTrees(root1.Left, root2.Left)
		result.Right = mergeTrees(root1.Right, root2.Right)
		return result
	} else if root1 != nil && root2 == nil {
		return root1 // 直接返回root1，因为root2为空，无需合并
	} else if root1 == nil && root2 != nil {
		return root2 // 直接返回root2，因为root1为空，无需合并
	} else {
		// 当root1和root2都为null时，可以返回一个null或者一个新的空节点
		return nil // 或者 return &TreeNode{Val: 0}
	}
}
