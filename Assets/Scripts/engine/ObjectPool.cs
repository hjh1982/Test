using UnityEngine;
using System.Collections;

namespace engine
{
    //TODO:未实现对象池功能，现在直接new对象返回
    public class ObjectPool
    {
        static public GameObject GetCreep(GameObject sprite, Vector3 position)
        {
            Object obj = GameObject.Instantiate(sprite,position,Quaternion.identity);

            return (GameObject)obj;
        }

    }
}
