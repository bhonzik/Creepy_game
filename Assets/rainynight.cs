using System.Collections.Generic;
using UnityEngine;

public class rainynight : MonoBehaviour
{
    // Start is called before the first frame update
    public Material rainyskybox;

    void Start()
    {
        RenderSettings.skybox = rainyskybox;
        RenderSettings.fogColor = new Color32(150, 150, 150, 255);
        RenderSettings.fogDensity = 0.005f;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
