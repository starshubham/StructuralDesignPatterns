using StructuralDesignPatterns.Adapter;
using StructuralDesignPatterns.Bridge;
using StructuralDesignPatterns.Composite;
using System.Text;

namespace StructuralDesignPatterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.OutputEncoding = Encoding.UTF8;

                Console.WriteLine("======================================");

                Console.WriteLine("   STRUCTURAL DESIGN PATTERNS DEMO");

                Console.WriteLine("======================================");

                Console.WriteLine("1. Adapter Pattern");

                Console.WriteLine("2. Bridge Pattern");

                Console.WriteLine("3. Composite Pattern");

                Console.WriteLine("4. Decorator Pattern");

                Console.WriteLine("5. Facade Pattern");

                Console.WriteLine("6. Flyweight Pattern");

                Console.WriteLine("7. Proxy Pattern");

                Console.WriteLine("8. Exit");

                Console.WriteLine("======================================");

                Console.Write("Choose Pattern: ");

                string choice = Console.ReadLine();

                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        TestAdapter();
                        break;

                    case "2":
                        TestBridge();
                        break;

                    case "3":
                        TestComposite();
                        break;

                    //case "4":
                    //    TestDecorator();
                    //    break;

                    //case "5":
                    //    TestFacade();
                    //    break;

                    //case "6":
                    //    TestFlyweight();
                    //    break;

                    //case "7":
                    //    TestProxy();
                    //    break;

                    case "8":
                        return;

                    default:
                        Console.WriteLine(
                            "Invalid Choice.");
                        break;
                }

                Console.WriteLine();
                Console.WriteLine(
                    "Press any key to continue...");

                Console.ReadKey();
            }
        }

        private static void TestAdapter()
        {
            Console.WriteLine("========== ADAPTER PATTERN ==========");

            OldPaymentGateway oldGateway = new OldPaymentGateway();

            IPayment payment = new PaymentAdapter(oldGateway);

            payment.Pay(5000);
        }

        private static void TestBridge()
        {
            Console.WriteLine("========== BRIDGE PATTERN ==========");

            IMessageSender emailSender = new EmailSender();

            Notification alert = new AlertNotification(emailSender);

            alert.Send();

            Console.WriteLine();

            IMessageSender smsSender = new SmsSender();

            Notification reminder = new ReminderNotification(smsSender);

            reminder.Send();
        }

        private static void TestComposite()
        {
            Console.WriteLine("========== COMPOSITE PATTERN ==========");

            Folder root = new Folder("Root");

            root.Add(new FileItem("Resume.pdf"));

            root.Add(new FileItem("Photo.jpg"));

            Folder documents = new Folder("Documents");

            documents.Add(new FileItem("CV.docx"));

            documents.Add(new FileItem("Report.pdf"));

            Folder projects = new Folder("Projects");

            projects.Add(new FileItem("Project1.cs"));

            documents.Add(projects);

            root.Add(documents);

            root.Display();
        }

        //private static void TestDecorator()
        //{
        //    Console.WriteLine(
        //        "========== DECORATOR PATTERN ==========");

        //    ICoffee coffee =
        //        new SimpleCoffee();

        //    Console.WriteLine(
        //        $"Base: {coffee.GetDescription()}");

        //    Console.WriteLine(
        //        $"Cost: ₹{coffee.GetCost()}");

        //    Console.WriteLine();

        //    coffee =
        //        new MilkDecorator(coffee);

        //    Console.WriteLine(
        //        $"After Milk: {coffee.GetDescription()}");

        //    Console.WriteLine(
        //        $"Cost: ₹{coffee.GetCost()}");

        //    Console.WriteLine();

        //    coffee =
        //        new SugarDecorator(coffee);

        //    Console.WriteLine(
        //        $"After Sugar: {coffee.GetDescription()}");

        //    Console.WriteLine(
        //        $"Cost: ₹{coffee.GetCost()}");
        //}

        //private static void TestFacade()
        //{
        //    Console.WriteLine(
        //        "========== FACADE PATTERN ==========");

        //    InventoryService inventory =
        //        new InventoryService();

        //    PaymentService payment =
        //        new PaymentService();

        //    InvoiceService invoice =
        //        new InvoiceService();

        //    EmailService email =
        //        new EmailService();

        //    OrderFacade orderFacade =
        //        new OrderFacade(
        //            inventory,
        //            payment,
        //            invoice,
        //            email);

        //    orderFacade.PlaceOrder(
        //        101,
        //        5000);
        //}

        //private static void TestFlyweight()
        //{
        //    Console.WriteLine(
        //        "========== FLYWEIGHT PATTERN ==========");

        //    TreeFactory factory =
        //        new TreeFactory();

        //    TreeType tree1 =
        //        factory.GetTreeType(
        //            "Oak",
        //            "Green");

        //    TreeType tree2 =
        //        factory.GetTreeType(
        //            "Oak",
        //            "Green");

        //    TreeType tree3 =
        //        factory.GetTreeType(
        //            "Oak",
        //            "Green");

        //    TreeType tree4 =
        //        factory.GetTreeType(
        //            "Pine",
        //            "Dark Green");

        //    tree1.Display(10, 20);

        //    tree2.Display(30, 40);

        //    tree3.Display(50, 60);

        //    tree4.Display(70, 80);

        //    Console.WriteLine();

        //    Console.WriteLine(
        //        $"Unique TreeType objects: " +
        //        $"{factory.GetTreeTypeCount()}");

        //    Console.WriteLine();

        //    Console.WriteLine(
        //        "Are tree1 and tree2 the same object?");

        //    Console.WriteLine(
        //        ReferenceEquals(tree1, tree2));
        //}

        //private static void TestProxy()
        //{
        //    Console.WriteLine(
        //        "========== PROXY PATTERN ==========");

        //    Console.WriteLine(
        //        "--- Unauthorized User ---");

        //    IDocument unauthorizedDocument =
        //        new DocumentProxy(false);

        //    unauthorizedDocument.Read();

        //    Console.WriteLine();

        //    Console.WriteLine(
        //        "--- Authorized User ---");

        //    IDocument authorizedDocument =
        //        new DocumentProxy(true);

        //    authorizedDocument.Read();
        //}
    }
}
