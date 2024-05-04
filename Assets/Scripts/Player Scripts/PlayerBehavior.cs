using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{

    [SerializeField] private float MoveSpeed;
    [SerializeField] private int ScoreToIncrease;

    // Update is called once per frame
    void Update()
    {
        float inputMoveX = Input.GetAxisRaw("Horizontal") * Time.deltaTime * MoveSpeed;
        transform.Translate(inputMoveX, 0, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.Instance.IncreaseScore(ScoreToIncrease);
    }
}
