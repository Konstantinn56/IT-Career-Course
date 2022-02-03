using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02.Model
{
    public class ExamTime
    {
        /// <summary>
        /// Часът на изпита
        /// </summary>
        private int examHour;

        public int ExamHour
        {
            get { return examHour; }
            set 
            { 
                if (value >= 0 && value <= 23)
                {
                    examHour = value;
                }
            }
        }

        /// <summary>
        /// Минута на изпита
        /// </summary>
        private int examMinutes;

        public int ExamMinutes
        {
            get { return examMinutes; }
            set 
            {
                if (value >= 0 && value <= 59)
                {
                    examMinutes = value;
                }
            }
        }

        /// <summary>
        /// Час на пристигане
        /// </summary>
        private int arrivedHour;

        public int ArrivedHour
        {
            get { return arrivedHour; }
            set 
            {
                if (value >= 0 && value <= 23)
                {
                    arrivedHour = value;
                }
                    
            }
        }

        /// <summary>
        /// Минута на пристигане
        /// </summary>
        private int arrivedMinutes;

        public int ArrivedMinutes
        {
            get { return arrivedMinutes; }
            set 
            { 
                if(value >=0 && value <= 59)
                {
                    arrivedMinutes = value;
                }
            }
        }


        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="eH">Час на изпита</param>
        /// <param name="eM">Минута на изпита</param>
        /// <param name="aH">Час на пристигане</param>
        /// <param name="aM">Минута на пристигане</param>
        public ExamTime(int eH, int eM, int aH, int aM)
        {
            this.ExamHour = eH;
            this.ExamMinutes = eM;
            this.ArrivedHour = aH;
            this.ArrivedMinutes = aM;
        }

        public ExamTime() : this(0, 0, 0,0)
        {
            //by default
        }

       /// <summary>
       /// Смята кога е дошъл ученикът
       /// </summary>
       /// <returns>Информация за времето през което ученикът е пристигнал</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            double examTime = this.ExamHour * 60 + this.ExamMinutes;
            double arrivedTime = this.ArrivedHour * 60 + this.ArrivedMinutes;
            double timeDiff = arrivedTime - examTime;
            if (examTime < arrivedTime)
            {
                sb.AppendLine("Late");
                if (timeDiff < 60)
                {
                    sb.AppendLine($"{(timeDiff).ToString()} minutes after the start");
                }
                else
                {
                    sb.AppendLine($"{this.ArrivedHour - this.ExamHour}:{ArrivedMinutes - this.ExamMinutes} hours after the start");
                }
            }
            else if (examTime == arrivedTime || (examTime - arrivedTime <= 30 && examTime - arrivedTime >= 0))
            {
                sb.AppendLine("On time");
                if (timeDiff == 0)
                {

                }
                else
                {
                    sb.AppendLine($"{Math.Abs(timeDiff)} minutes before the start");
                }
            }
            else if (examTime - arrivedTime > 30)
            {
                sb.AppendLine("Early");
                if(Math.Abs(timeDiff) > 60)
                {
                    sb.AppendLine($"{this.ExamHour - this.ArrivedHour}:{this.ExamMinutes - this.ArrivedMinutes} hours beofre the start");
                }
                else if(Math.Abs(timeDiff) == 60)
                {
                    sb.AppendLine($"1:00 hours beofre the start");
                }
                else
                {
                    sb.AppendLine($"{Math.Abs(timeDiff)} minutes beofre the start");
                }
                
            }
            return sb.ToString();
        }

    }
}
