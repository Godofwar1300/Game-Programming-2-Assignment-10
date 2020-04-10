using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TutorialController : MonoBehaviour
{

    public Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TutorialTimer());
    }

    public void SkipTutorial()
    {
        SceneManager.LoadScene(2);
    }

    public IEnumerator TutorialTimer()
    {

        float timerDuration = 20f;

        while (timerDuration > 0)
        {
            timerDuration -= Time.deltaTime;
            timerText.text = "Timer: " + timerDuration.ToString("00");
            yield return null;
        }

        if (timerDuration <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }

}
