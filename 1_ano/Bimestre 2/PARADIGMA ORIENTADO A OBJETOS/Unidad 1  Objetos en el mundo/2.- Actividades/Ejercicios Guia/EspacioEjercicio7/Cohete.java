import greenfoot.*;

public class Cohete extends Actor
{
    private int cantidadAvance;
    private int anguloGiro;
    
    public Cohete(){
        this.cantidadAvance = 0;
        this.anguloGiro = 0;
    }
    
    public Cohete(int cantidadAvance, int anguloGiro){
        this.cantidadAvance = cantidadAvance;
        this.anguloGiro = anguloGiro;
    }

    public int getCantidadAvance(){
        return this.cantidadAvance;
    }

    public int getAnguloGiro(){
        return this.anguloGiro;
    }
    
    public void setCantidadAvance(int cantidadAvance){
        this.cantidadAvance = cantidadAvance;
    }
    
    public void setAnguloGiro(int anguloGiro){
        this.anguloGiro = anguloGiro;
    }
    
    public void mover(){
        move(this.cantidadAvance);
    }
    
    public void girar(){
        turn(this.anguloGiro);
    }
    
    public void act()
    {
        mover();
        girar();
    }
}
