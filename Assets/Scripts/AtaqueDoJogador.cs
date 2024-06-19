using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueDoJogador : MonoBehaviour
{

    public Transform localDoDisparo;
    public GameObject disparo;
    public AudioSource somDoAtaque;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(disparo, localDoDisparo.position, localDoDisparo.rotation);
            somDoAtaque.Play();
        }
    }
}
