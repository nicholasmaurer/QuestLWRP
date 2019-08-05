/* 
 * author : jiankaiwang
 * description : The script provides you with basic operations of first personal control.
 * platform : Unity
 * date : 2017/12
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FpsCharacterController : MonoBehaviour {

    public float speed = 10.0f;
    private float translation;
    private float straffe;

    [SerializeField] private GameObject cameraGo;

    private Vector3 initialPosition;
    // Use this for initialization
    void Start () {
        // turn off the cursor
        Cursor.lockState = CursorLockMode.Locked;
        initialPosition = cameraGo.transform.localPosition;
    }
	
	// Update is called once per frame
	void Update () {
        // Input.GetAxis() is used to get the user's input
        // You can furthor set it on Unity. (Edit, Project Settings, Input)
        translation = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        straffe = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(straffe, 0, translation);

        if (Input.GetKeyDown("escape")) {
            // turn on the cursor
            Cursor.lockState = CursorLockMode.None;
        }

        if (Input.GetKey(KeyCode.LeftControl))
        {
            cameraGo.transform.localPosition = initialPosition + Vector3.down;
        }
        else
        {
            cameraGo.transform.localPosition = initialPosition;
        }
    }
}
