using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSprite : MonoBehaviour
{
    public Sprite[] sprites;
    public string resourceName;
    public int currentSprite = -1;
    Artefacts art;
    // Start is called before the first frame update
    void Start()
    {
        if (resourceName != "")
        {
            sprites = Resources.LoadAll<Sprite>(resourceName);

            if (currentSprite == -1)
            {
                currentSprite = Random.Range(0, sprites.Length);
            }
            else if (currentSprite >= sprites.Length)
            {
                currentSprite = sprites.Length -1;
            }
            GetComponent<SpriteRenderer>().sprite = sprites[currentSprite];
            art = GetComponent<Artefacts>();
            art.currentArtefact = art.artefact[currentSprite];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
