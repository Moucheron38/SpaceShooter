using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicManager : MonoBehaviour
{
    public AudioMixerSnapshot GameStart;
    // Start is called before the first frame update
    void Start()
    {
        GameStart.TransitionTo(0.01f);
    }

}
