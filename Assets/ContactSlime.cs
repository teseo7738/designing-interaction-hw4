using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactSlime : MonoBehaviour
{
    public Vector3 contactPt;
    public LineController lc;

    public bool contacted = false;

    public void OnTriggerEnter2D(Collider2D other)
    {
        contactPt = other.transform.position;
        contacted = true;
        lc.GetComponent<LineRenderer>().enabled = true;
    }

}
