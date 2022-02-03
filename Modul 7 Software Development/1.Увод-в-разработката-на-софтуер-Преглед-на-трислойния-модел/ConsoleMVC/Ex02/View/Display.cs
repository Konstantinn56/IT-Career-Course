using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02.View
{
    public class Display
    {
        /// <summary>
        /// Часът на изпита
        /// </summary>
        public int ExamHour { get; set; }

        /// <summary>
        /// Минутата на изпита
        /// </summary>
        public int ExamMinutes { get; set; }
        
        /// <summary>
        /// Часът на пристигане
        /// </summary>
        public int ArrivedHour { get; set; }

        /// <summary>
        /// Минутата на пристигане
        /// </summary>
        public int ArrivedMinutes { get; set; }
        public StringBuilder TimeDiff { get; set; }

        public Display()
        {
            this.ExamHour = 0;
            this.ExamMinutes = 0;
            this.ArrivedHour = 0;
            this.ArrivedMinutes = 0;
            GetValues();
        }

        private void GetValues()
        {
            Console.Write("Enter exam hour: ");
            this.ExamHour = int.Parse(Console.ReadLine());
            Console.Write("Enter exam min: ");
            this.ExamMinutes = int.Parse(Console.ReadLine());
            Console.Write("Enter arrive hour: ");
            this.ArrivedHour = int.Parse(Console.ReadLine());
            Console.Write("Enter arrive min: ");
            this.ArrivedMinutes = int.Parse(Console.ReadLine());
        }
    }
}
