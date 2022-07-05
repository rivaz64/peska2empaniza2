using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class FishBehavior : MonoBehaviour
{
    public FishData data;

    public Image image;

    public float dir = 1;

    // Start is called before the first frame update
    void Start()
    {
        image.sprite = data.image;
        if(UnityEngine.Random.Range(0,2) == 1){
            flip();
        }

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * data.vel * dir);
        if(Math.Abs(transform.position.x)>data.border && transform.position.x*dir>0){
            flip();
        }
    }

    public void flip(){
        dir *= -1;
        Vector3 theScale = image.transform.localScale;
        theScale.x *= -1;
        image.transform.localScale = theScale;
    }
}
