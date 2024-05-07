using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSpawn : MonoBehaviour
{

    public GameObject towers;
    public float height;
    public float maxTime = 2f;

    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newTowers = Instantiate(towers);
        newTowers.transform.position = transform.position + new Vector3(0,Random.Range(-height,height),0);
    }

    // Update is called once per frame
    void Update()
    {
      if(timer > maxTime){
        GameObject newTowers = Instantiate(towers);
        newTowers.transform.position = transform.position + new Vector3(0,Random.Range(-height,height),0);
        Destroy(newTowers, 20f);
        timer = 0;
      }  

      timer += Time.deltaTime;
    }
}
