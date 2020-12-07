using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    private GameObject unitychan;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.unitychan = GameObject.Find("unitychan");
        if (this.transform.position.z < this.unitychan.transform.position.z - 5)
        {
            Destroy(this.gameObject);
        }
    }
}
