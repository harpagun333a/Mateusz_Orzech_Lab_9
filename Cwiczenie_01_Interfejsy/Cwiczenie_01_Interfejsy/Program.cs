using System;

namespace Cwiczenie_01_Interfejsy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cwiczenie 1\n");

            c_Pojazd pojazd1 = new c_Pojazd("van", "IVECO", 1.6, 3, "123456", "rejestr1", 2015, "biały", "12124");
            c_Wlasciciel wlasciciel1 = new c_Wlasciciel("Janusz", "Nosacz", "Kwiatowa 6", "527152671", "2164d", "12,12,12", 2016, 3);

            c_Pojazd pojazd2 = new c_Pojazd("SUV", "TOYOTA", 3.6, 5, "7854397", "rej2", 2014, "Czarny", "73hofwe");
            c_Wlasciciel wlasciciel2 = new c_Wlasciciel("Beata", "Plizga", "Nowa 3", "89273508247", "wid9", "15.15.15", 2018, 17);

            c_Pojazd pojazd3 = new c_Pojazd("GIT", "Citroen", 1.6, 5, "2452r23r", "rej3", 2005, "srebrny", "397ery390");
            c_Wlasciciel wlasciciel3 = new c_Wlasciciel("Gabriel", "Kowal", "Stara 7", "93278yr9", "f387y", "15.16.17", 2015, 0);

            Auto[] samochody = new Auto[3];

            samochody[0] = new Auto(pojazd1, wlasciciel1);
            samochody[1] = new Auto(pojazd2, wlasciciel2);
            samochody[2] = new Auto(pojazd3, wlasciciel3);


            IPoliceData[] police = new IPoliceData[3];

            police[0] = samochody[0];
            police[1] = samochody[1];
            police[2] = samochody[2];

            ICepikData[] cepik = new ICepikData[3];

            cepik[0] = samochody[0];
            cepik[1] = samochody[1];
            cepik[2] = samochody[2];

            IStatData[] stat = new IStatData[3];

            stat[1] = samochody[1];
            stat[2] = samochody[2];
            stat[0] = samochody[0];


            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(police[i].get_user_punkty_karne());
                Console.WriteLine(cepik[i].get_user_imie());
                Console.WriteLine(stat[i].get_car_marka() + "\n");
            }
            
        }
    }

    public interface IPoliceData
    {
        public string get_car_typ_pojazdu();
        public string get_car_marka();
        public double get_car_pojemnosc();
        public int get_car_liczba_miejsc();
        public string get_car_vin();
        public string get_car_nr_rejestracyjny();
        public int get_car_rok_produkcji();
        public string get_car_kolor();
        public string get_car_nr_polisy();

        public string get_user_imie();
        public string get_user_nazwisko();
        public string get_user_adres();
        public string get_user_pesel();
        public string get_user_nr_prawa_jazdy();
        public string get_user_data_uzyskania_prawa_jazdy();
        public int get_user_rok_zakupu();
        public int get_user_punkty_karne();

    }

    public interface IStatData
    {
        public string get_car_typ_pojazdu();
        public string get_car_marka();
        public double get_car_pojemnosc();
        public int get_car_liczba_miejsc();
        public int get_car_rok_produkcji();
        public string get_car_kolor();
    }

    public interface ICepikData
    {
        public string get_car_typ_pojazdu();
        public string get_car_marka();
        public double get_car_pojemnosc();
        public int get_car_liczba_miejsc();
        public string get_car_vin();
        public string get_car_nr_rejestracyjny();
        public int get_car_rok_produkcji();
        public string get_car_kolor();
        public string get_car_nr_polisy();

        public string get_user_imie();
        public string get_user_nazwisko();
        public string get_user_adres();
        public string get_user_pesel();
        public string get_user_nr_prawa_jazdy();
        public string get_user_data_uzyskania_prawa_jazdy();
        public int get_user_rok_zakupu();
    }

    public class Auto: IPoliceData, IStatData, ICepikData
    {
        private c_Pojazd pojazd;
        private c_Wlasciciel wlasciciel;

        public Auto(c_Pojazd poj, c_Wlasciciel wl)
        {
            pojazd = new c_Pojazd(poj);
            wlasciciel = new c_Wlasciciel(wl);
        }

        public string get_car_typ_pojazdu()
        {
            return pojazd.typ_pojazdu;
        }

        public string get_car_marka()
        {
            return pojazd.marka;
        }

        public double get_car_pojemnosc()
        {
            return pojazd.pojemnosc;
        }

        public int get_car_liczba_miejsc()
        {
            return pojazd.liczba_miejsc;
        }

        public string get_car_vin()
        {
            return pojazd.vin;
        }

        public string get_car_nr_rejestracyjny()
        {
            return pojazd.nr_rejestracyjny;
        }

        public int get_car_rok_produkcji()
        {
            return pojazd.rok_produkcji;
        }

        public string get_car_kolor()
        {
            return pojazd.kolor;
        }

        public string get_car_nr_polisy()
        {
            return pojazd.nr_polisy;
        }

        public string get_user_imie()
        {
            return wlasciciel.imie;
        }

        public string get_user_nazwisko()
        {
            return wlasciciel.nazwisko;
        }

        public string get_user_adres()
        {
            return wlasciciel.adres;
        }

        public string get_user_pesel()
        {
            return wlasciciel.pesel;
        }

        public string get_user_nr_prawa_jazdy()
        {
            return wlasciciel.nr_prawa_jazdy;
        }

        public string get_user_data_uzyskania_prawa_jazdy()
        {
            return wlasciciel.data_uzyskania_prawa_jazdy;
        }

        public int get_user_rok_zakupu()
        {
            return wlasciciel.rok_zakupu;
        }

        public int get_user_punkty_karne()
        {
            return wlasciciel.punkty_karne;
        }
    }

    public class c_Pojazd
    {
        public string typ_pojazdu;
        public string marka;
        public double pojemnosc;
        public int liczba_miejsc;
        public string vin;
        public string nr_rejestracyjny;
        public int rok_produkcji;
        public string kolor;
        public string nr_polisy;

        public c_Pojazd(string typ_pojazdu, string marka, double pojemnosc, int liczba_miejsc, string vin, string nr_rejestracyjny, int rok_produkcji, string kolor, string nr_polisy)
        {
            this.typ_pojazdu = typ_pojazdu;
            this.marka = marka;
            this.pojemnosc = pojemnosc;
            this.liczba_miejsc = liczba_miejsc;
            this.vin = vin;
            this.nr_rejestracyjny = nr_rejestracyjny;
            this.rok_produkcji = rok_produkcji;
            this.kolor = kolor;
            this.nr_polisy = nr_polisy;
        }

        public c_Pojazd(c_Pojazd poj)
        {
            this.typ_pojazdu = poj.typ_pojazdu;
            this.marka = poj.marka;
            this.pojemnosc = poj.pojemnosc;
            this.liczba_miejsc = poj.liczba_miejsc;
            this.vin = poj.vin;
            this.nr_rejestracyjny = poj.nr_rejestracyjny;
            this.rok_produkcji = poj.rok_produkcji;
            this.kolor = poj.kolor;
            this.nr_polisy = poj.nr_polisy;
        }
    }

    public class c_Wlasciciel
    {
        public string imie;
        public string nazwisko;
        public string adres;
        public string pesel;
        public string nr_prawa_jazdy;
        public string data_uzyskania_prawa_jazdy;
        public int rok_zakupu;
        public int punkty_karne;

        public c_Wlasciciel(string imie, string nazwisko, string adres, string pesel, string nr_prawa_jazdy, string data_uzyskania_prawa_jazdy, int rok_zakupu, int punkty_karne)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.adres = adres;
            this.pesel = pesel;
            this.nr_prawa_jazdy = nr_prawa_jazdy;
            this.data_uzyskania_prawa_jazdy = data_uzyskania_prawa_jazdy;
            this.rok_zakupu = rok_zakupu;
            this.punkty_karne = punkty_karne;
        }

        public c_Wlasciciel(c_Wlasciciel wl)
        {
            this.imie = wl.imie;
            this.nazwisko = wl.nazwisko;
            this.adres = wl.adres;
            this.pesel = wl.pesel;
            this.nr_prawa_jazdy = wl.nr_prawa_jazdy;
            this.data_uzyskania_prawa_jazdy = wl.data_uzyskania_prawa_jazdy;
            this.rok_zakupu = wl.rok_zakupu;
            this.punkty_karne = wl.punkty_karne;
        }
    }
}
