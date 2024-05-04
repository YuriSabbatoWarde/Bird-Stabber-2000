using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorBehavior : MonoBehaviour
{
    [SerializeField] private int ScoreToDecrease;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Collectable"))
        {
            GameManager.Instance.DecreaseScore(ScoreToDecrease);
            GameManager.Instance.LooseLives();
        }
    }

}
