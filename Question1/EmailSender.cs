namespace SimcorpInterview
{
    public class EmailSender
    {
        private EmailSender() { }
        public readonly static EmailSender Instance = new EmailSender();
        public void SendEmail(string message) { }
    }
}
