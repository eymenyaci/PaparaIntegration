namespace PaparaIntegration.Interfaces
{
    public interface IRedisService
    {
        T GetValue<T>(string keyName);
    }

}