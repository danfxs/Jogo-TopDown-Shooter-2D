using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDosInimigos : MonoBehaviour
{
    public GameObject zumbi;
    public Transform[] pontosDeSpawn;

    public float tempoEntreSpawns;
    public float tempoAtual;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<GameManager>().jogadorEstaVivo)
        {
            tempoAtual -= Time.deltaTime;

            if (tempoAtual <= 0)
            {
                SpawnarInimigos();
            }
        }
    }

    void SpawnarInimigos()
    {
        int pontoAleatorio = Random.Range(0, pontosDeSpawn.Length);

        Instantiate(zumbi, pontosDeSpawn[pontoAleatorio].position, pontosDeSpawn[pontoAleatorio].rotation);
        
        tempoAtual = tempoEntreSpawns;
    }
}
