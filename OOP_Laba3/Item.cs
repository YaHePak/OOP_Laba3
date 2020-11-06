using System;

namespace OOP_Laba3
{
    public class Item <T>
    {
        private T data = default(T); // Значение по умолчанию
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
