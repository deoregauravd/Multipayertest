using UnityEngine;
using System.Collections.Generic;

public class CoinPool : MonoBehaviour
{
    public GameObject coinPrefab; // The coin prefab
    private List<GameObject> coinPool; // The pool of coins
    [SerializeField]private int poolSize; // The initial size of the pool

    public static CoinPool CoinPoolInstance;

    private void Awake()
    {
        CoinPoolInstance = this;
    }


    void Start()
    {
        coinPool = new List<GameObject>();
        // Instantiate the initial pool of coins
        for (int i = 0; i < poolSize; i++)
        {
            GameObject coin = Instantiate(coinPrefab);
            coin.transform.position = new Vector3(0,2,i*11);
            coin.SetActive(true);
            coinPool.Add(coin);
        }
    }

    // Method to get a coin from the pool
    public GameObject GetCoin()
    {
        for (int i = 0; i < coinPool.Count; i++)
        {
            if (!coinPool[i].activeInHierarchy)
            {
                return coinPool[i];
            }
        }
        // If there are no available coins, instantiate a new one and add it to the pool
        GameObject newCoin = Instantiate(coinPrefab);
        coinPool.Add(newCoin);
        return newCoin;
    }

    // Method to return a coin to the pool
    public void ReturnCoin(GameObject coin)
    {
        coin.transform.position = Vector3.zero;
        coin.transform.rotation = Quaternion.identity;
        coin.SetActive(false);
    }
}
