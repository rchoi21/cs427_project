using UnityEngine;

public class ToggleDirectionalLight : MonoBehaviour
{
    private Light dirLight;
    public KeyCode toggleKey = KeyCode.Space;  // Key to toggle the light

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
        if (Input.GetKeyDown(toggleKey))
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
