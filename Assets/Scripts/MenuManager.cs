using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private string Nomedolevel;
    [SerializeField] private GameObject menuinicial;
    [SerializeField] private GameObject menuopcoes;

    // public float stepDelay = 1f;
    // public float lockDelay = 0.5f;
    public void Jogar()
    {
        SceneManager.LoadScene(Nomedolevel);
    }
      
    public void AbrirOpcoes()
    {
        menuinicial.SetActive(false);
        menuopcoes.SetActive(true);
    }
      
    public void FecharOpcoesF()
    {
        menuopcoes.SetActive(false);
        menuinicial.SetActive(true);
        Piece.stepDelay = 1f;
        Piece.lockDelay = 0.5f;
    }

    public void FecharOpcoesM()
    {
        menuopcoes.SetActive(false);
        menuinicial.SetActive(true);
        Piece.stepDelay = 0.6f;
        Piece.lockDelay = 0.3f;
    }

    public void FecharOpcoesD()
    {
        menuopcoes.SetActive(false);
        menuinicial.SetActive(true);
        Piece.stepDelay = 0.2f;
        Piece.lockDelay = 0.2f;
    }

    public void SairJogo()
    {
        Debug.Log("Sair do Jogo");
        Application.Quit();
    }
}
