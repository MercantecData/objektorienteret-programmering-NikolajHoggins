using System;
using System.Collections.Generic;

namespace Dictionaries_Library
{
    public class DictionaryStore
    {
        //This dictionary will return the interger value of a give number in string form (from 1-10)
        public Dictionary<string, int> numbers = new Dictionary<string, int>();
        
        //This dictionary will retun if a number is cool or not.
        public Dictionary<float, bool> isNice = new Dictionary<float, bool>();

        //This dictionary will get the nickname of given person.
        public Dictionary<Person, string> nicknames = new Dictionary<Person, string>();
    }
}
