using UnityEngine;

public class CameraRotation : MonoBehaviour { 

    public float rotationSpeed2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
   
        if (Input.GetKey(KeyCode.E))
            {
            transform.Rotate(Vector3.right * rotationSpeed2 * Time.deltaTime);
            }

        if (Input.GetKey(KeyCode.Q))
            {
            transform.Rotate(Vector3.left * rotationSpeed2 * Time.deltaTime);
            }
        
    }
}