using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playMusic : MonoBehaviour
{
    public AudioSource mp3;
    public DoorOpenScript door;

    // Start is called before the first frame update
    void Start()
    {
        mp3 = GetComponent<AudioSource>();
        mp3.Pause();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!mp3.isPlaying)
        {
            mp3.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (door.get_isOpen())
        {
            mp3.Pause();
        }
    }

}