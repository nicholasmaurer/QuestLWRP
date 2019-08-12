using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitUntil(() => SceneController.Instance);
        yield return new WaitUntil(()=> SceneController.Instance.vrCamera);
        if (SceneController.Instance.vrCamera != this.gameObject)
        {
            if (SceneController.Instance.firstPersonCamera.gameObject != this.gameObject)
            {
                this.gameObject.SetActive(false);
            }   
        }
        yield return new WaitUntil(()=> SceneController.Instance.firstPersonCamera);
        if (SceneController.Instance.firstPersonCamera.gameObject)
        {
            if (SceneController.Instance.vrCamera != this.gameObject != this.gameObject)
            {
                this.gameObject.SetActive(false);
            }   
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
