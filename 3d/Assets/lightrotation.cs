using UnityEngine;

public class RotatelightObject : MonoBehaviour
{
    // Speed of rotation
    public float rotationSpeed = 50f;

    void Update()
    {
        // Rotate the object around the y-axis based on the rotation speed
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
