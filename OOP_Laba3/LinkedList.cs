using System;
using System.Collections;

namespace OOP_Laba3
{
    //Односвязный список
    public class LinkedList<T> : IEnumerable
    {
        //Первый элемент списка
        public Item<T> Head { get; private set; } //Может посмотреть, что является главным, но не можем извне его изменять
        //Последний элемент списка
        public Item<T> Tail { get; private set; }
        //Кол-во элементов в списке
        public int Count { get; private set; }
        //Создать пустой список
        public LinkedList()
        {
            Clear();
        }
        //Создать список с начальным элементом
        public LinkedList(T data)
        {        
            SetHeadAndTail(data);
        }
        //Добавить данные в конец списка
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
        //Удалить первое вхождение данных в список
        public void Delete(T data)
        {
            if(Head != null)
            {
                if (Head.Data.Equals(data))
                {
                    Head = Head.Next;
                    Count--;
                    return;
                }

                var current = Head.Next;
                var previous = Head;

                while (current != null)
                {
                    if (current.Data.Equals(data)) // Equals - опперация сравнения
                    {
                        previous.Next = current.Next;
                        Count--;
                        return;
                    }

                    previous = current;
                    current = current.Next;
                }
            }
            else
            {
                SetHeadAndTail(data);
            }
        }
        //Добавить данные в начало списка

        public void AppendHead(T data)
        {
            var item = new Item<T>(data)
            {
                Next = Head
            };
            Head = item;
            Count++;
        }
        //Вставить данные после искомого значения
        public void InsertAfter(T target, T data)
        {
            if (Head != null)
            {
                var current = Head;
                while (current != null)
                {
                    if (current.Data.Equals(target))
                    {
                        var item = new Item<T>(data);
                        item.Next = current.Next;
                        current.Next = item;
                        Count--;
                        return;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }
            }
            else
            {
                // Нужно решить, если список пустой, то либо не добавлять ничего, либо вставить данные
            }
        }
        //Очистить список
        public void Clear()
        {
            Head = null; // Первый элемент списка
            Tail = null; // Последний эллемент списка
            Count = 0;
        }
        public void SetHeadAndTail(T data) //Создание отдельного метода, чтобы небыло дублирования кода
        {
            var item = new Item<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }
        //Получить перечесление всех элементов списка
        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
        public override string ToString()
        {
            return "Linked List " + Count + " элементов";
        }
    }
}