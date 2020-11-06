using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Laba3
{
    public class Item <A>
    {
        private A data = default(A); // Значение по умолчанию
        public A Data
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
        public Item<A> Next { get; set; }

        public Item(A data)
        {
            Data = data; //Проверка
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
