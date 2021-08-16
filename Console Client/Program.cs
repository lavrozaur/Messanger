using System;
using Newtonsoft.Json;

namespace Messanger
{
    class Program
    {
        static void Main(string[] args)
        {
            Message msg = new Message("Pavel","Privet",DateTime.UtcNow);
            string output = JsonConvert.SerializeObject(msg);
            Console.WriteLine(output);
            Message deserializedMsg = JsonConvert.DeserializeObject<Message>(output);
            Console.WriteLine(deserializedMsg);
            //{ "UserName":"Pavel","MessageText":"Privet","TimeStamp":"2021-08-15T10:44:07.5976314Z"}
           // Pavel < 15.08.2021 10:44:07 >: Privet

        }
    }
}
