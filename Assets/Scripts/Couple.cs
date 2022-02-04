using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Couple : MonoBehaviour
{
    public string stage;


    void Start()
    {
        if (stage == "top")
        {
            this.transform.position = new Vector3(-11, 3, 0);
            this.transform.DOMoveX(11, 7f).SetEase(Ease.Linear).OnComplete(() => Destroy(this.gameObject));
        }
        else if (stage == "middle")
        {
            this.transform.position = new Vector3(11, 0, 0);
            this.transform.DOMoveX(-11, 7f).SetEase(Ease.Linear).OnComplete(() => Destroy(this.gameObject));

        }
        else if (stage == "bottom")
        {
            this.transform.position = new Vector3(-11, -3, 0);
            this.transform.DOMoveX(11, 7f).SetEase(Ease.Linear).OnComplete(() => Destroy(this.gameObject));
        }

    }

    void Update()
    {

    }
}
