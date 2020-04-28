using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundClick : MonoBehaviour
{
    [SerializeField] GameObject OnSoundButton;
    [SerializeField] GameObject OffSoundButton;

    bool SoundCheck = true;//소리있엉
    // Start is called before the first frame update
    void Start()
    {
        OnOffSound();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnOffSound()
    {
        if(SoundCheck==true)
        {
            OnSoundButton.SetActive(true);
            OffSoundButton.SetActive(false);
            SoundCheck = false;
        }

        else
        {
            OnSoundButton.SetActive(false);
            OffSoundButton.SetActive(true);
            SoundCheck = true;
        }
    }

}
