using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boden : MonoBehaviour {

    public Collider2D WurstCollider;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == WurstCollider)
        {
            WurstCollider.GetComponent<Scheisse>().SetBack();
        }
    }
}
