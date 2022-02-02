using DesignPatterns2022.Creational.AbstractFactory;
using DesignPatterns2022.Creational.Builder;
using DesignPatterns2022.Creational.Factory;
using DesignPatterns2022.Creational.Prototype;
using DesignPatterns2022.Creational.Singleton;
using DesignPatterns2022.Structural.Flyweight;
using DesignPatterns2022.Structural.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns2022.Structural.Composite;
using DesignPatterns2022.Structural.Facade;
using DesignPatterns2022.Structural.Proxy;
using DesignPatterns2022.Structural.Decorator;
using DesignPatterns2022.Structural.Bridge;
using DesignPatterns2022.Behavioral.Strategy;

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
            //CustomOperation customOperation = new CustomOperation(new OracleDatabaseFactory());
            //customOperation.RemoveById(1);

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

            #region Flyweight
            BoxFactory boxFactory = new BoxFactory();

            Box blackBox1 = boxFactory.Get(BoxColor.Black);
            Box blackBox2 = boxFactory.Get(BoxColor.Black);
            Box blackBox3 = boxFactory.Get(BoxColor.Black);
            Box blueBox1 = boxFactory.Get(BoxColor.Blue);

            blackBox1.Draw(97, 37);
            blackBox2.Draw(34, 78);
            blackBox3.Draw(74, 193);
            blueBox1.Draw(1, 4);
            #endregion

            #region Adapter
            Structural.Adapter.CustomOperation customOperationAdapter = new Structural.Adapter.CustomOperation(new CustomSerializerAdapter());
            string serializedObject = customOperationAdapter.SerializeObject(new object());
            Console.WriteLine(serializedObject);
            #endregion

            #region Composite
            ProductCatalog items = new ProductCatalog("Ürünler");

            ProductCatalog phones = new ProductCatalog("Telefonlar");
            
            ProductCatalog iPhone = new ProductCatalog("IPhone Telefonlar");
            ProductCatalog samsung = new ProductCatalog("Samsung Telefonlar");

            Product iphone5Item = new Product("IPhone 5 Telefon");
            Product samsungGalaxyItem = new Product("Samsung Galaxy Telefon");

            // En üst hiyerarşiye telefon düğümü ekleniyor.
            items.Add(phones);

            // Telefon hiyerarşisine Samsung ve iPhone düğümleri ekleniyor.
            phones.Add(iPhone);
            phones.Add(samsung);

            // iPhone hiyerarşisine iPhone5 yaprağı (En alt yapıdır, içerisinde bir düğüm içermez) ekleniyor.
            iPhone.Add(iphone5Item);

            // Samsung hiyerarşisine Samsung Galaxy yaprağı (En alt yapıdır, içerisinde bir düğüm içermez) ekleniyor.
            samsung.Add(samsungGalaxyItem);

            items.DrawHierarchy();

            //             -Ürünler
            //             --Telefonlar
            //             ---iPhone Telefonlar
            //             ----iPhone 5 Telefon
            //             --Samsung Telefonlar
            //             ---Samsung Galaxy Telefon

            #endregion

            #region Facade
            Customer malki = new Customer("Ugur", "Malki");

            CreditCardManager creditCardFacade = new CreditCardManager();
            creditCardFacade.CreateCreditCard(malki);

            #endregion

            #region Proxy
            Person john = new Person("12345678901", "İstanbul-Beşiktaş Dere Tepe Sok.");
            IOrderableMask orderableMask = new AuthenticatableMaskOrderProxy();
            orderableMask.CreateOrder(john);
            #endregion

            #region Decorator
            IDataSource dataSource = new FileDataSource("data.sql");

            IDataSource compressedDataSource = new ComporessionDecorator(dataSource);

            compressedDataSource.ReadData();
            compressedDataSource.WriteData(new object());
            // output:
            //      data.sql readed.
            //      Data compressed.
            //      Compressed data was written to data.sql.
            #endregion

            #region Bridge
            IMessageSender textMessageSender = new TextMessageSender();
            Message textMessage = new TextMessage(textMessageSender);
            textMessage.Send();
            // output: TextMessageSender: Sending text message...

            IMessageSender emailMessageSender = new EmailMessageSender();
            Message emailMessage = new EmailMessage(emailMessageSender);
            emailMessage.Send();
            // output: EmailMessageSender: Sending email message...
            #endregion

            #region Strategy
            ShoppingCart shoppingCart = new ShoppingCart();
            shoppingCart.AddItem(new Item("123456", 80));
            shoppingCart.AddItem(new Item("123457", 20));

            shoppingCart.SetPaymentMethod(new PaypalPayment("ugur@gmail.com", "123456"));
            shoppingCart.Pay();

            shoppingCart.SetPaymentMethod(new CreditCardPayment("ugur", "1234 1231 1234 54", "234", "10/2030"));
            shoppingCart.Pay();
            #endregion
        }
    }

}
