using DesignPatterns2022.Creational.AbstractFactory;
using DesignPatterns2022.Creational.Builder;
using DesignPatterns2022.Creational.Factory;
using DesignPatterns2022.Creational.Prototype;
using DesignPatterns2022.Creational.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Singleton
            Database firstInstanceRequest = Database.GetInstance();
            Database secondInstanceRequest = Database.GetInstance();

            bool isEquals = firstInstanceRequest == secondInstanceRequest;

            Console.WriteLine($"Database referance is equals: {isEquals}"); //output: Database referance is equals: True
            #endregion

            #region Factory
            NotifyFactory notifyFactory = new NotifyFactory();

            INotify notify = notifyFactory.CreateNotify("MAIL");

            notify.SendNotification(new User());
            #endregion

            #region Abstract Factory
            CustomOperation customOperation = new CustomOperation(new OracleDatabaseFactory());
            customOperation.RemoveById(1);

            #endregion

            #region Prototype
            Employee ugur = new Employee("Uğur", "Malki");
            Employee cloneUgur = ugur.Clone();

            // Aynı nesne örneklerini farklı referanslarda tutuyor.
            // Birbirinin aynısı ve farklı referanslarda olan nesneler elde ettik.

            Console.WriteLine(ugur == cloneUgur);
            #endregion

            #region Builder

            LessonBuilder lessonBuilder = new NewStudentLessonBuilder();

            LessonDirector lessonDirector = new LessonDirector(lessonBuilder);
            lessonDirector.Make();

            Lesson lesson = lessonBuilder.GetResult();

            Console.WriteLine($"{lesson.name} - {lesson.price} - {lesson.discountedPrice}");

            #endregion
        }
    }

}
