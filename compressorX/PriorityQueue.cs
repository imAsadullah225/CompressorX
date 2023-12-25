using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compressorX
{
    class PriorityQueue
    {
        private List<Node> list;
        public int Count { get { return list.Count; } }

        public PriorityQueue()
        {
            list = new List<Node>(); 
        }

        public void Enqueue(Node x)
        {
            list.Add(x);

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[i].frequency < list[j].frequency)
                    {
                        Node temp;

                        temp = list[j];
                        list[j] = list[i];
                        list[i] = temp;
                    }
                }
            }
        }

        public Node Dequeue()
        {
            Node target = Peek();
            list.RemoveAt(0);
            return target;
        }

        public Node Peek()
        {
            if (Count == 0) throw new InvalidOperationException("Queue is empty.");
            return list[0];
        }

        public void Clear()
        {
            list.Clear();
        }
    }
}
