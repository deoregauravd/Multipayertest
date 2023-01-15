using UnityEngine;
using System.Collections.Generic;

public class ObstacalPool : MonoBehaviour
{
    public GameObject obstacalPrefab; 
    private List<GameObject> obstacalPool;
    [SerializeField] private int obspoolSize; 

    public static ObstacalPool ObstacalInstance;

    private void Awake()
    {
        ObstacalInstance = this;
    }


    void Start()
    {
        obstacalPool = new List<GameObject>();
     
        for (int i = 0; i < obspoolSize; i++)
        {
            GameObject obstacal = Instantiate(obstacalPrefab);
            obstacal.transform.position = new Vector3(0, 4, i * 16);
            obstacal.SetActive(true);
            obstacalPool.Add(obstacal);
        }
    }


    public GameObject GetCoin()
    {
        for (int i = 0; i <obstacalPool.Count; i++)
        {
            if (!obstacalPool[i].activeInHierarchy)
            {
                return obstacalPool[i];
            }
        }
        
        GameObject newCoin = Instantiate(obstacalPrefab);
        obstacalPool.Add(newCoin);
        return newCoin;
    }

    public void ReturnCoin(GameObject obstacal)
    {
        obstacal.transform.position = Vector3.zero;
        obstacal.transform.rotation = Quaternion.identity;
        obstacal.SetActive(false);
    }
}
