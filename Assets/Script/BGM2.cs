using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM2 : MonoBehaviour
{

    float seconds = 0;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        seconds += Time.deltaTime;

        if (seconds <= 12)
        {
            audioSource.Pause();
        }
        else if (seconds >= 12.1)
            audioSource.UnPause();
    }
}
