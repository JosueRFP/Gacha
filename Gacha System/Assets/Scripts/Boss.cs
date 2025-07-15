using UnityEngine;

[System.Serializable]
public class BossCaracteristics
{
    [SerializeField] float life;
    [SerializeField] float maxLife;
    [SerializeField] float speed;
    [SerializeField] float damage;


   public void BossStats(float life, float maxLife, float speed, float damage)
   {
        this.life = life;
        this.maxLife = maxLife;
        this.speed = speed;
        this.damage = damage;
   }
}


public class Boss : MonoBehaviour
{
    BossCaracteristics caracteristics;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
