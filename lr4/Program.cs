using System;

namespace lr4
{

    public enum Sostoyanie { ok, norm, ploho };
    public enum Gruzopod { mnogo, malo, norm };
    public enum Vmestimost { mnogo, malo, norm };
    public enum vidtr { Avtomobil, Vertik }


    class TehSredstvo
    {
        public TehSredstvo(vidtr pVidTr, int pex)
        {
            vidtr= pVidTr;
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

    class Avto: TehSredstvo
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
        public Vmestimost mest;

        public override string Info
        {
            get { return base.Info + ", Вместимость: " + mest.ToString(); }
        }
    }

    class GruzAvto : TehSredstvo
    {
        public GruzAvto(vidtr pVidTr, int pex , Gruzopod ggruz) : base(pVidTr, pex) 
        {
            ggruz = gruz;
        }
        public Gruzopod gruz;

        public override string Info
        {
            get { return base.Info + ", Грузоподьемность: " + gruz.ToString(); }
        }
    }

    class LegAvto : TehSredstvo
    {
        public LegAvto(vidtr pVidTr, int pex, Vmestimost mesta) : base(pVidTr, pex)
        {
            mest = mesta;
        }
        public Vmestimost mest;

        public override string Info
        {
            get { return base.Info + ", Вместимость: " + mest.ToString(); }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            TehSredstvo s1 = new TehSredstvo();
            s1.CW();
            TehSredstvo[] mas = new TehSredstvo[5];

            mas[0] = new TehSredstvo(vidtr.Avtomobil, 2);
            mas[1] = new Avto(vidtr.Avtomobil, 3000, Sostoyanie.ok);
            mas[2] = new Vert(vidtr.Vertik, 0, Vmestimost.malo);
            mas[3] = new GruzAvto(vidtr.Avtomobil, 15, Gruzopod.mnogo);
            mas[4] = new LegAvto(vidtr.Avtomobil, 2, Vmestimost.norm);

            for (int i = 0; i < mas.Length; i++)
            {
                if (i != 1)
                {
                    Console.WriteLine("Имя класса: " + mas[i].GetType().Name);
                    Console.WriteLine(mas[i].Info);
                    s1.CW();
                }
                else
                {
                    Console.WriteLine("Имя класса: " + mas[i].GetType().Name);
                    Console.WriteLine(mas[1].Info);
                    s1.CW();
                }
            }
        }
    }
}
