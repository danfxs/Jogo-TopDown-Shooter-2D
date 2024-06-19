using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaDoInimigo : MonoBehaviour
{

    public int vidaMaximaDoInimigo;
    private int vidaAtualDoInimigo;
    public GameObject objetoParaDropar;
    public AudioSource somDeImpacto;

    // Start is called before the first frame update
    void Start()
    {
        vidaAtualDoInimigo = vidaMaximaDoInimigo;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MachucarInimigo(int danoParaReceber)
    {
        vidaAtualDoInimigo -= danoParaReceber;
        somDeImpacto.Play();

        if(vidaAtualDoInimigo <= 0)
        {
            if (Random.Range(0, 10) < 8)
            {
                Instantiate(objetoParaDropar, transform.position, transform.rotation);
            }
            FindObjectOfType<GameManager>().AumentarPontuacao();
            Destroy(this.gameObject);
        }
    }
}
