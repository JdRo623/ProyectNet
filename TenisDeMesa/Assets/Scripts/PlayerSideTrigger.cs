using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSideTrigger : MonoBehaviour
{

    [Header("Buttons")]
    public Button topspinButton;
    public Button underspinButton;
    public Button nospinButton;

    /*
    Enables the buttons when the ball enters the trigger
    */
    public void OnTriggerEnter(Collider colliderInfo)
    {
        if (colliderInfo.name == "Ball")
        {
            topspinButton.enabled = true;
            underspinButton.enabled = true;
            nospinButton.enabled = true;
        }
    }

}
