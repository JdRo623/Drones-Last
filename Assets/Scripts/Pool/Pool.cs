
using System.Collections.Generic;
using UnityEngine;

namespace PoolPattern
{
    public class Pool: MonoBehaviour
    {
        protected List<GameObject> pooledObjects;
        protected bool willGrow = false;
        public GameObject pooledObject;
        public int pooledMaxAmount;
        public int pooledInitialAmount;

        public GameObject GetPulledObject()
        {
            for (int i = 0; i < pooledObjects.Count; i++)
            {
                if (!pooledObjects[i].activeInHierarchy)
                {
                    return pooledObjects[i];
                }
            }
            if (willGrow && pooledObjects.Count < pooledMaxAmount)
            {
                GameObject obj = (GameObject)Instantiate(pooledObject);
                pooledObjects.Add(obj);
                return obj;
            }
            return null;
        }

        void Start() {
            pooledObjects = new List<GameObject>();
            for (int i = 0; i < pooledInitialAmount; i++)
            {
                GameObject obj = (GameObject)Instantiate(pooledObject, new Vector3(0, 0, 0), Quaternion.identity);
                obj.SetActive(false);
                pooledObjects.Add(obj);
            }
        }

    }
}
