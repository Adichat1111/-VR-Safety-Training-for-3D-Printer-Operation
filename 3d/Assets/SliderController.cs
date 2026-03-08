using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SliderController : MonoBehaviour
{
    private Slider slider;
    public GameObject arm;
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
    }
    public void ArmPositionController()
    {
        Animator armVertical = arm.GetComponent<Animator>();
        armVertical.SetFloat("PositionValue", slider.value);
    }
}
