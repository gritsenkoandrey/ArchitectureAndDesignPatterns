using System;
using System.Net.Http;
using System.Threading.Tasks;


namespace Prototype_1
{
    class DocumentReader : ICloneable
    {
        private string stringContents;

        public DocumentReader(Uri uri)
        {
            HttpClient httpClient = new HttpClient();
            Task<string> contents = httpClient.GetStringAsync(uri);
            stringContents = contents.Result;
        }

        public int FindWord(string findWord)
        {
            return stringContents.IndexOf(findWord);
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}