using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SpawnPoint : MonoBehaviour
{
    IEnumerator Start()
    {
        yield return new WaitUntil(()=> SceneController.Instance.vrCamera);
        yield return new WaitUntil(()=> SceneController.Instance.firstPersonCamera);
        if (Application.isEditor)
        {
            SceneController.Instance.vrCamera.SetActive(false);
            SceneController.Instance.firstPersonCamera.transform.position = transform.position + new Vector3(0, 1, 0);
            SceneController.Instance.firstPersonCamera.transform.rotation = transform.rotation;
        }
        else
        {
            SceneController.Instance.firstPersonCamera.SetActive(false);
            SceneController.Instance.vrCamera.transform.position = transform.position + new Vector3(0, 2, 0);
            SceneController.Instance.vrCamera.transform.rotation = transform.rotation;
        }
    }
}
