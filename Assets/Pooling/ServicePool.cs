﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServicePool<T> : GenericSingleton<ServicePool<T>> where T:class
{
    
    private List<PooledItems<T>> pooledItems;

    public virtual T GetItem()
    {
        if(pooledItems.Count>0)
        {
            PooledItems<T> item = pooledItems.Find(i => i.isUsed == false);
            if(item!=null)
            {
                item.isUsed = true;
                return item.Item;
            }

            
        }

        return CreateNewPooledItem();
    }

    private T CreateNewPooledItem()
    {
        PooledItems<T> pooledItem = new PooledItems<T>();
        pooledItem.Item = CreateItem();
        pooledItem.isUsed = true;
        pooledItems.Add(pooledItem);
        Debug.Log("New Item Added" + pooledItems.Count);
        return pooledItem.Item;
       
    }

    public virtual void ReturnItem(T item)
    {
        PooledItems<T> pooledItem = pooledItems.Find(i => i.Item.Equals(item));
        pooledItem.isUsed = false;
    }

    protected virtual T CreateItem()
    {
        return (T) null; 
    }

    private class PooledItems<T>
    {
        public T Item;
        public bool isUsed;
    }
    
}

