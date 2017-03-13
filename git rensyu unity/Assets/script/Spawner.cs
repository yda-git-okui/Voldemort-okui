using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public GameObject item;
    int cnt;
    int obj_x;
    Vector3 Object = Vector3.zero;

    // Use this for initialization
    void Start () {
        cnt = 0;
        Object.x = (Random.Range(0, 10) + 1) * 2;
    }
	
	// Update is called once per frame
	void Update () {
        cnt++;
		if(cnt >= 80)
        {
            Instantiate(item, transform.position + Object, transform.rotation);
            cnt = 0;
            Object.x = (Random.Range(0, 10) + 1) * 2;
        }
	}
}
