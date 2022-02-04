using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoupleManager : MonoBehaviour
{
    [SerializeField] private Couple couple;
    private string[] stages = { "top", "middle", "bottom" };
    void Start()
    {
        InvokeRepeating("BornCouple", 1f, 3f);

    }

    void Update()
    {

    }

    private void BornCouple()
    {
        var c = Instantiate(couple, new Vector3(0, 0, 0), Quaternion.identity);
        c.stage = stages[Random.Range(0, 3)];

    }
}
