using System;

namespace OOP_Laba3
{
    //Ячейка списка
    public class Item <T>
    {
        private T data = default(T); // Значение по умолчанию
        //Данные хранения в ячейке списка.
        public T Data
        {
            get => data;
            set
            {
                if (value != null)
                    data = value;
                else
                    throw new ArgumentNullException(nameof(value));
            }
        }
        //Следующая ячейка списка
        public Item<T> Next { get; set; }

        public Item(T data)
        {
            Data = data; //Проверка
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
