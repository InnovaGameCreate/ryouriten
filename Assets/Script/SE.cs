using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE : MonoBehaviour
{
    public AudioClip sound1;
    public AudioClip sound2;
    public AudioClip sound3;
    AudioSource audioSource;

    float seconds = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Component‚ðŽæ“¾
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        seconds += Time.deltaTime;

        if (seconds >= 3.0 && seconds <= 3.1)
        {
            //‰¹(sound1)‚ð–Â‚ç‚·
            audioSource.PlayOneShot(sound1);
        }

        if (seconds >= 120.0 && seconds <= 120.1)
            audioSource.PlayOneShot(sound2);

        if (seconds >= 180.0 && seconds <= 180.1)
            audioSource.PlayOneShot(sound3);
    }
}
