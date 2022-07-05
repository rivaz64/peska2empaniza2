using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public virtual void tick(Game game)
    {
        Debug.Log("state");
    }

    public virtual void onCatch(Game game, FishBehavior fish){
        
    }
}
