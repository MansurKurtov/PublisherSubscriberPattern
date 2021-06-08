using System;

namespace PublisherSubscriberPattern
{
    public interface IPublisher<T>
    {
        event EventHandler<MessageArgument<T>> OnDataPublished;
        void OnDataPublisher(MessageArgument<T> args);
        void PublishData(T data);
    }
}
