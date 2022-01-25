using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Creational.Builder
{
    abstract class LessonBuilder
    {
        public Lesson lesson;

        public abstract void GetLesson();
        public abstract void ApplyDiscount();
        public abstract void AddLessonNote();
        public abstract Lesson GetResult();
    }
}
