using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;


public class Mysql : MonoBehaviour
{

    public void Startsub()
    {
        //StartCoroutine(GetUsers());
        //StartCoroutine(Login("mostafa","m"));
        StartCoroutine(RegisterUser("Your Variables","Yourv ariable"));
    }


    IEnumerator GetUsers()
    {
        UnityWebRequest www = UnityWebRequest.Get("Your GET_USER WEBSITE ADRESS HERE");
        yield return www.SendWebRequest();

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log(www.error);
        }
        else
        {
            // Show results as text
            Debug.Log(www.downloadHandler.text);

            // Or retrieve results as binary data
            byte[] results = www.downloadHandler.data;
        }
    }


    IEnumerator RegisterUser(string var1, string var2) //YOur variables to save gonna be here
    {
        WWWForm form = new WWWForm();
        form.AddField("loginUser", var1);
        form.AddField("loginAge", var2);
        



        using (UnityWebRequest www = UnityWebRequest.Post("Your REGISTER WEBSITE ADRESS HERE", form))
        {
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
            }
        }
    }
}
