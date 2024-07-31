using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggle_weather_debug : MonoBehaviour
{
    // Start is called before the first frame update

    public Material dayskybox;
    public Material morningskybox;
    public Material nightskybox;
    public Material rainyskybox;
    public Light directionalLight;
    public ParticleSystem snow;

    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyDown("1"))
        {
            snow.Stop();
            snow.Clear();
            directionalLight.enabled = true;
            RenderSettings.skybox = dayskybox;
            RenderSettings.fogColor = new Color32(150, 150, 150, 150);
            RenderSettings.fogDensity = 0.0001f;
        }
        if (Input.GetKeyDown("2"))
        {
            snow.Stop();
            snow.Clear();
            directionalLight.enabled = false;
            RenderSettings.skybox = morningskybox;
            RenderSettings.fogColor = new Color32(255, 255, 255, 225);
            RenderSettings.fogDensity = 0.0001f;
        }
        if (Input.GetKeyDown("3"))
        {
            snow.Stop();
            snow.Clear();
            directionalLight.enabled = false;
            RenderSettings.skybox = nightskybox;
            RenderSettings.fogColor = new Color32(22, 23, 34, 225);
            RenderSettings.fogDensity = 0.03f;
        }
        if (Input.GetKeyDown("4"))
        {
            snow.Play();
            snow.Clear();
            directionalLight.enabled = false;
            RenderSettings.skybox = rainyskybox;
            RenderSettings.fogColor = new Color32(150, 150, 150, 255);
            RenderSettings.fogDensity = 0.005f;
        }
    }
}
