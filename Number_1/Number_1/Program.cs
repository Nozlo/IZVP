using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_1
{
    class Program
    {

        class Product
        {
            public string name;
            public int count;
            public string measure;
            public double price;
            public DateTime dateOfExpire;

            public Product() 
            {
                name = "qwer";
                count = 0;
                measure = "asdf";
                price = 0;
                dateOfExpire = DateTime.Now;
            }

            public double ExpiryDate()
            {
                Console.WriteLine("Кiлькiсть до завершення сроку придатностi: " + (dateOfExpire - DateTime.Now).TotalDays);

                return (dateOfExpire - DateTime.Now).TotalDays;
            }

            public double getCostOfGoods(int count_)
            {
                if (count_ > count)
                {
                    Console.WriteLine("Стiльки товару немає в наявностi.");
                }
                Console.WriteLine("Цiна товару за " + count_ + " штук: " + price*count_);
                return price * count_;
            }

            public void IncreasingPoroducts(int value)
            {
                if (value > 0)
                {
                    count += value;
                }
                Console.WriteLine("Кiлькість товару на складi: " + count);
            }

            public void output_info()
            {
                Console.WriteLine("Назва проудукту: " + name);
                Console.WriteLine("Кiлькість на складi: " + count);
                Console.WriteLine("Розмiрнiсть: " + measure);
                Console.WriteLine("Цiна за одницю: " + price);
                Console.WriteLine("Термiнпридатностi: " + dateOfExpire);
            }

        }

        static void Main(string[] args)
        {
            Product pr = new Product();
            pr.name = "Oil";
            pr.count = 12;
            pr.measure = "Литри";
            pr.dateOfExpire = new DateTime(2021, 12, 12);
            pr.price = 134;
            pr.output_info();
            pr.getCostOfGoods(3);
            pr.ExpiryDate();
            pr.IncreasingPoroducts(25);
        }
    }
}
