using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingCollectable : MonoBehaviour
{

    [SerializeField] private float FallingSpeed;
 
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, FallingSpeed * Time.deltaTime *-1, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject);
    }

}
