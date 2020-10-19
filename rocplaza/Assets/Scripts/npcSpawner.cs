using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class npcSpawner : MonoBehaviour
{
    public GameObject npc;
    public float spawnRate = 2f; // in seconds
    public List<Sprite> headSpr = new List<Sprite>();
    public List<Sprite> legsSpr = new List<Sprite>();
    public List<Sprite> upperBodySpr = new List<Sprite>();
    public List<Sprite> skinSpr = new List<Sprite>();
    Vector2 whereToSpawn;
    float nextSpawn = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            whereToSpawn = new Vector2(transform.position.x, transform.position.y);
            generateRandomNPC();
            Instantiate(npc, whereToSpawn, Quaternion.identity);
        }

    }
    
    void generateRandomNPC()
    {
        foreach(Transform child in npc.transform)
        {
            SpriteRenderer childSprite = child.GetComponent<SpriteRenderer>();
            int spriteIndex = 0;

            switch(child.tag)
            {
                case "npcUpperBody":
                    spriteIndex = getRandomSprite(upperBodySpr);
                    childSprite.sprite = upperBodySpr[spriteIndex]; 
                    break;
                case "npcLegs":
                    spriteIndex = getRandomSprite(legsSpr);
                    childSprite.sprite = legsSpr[spriteIndex]; 
                    break;
                case "npcHead":
                    spriteIndex = getRandomSprite(headSpr);
                    childSprite.sprite = headSpr[spriteIndex]; 
                    break;
                case "npcSkin":
                    spriteIndex = getRandomSprite(skinSpr);
                    childSprite.sprite = skinSpr[spriteIndex]; 
                    break;
                default:
                    spriteIndex = getRandomSprite(skinSpr);
                    childSprite.sprite = skinSpr[spriteIndex];
                    break;
            }
        } // foreach

    }

    int getRandomSprite(List<Sprite> spriteSet)
    {
        return Random.Range(0, spriteSet.Count - 1);
    }
}