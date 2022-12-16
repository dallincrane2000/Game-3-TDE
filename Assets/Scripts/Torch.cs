using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Rendering.Universal;


public class Torch : MonoBehaviour
{
    public float flickerSpeed = 0.5f;
    public float flickerAmount = 0.1f;

    public AudioSource TorchSound;

    private Light2D light;
    private float baseIntensity;

    void Start()
    {
        // Get the light component
        light = GetComponent<Light2D>();

        // Store the base intensity of the light
        baseIntensity = light.intensity;

        TorchSound.Play();
    }

    void Update()
    {
        // Generate a random noise value using Perlin noise
        float noise = Mathf.PerlinNoise(Time.time * flickerSpeed, 0);

        // Use the noise value to control the intensity of the light
        light.intensity = baseIntensity + noise * flickerAmount;
    }
}




