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

        int currentWave = 0;
        
		//最近一次产卵开始时间
        float lastSpawnTime = 0;
	
		/// <summary>
		/// 返回是否可以产卵
		/// </summary>
        public bool Spawn()
        {
            if (GameControl.gameState != GameState.Ended)
            {
                if (currentWave >= waves.Length - 1)
                {
                    GameControl.ShowDebugMessage("All waves has been spawned");
                    return false;
                }
                else
                {
                    if (currentWave == 0)
                    {
                        GameControl.gameState = GameState.Started;
                        GameControl.ShowDebugMessage("Game Started");
                    }

                    SpawnWave();
                    return true;
                }
            }

            return false;
        }

        void SpawnWave()
        {
			if (lastSpawnTime == 0) lastSpawnTime = RealTime.time;

            Wave wave = waves[currentWave];

            if ((currentWave < waves.Length) && (GameControl.gameState != GameState.Ended))
            {
                if ((RealTime.time - lastSpawnTime) >= wave.Interval)
                {
					lastSpawnTime = RealTime.time;
					StartCoroutine(SpawnCreep(wave));
                }
            }
        }

		IEnumerator SpawnCreep(Wave wave)
		{
			float lastCreepTime = RealTime.time;
			foreach (UnitCreep creep in wave.Creeps) 
			{
				if((RealTime.time - lastCreepTime) < creep.Interval)
				{
					yield return 0;
				}
				else
				{
					lastCreepTime = RealTime.time;
					SpawnUnitCreep(creep);
				}
			}
        }

		void SpawnUnitCreep(UnitCreep creep)
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
