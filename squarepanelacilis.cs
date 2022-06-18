ns using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class squarepanelacilis : MonoBehaviour
{

    public GameObject panel;
    private bool isActive = false;
    

    
    
    void Update()
    {
    if(isActive)
    {
       if(Input.GetKeyDown(KeyCode.E))
       {
         panel.SetActive(true);
       }
       
       
    }
      
        
    }
    
    void OnTriggerEnter2D(Collider2D collider)
    {
       if(collider.tag == "Player")
       {
          
          isActive=true;
       }
    }
    void OnTriggerExit2D(Collider2D collider)
    {
       if(collider.tag == "Player")
       {
          isActive=false;
       }
    }
    
    
    
}
