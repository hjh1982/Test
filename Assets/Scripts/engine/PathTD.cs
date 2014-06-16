using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace engine
{
    public class PathTD : MonoBehaviour
    {
        //速度单位是像素
        public float speed = 5f;
        //路点集合，路点的坐标也是像素
        public List<Vector3> waypoints;

        int pointIndex = 0;
        int maxIndex = 0;
        bool bFinishFind = false;

        void Start()
        {
            maxIndex = waypoints.Count - 1;
        }

        void Update()
        {
            if (!bFinishFind)
            {
                Vector3 point = waypoints[pointIndex];
                if (MoveToPoint(point))
                {
                    if (pointIndex == maxIndex)
                    {
                        FinishFind();
                    }
                    else
                    {
                        pointIndex = Mathf.Min(waypoints.Count - 1, pointIndex + 1);
                    }
                }
            }
        }

        bool MoveToPoint(Vector3 point)
        {
            Vector3 dir = (point - transform.localPosition).normalized;
            float dist = Vector3.Distance(point, transform.localPosition);
            if (dist < 1f) return true;
            transform.Translate(dir * Mathf.Min(dist, speed * RealTime.deltaTime), Space.Self);
            return false;
        }

        void FinishFind()
        {
            bFinishFind = true;
        }
    }
}