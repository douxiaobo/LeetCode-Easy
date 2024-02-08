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
    pub fn inorder_traversal(root: Option<Rc<RefCell<TreeNode>>>) -> Vec<i32> {
        let mut result:Vec<i32>=vec![];
        if root.is_none(){ return result; }

        inorder_recursive(root, &mut result);
        result
    }
}

fn inorder_recursive(root:Option<Rc<RefCell<TreeNode>>>,result: &mut Vec<i32>){
    match root{
        Some(node)=>{
            //递归遍历左子树
            inorder_recursive(node.borrow().left.clone(),result);
            //访问当前节点
            result.push(node.borrow().val);
            //递归遍历右子树
            inorder_recursive(node.borrow().right.clone(),result);
        }
        None=> { return; }
    }  
}