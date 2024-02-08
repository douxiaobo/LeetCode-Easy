// Definition for singly-linked list.
// #[derive(PartialEq, Eq, Clone, Debug)]
// pub struct ListNode {
//   pub val: i32,
//   pub next: Option<Box<ListNode>>
// }
// 
// impl ListNode {
//   #[inline]
//   fn new(val: i32) -> Self {
//     ListNode {
//       next: None,
//       val
//     }
//   }
// }
impl Solution {
    pub fn merge_two_lists(list1: Option<Box<ListNode>>, list2: Option<Box<ListNode>>) -> Option<Box<ListNode>> {
        match(list1,list2){
            (Some(node1),None)=>Some(node1),    //listnode2为空，返回listnode1的其余节点
            (None,Some(node2))=>Some(node2),    //listnode1为空，返回listnode2的其余节点
            (Some(mut node1),Some(mut node2))=>{
                //如果listnode1指向的节点值小于listnode2指向的节点值，listnode1指向的节点的下一个节点就是递归函数的返回值
                //否则，listnode2指向的节点的下一个节点就是递归函数的返回值
                if node1.val<node2.val{
                    let n=node1.next.take();
                    node1.next=Solution::merge_two_lists(n,Some(node2));
                    Some(node1)
                } else {
                    let n=node2.next.take();
                    node2.next=Solution::merge_two_lists(Some(node1),n);
                    Some(node2)
                }
            }
            _ => None,
        }
    }
}