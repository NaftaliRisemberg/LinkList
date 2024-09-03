﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LinkList
{
    public class Node
    {
        public int Data;
        public int GetValue () { return Data; }
        public void SetValue (int value) {Data = value; }
       
        public Node Next;
        public Node GetNext () { return Next; }
        public void SetNext (Node value) {Next = value;}

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }
}
