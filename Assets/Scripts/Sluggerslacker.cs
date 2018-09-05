using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sluggerslacker : MonoBehaviour {

    Animator cAnimator;
    SpriteRenderer cSpriteRenderer;

	void Start ()
    {
        cAnimator = GetComponent<Animator>();
        cSpriteRenderer = GetComponent<SpriteRenderer>();
	}
	
	
	void Update ()
    {
		
	}

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("AAA");
        cAnimator.SetTrigger("pups");
    }
}
