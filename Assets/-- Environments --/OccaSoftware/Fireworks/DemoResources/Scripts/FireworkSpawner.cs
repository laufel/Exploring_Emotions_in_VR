using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace OccaSoftware.Fireworks.Demo
{
    public class FireworkSpawner : MonoBehaviour
    {
        
        public List<GameObject> fireworkPrefabs = new List<GameObject>();
        public List<AudioClip> audioClips = new List<AudioClip>();

        public float spawnRadius = 10f;
        public float spawnRate = 1f;
        public bool timePassed = false;
        public float timerFireworks = 0;
        
        float randomizedRate;
        float timeTracker;


        void Start()
        {
            timeTracker = Time.time;
            randomizedRate = spawnRate * Random.Range(1f, 2f);
        }


        void Update()
        {
            timerFireworks += Time.deltaTime;
            if (timerFireworks >= 150.0f)
            {
                timePassed = true;
            }

            if (timerFireworks >= 300.0f)
            {
                timePassed = false;
            }

            if ((Time.time - timeTracker > randomizedRate) && timePassed)
            {
                Spawn();
                timeTracker = Time.time;
                randomizedRate = spawnRate * Random.Range(1f, 2f);
            }
        }

        void Spawn()
        {
            GameObject go = fireworkPrefabs[Random.Range(0, fireworkPrefabs.Count)];
            go.GetComponentInChildren<AudioSource>().clip = audioClips[Random.Range(0, audioClips.Count)];
            Vector3 sphere = Random.insideUnitSphere * spawnRadius;
            Instantiate(go, new Vector3(90 + sphere.x, 0, -270 + sphere.y ), Quaternion.identity);
        }
    }
}