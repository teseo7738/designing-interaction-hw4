using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMove : MonoBehaviour
{
    //[SerializeField] ContactSlime contact;

    public Vector3 mousePos;

    public float mouseSpeed;

    public float normalSpeed = 2f;
    public float slowSpeed = 0.001f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;

    }


    private void Update()
    {
        mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);


        //if (contact.contacted)
        //{
        //    mouseSpeed = 0.005f;
        //}
        //else
        //{
        //    mouseSpeed = 2f;
        //    //Debug.Log("Speed is normal");
        //}
    }
    void LateUpdate()
    {
        transform.position = Vector2.Lerp(transform.position, mousePos, mouseSpeed);
    }
}
