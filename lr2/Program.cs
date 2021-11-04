using System;

namespace lr2
{
    class Program
    {
        static void Main(string[] args)
        {
            Sklad mysklad = Sklad.Initialization();
            Console.WriteLine("Склад готов к работе!!");
            Console.WriteLine("Идентификация пользователя:");
            Console.Write("ФИО > ");
            String fiop =  Console.ReadLine();
            Polzovatel klient = new Polzovatel(fiop);
            int operation = 0;
            do
            {
                Console.Write("Уважаемый " + klient.fio + ", выберите действие: \n1 - Вывод ассортимента\n" + "2 - Запрос продукта\n3 - Возврат продукта\n" + "0 - Exit\n Ваш выбор > ");
                operation = Convert.ToInt32(Console.ReadLine());
                switch (operation)
                {
                    case 1: mysklad.Assortiment(); break;
                    case 2:
                        Console.Write("Kod producta? > ");
                        String kod = Console.ReadLine();
                        mysklad.PokupkaProduct(kod, klient);
                        break;
                    case 3:
                        mysklad.VozvratProsrochki(klient);
                        break;
                    default: break;
                }
            } while (operation != 0);

            Console.WriteLine("Sklad. Raбота заверешена!");
        }
    }
}
