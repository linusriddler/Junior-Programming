using System.Collections.Generic;
using UnityEngine;

public class CongratScript : MonoBehaviour
{
    public TextMesh Text;
    public ParticleSystem SparksParticles;

    private List<string> TextToDisplay;
    private float RotatingSpeed = 60f; // degrees per second
    private float TimeToNextText;
    private int CurrentText;

    private Vector3 textCenter; // Used for manual rotation

    void Start()
    {
        TimeToNextText = 0.0f;
        CurrentText = 0;

        TextToDisplay = new List<string>
        {
            "Congratulations!",
            "All Errors Fixed!"
        };

        Text.text = TextToDisplay[CurrentText];

        if (SparksParticles != null)
            SparksParticles.Play();

        // Estimate text center based on renderer bounds
        textCenter = Text.GetComponent<Renderer>().bounds.center;
    }

    void Update()
    {
        TimeToNextText += Time.deltaTime;

        // Switch text every 1.5 seconds
        if (TimeToNextText > 1.5f)
        {
            TimeToNextText = 0.0f;
            CurrentText = (CurrentText + 1) % TextToDisplay.Count;
            Text.text = TextToDisplay[CurrentText];

            // Update center since text size may change
            textCenter = Text.GetComponent<Renderer>().bounds.center;
        }

        // Rotate around the center of the text
        Text.transform.RotateAround(textCenter, Vector3.up, RotatingSpeed * Time.deltaTime);
    }
}