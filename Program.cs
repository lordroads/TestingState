using System;
using System.Linq;

namespace TestingState
{
    class Program
    {
        static void Main(string[] args)
        {

            ITest _questions = Tested.GetInstance();
            int input = 0;
            bool nextQuestion = false;
            int result = 0;
            int numberQuestion = 1;

            foreach (var item in _questions.GetQuestions())
            {
                Console.WriteLine(new string('-', 50));
                Console.WriteLine($"{numberQuestion++}) {item.TitleQuestion}");
                Console.WriteLine();
                Console.WriteLine(string.Join("\n",item.TitleAnswers.Select((item,index) => $"{index+1} {item}")));
                
                while(!nextQuestion){
                    var newResult = Assistant.GetInputResult(Console.ReadLine(), item.TitleAnswers.Count);
                    nextQuestion = newResult.nextQuestion;
                    input = newResult.inputResult;
                }
                nextQuestion = false;
                result += item.AnswerPoints[input];               
            }
            
            Assistant.ViewResult(result);
        }

        
    }
}
