namespace Jakas_aplikacja;

public partial class NWD : ContentPage
{

	public NWD()
	{
		InitializeComponent();
	}

	private int oblicNWD(int first,int second)
	{
		if(first <= 0 || second <= 0)
		{
			return 0;
		}

		while(first != second)
		{
			if(first > second)
			{
				first -= second;
				continue;
			}
			second-= first;
		}
		return first;
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		var first = Int32.Parse(this.firstNumber.Text); 
		var second = Int32.Parse(this.secondNumber.Text);


		Wynik.Text = $"Wynik: {oblicNWD(first, second)}";

		SemanticScreenReader.Announce(Wynik.Text);
	}
}

