using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reparent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      transform.parent =   GameObject.FindGameObjectWithTag("Player").transform;
    }

   
}
