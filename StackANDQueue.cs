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
        public void pop()                   //single node is poped
        {
            Node temp = top;
            if (top != null)
            {
                Console.WriteLine("Data of the poped node is " + temp.data);
                top = temp.next;
            }
            else
                Console.WriteLine("Stack is empty");
        }
        public void fullpop()                       //pop function till the statck is empty
        {
            while (top != null)
            {
                Node temp = top;
                Console.WriteLine("Data of the poped node is " + top.data);
                top = temp.next;
            }
                Console.WriteLine("Stack is empty");
        }
        public void peek()                  //gives the top most node data without popping it
        {
            if(this.top!=null)
            {
                Console.WriteLine("top element is "+top.data);
            }
            else
                Console.WriteLine("Stack is empty");
        }
        public void empty()                 //To check if the stackis empty
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            else
                Console.WriteLine("Stack is not empty");
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
