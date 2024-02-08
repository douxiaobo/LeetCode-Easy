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
    pub fn postorder_traversal(root: Option<Rc<RefCell<TreeNode>>>) -> Vec<i32> {
        let mut result=vec![];
        if root.is_none() { return result; }

        let mut stack1: Vec<Option<Rc<RefCell<TreeNode>>>>=Vec::new();
        let mut stack2: Vec<Option<Rc<RefCell<TreeNode>>>>=Vec::new();
        stack1.push(root);

        //将stack1栈顶的节点依次出栈，并将被节点入stack2，将该节点的左右子节点入stack1
        while let Some(Some(node))=stack1.pop() {
            if node.borrow().left.is_some() {
                stack1.push(node.borrow().left.clone());
            }
            if node.borrow().right.is_some() {
                stack1.push(node.borrow().right.clone());
            }
            stack2.push(Some(node));
        }

        //将stack2栈顶的节点依次出栈，并访问其节点值
        while let Some(Some(node))=stack2.pop(){
            result.push(node.borrow().val);
        }
        result
    }
}