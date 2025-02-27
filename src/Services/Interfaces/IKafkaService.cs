using Confluent.Kafka;

namespace KafkaRetry.Job.Services.Interfaces
{
    public interface IKafkaService
    {
        IConsumer<string, string> BuildKafkaConsumer();
        IProducer<string, string> BuildKafkaProducer();
        IAdminClient BuildAdminClient();
    }
}