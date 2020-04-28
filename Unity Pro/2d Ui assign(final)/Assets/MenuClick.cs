using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuClick : MonoBehaviour
{
    [SerializeField] GameObject MenuButton;
    bool ClickCheck = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void ClickMenuButton()
    {
        ClickCheck = true;
        MenuButton.SetActive(ClickCheck);
    }

    public void HomeButton()
    {
        ClickCheck = false;
        MenuButton.SetActive(ClickCheck);
    }
}
