using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIcanvasMenu : MonoBehaviour
{
    public Text distancecovered;
    public Text healthofPlayer;
  

    void Update()
    {
        distancecovered.text = "distance covered" + PlayerMovement.instance.playerMovement.position.z.ToString();
        healthofPlayer.text = "health = " + PlayerMovement.instance.health;
    }
}
