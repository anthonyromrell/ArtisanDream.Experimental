using System;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Events;

public class Pooling : MonoBehaviour
{
   public GameObject ItemToPool;
   public List<GameObject> Pool;
   private int poolCount;
   public UnityEvent StartEvent;

   private void Start()
   {
      StartEvent.Invoke();
   }

   public void AddToPool(int numberToAdd)
   {
      for (var i = 0; i < numberToAdd; i++)
      {
         var item = Instantiate(ItemToPool);
         Pool.Add(item);
      }
   }

   public void DisableAllPoolItems()
   {
      foreach (var item in Pool)
      {
         item.SetActive(false);
      }
   }

   public void UsePool()
   {
      if (poolCount < Pool.Count)
      {
         Pool[poolCount].SetActive(true);
         Pool[poolCount].transform.position = transform.position;
         poolCount++;
      }
      else
      {
         poolCount = 0;
         Pool[poolCount].SetActive(true);
         Pool[poolCount].transform.position = transform.position;
      }
   }
}