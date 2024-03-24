using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public float sensitivity=10.0f;
    private float rotX = 0.0f;
    private float rotY = 0.0f;
    private GameObject character;
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        this.character = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.timeScale > 0.0f)
        {
            float x = Input.GetAxis("Mouse X") * this.sensitivity;
            float y = Input.GetAxis("Mouse Y") * -this.sensitivity;

            this.character.transform.Rotate(0,x,0);

            this.rotX += y;
            this.rotY += x;

            this.transform.eulerAngles = new Vector3(this.rotX, this.rotY, 0.0f);
        }
    }
}
