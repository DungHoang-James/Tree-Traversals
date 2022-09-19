class Program
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int numberNode = int.Parse(Console.ReadLine());
        var listValue = (Console.ReadLine()).Split(" ");

        Node root = null;

        foreach (var value in listValue)
        {
            root = InsertNode(root, int.Parse(value.Trim()));
        }

        InOrder(root);
    }

    static void PreOrder(Node root)
    {
        Console.Write($"{root.Data} ");

        if (root.Left != null)
        {
            PreOrder(root.Left);
        }

        if (root.Right != null)
        {
            PreOrder(root.Right);
        }
    }

    static void InOrder(Node root)
    {
        if (root.Left != null)
        {
            InOrder(root.Left);
        }

        Console.Write($"{root.Data} ");

        if (root.Right != null)
        {
            InOrder(root.Right);
        }
    }

    static void PostOrder(Node root)
    {
        if (root.Left != null)
        {
            PostOrder(root.Left);
        }

        if (root.Right != null)
        {
            PostOrder(root.Right);
        }

        Console.Write($"{root.Data} ");
    }

    static Node InsertNode(Node root, int data)
    {
        if (root == null)
        {
            return new Node(data);
        }

        if (root.Data < data)
        {
            var right = InsertNode(root.Right, data);
            root.Right = right;
        }
        else
        {
            var left = InsertNode(root.Left, data);
            root.Left = left;
        }

        return root;
    }
}

public class Node
{
    public int Data { get; set; }
    public Node Left { get; set; }
    public Node Right { get; set; }

    public Node(int data)
    {
        Data = data;
        Left = null;
        Right = null;
    }
}