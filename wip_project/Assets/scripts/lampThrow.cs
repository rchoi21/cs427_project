using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lampThrow : MonoBehaviour
{
    public Light RoomLight;

    public GrabbableObject lamp;

    public float intensity = 0;
    public float range = 0;

    // Room1Light == Room1Light.intensity = 0.8F; && Room1Light.range = 80;
    // Room1Light == Room1Light.intensity = 0.6F; && Room1Light.range = 60;

    // Start is called before the first frame update
    void Start()
    {
        RoomLight = GetComponent<Light>();
        RoomLight.intensity = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // if lamp1 gets thrown
        if (lamp.getGrabbed() == false && lamp.getWasGrabbed() == true)
        {
            // Debug.Log("Am i ever here?");
            RoomLight.intensity = intensity;
            RoomLight.range = range;
        }
    }
}
