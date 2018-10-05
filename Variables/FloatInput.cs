using UnityEngine;

[CreateAssetMenu]
public class FloatInput : FloatData
{
	public string Axis = "Horizontal";
	
	public override float Value
	{
		get
		{
			return value*Input.GetAxis(Axis); 
		}
	}
}