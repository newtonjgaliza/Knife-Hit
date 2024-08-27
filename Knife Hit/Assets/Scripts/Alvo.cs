using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alvo : MonoBehaviour
{
    [Header ("Rotacao do Alvo")]
    [SerializeField] private int[] velocidadesDeRotacao;
    private int velocidadeDeRotacaoAtual;

    [Header ("Cronometro da troca de velocidade")]
    [SerializeField] private float tempoMaximoParaTrocarVelocidade;
    private float tempoAtualParaTrocarVelocidade;

    private void Update()
    {
        RodarCronometroDaTrocaDeVelocidade();   
        RotacionarAlvo();
    }

    private void RodarCronometroDaTrocaDeVelocidade()
    {
        tempoAtualParaTrocarVelocidade -= Time.deltaTime;

        if(tempoAtualParaTrocarVelocidade <= 0)
        {
            EscolherNovaVelocidadeDeRotacao();
            tempoAtualParaTrocarVelocidade = tempoMaximoParaTrocarVelocidade;
        }
    }

    private void EscolherNovaVelocidadeDeRotacao()
    {
        velocidadeDeRotacaoAtual = velocidadesDeRotacao[Random.Range(0, velocidadesDeRotacao.Length)];
    }

    private void RotacionarAlvo()
    {
        transform.Rotate(0f, 0f, velocidadeDeRotacaoAtual * Time.deltaTime);
    }
}
