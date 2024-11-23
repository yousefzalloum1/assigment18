using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace YoYo{
public class GameContainer<T>
{
    private T item;

    
    public void SetItem(T newItem)
    {
        item = newItem;
    }

  
    public T GetItem()
    {
        return item;
    }
}
}