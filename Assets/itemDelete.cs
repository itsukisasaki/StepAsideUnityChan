using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemDelete : MonoBehaviour
{
    private GameObject unitychan;

    // Start is called before the first frame update
    void Start()
    {
        this.unitychan = GameObject.Find("unitychan");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("unitychan Z:" + (unitychan.transform.position.z - transform.position.z));

        if (unitychan.transform.position.z - transform.position.z > 6)
        {
            Destroy(this.gameObject);
        }
    }
}