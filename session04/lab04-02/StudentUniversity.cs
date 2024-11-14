﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04_02
{
    internal class StudentUniversity:StudentCollege
    {
        protected double score4;

        //constructor 
        public StudentUniversity(string name, int year, double score1, double score2, double score3, double score4)
            : base(name, year, score1, score2, score3)
        { 
            this.score4 = score4;
        }

        //Phương thức tính điểm trung bình 
        public override double Average()
        {
            return (score1 + score2 + score3 + score4) / 4;
        }

        //Phương thức hiển thị thông tin 
        public new void Display()
        { 
            base.Display();
            Console.WriteLine("Score 4: {0:N1}", score4);
        }
    }
}
