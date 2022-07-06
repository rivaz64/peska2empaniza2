using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HookBehavior : MonoBehaviour
{
    public List<FishBehavior> fishesForColicion = new List<FishBehavior>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 pos = transform.position;
        pos.x = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
        transform.position = pos;
        foreach(FishBehavior fish in fishesForColicion){
            if(Math.Abs(transform.position.x-fish.transform.position.x) < fish.data.sizeX && 
               Math.Abs(transform.position.y-fish.transform.position.y) < fish.data.sizeY){
                
                Debug.Log("collide");

            }

        }
    }

    public void addFish(FishBehavior fish){
        
    }
}
