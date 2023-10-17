using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _17_10_23.Metods
{
    internal class ListInit
    {
        private int[] _list = new int[0];

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= _list.Length)
                    throw new IndexOutOfRangeException();
                return _list[index];
            }
            set
            {
                if (index >= 0 && index < _list.Length)
                    _list[index] = value;
                else
                    throw new IndexOutOfRangeException();
            }
        }

        public void Add(int num)
        {
            Array.Resize(ref _list, _list.Length + 1);
            _list[_list.Length - 1] = num;
        }

        public void AddRange(params int[] nums)
        {
            int originalLength = _list.Length;

            Array.Resize(ref _list, _list.Length + nums.Length );

            for (int i = 0; i < nums.Length; i++)
            {
                _list[originalLength + i] = nums[i];
            }
        }

        public bool Contains(int num)
        {
            foreach (int item in _list)
            {
                if (item == num)
                    return true;
            }

            return false;
        }

        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < _list.Length; i++)
            {
                sum += _list[i];
            }

            return sum;
        }

        public void Remove(int num)
        {
            int index = -1;
            for (int i = 0; i < _list.Length; i++)
            {
                if (_list[i] == num)
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                for (int i = index; i < _list.Length - 1; i++)
                {
                    _list[i] = _list[i + 1];
                }

                Array.Resize(ref _list, _list.Length - 1);
            }
        }

        public void RemoveRange(params int[] nums)
        {
            foreach (int num in nums)
            {
                int index = -1;
                for (int i = 0; i < _list.Length; i++)
                {
                    if (_list[i] == num)
                    {
                        index = i;
                        break;
                    }
                }
                if (index != -1)
                {
                    for (int i = index; i < _list.Length - 1; i++)
                    {
                        _list[i] = _list[i + 1];
                    }
                    Array.Resize(ref _list, _list.Length - 1);
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < _list.Length; ++i)
            {
                sb.Append(_list[i]);
                if (i < _list.Length - 1) { sb.Append(", "); }
            }
            return sb.ToString();
        }

    }
}



