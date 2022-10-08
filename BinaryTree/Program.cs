using BinaryTree;

var tree = new Tree();
tree.root = tree.Insert(1, tree.root);
tree.root = tree.Insert(2, tree.root);
tree.root = tree.Insert(3, tree.root);
tree.PrintInOrder(tree.root);
