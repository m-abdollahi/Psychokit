using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.time);  //Current time
        Debug.Log(Time.realtimeSinceStartup);  //Time from App lunch

    }
}
