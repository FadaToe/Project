using UnityEngine;
using System;
using System.ComponentModel.Design;
public class HelloWorld : MonoBehaviour
{
    
    void Start()
    {
        int health = 2;
        int level = 1;
        health *= level + 1;
        health /= level;
        print(health);
        print(level);
    }

    
    void Update()
    {
        
    }
}
