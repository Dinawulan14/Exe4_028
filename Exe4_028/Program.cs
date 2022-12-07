using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe4_028
{
    class Program
    {
        //dimana 48 merupakan hasil dari 7+28+1+2x10-10
        //didefinisikan array dengan ukuran maksimum 48
        private int[] dina = new int[46];
        //variabel ukuran array
        private decimal n;
        //Fungsi/Method untuk menerima masukan
        public void read()
        {
            //menerima angka untuk menentukan banyak data yang disimpan dalam array
            while (true)
            {
                Console.Write("Masukkan banyaknya elemen pada Array : ");
                //string s untuk terbaca
                string s = Console.ReadLine();
                //Parse untuk mengubah dalam bentuk desimal
                n = Int32.Parse(s);
                //pengambil keputusan
                //jika kurang dari 46 maka akan dilanjutkan
                if (n <= 46)
                    break;
                //jika lebih dari 46 maka akan muncul pernyataan maksimum elemen
                else
                    Console.WriteLine("\nArray maksimum elemen 46.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("-------------------");
            Console.WriteLine("Masukkan elemen Array");
            Console.WriteLine("");
            //code memasukkan elemen array
            for (int i = 0; i < dina.Length; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                dina[i] = (int)decimal.Parse(s1);
            }
        }
        public void display()
        {
            //menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("---------------------");
            Console.WriteLine("Element array yang telah terusun");
            Console.WriteLine("----------------------------");
            //menggunakan perulangan for akan mengulangi sampai perulangan tersebut sama dengan jumlah data
            for (int dina = 0; dina < n; dina++)
            {
                Console.WriteLine((Convert.ToDecimal(dina)).ToString());
            }
            Console.WriteLine("");
        }

        class Node
        {
            public int Info;
            public Node next;
            public Node(int i, Node n)
            {
                Info = i;
                next = n;
            }
        }

        class Stacks
        {
            Node top;

            public Stacks()
            {
                top = null;
            }

            bool empty()
            {
                if (top == null)
                    return (true);
                else
                    return (false);
            }

            public void push(int element)
            {
                Node fresh;
                fresh = new Node(element, null);

                fresh.next = top;
                top = fresh;
                Console.WriteLine("\n" + element + "pushed."); 
            }

            public void pop()
            {
                Console.WriteLine("\nThe popped element is: " + top.Info);
                top = top.next; //Make top point to the next node in sequence
            }

            public void display()
            {
                Node tmp;
                if (empty()) //if stack is empty
                    Console.WriteLine("\nStack Empty");
                else
                {
                    //Traverse the list from begginning till end
                    for (tmp = top; tmp != null; tmp = tmp.next)
                    {
                        Console.WriteLine(tmp.Info);
                    }
                    Console.WriteLine();
                }
            }
            static void Main(string[] args)
            {
                Stacks s = new Stacks();
                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("\n***Stack Menu***\n");
                    Console.WriteLine("1. Push.");
                    Console.WriteLine("2. Pop.");
                    Console.WriteLine("3. Display");
                    Console.WriteLine("4. Exit");
                    Console.Write("\nEnter your choice: ");
                    string sInput = Console.ReadLine();
                    char ch = Convert.ToChar(sInput == "" ? "0" : sInput);
                    switch (ch)
                    {
                        case '1':
                            Console.Write("\nEnter a number: ");
                            decimal num = Convert.ToDecimal(Console.ReadLine());
                            s.push(num);
                            break;
                        case '2':
                            if (s.empty())
                            {
                                Console.WriteLine("\nStack Empty");
                                break;
                            }
                            s.pop();
                            break;
                        case '3':
                            s.display();
                            break;
                        case '4':
                            return;
                        default:
                            Console.WriteLine("\nInvalid Choice");
                            break;
                    }
                }
            }
        }
    }
}