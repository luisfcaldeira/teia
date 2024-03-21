namespace StringInfo.Domain
{
    public interface IStringCleaner
    {
        IStringCleaner SetNext(IStringCleaner stringCleaner);

        string Handle(string value);
    }
}
