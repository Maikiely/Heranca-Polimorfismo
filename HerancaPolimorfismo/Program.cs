using System;
using HerancaPolimorfismo.Entities;
using System.Collections.Generic;
using System.Globalization;
using HerancaPolimorfismo.Entities.Shape;
using HerancaPolimorfismo.Entities.Shape.Enuns;
using HerancaPolimorfismo.Entities.Pessoa;
namespace HerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------------------Referente as classes Account, BusinessAccount e SavingsAccount------------------------
            //List<Account> list = new List<Account>();

            //list.Add(new SavingsAccount(1001, "Alex", 500.00, 0.01));
            //list.Add(new BusinessAccount(1002, "Maria", 500.00, 400.00));
            //list.Add(new SavingsAccount(1003, "Bob", 500.00, 0.01));
            //list.Add(new BusinessAccount(1004, "Anna", 500.00, 500.00));

            //double sum = 0.0;
            //foreach (Account acc in list)
            //{
            //    sum += acc.Balance;
            //}

            //Console.WriteLine("Total of balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));

            //foreach (Account acc in list)
            //{
            //    acc.Withdraw(10.00);
            //}

            //foreach (Account acc in list)
            //{
            //    Console.WriteLine("Update balance for account: "
            //    + acc.Number 
            //    + ": " 
            //    + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            //}
            //------------------------------------------------
            //------------------------Referente as classes Employee e OutsourcedEmployee ------------------------
            //List<Employee> emp = new List<Employee>();

            //Console.Write("Qual a quantidade de Funcioonarios:");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine($"Employee #{i} data:");
            //    Console.Write("Outsourced? Y/N");
            //    char ch = char.Parse(Console.ReadLine());
            //    Console.Write("Name: ");
            //    string name = Console.ReadLine();
            //    Console.Write("Worked hours:");
            //    int wh = int.Parse(Console.ReadLine());
            //    Console.Write("Value per hours:");
            //    double vp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //    if (ch == 'y' || ch == 'Y')
            //    {
            //        Console.Write("Additional Charge:");
            //        double ac = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //        emp.Add(new OutsourcedEmployee(name, wh, vp, ac));
            //    }
            //    else
            //    {
            //        emp.Add(new Employee(name, wh, vp));
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("Payment: ");
            //foreach (Employee empre in emp)
            //{
            //    Console.WriteLine(empre.Nome + " - $ " + empre.Payment().ToString("F2", CultureInfo.InvariantCulture));
            //}

            //--------------------------------------------------------------
            //------------------------Referente as classes Product, UsedProduct e ImportededProduct ------------------------
            //List<Product> prod = new List<Product>();
            //Console.Write("Qual a quantidade de Produtos:");
            //int num = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= num; i++)
            //{
            //    Console.WriteLine($"Product #{i} data:");
            //    Console.Write("Common, Used or Imported - c/u/i:  ");
            //    char op = char.Parse(Console.ReadLine());
            //    Console.Write("Name: ");
            //    string name = Console.ReadLine();
            //    Console.Write("Enter with the price:");
            //    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //    if (op == 'i' || op == 'I' )
            //    {
            //        Console.Write("Customs Fee:");
            //        double cf = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //        prod.Add(new ImportededProduct(name,price,cf));
            //    }else if (op == 'U' || op == 'u')
            //    {
            //        Console.Write("Manufacture date: ");
            //        DateTime dt = DateTime.Parse(Console.ReadLine());
            //        prod.Add(new UsedProduct(name, price, dt));
            //    }
            //    else
            //    {
            //        prod.Add(new Product(name, price));
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine("Price Date: ");
            //foreach (Product p in prod)
            //{
            //    Console.WriteLine(p.Tag());
            //}

            // ----------------------------------------------------------------------------------
            //--------------Referente as classes Shape, Retangle, Circle e Color ----------------

            //List<Shape> shaps = new List<Shape>();

            //Console.Write("Enter with the number of shape: ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine($"Shape #{i} data:");
            //    Console.Write("Retangle or Circle - R/C: ");
            //    char op = char.Parse(Console.ReadLine());
            //    Console.Write("Color: (Black/ Blue/ Red) ");
            //    Color color = Enum.Parse<Color>(Console.ReadLine());
            //    if (op == 'R' || op == 'r')
            //    {
            //        Console.Write("Enter with width: ");
            //        double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //        Console.Write("Enter with height: ");
            //        double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //        shaps.Add(new Retangle(width,height,color));
            //    }else
            //    {
            //        Console.Write("Enter with the radio: ");
            //        double radio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //        shaps.Add(new Circle(radio,color));
            //    }

            //}

            //Console.WriteLine();
            //Console.WriteLine("Shape Date: ");
            //foreach (Shape shape in shaps)
            //{
            //    Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            //}

            // ----------------------------------------------------------------------------------
            //--------------Referente as classes Pessoa, Pessoa Fisica e Pessoa Juridica ----------------

            List<Pessoa> list = new List<Pessoa>();
            Console.Write("Enter with the number of Tax Payers: ");
            int num = int.Parse(Console.ReadLine());
            
            double soma = 0.0;
            for (int i = 1; i<= num; i++)
            {
                Console.WriteLine($"Tax Payers #{i} data:");
                Console.Write("Individual or Company I/C? ");
                char op = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double anualRenda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                
                if (op == 'i' || op == 'I')
                {
                    Console.Write("Health expenditures:  ");
                    double healthEx = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new PessoaFisica(name,anualRenda,healthEx));
                }
                else
                {
                    Console.Write("Numero de Funcionarios:  ");
                    int quantFun = int.Parse(Console.ReadLine());
                    list.Add(new PessoaJuridica(name, anualRenda, quantFun));
                }
            }
            Console.WriteLine();
            Console.WriteLine("Taxes Paid: ");
            foreach (Pessoa pessoa in list)
            {
                soma += pessoa.CalculaImposto();
                Console.WriteLine(pessoa.ToString());
            }
            Console.WriteLine();
            Console.Write("Total Taxes: $ " + soma.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
