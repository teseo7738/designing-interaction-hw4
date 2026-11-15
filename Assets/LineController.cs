using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class LineController : MonoBehaviour
{
    [SerializeField] MouseMove mouse;
    [SerializeField] ContactSlime contact;

    private LineRenderer lr;
    private Vector3 mousePos;
    private Vector3 contactPos;

    private float lineLength;
    private float maxLineLength = 5f;

    private void Awake()
    {
        lr = GetComponent<LineRenderer>();
    }

    private void Start()
    {
        GetComponent<LineRenderer>().enabled = false;
    }

    private void Update()
    {
        mousePos = mouse.transform.position;
        contactPos = contact.contactPt;

        lr.positionCount = 2;

        if(contactPos != null)
        {
            lr.SetPosition(0, contactPos);
            lr.SetPosition(1, mousePos);
        }


        lineLength = Vector2.Distance(contactPos, mousePos);

        if(lineLength >= maxLineLength)
        {
            contact.contacted = false;

            Vector3 midpoint = (contactPos + mousePos) / 2f;

            lr.SetPosition(0, contactPos);
            lr.SetPosition(1, mousePos);


            GetComponent<LineRenderer>().enabled = false;

        }

    }

}
