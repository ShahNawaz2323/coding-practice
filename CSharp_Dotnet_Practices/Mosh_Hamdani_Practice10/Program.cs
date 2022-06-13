using System;

namespace Mosh_Hamdani_Practice10
{
    class Program
    {
        static void Main(string[] args)
        {
            var workFlow = new WorkFlowEngine();
            workFlow.RegisterActivity(new UploadVideo());
            workFlow.RegisterActivity(new NotifyService());
            workFlow.RegisterActivity(new SendEmailToUser());
            workFlow.RegisterActivity(new ChangeVideoStatus());
        }
    }
}
