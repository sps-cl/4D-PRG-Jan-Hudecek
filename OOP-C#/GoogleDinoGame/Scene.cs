using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleDinoGame
{
    public class Scene
    {
        private string[,] _scene;
        private int _width;
        private int _height;

        public Scene(int width, int height)
        {
            _width = width;
            _height = height;
            _scene = new string[height, width];
        }

        private void Clear()
        {
            for (int i = 0; i < _height; i++)
            {
                for (int j = 0; j < _width; j++)
                {
                    _scene[i, j] = "  ";
                }
            }

            Console.Clear();
        }

        public void Draw(params IDrawable[] drawables)
        {
            Clear();

            foreach (var drawable in drawables)
            {
                drawable.Draw(_scene);
            }

            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < _height; i++)
            {
                for (int j = 0; j < _width; j++)
                {
                    stringBuilder.Append(_scene[i, j]);
                }

                //Console.WriteLine(Highscore: + Program.score);
                Console.Write(stringBuilder.ToString());
                stringBuilder.Clear();
                stringBuilder.Append("\n");
            }
        }
    }
}
