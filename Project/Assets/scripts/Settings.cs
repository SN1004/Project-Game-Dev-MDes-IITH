using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    [SerializeField] private Sprite playing;
    [SerializeField] private Sprite paused;
    public void SoundUI(GameObject Sound_UI)
    {
        bool State = Sound_UI.activeInHierarchy;
        if (State) Sound_UI.SetActive(false);
        else Sound_UI.SetActive(true);
    }

    public void Sound(AudioSource Audio)
    {
        float volume = Audio.volume;
        if (volume > 0.0f) Audio.volume = 0;
        else Audio.volume = 0.15f;
    }

    public void SoundIcon(SpriteRenderer SI)
    {
        if (SI.sprite == playing) SI.sprite = paused;
        else SI.sprite = playing;
    }
}
