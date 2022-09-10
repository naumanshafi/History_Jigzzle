using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEditor;

public class score_text : MonoBehaviour
{
    public  Text txt;
    public  Text txt_1;
    public  Text txt_2;
    public  Text txt_3;
    public static string[] word;
    void Start()
    {
        WriteString();
        ReadString();
        txt.text = "1st Highest:  " + word[0];
        txt_1.text = "2nd Highest:  " + word[1];
        txt_2.text = "3rd Highest:  " + word[2];
        txt_3.text = "4th Highest:  " + word[3];
    }
    static void WriteString()
    {
        string path = "Assets/Resources/score.txt";

        //Write some text to the test.txt file
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine("0,0,0,0");
        writer.Close();
    }
    static void ReadString()
    {
        
        string path = "Assets/Resources/score.txt";
        string line;
        //Read the text from directly from the test.txt file
        StreamReader reader = new StreamReader(path);
        while ((line=reader.ReadLine())!=null)
        {
            try
            {
                word = line.Split(',');
               
            }
            catch
            {

            }
        }
        Debug.Log(reader.ReadToEnd());
        reader.Close();
    }
}

