using System.Collections.Generic;

namespace TestingState
{
    class Responses
    {
        private static readonly Responses instance = new Responses();
        List<Answer> Answers = new List<Answer>(){
            new Answer{
                numberOfPoints = 0,
                textAnswer = "все нормально"
            },new Answer{
                numberOfPoints = 14,
                textAnswer = "лёгкая депрессия"
            },new Answer{
                numberOfPoints = 20,
                textAnswer = "умеренная депрессия"
            },new Answer{
                numberOfPoints = 29,
                textAnswer = "тяжёлая депрессия"
            }
        };

        private Responses() {}

        public static Responses GetInstance(){
            return instance;
        }

        public Answer GetAnswerOfResult(int numberOfPoints){
            Answer result = new Answer();
            foreach (Answer _answer in Answers)
            {
                if(numberOfPoints >= _answer.numberOfPoints)
                    result = _answer;
            }
            return result;
        }
    }
}