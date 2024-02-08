// Definition for a binary tree node.
// #[derive(Debug, PartialEq, Eq)]
// pub struct TreeNode {
//   pub val: i32,
//   pub left: Option<Rc<RefCell<TreeNode>>>,
//   pub right: Option<Rc<RefCell<TreeNode>>>,
// }
// 
// impl TreeNode {
//   #[inline]
//   pub fn new(val: i32) -> Self {
//     TreeNode {
//       val,
//       left: None,
//       right: None
//     }
//   }
// }
use std::rc::Rc;
use std::cell::RefCell;
impl Solution {
    pub fn max_depth(root: Option<Rc<RefCell<TreeNode>>>) -> i32 {
        match root {
            Some(node)=> {
                //左子树最大深度
                let left=Self::max_depth(node.borrow().left.clone());
                //右子树最大深度
                let right=Self::max_depth(node.borrow().right.clone());
                //比较左右子树深度，取较大值加上根节点
                1+left.max(right)
            }
            //递归退出条件：当前节点为空
            _=>0,
        }
    }
}