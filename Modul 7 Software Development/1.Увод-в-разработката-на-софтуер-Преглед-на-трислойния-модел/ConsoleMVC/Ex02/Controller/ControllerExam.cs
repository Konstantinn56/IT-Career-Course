using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02.Controller
{
    using Ex02.View;
    using Ex02.Model;
    public class ControllerExam
    {
        private Display d;
        private ExamTime et;

        public ControllerExam()
        {
            this.d = new Display();
            this.et = new ExamTime(d.ExamHour,d.ExamMinutes,d.ArrivedHour,d.ArrivedMinutes);

            Console.WriteLine(et.ToString());
        }
    }
}
