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
        public void Enqueue(int AddToQueue)         //for adding nodes in the queue
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
        public void Dequeue()                       //for removing nodes one by one from the queue
        {
            if (rear == null && front == null)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Console.WriteLine("Taken out "+front.data+" from the que");
                front = front.next;
            }
        }
        public void DequeueTotal()                       //for removing all the nodes one by one from the queue
        {
            if (rear == null && front == null)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
               while(front!= null)
                {
                    Console.WriteLine("Taken out " + front.data + " from the que");
                    front = front.next;
                }
            }
        }
        public void display()                       //Displaying the node of the queue
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
