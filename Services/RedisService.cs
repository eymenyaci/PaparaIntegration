namespace PaparaIntegration.Services
{
    using StackExchange.Redis;
    using System.Text.Json;
    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Configuration;
    using PaparaIntegration.Interfaces;

    public class RedisService : IRedisService
    {
        private readonly IDatabase _db;
        private readonly ILogger<RedisService> _logger;

        public RedisService(IConfiguration configuration, ILogger<RedisService> logger)
        {
            _logger = logger;

            try
            {
                var redisConnectionString = configuration.GetConnectionString("Redis");
                if (string.IsNullOrEmpty(redisConnectionString))
                {
                    throw new ArgumentException("Redis bağlantı dizesi eksik veya hatalı.");
                }

                var redis = ConnectionMultiplexer.Connect(redisConnectionString);
                _db = redis.GetDatabase();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Redis'e bağlanırken hata oluştu: {ex.Message}");
                throw;
            }
        }

        public T GetValue<T>(string keyName)
        {
            try
            {
                string apiKeyJson = _db.StringGet("Configurations");
                if (!string.IsNullOrEmpty(apiKeyJson))
                {
                    var apiKeys = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(apiKeyJson);

                    if (apiKeys != null && apiKeys.TryGetValue(keyName, out var value))
                    {
                        if (typeof(T) == typeof(string) && value.ValueKind == JsonValueKind.String)
                        {
                            return (T)(object)value.GetString();
                        }
                        else if (typeof(T) == typeof(int) && value.ValueKind == JsonValueKind.Number)
                        {
                            return (T)(object)value.GetInt32();
                        }
                        else if (typeof(T) == typeof(bool) && value.ValueKind == JsonValueKind.True || value.ValueKind == JsonValueKind.False)
                        {
                            return (T)(object)value.GetBoolean();
                        }
                        else
                        {
                            throw new InvalidCastException($"'{keyName}' anahtarının değeri belirtilen türe dönüştürülemedi.");
                        }
                    }
                }
                _logger.LogWarning($"'{keyName}' anahtarı Redis'te bulunamadı.");
                return default;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Anahtar alınırken hata oluştu: {ex.Message}");
                return default;
            }
        }


    }


}