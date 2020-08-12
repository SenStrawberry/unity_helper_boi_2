using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class executibleApp
{
    public string appName { get; set; }
    public string fileLocation { get; set; }
}
public class input_and_processing : MonoBehaviour
{
    public string[] workspace_list = { "Blender", "Chrome"};
    public string user_input;   
    public GameObject input_field;
    public GameObject text_display;



    public void store_user_input()
    {
        user_input = input_field.GetComponent<Text>().text;
        text_display.GetComponent<Text>().text = "user said: " + user_input;
    }

    public void open_command() 
    {
        if(user_input == "open")
        {

            Process.Start("C:\\Program Files\\Blender Foundation\\Blender 2.82\\blender.exe");

        }
    }

    string filePath = @"C:\Users\Spencer\Documents\Homework\A_levels\NEA\app_locations.txt";
    Dictionary<string, executibleApp> apps = new Dictionary<string, executibleApp>();
    List<string> lines = new List<string>();
    private void Start() {
        lines = File.ReadAllLines(filePath).ToList();

        foreach (var line in lines) {
            string[] column = line.Split(',');

            executibleApp newApp = new executibleApp();

            newApp.appName = column[0];
            newApp.fileLocation = column[1];

            //apps.Add(newApp);
            try {
                apps.Add(newApp.appName, newApp);
            }
            catch {

            }
        }
    }


    //Open workspaces
    public void multi_open()
    {
        foreach (string i in workspace_list) {
            Process.Start($"{ apps[i].fileLocation}.exe");
        }

    }
}
