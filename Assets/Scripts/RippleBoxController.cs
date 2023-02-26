using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RippleBoxController : MonoBehaviour
{

    public AudioSource audioToPlay;

    public bool randomOnEachOccurrence = false;

    private int randomIndex;

    // Start is called before the first frame update
    void Start()
    {
        randomIndex = (int)(Random.value * 1000);

        if (null == audioToPlay)
        {
            audioToPlay = AudioController.Instance.getRandomAudioSource();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        RippleBoxController otherBox = collision.gameObject.GetComponent<RippleBoxController>();

        if (null != otherBox)
        {
            int otherRandomIndex = otherBox.randomIndex;

            if (this.randomIndex < otherRandomIndex)
            {
                return;
            }
            // If equal, then both play
        }

        audioToPlay.Play();

        if (randomOnEachOccurrence)
        {
            audioToPlay = AudioController.Instance.getRandomAudioSource();
        }
    }
}
