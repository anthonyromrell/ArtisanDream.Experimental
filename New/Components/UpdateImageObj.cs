using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class UpdateImageObj : ScriptableObject
{
    public FloatData Data;
    
    public void ChangeFillAmount(Image img)
    {
        img.fillAmount = Data.Value;
    }
}