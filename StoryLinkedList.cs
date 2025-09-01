using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Script_Manager
{
    public class StoryLinkedList
    {
        public Node? Head { get; private set; }

        public void Add(int number, string text)
        {
            Node newNode = new Node(number, text);
            if(Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = newNode;
            }
        }

        public void Sort()
        {
            if (Head == null) return;

            bool swapped;
            do
            {
                swapped = false;
                Node? current = Head;
                while (current?.Next != null)
                {
                    if (current.StoryNumber > current.Next.StoryNumber)
                    {

                        (current.StoryNumber, current.Next.StoryNumber) = (current.Next.StoryNumber, current.StoryNumber);
                        (current.StoryText, current.Next.StoryText) = (current.Next.StoryText, current.StoryText);
                        swapped = true;
                    }
                    current = current.Next;
                }
            } while (swapped);
        }

        public List<string> ToList()
        {
            List<string> list = new();
            Node? current = Head;
            while(current != null)
            {
                list.Add($"{current.StoryNumber}: {current.StoryText}");
                current = current.Next;
            }
            return list;
        }
    }
}
