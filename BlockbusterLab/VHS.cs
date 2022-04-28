using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockbusterLab
{
    class VHS : Movie
    {
        public VHS(string Title, int RunTime, Genre Category, params string[] Scenes)
               : base(Title, RunTime, Category, Scenes)

        {
        }

        public int CurrentScene { get; set; }
        public override void Play()
        {
            Console.WriteLine(CurrentScene);
            CurrentScene++;

           
        }
        public void Rewind()
        {
            CurrentScene = 0;
        }
    }
}
