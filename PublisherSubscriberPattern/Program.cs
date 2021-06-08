using System;

namespace PublisherSubscriberPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Publishers:
            var intDataPublisher = new Publisher<int>();
            var stringDataPublisher = new Publisher<string>();

            //Subscribers:
            var subscriber1 = new Subscriber<int>(intDataPublisher);
            var subscriber2 = new Subscriber<int>(intDataPublisher);
            var subscriber3 = new Subscriber<int>(intDataPublisher);

            var subscriber4 = new Subscriber<string>(stringDataPublisher);
            var subscriber5 = new Subscriber<string>(stringDataPublisher);

            //events:
            subscriber1.Publisher.OnDataPublished += Publisher_OnDataPublished;
            subscriber2.Publisher.OnDataPublished += Publisher_OnDataPublished1;
            subscriber3.Publisher.OnDataPublished += Publisher_OnDataPublished2;

            subscriber4.Publisher.OnDataPublished += Publisher_OnDataPublished3;
            subscriber5.Publisher.OnDataPublished += Publisher_OnDataPublished4;

            //publishing data:
            intDataPublisher.PublishData(200); intDataPublisher.PublishData(100);
            stringDataPublisher.PublishData("new message to the AVAST group");

            Console.ReadKey();
        }

        private static void Publisher_OnDataPublished4(object sender, MessageArgument<string> e)
        {
            Console.WriteLine("To Subscriber5 data coming:" + e.Message);
        }

        private static void Publisher_OnDataPublished3(object sender, MessageArgument<string> e)
        {
            Console.WriteLine("To Subscriber4 data coming:" + e.Message);
        }

        private static void Publisher_OnDataPublished2(object sender, MessageArgument<int> e)
        {
            Console.WriteLine("To Subscriber3 data coming:" + e.Message);
        }

        private static void Publisher_OnDataPublished1(object sender, MessageArgument<int> e)
        {
            Console.WriteLine("To Subscriber2 data coming:" + e.Message);
        }

        private static void Publisher_OnDataPublished(object sender, MessageArgument<int> e)
        {
            Console.WriteLine("To Subscriber1 data coming:"+e.Message);
        }
    }
}
