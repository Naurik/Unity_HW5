﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointLight : MonoBehaviour
{
    [SerializeField]
    private Light light;
    // Start is called before the first frame update
    void Start()
    {
        light.gameObject.SetActive(false);
    }

    public void EnableLight()
    {
        light.gameObject.SetActive(true);
    }
}
