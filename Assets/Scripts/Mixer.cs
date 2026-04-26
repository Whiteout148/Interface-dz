using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Mixer : MonoBehaviour
{
    private const float VolumeFactor = 20f;
    private const string MasterVolume = "MasterVolume";
    private const string BackGroundMusic = "BackGroundMusic";
    private const string Music = "Music";
    private const float MuteValue = -80f;
    private const float NormalValue = 0f;

    [SerializeField] private AudioMixerGroup _mixerGroup;
    [SerializeField] private Slider _allSoundsSlider;
    [SerializeField] private Slider _backGroundMusicSlider;
    [SerializeField] private Slider _buttonsMusicSlider;

    private bool isAllMute = false;

    public void SetAllValue()
    {
        if (!isAllMute)
        {
            _mixerGroup.audioMixer.SetFloat(MasterVolume, MuteValue);
            isAllMute = true;
        }
        else
        {
            _mixerGroup.audioMixer.SetFloat(MasterVolume, NormalValue);
            isAllMute = false;
        }
    }

    public void ChangeAllValue()
    {
        float volume = Mathf.Log10(_allSoundsSlider.value) * VolumeFactor;
        _mixerGroup.audioMixer.SetFloat(MasterVolume, volume);
    }

    public void ChangeBackGroundMusicValue()
    {
        float volume = Mathf.Log10(_backGroundMusicSlider.value) * VolumeFactor;
        _mixerGroup.audioMixer.SetFloat(BackGroundMusic, volume);
    }

    public void ChangeButtonsMusicValue()
    {
        float volume = Mathf.Log10(_buttonsMusicSlider.value) * VolumeFactor;
        _mixerGroup.audioMixer.SetFloat(Music, volume);
    }
}
