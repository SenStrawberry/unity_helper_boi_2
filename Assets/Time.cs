using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;


public class Time : MonoBehaviour 
{ 
    public GameObject time_display;
    public GameObject input_field;
    public GameObject system_dialog_box;
    public GameObject test_display;
    public string user_input;
    public int hour;
    public int minutes;
    public int seconds;
    public int date_day;

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
        if (user_input == "what is the time?") {
            hour = System.DateTime.Now.Hour;
            minutes = System.DateTime.Now.Minute;
            seconds = System.DateTime.Now.Second;
            system_dialog_box.GetComponent<Text>().text = "At the moment the time is " + hour + ":" + minutes;
           
        }

    }

    public void date_check()
    {
        date_day = System.DateTime.Now.Day;
        test_display.GetComponent<Text>().text = "" + date_day;
    }






}
