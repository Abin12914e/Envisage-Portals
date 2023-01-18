using UnityEngine.Audio;
using UnityEngine;
using System;
using System;

public class audiomanager : MonoBehaviour
{
    public sound[] sounds;

    private void Start()
    {
        play("theme");
    }

    void Awake()
    {
        foreach (sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.loop= s.loop;

            s.source.volume= s.volume;
            s.source.pitch= s.pitch;
        }
    }

    // Update is called once per frame
    public void play(string name)
    {
        sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            return;
        }
        s.source.Play();

    }
}
