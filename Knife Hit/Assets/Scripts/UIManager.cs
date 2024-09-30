using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    [SerializeField] private GameObject painelDasEspadas;
    [SerializeField] private GameObject imagemDaEspada;

    [SerializeField] private GameObject painelFinal;
    [SerializeField] private Text textoDoResultado;

    private void Awake()
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

    // Start is called before the first frame update
    void Start()
    {
        painelFinal.SetActive(false);
    }

    public void CarregarImagensDisponiveis(int espadasDisponiveis)
    {
        for (int i = 0; i < espadasDisponiveis; i++)
        {
            Instantiate(imagemDaEspada, painelDasEspadas.transform);
        }
    }

    public void AtualizarImagemDaEspada(int espadaAtual)
    {
         painelDasEspadas.transform.GetChild(espadaAtual).GetComponent<Image>().color = Color.black;
    }

    public void AtivarPainelFinal(bool venceu)
    {
        if (venceu == true)
        {
             textoDoResultado.text = "Você Venceu!";
        }
        else
        {
        textoDoResultado.text = "Você Perdeu";
        }

        painelFinal.SetActive(true);
        
    }
    
       


}
