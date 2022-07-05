using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    public float timer = 6;
    public float time = 0;
    public float profundidad = 0;
    public GameObject prefab;
    public HookBehavior hook;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        profundidad -= Time.deltaTime;
        if(time > timer){
            time -= timer;
            GameObject obj;
            obj = Instantiate(prefab, new Vector3(UnityEngine.Random.Range(-9.0f,9.0f), profundidad-6, 0), Quaternion.identity) as GameObject;
            hook.fishesForColicion.Add(obj.GetComponent<FishBehavior>());
        }
    }
}
