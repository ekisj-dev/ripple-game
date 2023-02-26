using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{

    public static AudioController Instance { get; private set; }

    List<AudioSource> childAudioSources;

    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.

        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }

        childAudioSources = new List<AudioSource>(this.GetComponentsInChildren<AudioSource>());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public AudioSource getRandomAudioSource()
    {
        return childAudioSources[Random.Range(0, childAudioSources.Count)];
    }
}
