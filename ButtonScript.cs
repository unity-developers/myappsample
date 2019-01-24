using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public GameObject TextPanel;
    public bool ishide = false;
    public bool isSpeake = false;
    public Sprite Speak_Sprite, DontSpeak_Sprite;
    public Button speaker_Btn;
    public AudioSource audioSource;

    bool play_1st_time = true;
    // public GameObject ArCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TextPanelFunc()
    {
        if(ishide)
        {

            TextPanel.GetComponent<Animator>().SetBool("Hide", true);

            audioSource.Stop();

            // ArCamera.SetActive(true);
            ishide = false;
        }
        else
        {
            TextPanel.GetComponent<Animator>().SetBool("Hide", false);
            if(play_1st_time)
            {
                audioSource.Play();
                play_1st_time = false;
            }
            else if (speaker_Btn.GetComponent<Image>().sprite == DontSpeak_Sprite)
            {
                audioSource.Pause();
            }
            else
            {
                audioSource.Play();
            }
            // ArCamera.SetActive(false);
            ishide = true;
        }
    }
    public void VolumeFunc()
    {
        if (isSpeake)
        {
            speaker_Btn.GetComponent<Image>().sprite = DontSpeak_Sprite;
            audioSource.Pause();
            isSpeake = false;
        }
        else
        {
            speaker_Btn.GetComponent<Image>().sprite = Speak_Sprite;
            audioSource.Play();
            isSpeake = true;
        }

    }
}
