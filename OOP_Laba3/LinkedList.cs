using System;

namespace OOP_Laba3
{
    public class LinkedList<T>
    {
        public Item<T> Head { get; private set; } //Может посмотреть, что является главным, но не можем извне его изменять
        public Item<T> Tail { get; private set; }
        public int Count { get; private set; }

        public LinkedList()
        {
            Head = null; // Первый элемент списка
            Tail = null; // Последний эллемент списка
            Count = 0;
        }
        public  LinkedList(T data)
        {        
            SetHeadAndTail(data);
        }
        
        public void Add(T data)
        {

            if(Tail != null)
            {
                var item = new Item<T>(data);
                Tail.Next = item;
                Tail = item;
                Count++;
            }
            else
            {
                SetHeadAndTail(data);
            }
        }
        public void SetHeadAndTail(T data) //Создание отдельного метода, чтобы небыло дублирования кода
        {
            var item = new Item<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }
    }
}
