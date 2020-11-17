using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LavaTriggered : MonoBehaviour
{

    public GameObject playerPos;
    [SerializeField] private Transform Player;
    [SerializeField] private Transform respawnPoint;
    public AudioSource burnAudio;
    public AudioClip burn;


    // Start is called before the first frame update
    void Start()
    {
        burnAudio = GetComponent<AudioSource>();
        Scene scene = SceneManager.GetActiveScene();
        Debug.Log("Scene loaded is '" + scene.name);

        if (scene.name == "LowPolyInterior_Demo")
        {
            //StartCoroutine(RiseLava());
            //rise up the lava after some seconds
            //transform.position += new Vector3(0, 0, 1) * Time.deltaTime;
        }
    }

   /*IEnumerator RiseLava()
    {
        while(transform.position.y < 7.08)
        {
            transform.position += new Vector3(0, 0, 0.2f);
        }
        yield break;
    }*/

    // Update is called once per frame
    void Update()
    {
        /*if(transform.position.y <7.08)
        transform.position += new Vector3(0, 0, 1) * Time.deltaTime;*/



    }

    private void OnTriggerEnter(Collider other)
    {
        //Scene scene = SceneManager.GetActiveScene();
        Debug.Log("Caiu na lava");
        /*burnAudio.clip = burn;
        burnAudio.Play();*/
        Player.transform.position = respawnPoint.transform.position;
        //SceneManager.LoadScene(scene.name);
    }
}
