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
using DesignPatterns2022.Behavioral.Command;
using DesignPatterns2022.Behavioral.Iterator;
using DesignPatterns2022.Behavioral.TemplateMethod;
using DesignPatterns2022.Behavioral.Observer;
using DesignPatterns2022.Behavioral.Memento;

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
            Creational.Prototype.Employee ugur = new Creational.Prototype.Employee("Uğur", "Malki");
            Creational.Prototype.Employee cloneUgur = ugur.Clone();

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

            #region Command
            StockManager stockManager = new StockManager("IPhone", 200);
            BuyStock buyStock = new BuyStock(stockManager);
            SellStock sellStock = new SellStock(stockManager);

            StockController stockController = new StockController();
            stockController.TakeOrder(buyStock);
            stockController.TakeOrder(sellStock);
            stockController.TakeOrder(sellStock);

            stockController.PlaceOrders();
            // output:
            //  Stock: iPhone, 200 bought!
            //  Stock: iPhone, 200 sold!
            //  Stock: iPhone, 200 sold!
            #endregion

            #region Iterator
            EmployeeListAggregate employeeListAggregate = new EmployeeListAggregate();

            Behavioral.Iterator.Employee snoop = new Behavioral.Iterator.Employee(1, "Snoop", "Dogg");
            Behavioral.Iterator.Employee dre = new Behavioral.Iterator.Employee(2, "Dr", "Dre");
            Behavioral.Iterator.Employee kanye = new Behavioral.Iterator.Employee(3, "Kanye", "West");

            employeeListAggregate.Add(snoop);
            employeeListAggregate.Add(dre);
            employeeListAggregate.Add(kanye);

            var iterator = employeeListAggregate.Iterator();

            while (iterator.HasNext())
            {
                Behavioral.Iterator.Employee currentEmployee = iterator.GetCurrentItem();
                Console.WriteLine($"{currentEmployee.firstName} {currentEmployee.lastName}");
            }
            // output:
            //  Snoop Dogg
            //  Dr Dre
            //  Kanye West
            #endregion

            #region TemplateMethod
            DataAnalyzerBase dataAnalyzer;

            dataAnalyzer = new XmlDataAnalyzer();
            dataAnalyzer.AnalyzeDataOfLastWeek();
            // output:
            //  Method worked: GetDataOfLastWeek
            //  Method worked: AnalyzeData
            //  XML exported.

            dataAnalyzer = new HtmlDataAnalyzer();
            dataAnalyzer.AnalyzeDataOfLastWeek();
            // output:
            //  Method worked: GetDataOfLastWeek
            //  Method worked: AnalyzeData
            //  HTML exported.
            #endregion

            #region Observer
            // Güncellemeden etkilenecek olan sınıf örnekleri.
            IObserverUser mehmet = new ObserverUser();
            IObserverUser ayse = new ObserverUser();
            IObserverUser deniz = new ObserverUser();
            IObserverUser sercan = new ObserverUser();

            // İzlenecek olan sınıf örneği.
            Samsung samsungPhone = new Samsung();

            // İzlenecek olan sınıfa etkilenecek olan nesnelerin atanması.
            samsungPhone.AddObserver(mehmet);
            samsungPhone.AddObserver(ayse);
            samsungPhone.AddObserver(deniz);
            samsungPhone.AddObserver(sercan);

            samsungPhone.ChangePrice();

            // output:
            //  Samsung updated. Message: Samsung's price updated.
            //  Samsung updated. Message: Samsung's price updated.
            //  Samsung updated. Message: Samsung's price updated.
            //  Samsung updated. Message: Samsung's price updated.
            #endregion

            #region Memento
            TextOriginator textOriginator = new TextOriginator();

            textOriginator.Text = "asm";
            textOriginator.CursorPosition = 3;

            // Anlık durum yığına ekleniyor.
            textOriginator.Save();

            textOriginator.Text = "asmi";
            textOriginator.CursorPosition = 4;

            // Anlık durum yığına ekleniyor.
            textOriginator.Save();

            textOriginator.Text = "asmin";
            textOriginator.CursorPosition = 5;

            // Anlık durum yığına ekleniyor.
            textOriginator.Save();

            // Yığındaki bir önceki duruma geçiyor.
            textOriginator.Undo();
            Console.WriteLine(textOriginator.ToString());

            // Yığındaki bir önceki duruma geçiyor.
            textOriginator.Undo();
            Console.WriteLine(textOriginator.ToString());

            // Yığındaki bir önceki duruma geçiyor.
            textOriginator.Undo();
            Console.WriteLine(textOriginator.ToString());

            //output:
            //  text: asmin, cursor position: 5
            //  text: asmi, cursor position: 4
            //  text: asm, cursor position: 3
            #endregion
        }
    }

}
