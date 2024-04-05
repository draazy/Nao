namespace Nao;


  public class Personagem
{
    double Mewing;
    double Sede;
    double Fome;



  public Personagem()
  
  {
    
    Mewing = 0;

    Sede = 0;

    Fome = 0;
    
  
  }




  //-------------------------------------------





  public void SetMewing (double m)
  {
        
    if (m < 0)
        Mewing = 0;

    else if (m > 1)
        Mewing = 1;

    else
        Mewing = m;

  }



  public void SetSede (double s)
  {
        
    if (s < 0)
        Sede = 0;

    else if (s > 1)
        Sede = 1;

    else
        Sede = s;

  }



  public void SetFome (double f)
  {
        
    if (f < 0)
        Mewing = 0;

    else if (f > 1)
        Mewing = 1;

    else
        Mewing = f;

  }


//-------------------------------------------


























}