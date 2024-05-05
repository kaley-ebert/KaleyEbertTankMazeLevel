using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TriggerZone : MonoBehaviour
{
    //set this reference in the inspector
    public TMP_Text output;

    //enter the text you want to display in the inspector
    public string textToDisplay;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("Triggered by " + collision.gameObject);

        //set the Player tag on the player in the inspector
        if (collision.gameObject.tag == "Player")
        {
            //display "You Win!" on the screen
            output.text = textToDisplay;
        }
    }
}
