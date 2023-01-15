using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool SharedInstance;
    public Queue<GameObject> hurdlePool;
    public Queue<GameObject> coinPool;
    public GameObject hurdlePrefab;
    public GameObject coinPrefab;
    public int amountToPool;
    public Transform[] hurdlePositions;
    public Transform[] coinPositions;


    private void Awake()
    {
        SharedInstance = this;
    }

    void Start()
    {
        { 
            coinPool = new Queue<GameObject>();
            hurdlePool = new Queue<GameObject>();
            for (int i = 0; i < amountToPool; i++)
            {
                GameObject coin = Instantiate(coinPrefab);
                GameObject hurdle = Instantiate(hurdlePrefab);

                coin.SetActive(false);
                hurdle.SetActive(false);
                coinPool.Enqueue(coin);
                hurdlePool.Enqueue(hurdle);
            }
        }

   
    }

    private void Update()
    {
    
    }

    public GameObject GetHurdlePooledObject()
    {
        if (hurdlePool.Count ==0)
        {
            GameObject hurdle = Instantiate(hurdlePrefab);
            return hurdle;
        }
        else
        {
            GameObject hurdle = hurdlePool.Dequeue();
            hurdle.SetActive(true);
            return hurdle;
        }
    }

    public GameObject GetCoinsPooledObject()
    {
        if (coinPool.Count == 0)
        {
            GameObject coin = Instantiate(coinPrefab);
            return coin;
        }
        else
        {
            GameObject coin = coinPool.Dequeue();
            coin.SetActive(true);
            return coin;
        }
    }

    public void CoinGeneration()
    {
        GameObject coin = ObjectPool.SharedInstance.GetCoinsPooledObject();
        for (int i = 0; i < ObjectPool.SharedInstance.coinPool.Count; i++)
        {
            if (coin != null) // if you dont use this codition its going to return null value from object pooling and it will cause null reference
            {
                Vector3 position = coinPositions[i].position;
                coin.transform.position = position; //new Vector3(0, 5, (i * 30));
                coin.gameObject.SetActive(true);
            }

        }
    }

    public void HurdleGenration()
    {

        GameObject hurdle = ObjectPool.SharedInstance.GetHurdlePooledObject();
        for (int i = 0; i <10; i++)
        {
            if (hurdle != null) // if you dont use this codition its going to return null value from object pooling and it will cause null reference
            {
                Vector3 positionHurdle = hurdlePositions[i].position;
                hurdle.transform.position = positionHurdle; //new Vector3(0, 5, (i * 30));
                hurdle.gameObject.SetActive(true);
            }

        }

    }
}
