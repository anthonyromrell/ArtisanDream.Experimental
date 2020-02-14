using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

[CreateAssetMenu]
public class UpdateImageObj : ScriptableObject
{
    [FormerlySerializedAs("Data")] public FloatData data;
    
    public void ChangeFillAmount(Image img)
    {
        img.fillAmount = data.value;
    }
}