using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   public static GameManager Instance;

    [SerializeField] private int Lives;

    private int Score;

    private void Awake()
    {
        Instance = this;
    }

    public void IncreaseScore(int Amount)
    {
        Score += Amount;
        print("Sua Pontua��o �: " + Score);
    }

    public void DecreaseScore(int Amount)
    {
        Score -= Amount;
        print("Sua Pontua��o �: " + Score);
    }

    public void LooseLives()
    {
        Lives--;
        print($"Voc� tem {Lives} vidas restantes");
    }

}
