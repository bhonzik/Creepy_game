using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class daytime : MonoBehaviour
{
    // Start is called before the first frame update
    public Material dayskybox;
    public Light directionalLight;

    void Start()
    {
        directionalLight.enabled = true;
        RenderSettings.skybox = dayskybox;
        RenderSettings.fogColor = new Color32(150, 150, 150, 150);
        RenderSettings.fogDensity = 0.0001f;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
