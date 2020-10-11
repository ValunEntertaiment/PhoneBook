namespace ControlLibrary
{
    public interface IPhoneBookItem
    {
        string Title { get; set; }

        string Phone { get; set; }

        string Image { get; set; }

        string Description { get; set; }
    }
}
