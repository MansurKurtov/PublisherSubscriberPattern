using System;

namespace PublisherSubscriberPattern
{
    /// <summary>
    /// MessageArgument class that represents a message that is published by a Publisher and is captured by an interested Subscriber
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MessageArgument<T> : EventArgs
    {
        public T Message { get; set; }
        public MessageArgument(T message)
        {
            Message = message;
        }
    }
}
