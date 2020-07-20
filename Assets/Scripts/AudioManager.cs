using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip shootingSFX;
    public AudioClip objectPickUpSFX;
    public AudioClip npcSFX;
    public AudioClip winSFX;
    public AudioClip playerDeathSFX;
    AudioSource myAudioSource;
    // Start is called before the first frame update
    void Start()
    {
        AudioSource[] audioSources = GetComponents<AudioSource>();
        myAudioSource = audioSources[1];


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shooting()
	{
        myAudioSource.clip = shootingSFX;
        myAudioSource.Play();
    }   
    
    public void ObjectPickUp()
	{
        myAudioSource.clip = objectPickUpSFX;
        myAudioSource.Play();
    } 
    public void NpcBlabla()
	{
        myAudioSource.clip = npcSFX;
        myAudioSource.Play();
    }
    public void PlayerDeath()
	{
        myAudioSource.clip = playerDeathSFX;
        myAudioSource.Play();
    }
    public void PlayerWins()
    {
        myAudioSource.clip = winSFX;
        myAudioSource.Play();
    }
}
