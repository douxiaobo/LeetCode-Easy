/**
 * Definition for a binary tree node.
 * struct TreeNode {
 *     int val;
 *     struct TreeNode *left;
 *     struct TreeNode *right;
 * };
 */

bool evaluateTree(struct TreeNode* root) {
    if (root == NULL) {
        fprintf(stderr, "Root should not be NULL\n");
        exit(EXIT_FAILURE);
    }
    
    switch (root->val) {
        case 0:
            return false;
        case 1:
            return true;
        case 2:
            return evaluateTree(root->left) || evaluateTree(root->right);
        case 3:
            return evaluateTree(root->left) && evaluateTree(root->right);
        default:
            fprintf(stderr, "Invalid node value\n");
            exit(EXIT_FAILURE);
    }
}
