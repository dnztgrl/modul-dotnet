namespace aufgabe_binarysearchtree;

public class BinaryTree<T> : IBinaryTree<T> where T : IComparable<T>
{
    private BinaryTreeNode<T> root;

    public void Clear()
    {
        root = null;
    }

    private BinaryTreeNode<T> Insert(BinaryTreeNode<T> node, T value)
    {
        if (node == null)
        {
            return new BinaryTreeNode<T>(value);
        }
        
        if (node.Data.CompareTo(value) > 0)
        {
            node.Left = Insert(node.Left, value);
            return node;
        }

        if (node.Data.CompareTo(value) < 0)
        {
            node.Right = Insert(node.Right, value);
            return node;
        }
    
        return node;
    }

    public void Insert(T value)
    {
        root = Insert(root, value);
    }

    private BinaryTreeNode<T> FindMin(BinaryTreeNode<T> node)
    {
        if (node != null)
        {
            if (node.Left == null)
            {
                return node;
            }

            return FindMin(node.Left);
        }

        return null;
    }

    private BinaryTreeNode<T> Delete(BinaryTreeNode<T> node, T value)
    {
        if (node == null)
        {
            return null;
        }

        if (node.Data.CompareTo(value) > 0)
        {
            node.Left = Delete(node.Left, value);
            return node;
        }

        if (node.Data.CompareTo(value) < 0)
        {
            node.Right = Delete(node.Right, value);
            return node;
        }

        else
        {
            if (node.Left == null && node.Right == null)
            {
                return null;
            }

            if (node.Left == null)
            {
                return node.Right;
            }

            if (node.Right == null)
            {
                return node.Left;
            }

            else
            {
                T minValue = FindMin(node.Right).Data;
                node.Data = minValue;
                node.Right = Delete(node.Right, minValue);
                return node;
            }
        }
    }

    public void Delete(T value)
    {
        root = Delete(root, value);
    }

    public bool Contains(T value)
    {
        return Search(value) != null;
    }

    private BinaryTreeNode<T> Search(BinaryTreeNode<T> node, T value)
    {
        if (node == null)
        {
            return null;
        }

        if (node.Data.CompareTo(value) > 0)
        {
            return Search(node.Left, value);
        }

        if (node.Data.CompareTo(value) < 0)
        {
            return Search(node.Right, value);
        }

        return node;
    }

    public BinaryTreeNode<T> Search(T value)
    {
        return Search(root, value);
    }

    public void PrintInorder()
    {
        PrintInOrder(root);
    }

    private void PrintInOrder(BinaryTreeNode<T> node)
    {
        if (node == null)
        {
            return;
        }

        PrintInOrder(node.Left);
        Console.WriteLine(node.Data);
        PrintInOrder(node.Right);
    }
}