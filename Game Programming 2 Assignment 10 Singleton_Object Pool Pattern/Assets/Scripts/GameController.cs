using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public Text healthText;

    // public Text timerText;


    private void Start()
    {

    }

    private void Update()
    {

        healthText.text = "Health:  " + PlayerStats.playerHealth.ToString("0") + "%";

    }

    //public IEnumerator TutorialTimer()
    //{

    //    float timerDuration = 20f;

    //    while(timerDuration > 0)
    //    {
    //        timerDuration -= Time.deltaTime;
    //        timerText.text = "Timer: " + timerDuration.ToString("00");
    //        yield return null;
    //    }
    //}

}
