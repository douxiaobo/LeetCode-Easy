/**
 * Definition for a binary tree node.
 * class TreeNode {
 *     val: number
 *     left: TreeNode | null
 *     right: TreeNode | null
 *     constructor(val?: number, left?: TreeNode | null, right?: TreeNode | null) {
 *         this.val = (val===undefined ? 0 : val)
 *         this.left = (left===undefined ? null : left)
 *         this.right = (right===undefined ? null : right)
 *     }
 * }
 */

function evaluateTree(root: TreeNode | null): boolean {
    if (root === null) {
        throw new Error("Root should not be null");
    }
    
    switch (root.val) {
        case 0:
            return false;
        case 1:
            return true;
        case 2:
            return evaluateTree(root.left) || evaluateTree(root.right);
        case 3:
            return evaluateTree(root.left) && evaluateTree(root.right);
        default:
            throw new Error("Invalid node value");
    }
}
