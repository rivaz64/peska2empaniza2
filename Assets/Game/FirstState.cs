using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstState : GameState
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public override void tick(Game game)
    {
        game.cam.transform.Translate(Vector3.down * Time.deltaTime);
        game.hook.transform.Translate(Vector3.down * Time.deltaTime);

        game.time += Time.deltaTime;
        game.profundidad -= Time.deltaTime;
        if(game.time > game.timer){
            game.time -= game.timer;
            GameObject obj;
            obj = Instantiate(game.prefab, new Vector3(UnityEngine.Random.Range(-9.0f,9.0f), game.profundidad-6, 0), Quaternion.identity) as GameObject;
            game.hook.fishesForColicion.Add(obj.GetComponent<FishBehavior>());
        }
    }

    public virtual void onCatch(Game game, FishBehavior fish)
    {
        game.state = new SecondState();
        game.hook.addFish(fish);
        
    }
}
