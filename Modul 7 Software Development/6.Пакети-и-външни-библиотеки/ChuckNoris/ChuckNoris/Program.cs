using System;

namespace ChuckNoris
{
    public class Program
    {
        /// <summary>
        /// Get Chuck Norris Joke
        /// </summary>
        /// <returns></returns>
        public static async Task<string> GetJokeInJSON()
        {
            var client = new HttpClient();
            var response = await client.GetStringAsync("https://api.chucknorris.io/jokes/random");//URL
            return response;
        }
        public static void Main(string[] args)
        {
            var joke = GetJokeInJSON().Result;
            Console.WriteLine("JSON:");
            Console.WriteLine(joke);

            //JSON TO C#
            var obj = 
        }

    }
}