using System;
using System.Linq;

namespace DayEight
{
    class Program
    {


        static void Main(string[] args)
        {



            int wide = 25;
            int tall = 6;
            //int wide = 2;
            //int tall = 2;
            int pixelsPerLayer = wide * tall;

            string text = System.IO.File.ReadAllText("input.txt");
            //string text = "0222112222120000";
            Console.WriteLine(text);
            Console.WriteLine(text.Length);

            int amountLayers = text.Length / pixelsPerLayer;

            Console.WriteLine(amountLayers);

            Layer[] AllLayers = new Layer[amountLayers];

            //Layer LayerOne = new Layer(text,);

            for (int i = 0; i < amountLayers; i++)
            {
                AllLayers[i] = new Layer(text,pixelsPerLayer,i*pixelsPerLayer);
            }

            Console.WriteLine(AllLayers[0].ReturnLayer());

            Console.WriteLine(AllLayers[0].AmountChars('0'));

            Layer THE_Layer = null;
            int minZeros = pixelsPerLayer+1;

            foreach (Layer i in AllLayers)
            {
                if (i.AmountChars('0') < minZeros)
                {
                    minZeros = i.AmountChars('0');
                    THE_Layer = i;
                }
            }

            Console.WriteLine("----------------------------------");

            Console.WriteLine(THE_Layer.ReturnLayer());
            Console.WriteLine(THE_Layer.AmountChars('0'));

            Console.WriteLine(THE_Layer.AmountChars('1')*THE_Layer.AmountChars('2'));

            ////////////////////
            /* START PART TWO */
            ////////////////////

            Layer AufgabeZweiLayer = Layer.FinalLayer(AllLayers);
            Console.WriteLine("----------------------------------");
            Console.WriteLine(AllLayers[0].ReturnLayer());
            Console.WriteLine(AllLayers[1].ReturnLayer());
            Console.WriteLine(AllLayers[2].ReturnLayer());
            Console.WriteLine(AllLayers[3].ReturnLayer());
            Console.WriteLine(AllLayers[4].ReturnLayer());
            Console.WriteLine(AufgabeZweiLayer.ReturnLayer());
            Console.WriteLine("----------------------------------");
            AufgabeZweiLayer.printLayer(wide, tall);


        }
    }
}
