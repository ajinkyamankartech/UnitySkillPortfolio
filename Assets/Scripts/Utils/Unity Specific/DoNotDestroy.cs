using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNotDestroy : MonoBehaviour
{
    //Create a class which will add current object to DontDestroyOnLoad
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

}
