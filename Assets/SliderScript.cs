using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    [SerializeField] Slider slider;
    [SerializeField] MouseMove mouse;
    [SerializeField] ContactSlime contact;

    // Start is called before the first frame update
    void Start()
    {
        slider.onValueChanged.AddListener((v) =>
        {
            slider.value = v; //everytime value changes, we'll change
            Debug.Log(slider.value);
        }); 
    }

    // Update is called once per frame
    void Update()
    {
        if (contact.contacted)
        {
            mouse.mouseSpeed = slider.value;
        }
        else
        {
            mouse.mouseSpeed = 2f;
        }
    }
}
