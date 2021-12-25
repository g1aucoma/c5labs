using System;

namespace lr5
{

    public enum Sostoyanie { ok, norm, ploho };
    public enum Gruzopod { mnogo, malo, norm };
    public enum Vmestimost { mnogo, malo, norm };
    public enum vidtr { Avtomobil, Vertik }


    class TehSredstvo
    {
        public TehSredstvo(vidtr pVidTr, int pex)
        {
            vidtr = pVidTr;
            ex = pex;
        }

        public TehSredstvo()
        {
            vidtr = vidtr.Avtomobil;
            ex = 0;
        }

        public vidtr vidtr;
        public int ex;

        public virtual string Info
        {
            get { return "Вид транспорта : " + vidtr + ", Срок эксплуатации: " + ex; }
        }


        public void CW()
        {
            Console.WriteLine();
        }

    }

    class Avto : TehSredstvo
    {
        public Avto() : base()
        {
            sost = Sostoyanie.ok;
        }

        public Avto(vidtr pVidTr, int pex, Sostoyanie p) : base(pVidTr, pex)
        {
            sost = p;
        }
        public Sostoyanie sost;

        public override string Info
        {
            get { return base.Info + ", Состояние автомобиля: " + sost.ToString(); }
        }
    }

    class Vert : TehSredstvo
    {
        public Vert(vidtr pVidTr, int pex, Vmestimost mesta) : base(pVidTr, pex)
        {
            mest = mesta;
        }

        public Vert()
        {
        }

        public Vmestimost mest;

        public override string Info
        {
            get { return base.Info + ", Вместимость: " + mest.ToString(); }
        }
        public void InfoObject()
        {
            Console.Write("`````---------------+--------------- \n" +
                          "``````````````___`/^^[____ \n" +
                          "`````````````/|^+------+```|#___________// \n" +
                          "````````````(`-+`|____|````______-------+/\n" +
                          "`````````````==_________--'````````````'\' \n" +
                          "```````````````~_|___|__ \n");
        }
    }

    class GruzAvto : TehSredstvo
    {
        public GruzAvto(vidtr pVidTr, int pex, Gruzopod ggruz) : base(pVidTr, pex)
        {
            ggruz = gruz;
        }

        public GruzAvto()
        {
        }

        public Gruzopod gruz;

        public override string Info
        {
            get { return base.Info + ", Грузоподьемность: " + gruz.ToString(); }
        }
    }

    interface Isomeinterface
    {
        void InfoObject();
    }

    class LegAvto : TehSredstvo
    {
        public LegAvto(vidtr pVidTr, int pex, Vmestimost mesta) : base(pVidTr, pex)
        {
            mest = mesta;
        }

        public LegAvto()
        {
        }

        public Vmestimost mest;

        public override string Info
        {
            get { return base.Info + ", Вместимость: " + mest.ToString(); }
        }

        public void InfoObject()
        {
            Console.Write("`````````````````````````````````````````````````` \n" +
                          "`````````````````1000000000000000000000```````````\n" +
                          "````````````````01`111100`````10`1```1001`````````\n" +
                          "``````````````10```1```10`````10`1`1```000````````\n" +
                          "``````1100000001100000000100010000000110000```````\n" +
                          "```110000010001100000111101000000000000000001`````\n" +
                          "``10000111100000000001010010000000000000000000````\n" +
                          "```00011000000000000000000000000011011111000001```\n" +
                          "```00111111000000000000000000000110011100100000```\n" +
                          "`````100```001```````````````````00111100`````````\n" +
                          "``````1000001`````````````````````0011001`````````\n" +
                          "00001111000111101010100011111000111011111110100000\n");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            TehSredstvo s1 = new TehSredstvo();
            s1.CW();
            LegAvto s2 = new LegAvto();
            Vert s3 = new Vert();
            GruzAvto s4 = new GruzAvto();



            TehSredstvo[] mas = new TehSredstvo[5];

            mas[0] = new TehSredstvo(vidtr.Avtomobil, 2);
            mas[1] = new Avto(vidtr.Avtomobil, 3000, Sostoyanie.ok);
            mas[2] = new Vert(vidtr.Vertik, 0, Vmestimost.malo);
            mas[3] = new GruzAvto(vidtr.Avtomobil, 15, Gruzopod.mnogo);
            mas[4] = new LegAvto(vidtr.Avtomobil, 2, Vmestimost.norm);

            for (int i = 0; i < mas.Length; i++)
            {
                if (i == 0 || i == 1)
                {
                    Console.WriteLine("Имя класса: " + mas[i].GetType().Name);
                    Console.WriteLine(mas[i].Info);
                    s1.CW();
                }
                if (i == 2)
                {
                    Console.WriteLine("Имя класса: " + mas[i].GetType().Name);
                    Console.WriteLine(mas[i].Info);
                    s1.CW();
                    s3.InfoObject();
                    s1.CW();
                }
                if (i == 3)
                {
                    Console.WriteLine("Имя класса: " + mas[i].GetType().Name);
                    Console.WriteLine(mas[1].Info);
                    s1.CW();
                }
                if (i == 4)
                {
                    Console.WriteLine("Имя класса: " + mas[i].GetType().Name);
                    Console.WriteLine(mas[1].Info);
                    s2.InfoObject();
                    s1.CW();
                }
            }
        }
    }
}