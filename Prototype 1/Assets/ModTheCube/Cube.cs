using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    
    void Start()
    {
        transform.position = new Vector3(2, 2, 2);
        transform.localScale = Vector3.one * 2f;
        
        Material material = Renderer.material;
        
        material.color = new Color(5f, 10f, 3f, 4f);
    }
    
    void Update()
    {
        transform.Rotate(0f * Time.deltaTime, 1f, 0.0f);
    }
}
