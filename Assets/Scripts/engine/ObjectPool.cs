using UnityEngine;
using System.Collections;

namespace engine
{
    //TODO:δʵ�ֶ���ع��ܣ�����ֱ��new���󷵻�
    public class ObjectPool
    {
        static public GameObject GetCreep(GameObject sprite, Vector3 position)
        {
            Object obj = GameObject.Instantiate(sprite,position,Quaternion.identity);

            return (GameObject)obj;
        }

    }
}
