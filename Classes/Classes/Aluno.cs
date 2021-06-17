using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Aluno
    {
        public string Name;
        public double Score1;
        public double Score2;
        public double Score3;

        public double FinalScore() 
        {
            return Score1 + Score2 + Score3;
        }
        public bool IsApproved()
        {
            return FinalScore() > 60;
        }
        public double HowMuchBelowPassMark()
        {
            return 60 - FinalScore();
        }

    }
}
