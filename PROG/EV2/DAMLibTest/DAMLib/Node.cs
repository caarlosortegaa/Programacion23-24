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
        public Node<T> Root => _parent;
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
        public List<Node<T>>? Checker(CheckDelegate<T> check)
        {
            List<Node<T>> result = new List<Node<T>>();

            if (check == null)
                return null;
            if(check(this))
                result.Add(this);
            Checker2(check, result);

            return result;
            
        }
        private void Checker2(CheckDelegate<T> check, List<Node<T>> list)
        {
            for(int i = 0; i < _children.Count; i++)
            {
                if (check(_children[i]))
                    list.Add(_children[i]);
                _children[i].Checker2(check, list);
            }
        }
        public Node<T>? Checker3(CheckDelegate<T> check)
        {
            if (check == null)
                return null;

            if(check(this))
                return this;
            
            for(int i = 0; i < _children.Count;i++)
            {
                Node<T>? node = _children[i].Checker3(check);
                if(node != null)
                    return node;
                
            }
            return null;
        }
       
        


    }
}
