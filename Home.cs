using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaterialSkin;
using MaterialSkin.Controls;

namespace ALGORITHME
{
    public partial class Home : MaterialForm
    {

        public const string CLE = "ISTIL";

        public Home()
        {
            InitializeComponent();

            //Initialision du style material
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE);

        }
        //Dictionnaire de la clé <position, lettre>
        public Dictionary<int,char> OrderCle(string cle)
        {
            int position = 0;
            char[] cleArray = cle.ToArray();
            char[] cleArrayOrder = cle.ToArray();
            
            Array.Sort(cleArrayOrder);
            //CleArrayOrder en Dictionnary
            Dictionary<int, char> cleDicOrder = new Dictionary<int, char>();
            foreach(char letter in cleArrayOrder)
            {
                cleDicOrder.Add(position, letter);
                position++;
            }

            
            Dictionary<int, char> dicOrder = new Dictionary<int, char>();

            foreach (char letter in cleArray)
            {
                foreach (KeyValuePair<int, char> currentPair in cleDicOrder)
                {
                    if (currentPair.Value == letter) 
                    {
                        dicOrder.Add(currentPair.Key, letter);
                        cleDicOrder.Remove(currentPair.Key);
                        break;
                    }
                }
            }
            return dicOrder;
        }

        public Dictionary<int, string> Encrypt(Dictionary<int, char> dicOrder, string phrase)
        {
            phrase.ToCharArray();

            Dictionary<int, string> result = new Dictionary<int, string>();
            foreach(KeyValuePair<int,char> kvp in dicOrder)
            {
                result.Add(kvp.Key, "");
            }

            int i = 0;
            //string[] blocs = new string[dicOrder.Count()];

            foreach (char lettre in phrase)
            {
                if (i >= dicOrder.Count())
                {
                    i = 0;
                }
                result[i] += lettre.ToString();
                i++;
            }

            return result;
        }

        public string ConvertMsg(Dictionary<int, string> crypt)
        {
            string phrase = "";

            foreach (KeyValuePair<int, string> kvp in crypt)
            {
                phrase += kvp.Value +" ";
            }
            return phrase;
        }

        private void LaunchAlgo(object sender, EventArgs e)
        {
            string input = inputWordToCrypt.Text;
            Dictionary<int, string> result =  Encrypt(OrderCle(CLE),input);
            string output = ConvertMsg(result);
            labelResultCrypt.Text = output;
        }
    }

    /*public Home()
    {
        InitializeComponent();

        //Initialision du style material
        MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
        materialSkinManager.AddFormToManage(this);
        materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

        materialSkinManager.ColorScheme = new ColorScheme(
            Primary.Blue400, Primary.Blue500,
            Primary.Blue500, Accent.LightBlue200,
            TextShade.WHITE);

        char[] v = OrderCle(CLE);
        Dictionary<string, char> crypt = fillCle(CLE, "L'ISTIL DEVIENT UNE ECOLE POLYTECHNIQUE");


        Dictionary<string, char>.KeyCollection myKeyCollection = crypt.Keys;

        // On parcourt les clefs (qui sont des objets de type string).

        //On parcourt la clé et pour chaque lettre on prend la premiere qui correspond puis on la delete
        char[] clesplit = CLE.ToCharArray();
        /*foreach (var lettre in clesplit)
        {
            foreach()
        }

    }

    public char[] OrderCle(string cle)
    {
        //char[] cleArray = cle.ToArray();
        char[] cleArrayOrder = cle.ToArray();
        Array.Sort(cleArrayOrder);
        return cleArrayOrder;
    }

    public Dictionary<string, char> fillCle(string cle, string str_phrase)
    {
        Dictionary<string, char> crypt = new Dictionary<string, char>();

        char[] orderCle = OrderCle(CLE);
        int tailleCle = orderCle.Length;
        int i = 0;
        int j = 0;
        char[] phrase = str_phrase.ToArray();
        string[] motscodés = new string[tailleCle];
        while (i < phrase.Length)
        {
            if (j < tailleCle)
            {
                motscodés[j] = motscodés[j] + phrase[i];
                j++;
                if (i < phrase.Length)
                    i++;
            }
            else
            {
                j = 0;
            }
        }
        for (int key = 0; key < motscodés.Length; key++)
        {
            crypt.Add(motscodés[key], orderCle[key]);
        }
        return crypt;
    }

    private String ToStringResult(Dictionary<string, char> crypt)
    {
        string result = "";
        foreach (KeyValuePair<string, char> kvp in crypt)
        {
            result += kvp.Key + " ";
        }

        return result;
    }

    private void launchAlgo(object sender, EventArgs e)
    {
        string input = inputWordToCrypt.Text

            labelResultCrypt.Text = ToStringResult(fillCle(CLE, input));
    }*/


}
