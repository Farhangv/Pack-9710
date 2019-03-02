using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableDemo
{
    class Exam:IEnumerable
    {
        public string Title { get; set; }
        public string Date { get; set; }
        public Question[] Questions { get; set; }

        public IEnumerator GetEnumerator()
        {
            //return this.Questions.GetEnumerator();
            return new ExamEnumerator(this.Questions);
        }
    }

    class ExamEnumerator : IEnumerator
    {
        public ExamEnumerator(Question[] _questions)
        {
            this.questions = _questions;
        }
        private Question[] questions { get; set; }
        public object Current { get { throw new NotImplementedException(); } }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
