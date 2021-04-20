using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Artefacts : MonoBehaviour
{
    public List<SpritesValue> artefact = new List<SpritesValue>();
    public SpritesValue currentArtefact;
    // Start is called before the first frame update
    void Start()
    {
        artefact.Add(new SpritesValue("kristali_0", 10));
        artefact.Add(new SpritesValue("kristali_1", 20));
        artefact.Add(new SpritesValue("kristali_2", 30));
        artefact.Add(new SpritesValue("kristali_3", 40));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
