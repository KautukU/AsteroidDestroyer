using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionAudioController : MonoBehaviour
{
    public AudioClip[] clips;

    private AudioSource aSource;
    // Start is called before the first frame update
    void Start()
    {
        aSource = GetComponent<AudioSource>();

        int randomNum = Random.Range(0, clips.Length);

        aSource.clip = clips[randomNum]; // Random Num will be 0 up to 
        aSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
