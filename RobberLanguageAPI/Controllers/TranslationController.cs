using Microsoft.AspNetCore.Mvc;
using RobberLanguageAPI.Model;

namespace RobberLanguageAPI.Controllers
{
    [Route("api/RobberLanguage")]
    [ApiController]
    public class TranslationController : ControllerBase
    {
        [Route("CreateTranslation")]
        [HttpPost]
        public Translation Translate(string sentence)
        {
            return new Translation()
            {
                OriginalSentence = sentence,
                TranslatedSentence = TranslateSentence(sentence),
            };
        }

        private static string TranslateSentence(string sentence)
        {
            const string consonants = "bcdfghjklmnpqrstvwxz";
            string newSentence = sentence;

            foreach (var consonant in consonants)
            {
                string c = Convert.ToString(consonant);
                newSentence = newSentence.Replace(c, $"{c}o{c}");
            }

            return newSentence;
        }
    }
}
