using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnabledOrDisabled : MonoBehaviour
{
    public GameObject lightSpot;

    public void Trigger()
    {
        if(lightSpot.activeInHierarchy == false)
        {
            lightSpot.SetActive(true);

        }
        else
        {
            lightSpot.SetActive(false);
        }
    }
}
