namespace aufgabe_binarysearchtree;

public interface IBinaryTree<T> where T : IComparable<T>
{
    void Clear();
    void Insert(T value);
    void Delete(T value);
    bool Contains(T value);
    BinaryTreeNode<T> Search(T value);
    void PrintInorder();
}