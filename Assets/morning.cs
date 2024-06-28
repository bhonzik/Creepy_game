using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class daynightcycle : MonoBehaviour
{
    // Start is called before the first frame update
    public Material dayskybox;

    void Start()
    {
        RenderSettings.skybox = dayskybox;
        RenderSettings.fogColor = new Color32(255, 255, 255, 225);
        RenderSettings.fogDensity = 0.0001f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
