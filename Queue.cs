using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_ad_Queue
{
    public class Queue
    {
        Node rear ;
        Node front ;
        public Queue()
        {
            this.rear = null;
            this.front = null;
        }
        public void Enqueue(int AddToQueue)
        {
            Node node = new Node(AddToQueue);
            if(front==null)
            {
                rear = node;
                front = rear;
                Console.WriteLine("Added the node " + rear.data + " to the queue");
            }
            else
            {
                rear.next = node;
                rear = rear.next;
                Console.WriteLine("Added the node " + rear.data + " to the queue");
            }
        }
        public void display()
        {
            if(rear==null&&front ==null)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Node temp = front;
                while(temp!=null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}
