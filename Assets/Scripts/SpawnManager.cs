using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetkeyDown(KeyCode.S))
        {
            Instantiate(animalPrefabs[0], new Vector3(0, 0, 20), animalPrefabs[0].transform.rotation);
        }
    }
}
