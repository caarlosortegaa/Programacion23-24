namespace DAMLib
{
    public delegate bool CheckDelegate <T>(Node<T> node);
    public class Node<T>
    {
        public T Content { get; set; }
        private List<Node<T>> _children;
        private Node<T> _parent {
            get
            {
                if(_parent == null)
                    return null;
                return _parent;
            } 
            set
            {
                SetParent(value);
                
            }
            }
        public bool IsRoot => _parent == null;
        public bool IsLeaf => _children.Count == 0 && _parent != null;
        public int ChildCount => _children.Count;
        public int Level => GetLevel();
        public bool Sibling => _parent._children .Count > 1;
        public Node<T> Root => GetRooT();
        public Node(T value)
        {
            Content = value;
            _children = new List<Node<T>>();
        }

        public Node<T>? GetParent()
        {
            if(_parent == null)
                return null;
            return _parent;
        }
        public int GetLevel()
        {
            if (_parent == null)
                return 0;
            return _parent.GetLevel() + 1;
        }
        public Node<T> GetRooT()
        {
            if (IsRoot)
                return this;
            return _parent.GetRooT();
        }
        public Node<T>? GetChildrenAt(int index)
        {
            if (index < 0 || index >= _children.Count)
                return null;
           return _children[index]; 
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
            if(parent == null)
                return;
            else
             parent.AddChild(this);
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
        public Node<T>? FindNode(CheckDelegate<T> check)
        {
            if (check == null)
                return null;

            if(check(this))
                return this;
            
            for(int i = 0; i < _children.Count;i++)
            {
                Node<T>? node = _children[i].FindNode(check);
                if(node != null)
                    return node;
                
            }
            return null;
        }
        public List<Node<T>> FindNodes(CheckDelegate<T> checker)
        {
            var list = new List<Node<T>>();
            if(checker == null)
                return list;
            FindNodes(checker, list);
            return list;
        }

        private void FindNodes(CheckDelegate<T> checker, List<Node<T>> list)
        {
            if(checker(this))
                list.Add(this);
            int n = ChildCount;
            for(int i = 0; i < n; i++)
                _children[i].FindNodes(checker, list);
        }

        public bool IsSibling(Node<T> node)
        {
            if (node == null || _parent == null)
                return false;
            if (this == node)
                return false;
            return _parent.ContainsParent(node);
        }


    }
}
