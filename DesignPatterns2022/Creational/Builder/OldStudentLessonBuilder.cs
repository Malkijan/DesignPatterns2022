using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Creational.Builder
{
    class OldStudentLessonBuilder : LessonBuilder
    {
        // Burada nesne çağırma işlemleri gerçekleştirilmektedir.
        // Nasıl çağrılacağı tamamen geliştiriciye kalmıştır.
        // Çıktıyı görmek amacıyla 1-2 değer ataması yapılacaktır.
        public override void GetLesson()
        {
            lesson = new Lesson();
            lesson.id = 1;
            lesson.name = "Artificial Intelligence -  Beginner to Advanced in 10 Minute.";
            lesson.price = 49.99;
        }

        // Burada eski öğrenciler için geçerli derste herhangi bir indirim yapılmadı.
        public override void ApplyDiscount()
        {
            lesson.discountedPrice = lesson.price;
            lesson.discountApplied = false;
        }

        public override void AddLessonNote()
        {
            lesson.lessonNote = "";
        }

        public override Lesson GetResult()
        {
            return lesson;
        }
    }
}
