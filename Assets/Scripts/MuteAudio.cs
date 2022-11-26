using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteAudio : MonoBehaviour
{
    public void MuteToggle(bool playing)
    {
        if (playing)
        {
           AudioListener.volume = 1; 
        }
        else
        {
            AudioListener.volume = 0;
        }
    }
}