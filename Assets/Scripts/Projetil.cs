using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetil : MonoBehaviour
{

    public float velocidadeDoDisparo;
    public int danoParaDar;
    public float tempoDeVida;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, tempoDeVida);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * velocidadeDoDisparo * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Inimigo"))
        {
            other.gameObject.GetComponent<VidaDoInimigo>().MachucarInimigo(danoParaDar);
            Destroy(this.gameObject);
        }
        if(other.gameObject.CompareTag("Parede"))
        {
            Destroy(this.gameObject);
        }
        
    }

}
