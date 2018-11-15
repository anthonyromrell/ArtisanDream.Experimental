using UnityEngine;
using UnityEngine.UI;

public class UpdateText : MonoBehaviour
{
	public IntData Data;
	private Text label;
	
	void Start ()
	{
		label = GetComponent<Text>();
		OnUpdate();
	}

	public void OnUpdate()
	{
		label.text = Data.Value.ToString("C0");
	}
}