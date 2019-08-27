using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedTransition : MonoBehaviour
{
    public float seconds = 60;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(seconds);
        SceneController.Instance.StartCoroutine(SceneController.Instance.LoadNextScene());
    }
}
