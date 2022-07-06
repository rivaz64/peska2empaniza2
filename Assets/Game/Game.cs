using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameState state;
    public HookBehavior hook;
    public Camera cam;

    public float timer = 6;
    public float time = 0;
    public float profundidad = 0;
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
        state = new FirstState();
    }

    // Update is called once per frame
    void Update()
    {   
        state.tick(this);
    }

    public virtual void onCatch(FishBehavior fish)
    {
        state.onCatch(this,fish);
    }
}
