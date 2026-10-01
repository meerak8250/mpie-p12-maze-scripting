using UnityEngine;

public class mazeRotation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float rotationSpeed = 1.0f;
    void Start()
    {
    
}

// Update is called once per frame
void Update()
{
    float tiltX = Input.GetAxis("Vertical")*rotationSpeed*Time.deltaTime;
    float tiltZ = Input.GetAxis("Horizontal")*rotationSpeed*Time.deltaTime;
 
    transform.Rotate(tiltX, 0, tiltZ);
    
}
}
