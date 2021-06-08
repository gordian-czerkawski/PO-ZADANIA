using System;


namespace z2l3
{
    public class slownik<K, V> where K : IComparable<K>
    {
        slownik<K, V> next;
        protected K key;
        protected V val;

        public slownik()
        {
            next = null;
            key = default(K);
            val = default(V);
        }

        public void Add(K key, V val)
        {
            if (this.next != null)
            {
                this.next.Add(key, val); //dochodzimy rekurencyjnie na koniec slownika
            }
            else
            {
                this.next = new slownik<K, V>();
                this.next.key = key;
                this.next.val = val;
            }

        }
        public void Delete(K key)
        {
            if (key.CompareTo(this.next.key) == 0) //nastepny to klucz ktory chcemy usunac
            {
                this.next = this.next.next;
            }
            else
            {
                if (this.next != null)
                    this.next.Delete(key); //przechodzimy dalej rekurencyjnie
            }
        }

        public V Find(K key)
        {
            slownik<K, V> current = this;
            while (key.CompareTo(current.key) != 0) //wychodzimy z petli gdy current to szukane haslo
            {
                current = current.next;
                if (current == null)
                    return default(V);
            }
            return current.val;

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var Dictionary = new slownik<int, string>();
            Dictionary.Add(53, "pies");
            Dictionary.Add(65, "kot");
            Dictionary.Add(79, "owca");
            Dictionary.Delete(53);
            System.Console.WriteLine(Dictionary.Find(53));
            System.Console.WriteLine(Dictionary.Find(65));
            System.Console.WriteLine(Dictionary.Find(79));
        }
    }
}
