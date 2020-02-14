using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class UpdateText : MonoBehaviour
{
	[FormerlySerializedAs("Data")] public IntData data;
	private Text label;
	[FormerlySerializedAs("Format")] public string format = "C0";
	
	void Start ()
	{
		label = GetComponent<Text>();
		OnUpdate();
	}

	public void OnUpdate()
	{
		label.text = data.value.ToString(format);
	}
}