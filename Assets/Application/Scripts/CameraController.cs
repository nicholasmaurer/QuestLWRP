using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public static CameraController Instance;

    private void Awake()
    {
        if (!Application.isEditor)
        {
            gameObject.SetActive(false);
            return;
        }
        
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }
}
