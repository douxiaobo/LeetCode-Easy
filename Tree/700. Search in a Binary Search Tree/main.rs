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
    pub fn search_bst(root: Option<Rc<RefCell<TreeNode>>>, val: i32) -> Option<Rc<RefCell<TreeNode>>> {
        let mut r=root.clone();
        while let Some(node)=r {
            //如果等于目标值，返回该节点
            if node.borrow().val==val { return Some(node); }

            //如果大于目标值，搜索左子树
            //否则，搜索右子树
            if node.borrow().val>val {
                r=node.borrow().left.clone();
            } else {
                r=node.borrow().right.clone();
            }
        }
        //没找到，返回None
        None
    }
}