using Azure.Storage.Queues;
using System;

namespace QueueInsert
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Testing Test Branch
            CreateQueueClient("myqueue-items");
            Console.WriteLine("Hello World!");
        }

        private static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static void CreateQueueClient(string queueName)
        {
            string connectionString = "DefaultEndpointsProtocol=https;AccountName=cvejpdev;AccountKey=pmkCPAg0Jn+POws3rISYwgjETCqk5j+/ezvZlWWKfLTB+GOnpn4LuklE1ihrlkyhAtGkEv+pvHXWq00lDchW/g==;EndpointSuffix=core.windows.net";
            QueueClient queueClient = new QueueClient(connectionString, queueName);
           
            if (queueClient.Exists())
            {
                
                queueClient.SendMessage(Base64Encode("Hello World!"));
            }
        }
    }
}
