public abstract class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private TimeSpan _time;
    private Address _eventAddress;

    protected Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _eventAddress = address;
    }

    public string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {_time}\nAddress: {_eventAddress}";
    }

    public abstract string GetFullDetails();

    public string GetShortDescription()
    {
        return $"Type: {GetEventType()}\nTitle: {_title}\nDate: {_date.ToShortDateString()}";
    }

    protected abstract string GetEventType();
}
