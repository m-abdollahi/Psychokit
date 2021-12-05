using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class txtfile : MonoBehaviour
{
    public float samplingRate = 10f; // sample rate in Hz
    private StreamWriter _sw;
    public string data1;
    public string data2;
    public string data3;

    public void OnEnable()
    {
        
        _sw = System.IO.File.AppendText("Your file name" + ".txt");
        _sw.WriteLine("Data to write here");



        InvokeRepeating("SampleNow", 0, 1 / samplingRate);
    }

    public void OnDisable()
    {
        _sw.Close();
        CancelInvoke();
    }

    public void SampleNow()
    {   
        _sw.WriteLine("data1 {0} data2 {1} data3 {2}",  data1, data2, data3);
    }

}
