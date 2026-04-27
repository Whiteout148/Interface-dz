using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering.Universal;

public class Muter : MonoBehaviour
{
    private const float MuteValue = -80f;
    private const float PlayingValue = 0f;

    [SerializeField] private string _mixerName;
    [SerializeField] private AudioMixerGroup _mixer;

    private bool _isMuted;

    private void Awake()
    {
        _isMuted = false;
    }

    public void OnValueChanged()
    {
        if (_isMuted)
        {
            _mixer.audioMixer.SetFloat(_mixerName, PlayingValue);
            _isMuted = false;
        }
        else
        {
            _mixer.audioMixer.SetFloat(_mixerName, MuteValue);
            _isMuted = true;
        }
    }
}
