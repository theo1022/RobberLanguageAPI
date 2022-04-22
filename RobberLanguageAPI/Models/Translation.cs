namespace RobberLanguageAPI.Model
{
    public class Translation
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
        public string OriginalSentence { get; set; }
        public string TranslatedSentence { get; set; }
    }
}
