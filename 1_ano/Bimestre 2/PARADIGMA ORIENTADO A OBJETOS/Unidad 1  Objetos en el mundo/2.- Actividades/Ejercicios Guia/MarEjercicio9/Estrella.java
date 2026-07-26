import greenfoot.*; 

public class Estrella extends Actor
{
    private int gradosGiro;
    private int cantidadMovimientos;
    
    public Estrella(){
        this.gradosGiro = 0;
        this.cantidadMovimientos = 0;
    }
    
    public Estrella(int gradosGiro, int cantidadMovimientos){
        this.gradosGiro = gradosGiro;
        this.cantidadMovimientos = cantidadMovimientos;
    }
    
    public int getGradosGiro(){
        return this.gradosGiro;
    }
    
    public int getCantidadMovimientos(){
        return this.cantidadMovimientos;
    }
    
    public void setGradosGiro(int gradosGiro){
        this.gradosGiro = gradosGiro;
    }
    
    public void setCantidadMovimientos(int cantidadMovimientos){
        this.cantidadMovimientos = cantidadMovimientos;
    }
    
    public void cambiar(){
        turn(this.gradosGiro);
        this.cantidadMovimientos = this.cantidadMovimientos + 1;
    }
    
    public String mostrarMensaje(){
        return "Esta estrella gira " + this.gradosGiro + " grados"
        + " y lleva " + this.cantidadMovimientos + " movimientos"; 
    }
    
    public void act()
    {
        cambiar();
    }
}
