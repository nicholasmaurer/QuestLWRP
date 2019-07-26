using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPSDisplay : MonoBehaviour
{
    public float deltaTime;
    public float msec;
    public float fps;
    public Text text;
    void Update()
    {
        deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;
        msec = deltaTime * 1000.0f;
        fps = 1.0f / deltaTime;
        text.text = fps.ToString("F1");
    }
 
//    void OnGUI()
//    {
//        int w = Screen.width, h = Screen.height;
// 
//        GUIStyle style = new GUIStyle();
// 
//        Rect rect = new Rect(0, 0, w, h * 2 / 100);
//        style.alignment = TextAnchor.UpperLeft;
//        style.fontSize = h * 2 / 100;
//        style.normal.textColor = new Color (0.0f, 0.0f, 0.5f, 1.0f);
            
//        string text = string.Format("{0:0.0} ms ({1:0.} fps)", msec, fps);
//        GUI.Label(rect, text, style);
//    }
}