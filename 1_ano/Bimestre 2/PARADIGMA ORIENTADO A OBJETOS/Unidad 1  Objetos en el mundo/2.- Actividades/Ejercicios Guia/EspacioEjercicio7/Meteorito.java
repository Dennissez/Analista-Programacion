import greenfoot.*;  

public class Meteorito extends Actor
{
    public void avanzar(int distancia){
        move(distancia);
    }
    
    public void girar(){
        turn(180);
    }

    public void retroceder(int distancia){
        move(-1 * distancia);
    }
    
    public void act()
    {
        avanzar(300);
        girar();
        retroceder(250);
    }
}
