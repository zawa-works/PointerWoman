using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoyController : MonoBehaviour
{
    [SerializeField] private GameObject tit;
    [SerializeField] private GameObject[] face;
    private bool isAngry = false;
    void Start()
    {
        face[0].SetActive(true);
        face[1].SetActive(false);

    }


    void Update()
    {
        if (tit == null && !isAngry)
        {
            this.gameObject.transform.parent = null;
            this.transform.Translate(0, 0.5f, 0);
            face[0].SetActive(false);
            face[1].SetActive(true);
            isAngry = true;
        }

    }
}
