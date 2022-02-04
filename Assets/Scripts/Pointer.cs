using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{
    public GetRightJoycon rightJoycon;
    // private Vector3 worldScreenSize;
    void Start()
    {

        // worldScreenSize = Camera.main.ScreenToWorldPoint(Screen.width, Screen.height, 0);

    }


    void Update()
    {

        var pos = this.transform.position;
        var gyro = rightJoycon.gyro / 5;
        if (Mathf.Abs(gyro.z) < 0.01f) gyro.z = 0;
        if (Mathf.Abs(gyro.y) < 0.01f) gyro.y = 0;

        pos.x += gyro.z;
        pos.y += gyro.y;



        this.transform.position = pos;


    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Tit")
        {
            if (rightJoycon.button != null)
            {
                Destroy(other.gameObject);
                Debug.Log("hoge");
            }
        }

    }
}
