using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoupleManager : MonoBehaviour
{
    [SerializeField] private Couple couple;
    private string[] stages = { "top", "middle", "bottom" };
    private int index = 0;
    void Start()
    {
        InvokeRepeating("BornCouple", 1f, 1.5f);

    }

    void Update()
    {

    }

    private void BornCouple()
    {
        var c = Instantiate(couple, new Vector3(0, 0, 0), Quaternion.identity);
        c.stage = stages[index];

        index++;
        index = index % 3;

    }
}
