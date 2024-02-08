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
use std::collections::VecDeque;

impl Solution {
    pub fn max_depth(root: Option<Rc<RefCell<TreeNode>>>) -> i32 {
        if root.is_none() { return 0; }

        let mut depth=0;
        let mut deque: VecDeque<Option<Rc<RefCell<TreeNode>>>>= VecDeque::new();
        deque.push_back(root);

        while !deque.is_empty(){
            let level_size=deque.len();
            //遍历新的一层，深度加1
            depth+=1;

            //层级遍历，当前层节点弹出队列，同时将其左、右子节点压入队列
            for _i in 0..level_size {
                if let Some(Some(node)) = deque.pop_front() {
                    if node.borrow().left.is_some() {
                        deque.push_back(node.borrow().left.clone());
                    }
                    if node.borrow().right.is_some() {
                        deque.push_back(node.borrow().right.clone());
                    }
                }
            }
        }
        depth
    }
}