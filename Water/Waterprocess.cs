using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waterprocess : MonoBehaviour {

    [SerializeField]
    private GameObject water;
    [SerializeField]
    private GameObject waterFall;

    private bool hasWater = false;

    void Update()
    {
        if (transform.localEulerAngles.x > 80 && hasWater)
        {
            waterFall.SetActive(true);
            hasWater = false;
        }
    }

    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "waterTank")
        {
            water.SetActive(true);
            hasWater = true;
        }
    }
}
