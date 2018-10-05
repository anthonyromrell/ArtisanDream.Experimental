namespace ArtisanDream.Experimental.Animals
{
	public class Dog : Mammal
	{
		public string Bark;

		public void OnBark()
		{
			print(Bark);
		}	
	}
}