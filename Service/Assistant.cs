namespace TestingState
{
    static class Assistant
    {
        public static (int inputResult, bool nextQuestion) GetInputResult(string input, int countAnswers){
            int inputResult = 0;
            bool nextQuestion = false;
            if (int.TryParse(input, out inputResult))
                {
                    if (inputResult <= countAnswers & inputResult > 0)
                    {
                        nextQuestion = true;
                    }
                    else{
                        nextQuestion = false;
                    }
                }  
            
            return (inputResult, nextQuestion);
        }

        public static void ViewResult(int result){
            Answer _answer = Responses.GetInstance().GetAnswerOfResult(result);
            System.Console.WriteLine();
            System.Console.WriteLine($"Твой результат - {result}, результат начинается с {_answer.numberOfPoints}");
            System.Console.WriteLine($"У тебя {_answer.textAnswer}.");
        }
    }
}