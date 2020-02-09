using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reactivateCollectibles : MonoBehaviour
{
    public GameObject[] life;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            //Debug.Log("respawn col");

            for(int i = 0; i < life.Length; i++)
            {
                if(life[i].activeInHierarchy == false)
                {
                    life[i].SetActive(true);
                }
            }
        }
    }
}
