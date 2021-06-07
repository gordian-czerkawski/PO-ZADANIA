using System;

namespace zad1l2
{
    public class IntStream
    {
      protected int value;

      public IntStream() //w konstruktorze ustawiam value na -1 zeby po wywolaniu next() otrzymac 0 i pozniej kolejne liczby naturalne
      {
        value = -1;
      }

      virtual public int next()
      {
        if (value == int.MaxValue)
          return -1;
        value++;
        return value;
      }

      virtual public bool eos() //sprawdzamy czy wartosc strumienia to juz wartosc maksymalna
      {
        if (value == int.MaxValue)
          return true;
        else
          return false;
      }

      virtual public void reset()
      {
        value = -1;
      }
    }





    public class PrimeStream : IntStream
    {

    public bool is_prime(long number) //funkcja sprawdza czy liczba jest pierwsza
      {
          if (number == 1) return false;
          if (number == 2) return true;
          if (number % 2 == 0) return false;

          for (int i = 3; i < number; i += 2)
          {
            if (number % i == 0) return false;
          }
          return true;
      }

      override public int next()
      {
        if (value == int.MaxValue)
          return -1;
        value++;
        while(is_prime(value) == false && value < int.MaxValue) //iterujemy po kolejnych liczbach i przerwyamy kiedy natrafimy na liczbe pierwsza
          value += 1;
        if (value == int.MaxValue)
          return -1;
        else
          return value;

      }
    }





    public class RandomStream : IntStream
    {
      Random rnd = new Random();

      public override int next() //losujemy zwracana liczbe
      {
        return rnd.Next(0, int.MaxValue);
      }

      public override bool eos() //eos zawsze flaszywy
      {
        return false;
      }
    }



    public class RandomWordStream
    {

      protected static PrimeStream len = new PrimeStream();
      protected int length;
      protected RandomStream random = new RandomStream();
      protected string str;


      public string next()
      {
        str = null; //zereujemy string, bo chcemy zeby za kazdym razem byl nowy
        length = len.next(); //dlugosc str, kolejne liczby pierwsze
        int ran = random.next();
        string chars = "abcdefghijklmnopqrstuvwxyz";
        for (int i = 0; i < length; i++)
        {
          str += chars[ran%26]; //reszte z dzielenia 26 bo tyle znakow ma 'char'
          ran = random.next();
        }
        return str;
      }

      public bool eos()
      {
        if (length == int.MaxValue)
          return true;
        else
          return false;
      }

      virtual public void reset()
      {
        len.reset();
        str = null;
      }
    }


    class Testy {
        public static void Main(string[] args)
        {
          System.Console.WriteLine("\nIntStream");
          IntStream inst = new IntStream();
          System.Console.WriteLine(inst.next());
          System.Console.WriteLine(inst.next());
          System.Console.WriteLine(inst.next());
          System.Console.WriteLine(inst.eos());
          inst.reset();
          System.Console.WriteLine(inst.next());
          System.Console.WriteLine(inst.next());

          System.Console.WriteLine("\nPrimeStream");
          PrimeStream ps = new PrimeStream();
          System.Console.WriteLine(ps.next());
          System.Console.WriteLine(ps.next());
          System.Console.WriteLine(ps.next());
          System.Console.WriteLine(ps.eos());
          ps.reset();
          System.Console.WriteLine(ps.next());
          System.Console.WriteLine(ps.next());

          System.Console.WriteLine("\nRandomStream");
          RandomStream rs = new RandomStream();
          System.Console.WriteLine(rs.next());
          System.Console.WriteLine(rs.next());
          System.Console.WriteLine(rs.next());
          System.Console.WriteLine(rs.eos());
          rs.reset();
          System.Console.WriteLine(rs.next());
          System.Console.WriteLine(rs.next());

          System.Console.WriteLine("\nRandomWordStream");
          RandomWordStream rws = new RandomWordStream();
          System.Console.WriteLine(rws.next());
          System.Console.WriteLine(rws.next());
          System.Console.WriteLine(rws.next());
          System.Console.WriteLine(rws.eos());
          rws.reset();
          System.Console.WriteLine(rws.next());
          System.Console.WriteLine(rws.next());
          System.Console.WriteLine(rws.next());
          Console.ReadKey();
        }
    }
}
