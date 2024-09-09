using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioSettingsManager : MonoBehaviour
{
    public AudioMixer audioMixer; // Referencja do AudioMixer
    public Slider musicSlider; // Suwak do regulacji głośności muzyki
    public Slider sfxSlider; // Suwak do regulacji głośności efektów dźwiękowych

    private const string MusicVolumeKey = "MusicVolume";
    private const string SfxVolumeKey = "SfxVolume";

    void Start()
    {
        // Odczytaj i ustaw wartości suwaków z PlayerPrefs
        musicSlider.value = PlayerPrefs.GetFloat(MusicVolumeKey, 0.5f); // Domyślnie 0.5
        sfxSlider.value = PlayerPrefs.GetFloat(SfxVolumeKey, 0.5f); // Domyślnie 0.5

        // Ustaw wartości głośności w AudioMixer
        SetMusicVolume(musicSlider.value);
        SetSfxVolume(sfxSlider.value);
    }

    public void SetMusicVolume(float volume)
    {
        // Ustaw głośność muzyki w AudioMixer
        audioMixer.SetFloat("MusicVolume", Mathf.Log10(volume) * 20); // Przekształć wartość suwaka na decybele
        PlayerPrefs.SetFloat(MusicVolumeKey, volume); // Zapisz wartość suwaka
        PlayerPrefs.Save();
    }

    public void SetSfxVolume(float volume)
    {
        // Ustaw głośność efektów dźwiękowych w AudioMixer
        audioMixer.SetFloat("SfxVolume", Mathf.Log10(volume) * 20); // Przekształć wartość suwaka na decybele
        PlayerPrefs.SetFloat(SfxVolumeKey, volume); // Zapisz wartość suwaka
        PlayerPrefs.Save();
    }
}

