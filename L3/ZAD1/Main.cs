using System;

namespace zad1l3{
  public class Node<T>
    {
        public T value;
        public Node<T> next;

        public Node()
        {
            next = null;
            value = default(T);
        }
    }


  public class Lista<T>
  {
  public Node<T> first;

  public Lista()
  {
    first = null;
  }

  public bool IsEmpty()
        {
          if (first == null)
            return true;
          else
            return false;
        }

  public void push_front(T elem)
  {
    if (first == null) //gdy lista jest pusta
    {
        first = new Node<T>();
        first.value = elem;
    }
    else
    {
        Node<T>  n = new Node<T>();
        n.value = elem;
        n.next = first;
        first = n;
    }
  }

    public void push_end(T elem)
        {
            if (first == null) //gdy lista jest pusta
            {
                first = new Node<T>();
                first.value = elem;
            }
            else
            {
                Node<T> n = new Node<T>();
                n.value = elem;
                if (first.next == null)
                {
                    first.next = n;
                }
                else
                {
                    Node<T> temp = first;
                    while (temp.next != null)
                    {
                      temp = temp.next;
                    }
                    temp.next = n;
                }
            }
        }
        public T pop_front()
         {
             if (first == null) //gdy lista jest pusta
             {
                 Console.WriteLine("Lista pusta!");
                 return default(T);
             }
             else
             {
                 T temp = first.value;
                 first = first.next;
                 return temp;
             }
         }

         public T pop_back()
          {
              T tempval;
              Node<T> temp = first;

              if (first == null) //gdy lista jest pusta
              {
                  Console.WriteLine("Lista pusta");
                  return default(T);
              }
              else
              {
                  if (temp.next == null)
                  {
                      tempval = temp.value;
                      temp = null;
                      return tempval;
                  }
                  while (temp.next.next != null)
                  {
                      temp = temp.next;
                  }
                  tempval = temp.next.value;
                  temp.next = null;
                  return tempval;
              }
          }
      }



      class Testy
       {
           static void Main(string[] args)
           {
               Lista<int> obiekt = new Lista<int>();
               Console.WriteLine("TEST");
               Console.WriteLine("Wynik wywolania IsEmpty dla pustej:");
               Console.WriteLine(obiekt.IsEmpty());
               Console.WriteLine("Dodajemy 7 na koniec");
               obiekt.push_front(7);
               Console.WriteLine("Dodajemy 3 na koniec");
               obiekt.push_end(3);
               Console.WriteLine("Dodajemy 1 na poczatek");
               obiekt.push_front(1);
               Console.WriteLine("Dodajemy 15 na poczatek");
               obiekt.push_front(15);
               Console.WriteLine("Dodajemy 4 na koniec");
               obiekt.push_end(4);
               Console.WriteLine("Wynik wywolania IsEmpty niepustej:");
               Console.WriteLine(obiekt.IsEmpty());
               Console.WriteLine("Usuwamy 1. element");
               Console.WriteLine(obiekt.pop_front());
               Console.WriteLine("Usuwamy ostatni element");
               Console.WriteLine(obiekt.pop_back());
           }
       }
}
