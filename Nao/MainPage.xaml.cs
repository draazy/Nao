namespace Nao;

public partial class MainPage : ContentPage
{
	Nigget Nugget;
	Mogger Maca;
	Diego Pera;

	Personagem Atual;
	public MainPage()
	{
		InitializeComponent();
	
//..........................................................
	

		var timer = Application.Current.Dispatcher.CreateTimer();
		timer.Interval = TimeSpan.FromSeconds(3);
		timer.Tick += (s, e) => TimePassed();
		timer.Start();
	


//..........................................................


	Nugget = new Nigget();
	Maca = new Mogger();
	Pera = new Diego();

//..........................................................


	Atual = Nugget;

//..........................................................


	Atual.SetMewing(0.4);
	Atual.SetSede(0.4);
	Atual.SetFome(0.4);
}
//..........................................................

 void TimePassed()
 {

	Atual.SetSede(Atual.GetSede() - 0.01);
		barraagua.Progress = Atual.GetSede();

		Atual.SetFome(Atual.GetFome() - 0.0001);
		barrafome.Progress = Atual.GetFome();

		Atual.SetMewing(Atual.GetMewing() - 0.0001);
		barramewing.Progress = Atual.GetMewing();

		Nugget.SetSede(Nugget.GetSede() - 0.01);
		Nugget.SetFome(Nugget.GetFome() - 0.0001);
		Nugget.SetMewing(Nugget.GetMewing() - 0.0001);

		Maca.SetSede(Maca.GetSede() - 0.01);
		Maca.SetFome(Maca.GetFome() - 0.0001);
		Maca.SetMewing(Maca.GetMewing() - 0.0001);

		Pera.SetSede(Pera.GetSede() - 0.01);
		Pera.SetFome(Pera.GetFome() - 0.0001);
		Pera.SetMewing(Pera.GetMewing() - 0.0001);
	
	}

	public void BotaoProximo(object sender, EventArgs args) 
	{
		if(Atual == Nugget)
			Atual = Maca;
		
		else if(Atual == Maca)
			Atual = Pera;

		else if(Atual == Pera)
			Atual = Nugget;

		FotoComida.Source = Atual.GetArquivo();
		LabelNome.Text = Atual.GetNomePersonagem();
	}

//...............................................................

	public void BotaoAnterior(object sender, EventArgs args) 
	{
		if(Atual == Nugget)
			Atual = Pera;
		
		else if(Atual == Pera)
			Atual = Maca;

		else if(Atual == Maca)
			Atual = Nugget;

		FotoComida.Source = Atual.GetArquivo();
		LabelNome.Text = Atual.GetNomePersonagem();
	}

//...................................................................


void AtualizarProgresso()
	{
		barraagua.Progress = Atual.GetSede();
		barrafome.Progress = Atual.GetFome();
		barramewing.Progress = Atual.GetMewing();
	}



//...................................................................

	private void ClicouBotaoAgua(object sender, EventArgs args) 
	{
		Atual.SetSede(Atual.GetSede() + 0.1);
		barraagua.Progress = Atual.GetSede();
	}

//------------------------------------------------------------

	private void ClicouBotaoComida(object sender, EventArgs args) 
	{
		Atual.SetFome(Atual.GetFome() + 0.1);
		barrafome.Progress = Atual.GetFome();
	}

//------------------------------------------------------------

	private void ClicouBotaoMewing(object sender, EventArgs args) 
	{
		Atual.SetMewing(Atual.GetMewing() + 0.1);
		barramewing.Progress = Atual.GetMewing();

	}
}

