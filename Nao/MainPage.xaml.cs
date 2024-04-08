namespace Nao;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	
//..........................................................
	

		var timer = Application.Current.Dispatcher.CreateTimer();
		timer.Interval = TimeSpan.FromSeconds(3);
		timer.Tick += (s, e) => PassouTempo();
		timer.Start();

//..........................................................


	Nugget = new Nigget();
	Maca = new Mogger();
	Pera = new Diego();

//..........................................................


	Atual = Nigget;

//..........................................................


	Atual.SetMewing(0.4);
	Atual.SetSede(0.4);
	Atual.SetFome(0.4);

//..........................................................

	
	
	
	
	
	
	
	
	
	}

}

