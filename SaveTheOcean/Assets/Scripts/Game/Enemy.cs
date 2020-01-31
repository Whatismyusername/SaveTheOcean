using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject deathFX;
    [SerializeField] Transform parent;
    [SerializeField] int hits = 2;
    ScoreBoard scoreBoard;
    private void Start() {
        AddBoxCollider();
        scoreBoard = FindObjectOfType<ScoreBoard>();
    }

    private void OnParticleCollision(GameObject other) {
        
        hits--;
        scoreBoard.ScorePerHit();

        if(hits < 1) {
            Killed();
        }
    }

    private void AddBoxCollider() {
        Collider boxCollider = gameObject.AddComponent<BoxCollider>();
        boxCollider.isTrigger = false;
    }

    private void Killed() {
        // Play Death FX
        GameObject fx = Instantiate(deathFX, transform.position, Quaternion.identity);
        fx.transform.parent = parent;

        // Add Scores
        scoreBoard.ScorePerKill();
        
        Destroy(gameObject);
    }
}
