using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List {
    class Node {

        public string value;

        //Get set metod för next node
        public Node nextNode;

        //konstruktor 
        public Node(string Value) {
            this.value = Value;
            nextNode = null;
        }
    }
}
