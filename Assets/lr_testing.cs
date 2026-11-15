using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lr_testing : MonoBehaviour
{
    [SerializeField] private Transform[] points;
    [SerializeField] private LineController line;

    [SerializeField] MouseMove mouse;
    [SerializeField] ContactSlime contact;

    //private void Update()
    //{
    //    if (mouse != null && contact.contactPt != null)
    //    {
    //        line.SetUpLine(points);
    //    }
    //}
}
