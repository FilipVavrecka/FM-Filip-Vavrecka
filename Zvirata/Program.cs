class Program{
    public static void Main(string[] args){
        Zvire Kocka = new Zvire("Kočka", "Meow", "Zrzavá", 4);
        Zvire Pes = new Zvire("Pes", "Woof", "Husky", 3);
        Zvire Krava = new Zvire("Kráva", "Moo", "Puntikovaná", 5);
        Zvire Ovce = new Zvire("Ovce", "Baa", "Bíla", 2);
        Zvire Kralik = new Zvire("Králík", "Squeak", "Bílý", 1);
        Zvire Kachna = new Zvire("Kachna", "Quack", "Velká", 2);
        Zvire Kun = new Zvire("Kůň", "Hyee", "Hnědý", 7);
        Zvire Prase = new Zvire("Prase", "Oink", "Růžové", 4);
        Zvire Koza = new Zvire("Koza", "Bleeh", "Ďábelská", 3);
        Zvire Kure = new Zvire("Kuře", "Chirp", "Slepičí", 1);
        
        Zvire.print(Kocka);
        Zvire.print(Pes);
        Zvire.print(Krava);
        Zvire.print(Ovce);
        Zvire.print(Kralik);
        Zvire.print(Kachna);
        Zvire.print(Kun);
        Zvire.print(Prase);
        Zvire.print(Koza);
        Zvire.print(Kure);
    }

    class Zvire{
        public string jmeno;
        public string zvuk;
        public string rasa;
        public int vek;

        public Zvire(string jmeno, string zvuk, string rasa, int vek){
            this.jmeno = jmeno;
            this.zvuk = zvuk;
            this.rasa = rasa;
            this.vek = vek;
        }

        public static void print(Zvire zvire){
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Zvíře: " + zvire.jmeno + " | Zvuk: " + zvire.zvuk + " | Rasa: " + zvire.rasa + " | Věk: " + zvire.vek);
        }
    }
}