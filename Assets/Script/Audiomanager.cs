﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Audiomanager : MonoBehaviour
{
    public sound[] sounds;

    public static Audiomanager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        foreach(sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
           }

    public void play(string name)
    {
        sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
        
    }

    
}
