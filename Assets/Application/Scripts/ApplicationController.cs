using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationController : MonoBehaviour
{
    public SpawnPoint SpawnPoint;
    public Bounds sceneBounds;
    public GameObject vrCamera;
    public GameObject firstPersonCamera;
    public GameObject ovrManagerGo;
    public static ApplicationController Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if(Instance != this)
        {
            Destroy(gameObject);
        }

        if (SpawnPoint != null)
        {
            if (Application.isEditor)
            {
                if (vrCamera != null)
                {
                    vrCamera.SetActive(false);
                }
                firstPersonCamera.transform.position = SpawnPoint.transform.position + new Vector3(0, 1, 0);
                firstPersonCamera.transform.rotation = SpawnPoint.transform.rotation;
                DontDestroyOnLoad(firstPersonCamera.gameObject);
            }
            else
            {
                firstPersonCamera.SetActive(false);
                vrCamera.transform.position = SpawnPoint.transform.position + new Vector3(0, 2, 0);
                vrCamera.transform.rotation = SpawnPoint.transform.rotation;
                DontDestroyOnLoad(vrCamera.gameObject);
            }
        }
        else
        {
            
        }

        if (ovrManagerGo != null)
        {
            DontDestroyOnLoad(ovrManagerGo);
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 75;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
