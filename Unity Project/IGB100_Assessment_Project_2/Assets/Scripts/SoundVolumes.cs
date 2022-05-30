using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SoundVolumes : MonoBehaviour
{
    public Slider masterSlider;
    public Slider noiseMakersSlider;
    public Slider melodySlider;
    public AudioMixerGroup masterGroup;
    public AudioMixerGroup noiseMakerGroup;
    public AudioMixerGroup melodyGroup;

    // Start is called before the first frame update
    void Start()
    {
        masterSlider.minValue = -80;
        noiseMakersSlider.minValue = -80;
        melodySlider.minValue = -80;
        masterSlider.maxValue = 20;
        noiseMakersSlider.maxValue = 20;
        melodySlider.maxValue = 20;
    }

    // Update is called once per frame
    void Update()
    {
        masterGroup.audioMixer.SetFloat("VolumeMaster", masterSlider.value);
        noiseMakerGroup.audioMixer.SetFloat("VolumeNoiseMakers", noiseMakersSlider.value);
        melodyGroup.audioMixer.SetFloat("VolumeMelody", melodySlider.value);
    }
}
