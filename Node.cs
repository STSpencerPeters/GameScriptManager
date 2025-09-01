using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Script_Manager
{
    public class Node
    {
        public int StoryNumber { get; set; }
        public string StoryText { get; set; }
        public Node? Next { get; set; }

        public Node (int number, string text)
        {
            StoryNumber = number;
            StoryText = text;
            Next = null;
        }
    }
}
