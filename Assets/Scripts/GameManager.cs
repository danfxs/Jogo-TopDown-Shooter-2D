using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool jogadorEstaVivo;
    public int inimigosDerrotados;
    public Text textoDePontuacaoAtual;
    public GameObject painelDeGameOver;
    public Text textoDePontuacaoFinal;
    public Text textoDeHighScore;

    private readonly string HIGH_SCORE = "HighScore";


    // Start is called before the first frame update
    void Start()
    {
        jogadorEstaVivo = true;
        inimigosDerrotados = 0;
        
        textoDePontuacaoAtual.text = "INIMIGOS DERROTADOS: " + inimigosDerrotados.ToString("00");

        painelDeGameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AumentarPontuacao()
    {
        inimigosDerrotados += 1;
        textoDePontuacaoAtual.text = "INIMIGOS DERROTADOS: " + inimigosDerrotados.ToString("00");
    }

    public void GameOver()
    {
        Cursor.visible = true;
        jogadorEstaVivo = false;
        painelDeGameOver.SetActive(true);
        textoDePontuacaoFinal.text = textoDePontuacaoAtual.text;

        if (inimigosDerrotados > PlayerPrefs.GetInt(HIGH_SCORE))
        {
            PlayerPrefs.SetInt(HIGH_SCORE, inimigosDerrotados);
        }

        textoDeHighScore.text = "HIGH SCORE: " + PlayerPrefs.GetInt(HIGH_SCORE).ToString("00");
    }
}
