using System.Collections.Generic;
using UnityEngine;

public class nighttime : MonoBehaviour
{
    // Start is called before the first frame update
    public Material nightskybox;

    void Start()
    {
        RenderSettings.skybox = nightskybox;
        RenderSettings.fogColor = new Color32(13, 13, 23, 225);
        RenderSettings.fogDensity = 0.01f;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
