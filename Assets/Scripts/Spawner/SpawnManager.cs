using System.Collections.Generic;
using UnityEngine;
using Colombus.Environment;
using Colombus.Utils;

namespace Colombus
{
    public class SpawnManager : MonoBehaviour
    {
        [SerializeField] private List<Transform> _supplySpawnPointList;
        [SerializeField] private List<Transform> _bigObstacleSpawnPointList;
        [SerializeField] private List<Transform> _smallObstacleSpawnPointList;
        [SerializeField] private List<EntityBase> _entityList;

        WeightenedRandomBag<EntityBase> _entities = new WeightenedRandomBag<EntityBase>();


        private bool _isSpawnAvailable = false;
        private float _spawnTimer = 0f;
        private float _timeBetweenSpawns = 2f;

        private void Awake()
        {
            Initialize();
        }

        private void Update()
        {
            CheckTimer();
            if (_isSpawnAvailable)
            {
                SpawnUnit();
            }
        }

        #region Random Entity
        private void Initialize()
        {
            SetRandomEntity();
        }

        private void SetRandomEntity()
        {
            foreach (EntityBase entity in _entityList)
            {
                _entities.AddEntry(entity, entity.RarityRate);
            }
        }

        private EntityBase GetRandomEntity()
        {
            return _entities.GetRandom();
        }

        #endregion

        private void SpawnUnit()
        {
            var entity = GetRandomEntity();
            List<Transform> spawnPointList = GetProperList(entity);
            var rand = Random.Range(0, spawnPointList.Count);
            var instantiated = Instantiate(entity, spawnPointList[rand].position, Quaternion.identity);

            // if supply spawns at last point we must mirror it

            if (entity.GetEntityType == EntityType.Supply && rand == spawnPointList.Count - 1)
                instantiated.transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
            
            _isSpawnAvailable = false;
        }

        private List<Transform> GetProperList(EntityBase entity)
        {
            switch (entity.GetEntityType)
            {
                case EntityType.Supply:
                    return _supplySpawnPointList;
                case EntityType.BigObstacle:
                    return _bigObstacleSpawnPointList;
                case EntityType.SmallObstacle:
                    return _smallObstacleSpawnPointList;
                default:
                    return null;
            }
        }

        private void CheckTimer()
        {            
            _spawnTimer += Time.deltaTime;
            if (_spawnTimer >= _timeBetweenSpawns)
            {
                _timeBetweenSpawns = Random.Range(1f, 2f);
                _spawnTimer = 0f;
                _isSpawnAvailable = true;
            }
        }
    }
}