using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceCreamPickup : MonoBehaviour
{
    public AudioSource slurp;
   

    private void Start()
    {
        
        slurp = GetComponent<AudioSource>();
    }

    private void Update()
    {
        transform.Rotate(new Vector3(15, 30, 0) * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider info)
    {
        if (info.tag == "Player")
        {          
            slurp.Play();
           // gameObject.SetActive(false);
        }
    }
}
