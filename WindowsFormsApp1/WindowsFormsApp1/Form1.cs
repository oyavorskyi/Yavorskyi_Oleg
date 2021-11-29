using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static Dictionary<string, string> MyDictionary = new Dictionary<string, string>();
        List<string> KeyList;
        int currentID = 0;
        int decorID = 1;
        int changeID = 0;
        string pathRead = "uk.json.txt";
        string pathWrite = "uk.json.txt";
        public string current_translator = "OleLeafen";

        public static void ReadInDictionary(string path)
        {
            using (StreamReader sr = new StreamReader(path, Encoding.GetEncoding(1251)))
            {
                string[] textFromFile = System.Text.RegularExpressions.Regex.Split(sr.ReadToEnd(), "\":|\",");

                var z = textFromFile.Length - 1;

                MyDictionary.Add(textFromFile[0].Trim().Substring(5), textFromFile[1].Trim().Substring(1));
                for (int i = 2; i < textFromFile.Length - 3; i += 2)
                {
                    if ((i + 1) <= textFromFile.Length - 3)
                    {
                        //var set = textFromFile[i];
                        //var set1 = textFromFile[i].Trim().Substring(5);
                        try
                        {
                            MyDictionary.Add(textFromFile[i].Trim().Substring(1), textFromFile[i + 1].Trim().Substring(1));
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("\n=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=");
                            Console.WriteLine("----------------Alert!-----------------");
                            Console.WriteLine($"Exeption: {ex}");
                            Console.WriteLine($"\nKey: { textFromFile[i].Trim().Substring(1)}\nValue: { textFromFile[i + 1].Trim().Substring(1)}");
                            Console.WriteLine("=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=");

                            var inputValue = textFromFile[i + 1].Trim().Substring(1); var key = textFromFile[i].Trim().Substring(1); bool check = true;
                            var alredyValue = MyDictionary[key];
                            for (int j = 0; j < inputValue.Length; j++)
                            {
                                //var id = 'A';
                                //var test = keyValuePair.Value[i];
                                var currentUnicode = (int)(inputValue[j]);
                                if (currentUnicode >= 1040 && currentUnicode <= 1103)
                                {
                                    for (int k = 0; k < alredyValue.Length; k++)
                                    {
                                        //var id = 'A';
                                        //var test = keyValuePair.Value[i];
                                        currentUnicode = (int)(alredyValue[k]);
                                        if (currentUnicode >= 1040 && currentUnicode <= 1103)
                                        {
                                            check = false;
                                            break;
                                        }
                                    }

                                    if (check)
                                    {
                                        Console.WriteLine($"Value of key: {key} was changed.");
                                        MyDictionary[key] = inputValue;
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
                var stop = "Pause for check";
            }
        }

        public static void WriteInFile(string path, string current_translator)
        {
            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                //sw.WriteLine(MyDictionary.Keys);
                sw.WriteLine("{");
                foreach (KeyValuePair<string, string> keyValue in MyDictionary)
                {
                    sw.WriteLine($"\t\"{keyValue.Key}\": \"{keyValue.Value}\",");
                }
                sw.WriteLine($"\t\"current-translator\": \"{current_translator}\"");
                sw.WriteLine("}");
            }
        }

        private void StartTranslate_Click(object sender, EventArgs e)
        {          
            ReadInDictionary(pathRead);

            KeyList = MyDictionary.Keys.ToList();
            string resultOutBox = "", resultInBox = "";

            for (int i = currentID; i < KeyList.Count; i++)
            {
                bool check = true;
                var key = KeyList[i];
                var value = MyDictionary[key];
                for (int j = 0; j < value.Length; j++)
                {
                    //var id = 'A';
                    //var test = keyValuePair.Value[i];
                    var currentUnicode = (int)(value[j]);
                    if (currentUnicode >= 1040 && currentUnicode <= 1103)
                    {
                        check = false;
                        break;
                    }
                }

                if (check)
                {
                    decorID = i + 1;
                    resultOutBox = $"\n{decorID}. {key}: \r\n\t{value}";
                    resultInBox = $"{value}";
                    //Console.ReadKey();
                    currentID = i + 1;
                    break;
                }
            }

            listBox1.DataSource = new BindingSource(MyDictionary, null);
            listBox1.DisplayMember = "Key";
            listBox1.ValueMember = "Value";

            listBox1.SelectedIndex = decorID - 1;

            textOutBox.Text = resultOutBox;
            textInBox.Text = resultInBox;

            changeID = currentID - 1;
        }

        private void EndTranslate_Click(object sender, EventArgs e)
        {
            WriteInFile(pathWrite, current_translator);
            Process.Start(pathWrite);
        }

        private void NextExpresion_Click(object sender, EventArgs e)
        {
            string resultOutBox = "", resultInBox = "";

            for (int i = currentID; i < KeyList.Count; i++)
            {
                bool check = true;
                var key = KeyList[i];
                var value = MyDictionary[key];
                for (int j = 0; j < value.Length; j++)
                {
                    //var id = 'A';
                    //var test = keyValuePair.Value[i];
                    var currentUnicode = (int)(value[j]);
                    if (currentUnicode >= 1040 && currentUnicode <= 1103)
                    {
                        check = false;
                        break;
                    }
                }

                if (check)
                {
                    decorID = i + 1;
                    resultOutBox = $"\n{decorID}. {key}: \r\n\t{value}";
                    resultInBox = $"{value}";
                    listBox1.SelectedIndex = decorID - 1;
                    //Console.ReadKey();
                    currentID = i + 1;
                    break;
                }
            }

            textOutBox.Text = resultOutBox;
            textInBox.Text = resultInBox;
            changeID = currentID - 1;
        }

        private void ChangeValue_Click(object sender, EventArgs e)
        {
            var newValue = textInBox.Text;
            var proxyChangeID = changeID;
            MyDictionary[KeyList[changeID]] = newValue;


            listBox1.DataSource = new BindingSource(MyDictionary, null);
            listBox1.DisplayMember = "Key";
            listBox1.ValueMember = "Value";

            textOutBox.Text = $"\n{proxyChangeID + 1}. {KeyList[proxyChangeID]}: \r\n\t{MyDictionary[KeyList[proxyChangeID]]}";
            textInBox.Text = MyDictionary[KeyList[proxyChangeID]];
            listBox1.SelectedIndex = proxyChangeID;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] selectedKey = listBox1.SelectedItem.ToString().Split(new char[] { '[', ',' });
            string resultOutBox = $"\n{listBox1.SelectedIndex + 1}. {selectedKey[1]}: \r\n\t{listBox1.SelectedValue}";
            string resultInBox = $"{listBox1.SelectedValue}";

            changeID = listBox1.SelectedIndex;
            currentID = listBox1.SelectedIndex;

            textOutBox.Text = resultOutBox;
            textInBox.Text = resultInBox;
        }
    }
}
