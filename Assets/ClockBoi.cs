using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ClockBoi : MonoBehaviour
{
    public GameObject time_display;
    public GameObject input_field;
    public GameObject system_dialog_box;
    public string user_input;
    public int hour;
    public int minutes;
    public int seconds;


    // Update is called once per frame
    void Update()
    {
        hour = System.DateTime.Now.Hour;
        minutes = System.DateTime.Now.Minute;
        seconds = System.DateTime.Now.Second;
        time_display.GetComponent<Text>().text = "" + hour + ":" + minutes + ":" + seconds;
    }

    public void time_check()
    {
        user_input = input_field.GetComponent<Text>().text;
        if (user_input == "what is the time?")
        {
            hour = System.DateTime.Now.Hour;
            minutes = System.DateTime.Now.Minute;
            seconds = System.DateTime.Now.Second;
            system_dialog_box.GetComponent<Text>().text = "At the moment the time is " + hour + ":" + minutes + ":" + seconds;
        }

    }
}
