using System;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class Pooling : MonoBehaviour
{
   public GameObject itemToPool;
   public List<GameObject> pool;
   private int poolCount;
   public UnityEvent startEvent;

   private void Start()
   {
      startEvent.Invoke();
   }

   public void AddToPool(int numberToAdd)
   {
      for (var i = 0; i < numberToAdd; i++)
      {
         var item = Instantiate(itemToPool);
         pool.Add(item);
      }
   }

   public void DisableAllPoolItems()
   {
      foreach (var item in pool)
      {
         item.SetActive(false);
      }
   }

   public void UsePool()
   {
      if (poolCount < pool.Count)
      {
         pool[poolCount].SetActive(true);
         pool[poolCount].transform.position = transform.position;
         poolCount++;
      }
      else
      {
         poolCount = 0;
         pool[poolCount].SetActive(true);
         pool[poolCount].transform.position = transform.position;
      }
   }
}