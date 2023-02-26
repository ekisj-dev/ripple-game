using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioOnCollide : MonoBehaviour
{

    public AudioSource audioToPlay;
    public List<AudioSource> randomAudios;

    public bool randomOnEachOccurrence = false;

    private int randomIndex;

    // Start is called before the first frame update
    void Start()
    {
        randomIndex = (int) (Random.value * 1000);

        if (null == audioToPlay && randomAudios.Count > 0)
        {
            audioToPlay = getRandomAudio();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioOnCollide otherAudio = collision.gameObject.GetComponent<AudioOnCollide>();

        if (null != otherAudio)
        {
            int otherRandomIndex = otherAudio.randomIndex;

            if (this.randomIndex < otherRandomIndex)
            {
                return;
            }
            // If equal, then both play
        }

        audioToPlay.Play();

        if (randomOnEachOccurrence)
        {
            audioToPlay = getRandomAudio();
        }
    }

    private AudioSource getRandomAudio()
    {
        return randomAudios[Random.Range(0, randomAudios.Count)];
    }
}
