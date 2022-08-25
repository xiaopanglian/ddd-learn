namespace ddd_learn_service.interfaces
{
    public interface IPublisher
    {
        Task Publish<T>(T t);
    }
}
