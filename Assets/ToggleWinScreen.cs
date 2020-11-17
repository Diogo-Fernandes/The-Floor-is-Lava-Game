using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToggleWinScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ToggleWin());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ToggleWin()
    {

        yield return new WaitForSeconds(4f);


        SceneManager.LoadScene("SampleScene");

    }
}
