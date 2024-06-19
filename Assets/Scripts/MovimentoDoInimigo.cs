using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoDoInimigo : MonoBehaviour
{

    public float velocidadeMinimaDoInimigo;    
    public float velocidadeMaximaDoInimigo;
    public float velocidadeAtualDoInimigo;
    public int danoParaDar;

    private Rigidbody2D oRigidbody2D;
    private Transform oJogador;


    void Start()
    {
        velocidadeAtualDoInimigo = Random.Range(velocidadeMinimaDoInimigo, velocidadeMaximaDoInimigo);
        oRigidbody2D = GetComponent<Rigidbody2D>();
        oJogador = FindObjectOfType<MovimentoDoJogador>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<GameManager>().jogadorEstaVivo)
        {
            transform.position = Vector2.MoveTowards(transform.position, oJogador.position, velocidadeAtualDoInimigo * Time.deltaTime);

            Vector3 direcaoDoOlhar = oJogador.position - transform.position;
            float anguloParaOlhar = Mathf.Atan2(direcaoDoOlhar.y, direcaoDoOlhar.x) * Mathf.Rad2Deg;

            oRigidbody2D.rotation = anguloParaOlhar;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<VidaDoJogador>().MachucarJogador(danoParaDar);
        }
    }
}
