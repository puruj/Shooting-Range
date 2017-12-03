using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrinttoText : MonoBehaviour {

    public void WriteToText(string message)
    {
        using (System.IO.StreamWriter logFile = new System.IO.StreamWriter(@"C:\Users\Puru\Desktop\LogFile.txt"))
        {
            logFile.WriteLine(message);
        }
    }
}
