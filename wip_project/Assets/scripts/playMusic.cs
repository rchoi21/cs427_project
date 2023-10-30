using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playMusic : MonoBehaviour
{
    public bool play;
    public AudioSource wavFile;
    public DoorOpenScript door;

    // Start is called before the first frame update
    void Start()
    {
        wavFile = GetComponent<AudioSource>();
        door = GetComponent<DoorOpenScript>();
        //Debug.Log("play: " + play);
    }

    // Update is called once per frame
    void Update()
    {
        if (play)
        {
            //Debug.Log("first layer?");
            if (door.get_isOpen())
            {
                //Debug.Log("second layer?");
                wavFile.playOnAwake = true;
                wavFile.loop = true;
                wavFile.Play();
            }
        }
        else
        {
            Debug.Log("am i ever here?");
            wavFile.Pause();
        }
    }
}
