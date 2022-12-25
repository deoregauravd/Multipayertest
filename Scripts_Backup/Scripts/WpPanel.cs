using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WpPanel : MonoBehaviour
{
    //public SerializeField;

    [SerializeField] private GameObject wPanel;

    // Start is called before the first frame update
     private void Start()
    {
        wPanel.SetActive(false);
    }

    private void WeaponPanel()
    {
        if (wPanel.activeSelf)
        {
            Time.timeScale = 0f;
            wPanel.SetActive(false);
        }

        else
        {
            wPanel.SetActive(true);
        }
    
    }
} 
