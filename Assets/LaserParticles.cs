using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserParticles : MonoBehaviour
{
    private void Start()
    {
        Destroy(gameObject, 2f);
        StartCoroutine(moveTo());
    }

    IEnumerator moveTo()
    {
        while(true)
        {
            transform.Translate(transform.forward * Time.deltaTime * 10f);
            yield return null;
        }
    }
}
