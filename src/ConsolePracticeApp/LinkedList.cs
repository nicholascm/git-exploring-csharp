using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsolePracticeApp
{
    public class LinkedList
    {
        private Node head;
        private Node current;
        public int Count;

        public LinkedList()
        {
            head = new Node();
            current = head;
        }
        public void AddAtLast(object data)
        {
            Node newNode = new Node();
            newNode.value = data;
            current.next = newNode;
            current = newNode;
            Count++; 
        }

        public void AddAtStart(object data)
        {
            Node newNode = new Node();
            newNode.value = data;
            newNode.next = head.next;
            head.next = newNode;
        }
        public void RemoveFromStart()
        {
            if(Count > 0)
            {
                head.next = head.next.next;
                Count--; 
            }
        }

        public void PrintAllNodes()
        {
            Console.Write("Head -> ");
            Node curr = head; 
            while (curr.next != null)
            {
                curr = curr.next;
                Console.Write(curr.value);
                Console.Write("->"); 
            }
            Console.Write("NULL"); 
        }

        public void RemoveLastNode()
        {
            Node curr = head; 
            while(curr.next != null)
            {
                Node tmp = curr;
                curr = curr.next; 
                if(curr.next == null)
                {
                    tmp.next = null; 
                }
            }
        }

        public void RemoveAtPostion(int position)
        {
            Node curr = head;
            Node prev = curr; 
            int index = 0; 
            while (curr.next != null)
            {
                if (index == position)
                {
                    prev.next = curr.next; 
                }
                index++;
                prev = curr;
                curr = curr.next;
            }
        }

        public Node addAtPosition(int position, object data)
        {
            Node curr = head;
            int count = 0;
            Node newNode = new Node();
            newNode.value = data;
            if (head == null)
            {
                return newNode; 
            }
            else
            {
                while(curr.next != null)
                {
                    if (position == count)
                    {
                        newNode.next = curr.next;
                        curr.next = newNode; 
                    }

                }
                return head;
            }
        }
    }
}
