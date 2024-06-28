using System.Collections.Generic;
using UnityEngine;

public class nighttime : MonoBehaviour
{
    // Start is called before the first frame update
    public Material nightskybox;

    void Start()
    {
        RenderSettings.skybox = nightskybox;
        RenderSettings.fogColor = new Color32(22, 23, 34, 225);
        RenderSettings.fogDensity = 0.03f;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
