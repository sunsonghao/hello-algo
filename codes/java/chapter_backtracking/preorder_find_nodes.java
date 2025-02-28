/**
 * File: preorder_find_nodes.java
 * Created Time: 2023-04-16
 * Author: Krahets (krahets@163.com)
 */

package chapter_backtracking;

import include.*;
import java.util.*;

public class preorder_find_nodes {
    static List<TreeNode> res;

    /* 前序遍历 */
    static void preOrder(TreeNode root) {
        if (root == null) {
            return;
        }
        if (root.val == 7) {
            // 记录解
            res.add(root);
        }
        preOrder(root.left);
        preOrder(root.right);
    }

    public static void main(String[] args) {
        TreeNode root = TreeNode.listToTree(Arrays.asList(1, 7, 3, 4, 5, 6, 7));
        System.out.println("\n初始化二叉树");
        PrintUtil.printTree(root);

        // 前序遍历
        res = new ArrayList<>();
        preOrder(root);

        System.out.println("\n输出所有值为 7 的节点");
        List<Integer> vals = new ArrayList<>();
        for (TreeNode node : res) {
            vals.add(node.val);
        }
        System.out.println(vals);
    }
}
