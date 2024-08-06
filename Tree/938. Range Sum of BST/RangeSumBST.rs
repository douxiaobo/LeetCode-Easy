// Definition for a binary tree node.
#[derive(Debug, PartialEq, Eq)]
pub struct TreeNode {
  pub val: i32,
  pub left: Option<Rc<RefCell<TreeNode>>>,
  pub right: Option<Rc<RefCell<TreeNode>>>,
}

impl TreeNode {
  #[inline]
  pub fn new(val: i32) -> Self {
    TreeNode {
      val,
      left: None,
      right: None
    }
  }
}

use std::rc::Rc;
use std::cell::RefCell;
impl Solution {
    pub fn range_sum_bst(root: Option<Rc<RefCell<TreeNode>>>, low: i32, high: i32) -> i32 {
        if let Some(node) = root {
            let node = node.borrow();
            let mut sum = 0;
            // 如果当前节点的值在范围内，则加入总和
            if node.val >= low && node.val <= high {
                sum += node.val;
            }
            // 递归检查左子树，范围仍然是[low, high]
            sum += Self::range_sum_bst(node.left.clone(), low, high);
            // 递归检查右子树，范围仍然是[low, high]
            sum += Self::range_sum_bst(node.right.clone(), low, high);
            sum
        } else {
            0
        }
    }
}