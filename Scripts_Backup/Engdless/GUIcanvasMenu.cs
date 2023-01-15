using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIcanvasMenu : MonoBehaviour
{
    public Text distancecovered;
    public Text healthofPlayer;
    public Text coinsCollection;
  

    void Update()
    {
        distancecovered.text = "distance covered" + PlayerMovement.instance.playerMovement.position.z.ToString();
        healthofPlayer.text = "health = " + PlayerMovement.instance.health.ToString();
        coinsCollection.text = "coins = " + PlayerMovement.instance.score.ToString();
    }
}
