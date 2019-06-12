using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{

    public AudioClip clipsatu;
    AudioSource audioSource;

    string strTag;


    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision Collision)
    {
        if (Collision.collider.tag == strTag)
            audioSource.clip = clipsatu;
        audioSource.Play();

    }
}
