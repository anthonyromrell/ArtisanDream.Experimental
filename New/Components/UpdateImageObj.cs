using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class UpdateImageObj : ScriptableObject
{
    public FloatDataObj Data;
    
    public void ChangeFillAmount(Image img)
    {
        img.fillAmount = Data.Value;
    }
}