using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Zala
{
    public class Data : DVD 
    {
        public Data(string name, string genre) : base(name, genre)
        {

        }

        private int id;
        private string director;
        private float duration;
        private string musicOrmovie;
        private string musicianOractor;
        private string mmName;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Director
        {
            get { return director; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("value");
                }
                director = value;
            }
        }

        public float Duration
        { 
            get { return duration; } 
            set 
            { 
                if (value <= 0)
                {
                    throw new ArgumentException("value");
                }
                duration = value;
            }
        }

        public string MusicianOractor
        {
            get { return musicianOractor; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("value");
                }
                musicianOractor = value;
            }
        }

        public string MusicOrmovie
        {
            get { return musicOrmovie; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("value");
                }
                musicOrmovie = value;
            }
        }

        public string MmName
        {
            get { return mmName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("value");
                }
                mmName = value;
            }
        }

        public override void CalculateAverage(List<Data> list)
        {
            float sum = 0;
            foreach (var item in list)
            {
                sum += item.Duration;
            }

            Console.WriteLine($"Средната продължителност на DVD-тата е {sum / list.Count}");
        }

        public override void Print()
        {
            Console.WriteLine($"Номера на DVD-то {id}, Режисьорът е {director}," +
            $"DVD-то в минути е {duration}," +
            $"DVD-то е {musicOrmovie}," +
            $"и главният {musicianOractor} е {mmName}");
            
        }
    }
}
