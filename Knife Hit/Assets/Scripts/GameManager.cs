using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [Header("Controle das Espadas")]
    [SerializeField] private int espadasDiponiveis = 7;
    private int espadaAtual = 0;

    [Header("Spawn das Espadas")]
    [SerializeField] private GameObject espadaParaSpawnar;
    [SerializeField] private Vector2 posicaoInicialDaEspada = new Vector2(0f, -2f);

    void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    void Start()
    {
        SpawnarNovaEspada();
    }

    public void SpawnarNovaEspada()
    {
        Instantiate(espadaParaSpawnar, posicaoInicialDaEspada, Quaternion.identity);
    }

    public void QuandoAtingirAlvo()
    {
        espadasDiponiveis--;
        espadaAtual++;

        if(espadasDiponiveis <= 0)
        {

        }
        else
        {
            SpawnarNovaEspada();
        }
    }

    public void QuandoAtingirEspada()
    {
        
    }

}
