using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List {
    class Node<T> {

        public T value;

        //Get set metod för next node
        public Node<T> nextNode;

        //konstruktor 
        public Node(T Value) {
            this.value = Value;
            nextNode = null;
        }
    }
}
