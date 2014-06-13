using UnityEngine;
using System.Collections;

namespace engine
{
    /// <summary>
    /// 现在只支持有限模式
    /// </summary>
    public class SpawnManager : MonoBehaviour
    {
        static public SpawnManager spawnManager;
        public Wave[] waves;

        int currentWaveIndex = 0;
        
        float lastSpawnTime = 0;
        float waitingTime = 0;
        public bool Spawn()
        {
            if (GameControl.gameState != GameState.Ended)
            {
                if (currentWaveIndex >= waves.Length - 1)
                {
                    GameControl.ShowDebugMessage("All waves has been spawned");
                    return false;
                }
                else
                {
                    if (currentWaveIndex == 0)
                    {
                        GameControl.gameState = GameState.Started;
                        GameControl.ShowDebugMessage("Game Started");
                    }

                    //StartCoroutine(CoroutineSpawnWave());
                    return true;
                }
            }

            return false;
        }

        //IEnumerator CoroutineSpawnWave()
        //{
        //    Wave wave = waves[currentWaveIndex];

        //    while (currentWaveIndex < waves.Length && GameControl.gameState != GameState.Ended)
        //    {
        //        if (RealTime.time - lastSpawnTime >= wave.Interval)
        //        {
        //            lastSpawnTime = RealTime.time;
        //        }
        //    }
        //    foreach (SubWave subWave in wave.SubWaves)
        //    {
        //    }
        //}

        private void SpawnSubWave(SubWave subWave)
        {
        }


        // Use this for initialization
        void Awake()
        {
            spawnManager = this;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
