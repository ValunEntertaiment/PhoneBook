using System.Collections.Generic;

namespace PhoneBook.ViewModel
{
    class GoogleCaller : BaseCaller
    {
        enum Group {Famaly, Сolleagues, Friend, MyContacts, NotAssigned };

        enum Type {Home, Job, Main, Other };

        List<string> Phones = new List<string>();
    }
}
