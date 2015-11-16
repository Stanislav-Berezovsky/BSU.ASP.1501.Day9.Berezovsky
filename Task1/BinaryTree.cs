using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class BinaryTree<T>:IEnumerable<T>
    {
        public class TreeNode<T>
        {
            public T Value { get; set; }
            public TreeNode<T> Right { get; set; }
            public TreeNode<T> Left { get; set; }
            public TreeNode(T value)
            {
                this.Value = value;
            }
        }
        private TreeNode<T> root;
        public int Count { get; private set; }
        public IComparer<T> Comparer;
        public BinaryTree()
            : this(Comparer<T>.Default) { }

        public BinaryTree(IComparer<T> comparer)
        {
            if (comparer == null)
                throw new ArgumentNullException();
            this.Comparer = comparer;
        }
        public void Insert(T element)
        {
            var node = new TreeNode<T>(element);
            TreeNode<T> nodeParent = null;
            var nodeTemp = root;
            // Пока ещё есть вершины которые надо просмотреть, то 
            // есть пока мы не добрались до “листочков” дерева
            while (nodeTemp != null)
            {
                nodeParent = nodeTemp;
                 //Если ключ вершины, которую мы хотим вставить, 
                 // меньше ключа текущей вершины     
                if (Comparer.Compare(node.Value, nodeTemp.Value) == -1)
                {
                    nodeTemp = nodeTemp.Left; //То он должен быть в его левом поддереве
                }
                else
                {
                    nodeTemp = nodeTemp.Right;//иначе в правом
                }
            }
            if (nodeParent == null)// Если в дереве ещё нет вершин
            {
                root = node;// То добавить первую
            }
            else
            {
                // Если ключ вершины, которую мы хотим вставить, 
                // меньше ключа вершины, потомком которой должна стать 
                // вставляемая вершина
                if (Comparer.Compare(node.Value, nodeParent.Value) == -1)
                {
                    nodeParent.Left = node;// То добавить в дерево как левого потомка
                }
                else
                {
                    nodeParent.Right = node;// Иначе добавить в дерево как правого потомка
                }
            }
            Count++;
        }


        public void Delete(T element)
        {
            var node = new TreeNode<T>(element);
        }



        public IEnumerator<T> GetEnumerator()
        {
            return Inorder(root).GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerable<T> Preorder()
        {
            return Preorder(root);
        }

        public IEnumerable<T> Inorder()
        {
            return Inorder(root);
        }

        public IEnumerable<T> Postorder()
        {
            return Postorder(root);
        }
        private IEnumerable<T> Preorder(TreeNode<T> node)
        {
            if (node == null)
                yield break;
            yield return node.Value;
            foreach (var e in Preorder(node.Left))
                yield return e;

            foreach (var e in Preorder(node.Right))
                yield return e;
        }

        private IEnumerable<T> Inorder(TreeNode<T> node)
        {
            if (node == null)
                yield break;
            foreach (var e in Preorder(node.Left))
                yield return e;
            yield return node.Value;
            foreach (var e in Preorder(node.Right))
                yield return e;
        }

        private IEnumerable<T> Postorder(TreeNode<T> node)
        {
            if (node == null)
                yield break;
            foreach (var e in Preorder(node.Left))
                yield return e;
            foreach (var e in Preorder(node.Right))
                yield return e;
            yield return node.Value;
        } 
    }
}
