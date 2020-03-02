using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DayEight
{
    class Layer
    {
        string a;

        public Layer(string input)
        {
            a = input;
        }

        public Layer(string input,int size)
        {
            a = input.Substring(0, size);
        }

        public Layer(string input, int size,int start)
        {
            a = input.Substring(start, size);
        }

        public string ReturnLayer()
        {
            return a;
        }

        public int AmountChars(char a)
        {
            return this.ReturnLayer().Count(c => c == a);
        }

        public static Layer FinalLayer(Layer[] allLayers)
        {
            int pixelsPerLayer = allLayers[0].ReturnLayer().Length;
            string finalString = "";
            for (int i = 0; i < pixelsPerLayer; i++)
            {
                foreach(Layer u in allLayers)
                {
                    if (u.ReturnLayer().Substring(i, 1) != "2")
                    {
                        finalString += u.ReturnLayer().Substring(i, 1);
                        break;
                    }
                }
            }
            return new Layer(finalString);
        }

        public void printLayer(int wide,int tall)
        {
            int anzahlZeilen = this.ReturnLayer().Length / wide;
            for(int i = 0;i < anzahlZeilen; i++)
            {
                Console.WriteLine(this.ReturnLayer().Substring(i * wide, wide).Replace('0',' '));
            }
        }
    }
}
