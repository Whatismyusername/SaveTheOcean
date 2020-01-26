﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrepareFusionParticleEffects : MonoBehaviour
{
    private ParticleSystem particleSystem;
    // Start is called before the first frame update
    void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("PlayParticleEffect", 2f);
    }

    void PlayParticleEffect() {
        particleSystem.Play();
    }
}