using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioMixer : MonoBehaviour
{
    [SerializeField] private string _volumeName;

    private readonly int _volumeModifier = 20;
    private AudioSource _audioSource;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void PlayAudioClip(AudioClip audioClip)
    {
        _audioSource.clip = audioClip;
        _audioSource.Play();
    }

    public void ChangeVolume(float volume)
    {
        _audioSource.outputAudioMixerGroup.audioMixer.SetFloat(_volumeName, Mathf.Log10(volume) * _volumeModifier);
    }
}
