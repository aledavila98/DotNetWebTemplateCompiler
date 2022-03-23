namespace DotNetWeb.Core.Interfaces
{
    public interface IParser
    {
        void Parse();
        bool ValidateSemantic(string type);
    }
}