using UnityEngine;

[CreateAssetMenu(menuName = "Words/Word")]
public class WordObject : ScriptableObject
{
    public GameObject letterPrefab;
    public GameObject ringObject;
  
    public LetterObjectList list;
    private GameObject tempLetter;
    private GameObject tempRing;
    private Transform parentTransform;
    private GameObject patrolPrefab;
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
            foreach (var letter in list.letter)
            {
                if (character != letter.name[0]) continue;
                tempLetter = Instantiate(letterPrefab);
                tempLetter.GetComponentInChildren<SpriteRenderer>().sprite = letter.letterSprite;
                tempLetter.GetComponent<MatchID>().ID = letter.id;
                tempLetter.GetComponent<AiBehaviour>().OnStart = letter.patrol;
                tempLetter.GetComponent<AiBehaviour>().OnEnter = letter.patrol;
                tempLetter.GetComponent<AiBehaviour>().OnExit = letter.patrol;
                tempLetter.GetComponent<AiBehaviour>().Patrol = letter.patrol;
                tempLetter.name = letter.name;
                 
                tempRing = Instantiate(ringObject);
                tempRing.transform.parent = parentTransform;
                tempRing.GetComponent<MatchID>().ID = letter.id;
                tempRing.name = letter.name;
                ringPosition.x += distance;
                pos += distance;
                tempRing.transform.position = ringPosition;
                //ringPosition.x -= .75f;
                //tempRing.transform.parent.position += ringPosition;
            }
        }

        var tempV = Vector3.zero;
        tempV.x = pos*0.5f;

        parentTransform.position -= tempV;
    }
}