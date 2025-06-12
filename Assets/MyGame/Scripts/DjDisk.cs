using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DjDisk : MonoBehaviour
{
    public TMP_Text button_play_pause_text;
    public TMP_Text button_stop_text;
    [SerializeField] private AudioSource audiosource;
    // Start is called before the first frame update
    void Start()
    {
        button_play_pause_text.text = "Play/Pause";
        button_stop_text.text = "Stop";
        audiosource = GetComponent<AudioSource>();

    }

    public void PlayOnTouch()
    {
        audiosource.Play();
    }



    public void StopOnTouch()
    {
        audiosource.Stop();
    }
    // Update is called once per frame
    void Update()
    {

    }

    public void PauseOnTouch()
    {
        audiosource.Pause();
    }
}
