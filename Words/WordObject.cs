using UnityEngine;

[CreateAssetMenu(menuName = "Words/Word")]
public class WordObject : ScriptableObject
{
    public GameObject LetterPrefab;
    public GameObject RingObject;
  
    public LetterObjectList List;
    private GameObject tempLetter;
    private GameObject tempRing;
    private Transform parentTransform;
    private GameObject PatrolPrefab;
    private Vector3 ringPosition;
    public float distance = 1.5f;
    
    public void SetParentTransform(Transform t)
    {
        parentTransform = t;
    }

    public void Generate()
    {
       
        float pos = 0;
        ringPosition = Vector3.zero;
        foreach (var character in name)
        {
            foreach (var letter in List.Letter)
            {
                if (character != letter.name[0]) continue;
                tempLetter = Instantiate(LetterPrefab);
                tempLetter.GetComponentInChildren<SpriteRenderer>().sprite = letter.LetterSprite;
                tempLetter.GetComponent<MatchID>().Id = letter.ID;
                tempLetter.GetComponent<AiBehaviour>().OnStart = letter.Patrol;
                tempLetter.GetComponent<AiBehaviour>().Patrol = letter.Patrol;
                tempLetter.name = letter.name;
                 
                tempRing = Instantiate(RingObject);
                tempRing.transform.parent = parentTransform;
                tempRing.GetComponent<ObjectID>().ID = letter.ID;
                tempRing.name = letter.name;
                ringPosition.x += distance;
                pos += distance;
                tempRing.transform.position = ringPosition;
                //ringPosition.x -= .75f;
                //tempRing.transform.parent.position += ringPosition;
            }
        }

        Vector3 tempV = Vector3.zero;
        tempV.x = pos*0.5f;

        parentTransform.position -= tempV;
    }
}