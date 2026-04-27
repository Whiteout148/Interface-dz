using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Mixer : MonoBehaviour
{
    private const float VolumeFactor = 20f;

    [SerializeField] private string _mixerName;
    [SerializeField] private AudioMixerGroup _mixerGroup;
    [SerializeField] private Slider _slider;

    private bool isAllMute = false;

    public void OnValueChanged()
    {
        float volume = Mathf.Log10(_slider.value) * VolumeFactor;
        _mixerGroup.audioMixer.SetFloat(_mixerName, volume);
    }
}
