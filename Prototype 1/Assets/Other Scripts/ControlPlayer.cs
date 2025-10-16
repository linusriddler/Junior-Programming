using UnityEngine;
using UnityEngine.UIElements;

public class ControlPlayer : MonoBehaviour
{
    private bool gameOver = false;
    public float velocity = 5.0f;
    public Rigidbody playerRb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move Up, Down, Left, and Right with W, S, A, and D
        if (Input.GetKeyUp(KeyCode.W) && gameOver == false)
        {
            playerRb.AddForce(Vector3.forward * velocity, ForceMode.Acceleration);
        }
        if (Input.GetKeyUp(KeyCode.D) && gameOver == false)
        {
            playerRb.AddForce(Vector3.right * velocity, ForceMode.Acceleration);
        }
        if (Input.GetKeyUp(KeyCode.A) && gameOver == false)
        {
            playerRb.AddForce(Vector3.left * velocity, ForceMode.Acceleration);
        }
        if (Input.GetKeyUp(KeyCode.S) && gameOver == false)
        {
            playerRb.AddForce(Vector3.back * velocity, ForceMode.Acceleration);
        }
    }
}
