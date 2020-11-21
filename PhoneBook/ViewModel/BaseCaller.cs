namespace PhoneBook.ViewModel
{
    public abstract class BaseCaller
    {
        /// <value>
        /// Имя которое отображается в телефонной книге.
        /// </value>
        public string Title { get; set; }

        /// <value>
        /// Номер который отображается в телефонной книге.
        /// </value>
        public string Phone { get; set; }
        
        /// <value>
        /// Ссылка на аватарку которая отображается в телефонной книге.
        /// </value>
        public string Image { get; set; }

        /// <value>
        /// Описание которое отображается при просмотре сведений.
        /// </value>
        public string Description { get; set; }
    }
}
