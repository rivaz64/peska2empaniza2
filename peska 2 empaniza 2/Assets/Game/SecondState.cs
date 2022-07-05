using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondState : GameState
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public override void tick(Game game)
    {
        game.cam.transform.Translate(Vector3.up * Time.deltaTime);
        game.hook.transform.Translate(Vector3.up * Time.deltaTime);
    }

    public override void onCatch(Game game, FishBehavior fish)
    {
        game.hook.addFish(fish);
    }
}
