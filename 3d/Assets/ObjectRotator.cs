using UnityEngine;
using UnityEngine.UI;

public class ObjectRotator : MonoBehaviour
{
    public Slider rotationSlider;
    private Quaternion initialRotation;

    private void Start()
    {
        // Store the initial rotation of the object as a Quaternion
        initialRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        // Apply the initial rotation and then rotate based on the inverted slider value
        float invertedRotation = -rotationSlider.value; // Invert the rotation direction
        transform.rotation = initialRotation * Quaternion.Euler(0, 0, invertedRotation);
    }
}
