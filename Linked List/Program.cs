using System;

namespace Linked_List {
    class Program {
        static void Main(string[] args) {
            string input;

            LinkedList<string> Lista = new LinkedList<string>();

            Lista.addFirst("1");
            Lista.addFirst("2");
            Lista.addFirst("3");
            Lista.addFirst("4");
            Lista.addLast("5");
            Lista.addLast("6");
            Lista.addLast("7");
            Lista.addLast("8");


            //Test Skriv ut.
            


            Console.WriteLine("AF för AddFirst | AL för AddLast | RF för Delete first | RL för Delete Last | P för print | F för find | RV för delete value");

            input = Console.ReadLine();

            // En loop som låter en testa kön med kommandona 
            while (true) {
                switch (input) {
                    case "AF":
                        Console.WriteLine("Skriv in vad du vill lägga till");
                        Lista.addFirst(Console.ReadLine());
                        Console.WriteLine("Tillagd");
                        break;

                    case "AL":
                        Console.WriteLine("Skriv in vad du vill lägga till");
                        Lista.addLast(Console.ReadLine());
                        Console.WriteLine("Tillagd");
                        break;

                    case "RF":
                        Console.WriteLine("Tagit bort första elementet som var " + Lista.RemoveFirst().value);
                        break;

                    case "RL":
                        Console.WriteLine("Tagit bort sista elementet som var " + Lista.RemoveLast().value);
                        break;

                    case "F":
                        Console.WriteLine("Skriv in vad du vill hitta");
                        Console.WriteLine(Lista.FindValue(Console.ReadLine()));
                        break;

                    case "P":
                        Node<string> toPrint = Lista.head;
                        while (toPrint != null) {
                            Console.WriteLine(toPrint.value);
                            toPrint = toPrint.nextNode;
                        }
                        break;

                    case "RV":
                        Console.WriteLine("Skriv in det värdet du vill ta bort");
                        Console.WriteLine(Lista.DeleteValue(Console.ReadLine()));
                        break;

                    default:
                        Console.WriteLine("Det där är inget kommando!?!?!?!");
                        break;
                }

                input = Console.ReadLine();

            }

        }
    }
}

