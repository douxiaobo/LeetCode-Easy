﻿namespace CSharp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public int MinDepth(TreeNode root) {
        if(root==null){
            return 0;
        }
        if(root.left==null){
            return MinDepth(root.right)+1;
        }
        if(root.right==null){
            return MinDepth(root.left)+1;
        }

        var left=MinDepth(root.left);
        var right=MinDepth(root.right);           
        return Math.Min(left,right)+1;
    }
}