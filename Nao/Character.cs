namespace Nao;


        public class Personagem
{





    public int mewingLevel;

    public int sedeLevel;

    public int fomeLevel;





        public Personagem()

{
    mewingLevel = 0;
    sedeLevel = 0;
    fomeLevel = 0;
}


//-----------------------------------------------------------------------------------------------------


    public void SetFome (int f)
    {
        
        if (1 <= f || f >= 0)
          
          mewingLevel = f;

        else if (f > 1)

          mewingLevel = 1;

        else

          mewingLevel = 0;

    }





































}