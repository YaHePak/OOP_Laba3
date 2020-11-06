using System;
using System.Collections;

namespace OOP_Laba3
{
    /// <summary>
    /// Односвязный список
    /// </summary>
    public class LinkedList<T> : IEnumerable
    {
        /// <summary>
        /// Первый элемент списка
        /// </summary>
        public Item<T> Head { get; private set; } //Может посмотреть, что является главным, но не можем извне его изменять
        /// <summary>
        /// Последний элемент списка
        /// </summary>
        public Item<T> Tail { get; private set; }
        /// <summary>
        /// Кол-во элементов в списке
        /// </summary>
        public int Count { get; private set; }
        /// <summary>
        /// Создать пустой список
        /// </summary>
        public LinkedList()
        {
            Clear();
        }
        /// <summary>
        /// Создать список с начальным элементом
        /// </summary>
        public  LinkedList(T data)
        {        
            SetHeadAndTail(data);
        }
        /// <summary>
        /// Добавить данные в конец списка
        /// </summary>
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
        /// <summary>
        /// Удалить первое вхождение данных в список
        /// </summary>
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
        }
        /// <summary>
        /// Добавить данные в начало списка
        /// </summary>

        public void AppendHead(T data)
        {
            var item = new Item<T>(data)
            {
                Next = Head
            };
            Head = item;
            Count++;
        }
        public void InsertAfter(T target, T data)
        {

        }
        /// <summary>
        /// Очистить список
        /// </summary>
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
        /// <summary>
        /// Получить перечесление всех элементов списка
        /// </summary>
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
