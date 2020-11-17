using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using EZCameraShake;

public class CountdownTimer : MonoBehaviour
{
    public int countdownTime;
    public TextMeshProUGUI countdownDisplay;
    public Image floorIsLava;

    private void Start()
    {
        floorIsLava.gameObject.SetActive(false);
        StartCoroutine(CountdownToStart());
    }

    //maybe make array com as strings?

    IEnumerator CountdownToStart()
    {

        yield return new WaitForSeconds(4f);
        while (countdownTime > 0)
        {
            CameraShaker.Instance.ShakeOnce(4f, 6f, .5f, .5f);
            countdownDisplay.text = countdownTime.ToString();

            yield return new WaitForSeconds(1f);

            countdownTime--;
        }

        countdownDisplay.gameObject.SetActive(false);
        //display image in center
        floorIsLava.gameObject.SetActive(true);

        yield return new WaitForSeconds(3f);

        floorIsLava.gameObject.SetActive(false);
    }
}
