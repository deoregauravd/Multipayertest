/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool SharedInstance;
    public GameObject [] hurdlePool;
    public GameObject [] coinPool;
    public GameObject hurdlePrefab;
    public GameObject coinPrefab;
    public int amountToPool;
    public Transform[] hurdlePositions;
    public Transform[] coinPositions;
    private int size = 1;


    private void Awake()
    {
        SharedInstance = this;
    }

    void Start()
    {
        { 
        
            for (int i = 0; i < amountToPool; i++)
            {
                GameObject coin = Instantiate(coinPrefab);
                GameObject hurdle = Instantiate(hurdlePrefab);

                coin.transform.position = new Vector3(0, 0, size * 10);
                hurdle.transform.position = new Vector3(0, 0, size * 20);

                coin.SetActive(true);
                hurdle.SetActive(true);
                
            }
        }

    }
    public GameObject GetHurdlePooledObject()
    {
        for (int i = 0; i < amountToPool; i++)
        {
            GameObject hurdle = hurdlePool[i];
            return hurdle;
        }
        return null;
    }

    *//*public GameObject GetHurdlePooledObject()
    {
        if (hurdlePool.Count ==0)
        {
            GameObject hurdle = Instantiate(hurdlePrefab);
            return hurdle;
        }
        else
        {
            GameObject hurdle = hurdlePool.Dequeue();
            hurdle.transform.position = new Vector3(0, 0, size * 10);
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
                coin.transform.position = new Vector3(0, 0, size*10);
                coin.SetActive(true);
                return coin;
          
        }
    }*/

    /* public void CoinGeneration()
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

         }*//*


}
*/