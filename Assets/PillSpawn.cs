using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillSpawn : MonoBehaviour {
    public float _spawnRate;
    private float _randNum;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        _randNum = Random.Range(-100, 100);

	}
    
}
