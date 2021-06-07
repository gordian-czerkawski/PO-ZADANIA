using System;
using System.Collections.Generic;

namespace z4l2
{
  class LeniwaLista
  {
    protected int length;
    protected List<int> list;
    protected Random rnd;

    public LeniwaLista() {
            length = 0;
            list = new List<int>();
            rnd = new Random();
        }

      virtual public int element(int elem)
      {
        if(list.Count > elem-1) //czy lista ma juz tyle elementow
        {
            return list[elem-1];
        }
        else
        {
          for(int i=0; i<elem; i++)
          {
            if(list.Count <= i)
            {
              int liczba = rnd.Next(0,10000);
              list.Add(liczba);
            }
          }
          return list[elem-1];
        }
      }

    virtual public int size()
    {
      return length;
    }

  }



  class Pierwsze : LeniwaLista{

    private bool prime(int x){ //funkcja pomocnicza do sprawdzania czy liczba jest pierwsza
            if (x < 2)
                return false;
            for (int i = 2; i <= Math.Sqrt(x) && i < int.MaxValue; i++) {
                if (x % i == 0)
                    return false;
            }
            return true;
        }

    override public int element(int n)
    {
      if(list.Count >= n+1)
      {
          return list[n-1];
      }
      else
      {
        if (list.Count == 0)
        {
          list.Add(2);
        }
        int i = list[list.Count-1];
        while (list.Count < n)
        {
          i++;
          if (prime(i))
          {
            list.Add(i);
          }
        }
        return list[n-1];
        }
      }
  }




  class Testy {
        static void Main(string[] args) {

          Console.WriteLine("\nListaLeniwa :\n");
          LeniwaLista L1 = new LeniwaLista();
          Console.WriteLine("5 element listy to " + L1.element(5));
          Console.WriteLine("10 element listy to " + L1.element(10));
          Console.WriteLine("2 element listy to " + L1.element(2));
          Console.WriteLine("10 element listy to " + L1.element(10));
          Console.WriteLine("100 element listy to " + L1.element(100));
          Console.WriteLine("2 element listy to " + L1.element(2));

          Console.WriteLine("\nPierwsze :\n");
          Pierwsze L2 = new Pierwsze();
          Console.WriteLine("1 element listy to " + L2.element(1));
          Console.WriteLine("2 element listy to " + L2.element(2));
          Console.WriteLine("3 element listy to " + L2.element(3));
          Console.WriteLine("2 element listy to " + L2.element(2));
          Console.WriteLine("5 element listy to " + L2.element(5));
          Console.WriteLine("6 element listy to " + L2.element(6));
          Console.WriteLine("2 element listy to " + L2.element(2));
          Console.WriteLine("5 element listy to " + L2.element(5));
          Console.WriteLine("10 element listy to " + L2.element(10));
          Console.WriteLine("2 element listy to " + L2.element(2));
          Console.WriteLine("3 element listy to " + L2.element(3));
          Console.WriteLine("10 element listy to " + L2.element(10));
          Console.WriteLine("100 element listy to " + L2.element(100));
          Console.WriteLine("5 element listy to " + L2.element(5));
        }

    }
}
