using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Computer_Zala
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //създава лист с клас 
            List<Data> list = new List<Data>();
            
            Console.WriteLine("Въведи брой DVD-та: ");
            int n = int.Parse(Console.ReadLine());

            //тва е за counter-a (ID=1/2/3/4)
            int i = 1;

            do
            {
                Console.WriteLine($"Въведи име на DVD #{i}: ");
                string name = Console.ReadLine();

                Console.WriteLine($"Въведи жанр на DVD: ");
                string genre = Console.ReadLine();

                Console.WriteLine($"Въведи режисьор на DVD: ");
                string director = Console.ReadLine();

                Console.WriteLine($"Въведи продължителност на DVD в минути: ");
                float duration = float.Parse(Console.ReadLine());

                Console.WriteLine($"Какво е DVD-то(музика/филм): ");
                string musicOrmovie = Console.ReadLine();

                Console.WriteLine($"Въведи музикант или актьор на DVD: ");
                string musicianOractor = Console.ReadLine();

                Console.WriteLine($"Въведи име на DVD-то: ");
                string mmName = Console.ReadLine();

                //тук създавам dvd-то
                Data data = new Data(name, genre);
                data.Id = i;
                data.Director = director;
                data.Duration = duration;
                data.MusicOrmovie = musicOrmovie;
                data.MusicianOractor = musicianOractor;
                data.MmName = mmName;
                
                //тук вкарвам dvd-то в списъка
                list.Add(data);


                Console.WriteLine();


                i++;
            } while (i < n + 1);

            //принтира всички данни от листа
            list.ForEach(x => x.Print());

            Console.WriteLine();

            Console.WriteLine("Въведи ID на DVD-то, който искаш да търсиш: ");
            int searchId = int.Parse(Console.ReadLine());
            //търси в листа ид-то което сме въвели
            Data search = list.Find(x => x.Id == searchId);
            //ако съществува го принти
            if (search != null)
            {
                search.Print();
            }
            //ако не съществува не го принти
            else
            {
                Console.WriteLine("Не съществува DVD с такова ID.");
            }

            Console.WriteLine();
            
            //взимам dvd и го ползвам за да извикам метода calculateaverage, не се ползва, само вика метода
            Data anyDataObject = list.FirstOrDefault();
            if (anyDataObject != null)
            {
                anyDataObject.CalculateAverage(list);
            }

            Console.WriteLine();

            Console.WriteLine("Най-дългият запис в минути е: ");

            Data longest = list.OrderByDescending(x => x.Duration).First();
            longest.Print();

            Console.WriteLine();

            CompareDVD comparer = new CompareDVD();
            list.Sort(comparer);
            Console.WriteLine("Сортиран списък по време в низходящ ред е: ");
            list.ForEach(x => x.Print());

            Console.WriteLine();

            string fileName = "DVD.txt";

            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var item in list)
                {
                    writer.WriteLine($"Id: {item.Id},Ime: {item.Name},Janr: {item.Genre},Rejisior: {item.Director},Vremetraene: {item.Duration},Tip: {item.MusicOrmovie},Izpulnitel: {item.MusicianOractor},Ime na izpulnitel: {item.MmName}");
                }
            }
            Console.WriteLine($"Файлът е създаден успешно s име {fileName}");
        }
    }
}