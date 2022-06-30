using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_ad_Queue
{
    internal class StackANDQueue
    {
        Node top;
        public StackANDQueue()
        {
            this.top = null;
        }
        public void push(int pushNode)
        {
            Node node = new Node(pushNode);
            if (top == null)
            {
                node.next = null; ;
            }
            else
            {
                node.next = top;
            }
            top = node;
            Console.WriteLine("Pushed nodewith data "+node.data);
        }
        public void print()
        {
            Node temp = top;
            while(temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }
}
