using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace ConsoleSMS
{
    class Program
    {

        static void Main(string[] args)
        {
            // Find your Account Sid and Auth Token at twilio.com/console
            const string accountSid = "AC715d31f4d9f2159655177501663806ab";
            const string authToken = "b4ca0b7606ee6af782013d8a98ffb630";
            TwilioClient.Init(accountSid, authToken);

            var to = new PhoneNumber("+5511949620982");
            var message = MessageResource.Create(
                to,
                from: new PhoneNumber("(781) 361-9919"),
                body: "Hello World!");

            Console.WriteLine(message.Sid);
        }
    }
}
