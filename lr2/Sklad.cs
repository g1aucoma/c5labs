using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace lr2
{
    class Sklad
    {
        private readonly Dictionary<Product, List<Polzovatel>> product = new Dictionary<Product, List<Polzovatel>>();

        private Sklad()
        {
        }

        public static Sklad Initialization()
        {
            var res = new Sklad();
            var novi = new Product
            {
                name = "moloko",
                proizvoditel = "Kyban",
                code = "001",
                price = "50 rub",
                nalichie = Nalichie.est,
                otdel = Otdel.molochni
            };

            res.product.Add(novi, new List<Polzovatel>());
            novi = new Product
            {
                name = "kolbosa",
                proizvoditel = "cow",
                code = "002",
                price = "100 rub",
                nalichie = Nalichie.net,
                otdel = Otdel.myasnoi
            };

            res.product.Add(novi, new List<Polzovatel>());

            return res;

        }

        public void PokupkaProduct(String codeProducta, Polzovatel polzovatel)
        {
            var res = (from ob in product where ob.Key.code == codeProducta select ob).ToList();

            if (res.Count > 0)
            {
                if (res[0].Key.nalichie == Nalichie.est)
                {
                    res[0].Key.nalichie = Nalichie.net;
                    res[0].Value.Add(polzovatel);
                    Console.WriteLine("Покупка продукта зафиксирована.");
                }
                else
                    Console.WriteLine("Продукта нет на полках.");
            }
            else
                Console.WriteLine("Покупка продукта зафиксирована.");
        }

        public void VozvratProsrochki(Polzovatel polzovatel)
        {
            Console.WriteLine("Функция не реализована!!!");
        }

        public void Assortiment()
        {
            foreach(var product in product.Keys)
            {
                Console.WriteLine(product.name + "\n" + product.proizvoditel + "\n" + product.price + "\n" + product.code);
            }
        }
    }
}
