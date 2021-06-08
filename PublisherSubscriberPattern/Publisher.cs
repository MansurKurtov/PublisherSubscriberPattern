using System;

namespace PublisherSubscriberPattern
{
    public class Publisher<T> : IPublisher<T>
    {
        //publisher event  
        public event EventHandler<MessageArgument<T>> OnDataPublished;

        public void OnDataPublisher(MessageArgument<T> args)
        {
            var handler = OnDataPublished;
            if (handler != null)
                handler(this, args);
        }


        public void PublishData(T data)
        {
            MessageArgument<T> message = (MessageArgument<T>)Activator.CreateInstance(typeof(MessageArgument<T>), new object[] { data });
            OnDataPublisher(message);
        }
    }
}
