"""
File: preorder_find_paths.py
Created Time: 2023-04-15
Author: Krahets (krahets@163.com)
"""

import sys, os.path as osp

sys.path.append(osp.dirname(osp.dirname(osp.abspath(__file__))))
from modules import *


def pre_order(root: TreeNode) -> None:
    """前序遍历"""
    if root is None:
        return
    # 尝试
    path.append(root)
    if root.val == 7:
        # 记录解
        res.append(list(path))
    pre_order(root.left)
    pre_order(root.right)
    # 回退
    path.pop()


"""Driver Code"""
if __name__ == "__main__":
    root = list_to_tree([1, 7, 3, 4, 5, 6, 7])
    print("\n初始化二叉树")
    print_tree(root)

    # 前序遍历
    path = list[TreeNode]()
    res = list[list[TreeNode]]()
    pre_order(root)

    print("\n输出所有根节点到节点 7 的路径")
    for path in res:
        print([node.val for node in path])
