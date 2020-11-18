using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearLava : MonoBehaviour
{

    public GameObject Lava;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider info)
    {
        if (info.tag == "Player")
        {
            Lava.gameObject.SetActive(false);
            // gameObject.SetActive(false);
        }
    }
}
