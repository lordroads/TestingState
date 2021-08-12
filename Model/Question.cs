using System.Collections.Generic;

namespace TestingState
{
    class Question
    {
        public string TitleQuestion { get; set; } 
        public List<string> TitleAnswers {get; set; }  = 
        new List<string>(){
                    "Отлично", 
                    "Хорошо", 
                    "Нормльно", 
                    "Плохо", 
                }; 
        public Dictionary<int, int> AnswerPoints { get; set; }  =
        new Dictionary<int, int>(){ 
                    { 1, 0}, 
                    { 2, 1}, 
                    { 3, 2}, 
                    { 4, 3} 
                };
    }
}