using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List {
    class LinkedList {

        public Node head = null;

        /*
        *
        * a -> b -> c -> d -> null
        * 
        */

        //Lägg till först (längst till vänster)
        public void addFirst(string Value) {
            Node tmp = head;

            Node newNode = new Node(Value);

            //eftersom (gammla head nu är ett steg framför blir den next node för nya)
            newNode.nextNode = head;
            // gör head till nya noden (första noden)
            head = newNode;
        }
        
        //Lägg till sist (längst till höger)
        public void addLast(string Value) {
            Node tmp = head;

            Node newNode = new Node(Value);

            //hitta en innan sista
            while (tmp.nextNode != null) {
                tmp = tmp.nextNode;
            }

            tmp.nextNode = newNode;

        }

        public Node RemoveFirst() {
            Node ToRemove = head;

            //nya head =
            head = ToRemove.nextNode;

            return ToRemove;
        }

        public Node RemoveLast() {
            Node tmp = head; 

            //hitta en innan sista
            while (tmp.nextNode.nextNode != null) {
                tmp = tmp.nextNode;
            }

            tmp.nextNode = null;

            return tmp.nextNode;
        }

        public string FindValue(string value) {
            Node tmp = head;

            while (tmp != null && tmp.value != value) {
                tmp = tmp.nextNode;
            }

            if (tmp != null && tmp.value == value) {
                return "Värdet hittades och är " + value;
            } else {
                return "Värdet fanns ej";
            }
        }

        public string DeleteValue(string value) {
            Node tmp = head;

            if (tmp.value == value) {
                RemoveFirst();
            }

            while (tmp.nextNode != null && tmp.nextNode.value != value) {
                tmp = tmp.nextNode;
            }

            if (tmp.nextNode != null && tmp.nextNode.value == value) {
                tmp.nextNode = tmp.nextNode.nextNode;
                return "Värdet som var " + value + " är nu bortaget";
            } else {
                return "Värdet fanns ej";
            }
        }



    }
}
