using System.Collections;
using UnityEngine;

public class DoorOpenScript : MonoBehaviour
{
    public float openSpeed = 1.0f;          // Speed at which the door opens
    public float openAngle = 90.0f;         // Angle by which the door rotates when opened (e.g., 90 degrees)
    public Vector3 rotationAxis = Vector3.up; // Axis around which the door will rotate (default is Y axis for a typical door)

    private Quaternion closedRotation;      // The original rotation of the door
    private Quaternion openRotation;        // The target rotation of the door
    private bool isOpen = false;         // Flag to check if the door is open

    private void Start()
    {
        closedRotation = transform.rotation;
        openRotation = Quaternion.Euler(rotationAxis * -openAngle) * closedRotation;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isOpen)
        {

            StartCoroutine(OpenDoor());
        }
    }

    private IEnumerator OpenDoor()
    {
        float t = 0;
        while (t < 1.0f)
        {
            t += Time.deltaTime * openSpeed;
            transform.rotation = Quaternion.Slerp(closedRotation, openRotation, t);
            yield return null;
        }

        isOpen = true;

    }

    // A getter for playMusic Script for whether the door is opened
    public bool get_isOpen()
    {
        return isOpen;
    }

}
