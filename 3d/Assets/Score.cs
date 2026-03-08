using System.Collections;
using System.Collections.Generic; 
using UnityEngine; 
using TMPro;
public class Score : MonoBehaviour
{
    public TextMeshProUGUI numberText;
    int counter = 1000;
    public void Increase()
    {
        counter++;
        numberText.text = counter + "";
    }
        public void Decrease()
        {
            counter--;
            numberText.text = counter + "";
        }
    void Start()
    {

    }
    void Update()
    {

    }
}

