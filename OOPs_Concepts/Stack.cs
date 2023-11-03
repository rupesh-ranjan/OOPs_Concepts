using System.Collections;

namespace OOPs_Concepts
{
    public class Stack
    {
        private readonly ArrayList _list;
        private int _count;
        public Stack()
        {
            _list = new ArrayList();
            _count = -1;
        }
        public void Push(object obj)
        {
            if (obj != null)
            {
                _list.Add(obj);
                _count += 1;
            }
            else
                throw new InvalidOperationException();
        }
        public object Pop()
        {
            if (_count > -1)
            {
                var result = _list[_count];
                _list.RemoveAt(_count);
                _count -= 1;
                return result;
            }
            else
                throw new InvalidOperationException();

        }
        public void Clear()
        {
            if (_count > -1)
            {

                _list.Clear();
                _count = 0;
            }
            else
                throw new InvalidOperationException();
        }
    }

}