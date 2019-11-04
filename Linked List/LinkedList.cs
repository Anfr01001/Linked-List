using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List {
    class LinkedList<T> {

        public Node<T> head = null;

        /*
        *
        * a -> b -> c -> d -> null
        * 
        */

        //Lägg till först (längst till vänster)
        public void addFirst(T Value) {
            Node<T> tmp = head;

            Node<T> newNode = new Node<T>(Value);

            //eftersom (gammla head nu är ett steg framför blir den next node för nya)
            newNode.nextNode = head;
            // gör head till nya noden (första noden)
            head = newNode;
        }
        
        //Lägg till sist (längst till höger)
        public void addLast(T Value) {
            Node<T> tmp = head;

            Node<T> newNode = new Node<T>(Value);

            //hitta en innan sista
            while (tmp.nextNode != null) {
                tmp = tmp.nextNode;
            }

            tmp.nextNode = newNode;

        }

        public Node<T> RemoveFirst() {
            Node<T> ToRemove = head;

            //nya head =
            head = ToRemove.nextNode;

            return ToRemove;
        }

        public Node<T> RemoveLast() {
            Node<T> tmp = head; 

            //hitta en innan sista
            while (tmp.nextNode.nextNode != null) {
                tmp = tmp.nextNode;
            }

            tmp.nextNode = null;

            return tmp.nextNode;
        }

        public string FindValue(T value) {
            Node<T> tmp = head;

            while (tmp != null && !tmp.value.Equals(value)) {
                tmp = tmp.nextNode;
            }

            if (tmp != null && tmp.value.Equals(value)) {
                return "Värdet hittades och är " + value;
            } else {
                return "Värdet fanns ej";
            }
        }

        public T DeleteValue(T value) {
            Node<T> tmp = head;

            if (tmp.value.Equals(value)) {
                RemoveFirst();
            }

            while (tmp.nextNode != null && !tmp.value.Equals(value)) {
                tmp = tmp.nextNode;
            }

            if (tmp.nextNode != null && tmp.value.Equals(value)) {
                tmp.nextNode = tmp.nextNode.nextNode;
                Console.WriteLine("Värdet som var " + value + " är nu bortaget");
                return default;
            } else {
                Console.WriteLine("Värdet fanns ej");
                return default;
            }
        }



    }
}
