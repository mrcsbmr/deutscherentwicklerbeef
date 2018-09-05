using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scheisse : MonoBehaviour {

    public Arsch Anus;
    public float abdrueckTime = 2f;
    public float abdrueckSpeed;
    public float fallingSpeed;

    bool feuernd = false;
    bool ready = true;
    Vector3 arschOffset;

    Transform cTransform;

    private void Start()
    {
        cTransform = transform;
        arschOffset = cTransform.position - Anus.transform.position;
    }

    void Update ()
    {
		
        if (!feuernd)
        {
            cTransform.position = Anus.transform.position + arschOffset;
        }

        if (ready && feuernd)
        {
            ready = false;
            StartCoroutine(CoFire());

        }
	}


    IEnumerator CoFire()
    {
        float counter = 0;

        while (counter < abdrueckTime)
        {
            cTransform.position = new Vector3(cTransform.position.x, cTransform.position.y - abdrueckSpeed * Time.deltaTime, cTransform.position.z);
            counter += Time.deltaTime;
            yield return 0f;
        }

        while (!ready)
        { 
            cTransform.position = new Vector3(cTransform.position.x, cTransform.position.y - fallingSpeed * Time.deltaTime, cTransform.position.z);
            yield return 0f;
        }

        yield return 0f;
    }

    public void Feuer()
    {
        feuernd = true;
        Anus.AssWait();
    }


    public void SetBack()
    {
        feuernd = false;
        ready = true;
        Anus.ReadyAss();
    }
}
