using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float currentDogDelay = 0f;
    private float totalDogDelay = 1f;

    // Update is called once per frame
    void Update()
    {
        if (totalDogDelay > 0)
        {
            currentDogDelay -= Time.deltaTime;
        }
        else 
        {
            currentDogDelay = 0;
        }
        if (currentDogDelay < 0f)
        {
            // On spacebar press, send dog
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                currentDogDelay += totalDogDelay;
            }
        }
    }
}
