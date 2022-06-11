namespace InterfacesPloy
{
     public class VideoEncoder
    {
        private readonly MailService _mailService;
        public VideoEncoder()
        {
            _mailService = new MailService();
        }
         public video Encode(Video video)
        {
            //Video encoding logicnn 
            //...
            _mailService.Send(new Mail());
        }
    }
}
