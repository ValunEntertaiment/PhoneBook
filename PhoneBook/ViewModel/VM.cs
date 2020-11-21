using System.Collections.Generic;

namespace PhoneBook.ViewModel
{
    public class VM
    {
        /// <summary>
        /// Коллекция номеров используемая в телефонной книге.
        /// </summary>
        public List<BaseCaller> PhoneBookItems = new List<BaseCaller>()
        {
            new Caller() { Title = "Папа", Phone = "1234567890", Image = "C:\\Users\\timva\\Desktop\\2K8V8nA-auU.jpg" },
            new Caller() { Title = "Мама", Phone = "0987654321", Image = "C:\\Users\\timva\\Desktop\\pingvin.png" },
            new Caller() { Title = "Алина", Phone = "89173580243", Image = "C:\\Users\\timva\\Desktop\\pingvin.png" }
        };
    }
}
