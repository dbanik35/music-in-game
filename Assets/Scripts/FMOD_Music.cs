using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMOD.Studio;


public class FMOD_Music : MonoBehaviour
{
    public FMODUnity.StudioEventEmitter soundtrackemitter;
    private bool isMusicPlaying;

    // Start is called before the first frame update
    void Start()
    {
        soundtrackemitter.SetParameter("Switch_parts", 0);
        soundtrackemitter.Play();

        isMusicPlaying = true;
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.E))
        {
            if (isMusicPlaying)
            {
                soundtrackemitter.Stop();
                isMusicPlaying = !isMusicPlaying;
            }
            else
            {
                soundtrackemitter.Play();
                isMusicPlaying = !isMusicPlaying;
            }

        }
    }
}
            
