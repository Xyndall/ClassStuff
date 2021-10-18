using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTest : MonoBehaviour
{

    AudioSource aSource = null;

    public AudioClip[] aClips = null;

    public float timerMax = 1f;
    public float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        aSource = GetComponent<AudioSource>();
        timer = timerMax;
    }

    // Update is called once per frame
    void Update()
    {
        int aIndex = Random.Range(0, aClips.Length);

        timer -= Time.deltaTime;

        if (timer < 0)
        {
            timer = timerMax;
            aSource.clip = aClips[aIndex];
            aSource.pitch = Random.Range(-0.5f, 0.5f);
            PlayAudio(aClips[aIndex]);
        }


        
        

    }

    void PlayAudio(AudioClip clip)
    {
        aSource.PlayOneShot(clip);
    }

}
