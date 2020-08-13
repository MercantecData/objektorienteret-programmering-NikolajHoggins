using System;
using System.Text.RegularExpressions;

namespace Fremlæggelse_Library
{
    public class JokeDisplayHelper
    {        
        public delegate string ReturnRaw(string joke);
        public delegate string ReturnPresented(string joke, string presentation = "");
        public delegate string ReturnReplacedWords(string joke, string wordToReplace, string wordToInsert);

        //Lambda med implicit return
        public static ReturnRaw raw = joke => joke;

        public static ReturnPresented presented = (joke, presentation) => 
            (presentation != "" ? presentation.Trim() + " " : "The joke is: ") + joke;

        //This is a lambda that takes more than one parameter
        public static ReturnReplacedWords replacedWords = (joke, wordToReplace, wordToInsert) =>
        {
            //Flere linjer kode i en lambda!
            return Regex.Replace(joke, wordToReplace, wordToInsert);
        };
        
    }
}