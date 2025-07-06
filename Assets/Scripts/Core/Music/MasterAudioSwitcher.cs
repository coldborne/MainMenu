using UnityEngine;
using UnityEngine.Audio;

public class MasterAudioSwitcher : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _masterAudioMixerGroup;
    
    private readonly string MasterVolume = nameof(MasterVolume);

    private readonly float _minVolume = -80f;
    private readonly float _maxVolume = 0f;
    
    private bool _isEnabled;

    private void OnEnable()
    {
        _isEnabled = true;
    }

    private void OnDisable()
    {
        _isEnabled = false;
    }

    public void ToggleAudio()
    {
        _isEnabled = !_isEnabled;

        if (_isEnabled)
        {
            _masterAudioMixerGroup.audioMixer.SetFloat(MasterVolume, _maxVolume);
        }
        else
        {
            _masterAudioMixerGroup.audioMixer.SetFloat(MasterVolume, _minVolume);
        }
    }
}
