using UnityEngine;
using System.Collections;

public class ToggleDirectionalLight : MonoBehaviour
{
    private Light dirLight;
    public CAVE2.Button toggleKey = CAVE2.Button.Button5;
    public int wandID = 1;

    private void Start()
    {
        dirLight = GetComponent<Light>();

        // Check if the light component is attached
        if (dirLight == null)
        {
            Debug.LogError("No Light component found on this GameObject. Please attach this script to a Directional Light.");
        }
    }

    private void Update()
    {
    Debug.Log(CAVE2.Input.GetButton(1, toggleKey));

        if (CAVE2.Input.GetButton(wandID,toggleKey))
        {
            ToggleLight();
        }
    }

    void ToggleLight()
    {
        if (dirLight != null)
        {
            dirLight.enabled = !dirLight.enabled;
        }
    }
}
