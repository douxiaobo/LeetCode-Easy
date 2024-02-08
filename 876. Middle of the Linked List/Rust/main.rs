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
    pub fn middle_node(head: Option<Box<ListNode>>) -> Option<Box<ListNode>> {
        let mut fast_p=&head;   //快指针
        let mut slow_p=&head;   //慢指针

        //满足fast_p指向的节点和下个节点都非空条件执行循环
        while fast_p.is_some()&&fast_p.as_ref().unwrap().next.is_some(){
            //slow_p往后移动一个节点
            slow_p=&slow_p.as_ref().unwrap().next;
            //fast_p往后移动两点
            fast_p=&fast_p.as_ref().unwrap().next.as_ref().unwrap().next;
        }
        slow_p.clone()
    }
}