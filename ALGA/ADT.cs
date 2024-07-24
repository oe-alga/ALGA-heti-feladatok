namespace OE.ALGA.Adatszerkezetek
{
    public interface Lista<T>
    {
        public int Elemszam { get; }

        public T Kiolvas(int index);
        public void Modosit(int index, T ertek);
        public void Hozzafuz(T ertek);
        public void Beszur(int index, T ertek);
        public void Torol(T ertek);
        public void Bejar(Action<T> muvelet);
    }

    public interface Halmaz<T>
    {
        public void Beszur(T ertek);
        public bool Eleme(T ertek);
        public void Torol(T ertek);
        public void Bejar(Action<T> muvelet);
    }

    public interface Verem<T>
    {
        void Verembe(T ertek);
        T Verembol();
        T Felso();
        bool Ures();
    }

    public interface Sor<T>
    {
        void Sorba(T ertek);
        T Sorbol();
        T Elso();
        bool Ures();
    }

    public interface PrioritasosSor<T>
    {
        void Sorba(T ertek);
        T Sorbol();
        T Elso();
        bool Ures();
        void Frissit(T elem);
    }

    public interface GrafEl<V>
    {
        V Honnan { get; }
        V Hova { get; }
    }

    public interface Graf<V, E> where E : GrafEl<V>
    {
        int CsucsokSzama { get; }
        int ElekSzama { get; }
        Halmaz<V> Csucsok { get; }
        Halmaz<E> Elek { get; }
        bool VezetEl(V honnan, V hova);
        Halmaz<V> Szomszedai(V csucs);
    }

    public interface SulyozatlanGraf<V, E> : Graf<V, E> where E : GrafEl<V>
    {
        void UjEl(V honnan, V hova);
    }

    public interface SulyozottGrafEl<V> : GrafEl<V>
    {
        float Suly { get; }
    }

    public interface SulyozottGraf<V, E> : Graf<V, E> where E : SulyozottGrafEl<V>
    {
        void UjEl(V honnan, V hova, float suly);
        float Suly(V honnan, V hova);
    }

    public interface Szotar<K, T>
    {
        public void Beir(K kulcs, T ertek);
        public T Kiolvas(K kulcs);
        public void Torol(K kulcs);
    }

    public class HibasKulcsKivetel : Exception
    {
    }

    public class HibasIndexKivetel : Exception
    {
    }

    public class NincsElemKivetel : Exception
    {
    }

    public class NincsHelyKivetel : Exception
    {
    }

    public class NincsElKivetel : Exception
    {
    }

    public class NemOsszehasonlithatoKivetel : Exception
    {
    }

}
