namespace DAMLib
{
    public class Node<T>
    {
        public T Content { get; set; }
        private List<Node<T>> _children;
        private Node<T>? _parent { get; set; }
        public bool IsRoot => GetLevel() == 0;
        public bool IsLeaf => _children.Count == 0;
        public int ChildCount => _children.Count;
        public int Level => GetLevel();
        public Node<T> Root => _parent;
        public Node(T value)
        {
            Content = value;
            _children = new List<Node<T>>();
        }


        public int GetLevel()
        {
            if (_parent == null)
                return 0;
            return _parent.GetLevel() + 1;
        }
        //public Node<T> GetRooT()
        //{

        //}
        public Node<T>? GetChildrenAt(int index)
        {
            if (index < 0 || index >= _children.Count)
                return null;
            for (int i = 0; i < _children.Count; i++)
            {
                if()
                 return _children[i];
            }
            return null;
        }
        public void UnLink()
        {
            if(_parent != null)
            _parent._children.Remove(this);
            _parent = null;
        }
        
        public void AddChild(Node<T> child)
        {
            if (child == null || child == this)
                return;
            child.UnLink();
            child._parent = this;
            _children.Add(child);
        }
        public void SetParent(Node<T> parent)
        {

        }
        public bool ContainsParent(Node<T> parent)
        {
            if(parent == null)
            return false;
            for(int i = 0; i < _children.Count;i++)
            {
                if(_children[i] == parent)
                    return true;
                if (_children[i].ContainsParent(parent))
                    return true;
            }
            return false;
        }
    }
}
