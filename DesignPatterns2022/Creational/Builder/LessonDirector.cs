using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Creational.Builder
{
    class LessonDirector
    {
        private LessonBuilder lessonBuilder;

        public LessonDirector(LessonBuilder lessonBuilder)
        {
            this.lessonBuilder = lessonBuilder;
        }

        public void Make()
        {
            lessonBuilder.GetLesson();
            lessonBuilder.ApplyDiscount();
            lessonBuilder.AddLessonNote();
        }
    }
}
