using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

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
            face[0].SetActive(false);
            face[1].SetActive(true);
            this.transform.DOMoveY(-7, 2f).SetEase(Ease.Linear);
            isAngry = true;
        }

    }
}
