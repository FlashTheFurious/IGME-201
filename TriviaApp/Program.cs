using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Web;

namespace TriviaApp
{

    class TriviaResult
    {
        public string category;
        public string type;
        public string difficulty;
        public string question;
        public string correct_answer;
        public List<string> incorrect_answers;
    }
    class Trivia
    {
        public int response_code;
        public List<TriviaResult> results;
    }
    //{"response_code":0,"results":[{"category":"Entertainment: Television","type":"boolean",
    //"difficulty":"medium","question":"The television show Doctor Who first aired in 1963.",
    //"correct_answer":"True","incorrect_answers":["False"]

    class Program
    {
        static void Main(string[] args)
        {
            string url = null;
            string s = null;

            HttpWebRequest request;
            HttpWebResponse response;
            StreamReader reader;

            url = "https://opentdb.com/api.php?amount=1&type=multiple";


            request = (HttpWebRequest)WebRequest.Create(url);
            response = (HttpWebResponse)request.GetResponse();
            reader = new StreamReader(response.GetResponseStream());
            s = reader.ReadToEnd();
            reader.Close();

            Trivia trivia = JsonConvert.DeserializeObject<Trivia>(s);

            trivia.results[0].question = HttpUtility.HtmlDecode(trivia.results[0].question);
            trivia.results[0].correct_answer = HttpUtility.HtmlDecode(trivia.results[0].correct_answer);

            for (int i = 0; i < trivia.results[0].incorrect_answers.Count; ++i)
            {
                trivia.results[0].incorrect_answers[i] = HttpUtility.HtmlDecode(trivia.results[0].incorrect_answers[i]);
            }


            Random random = new Random();

            if (trivia.results[0].type == "multiple")
            {
                Console.WriteLine(trivia.results[0].question);

                int answer_index = random.Next(0, 4);   // 3 incorrect answers, 1 correct answer
                int incorrect_cntr = 0;
                for (int i = 0; i < 4; i++)
                {
                    if (i == answer_index)
                    {
                        Console.WriteLine(i + 1 + ": " + trivia.results[0].correct_answer);
                    }
                    else
                    {
                        Console.WriteLine(i + 1 + ": " + trivia.results[0].incorrect_answers[incorrect_cntr]);
                        ++incorrect_cntr;
                    }

                }

                Console.WriteLine("Press the number of the correct answer");
                string sUserAnswer;
                Int32 nUserAnswer = 0;
                bool bValid = false;

                // Prompt user for the question and parse it into an int using sUserAnswer and nUserAnswer to store their response
                do
                {
                    sUserAnswer = Console.ReadLine();

                    try
                    {
                        nUserAnswer = int.Parse(sUserAnswer);
                        if (nUserAnswer == 1 || nUserAnswer == 2 || nUserAnswer == 3 || nUserAnswer == 4)
                        {
                            bValid = true;
                        }

                    }
                    catch
                    {
                        Console.WriteLine("Please enter a valid integer.");
                        bValid = false;
                    }
                } while (bValid == false);
                //} while (!bValid) ;


                if (nUserAnswer - 1 == answer_index)
                {
                    Console.WriteLine("Congrats!! You answered correctly");
                }
                else
                {
                    Console.WriteLine("Sorry, You answered Wrong... The correct answer is " + trivia.results[0].correct_answer);
                }

            }



        }
    }
}

