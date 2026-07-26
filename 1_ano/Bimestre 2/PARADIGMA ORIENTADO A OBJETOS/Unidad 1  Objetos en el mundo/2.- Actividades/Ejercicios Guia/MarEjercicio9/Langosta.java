import greenfoot.*; 

public class Langosta extends Actor
{
    private int movimientoX;
    private int movimientoY;
    
    public Langosta(int movimientoX, int movimientoY){
        this.movimientoX = movimientoX;
        this.movimientoY = movimientoY;
    }
    
    public int getMovimientoX(){
        return this.movimientoX;
    }
    
    public int getMovimientoY(){
        return this.movimientoY;
    }
    
    public void setMovimientoX(int movimientoX){
        this.movimientoX = movimientoX;
    }
    
    public void setMovimientoY(int movimientoY){
        this.movimientoY = movimientoY;
    }
    
    public void desplazar(){
        int xActual = getX();
        int yActual = getY();
        this.setLocation(xActual + this.getMovimientoX(), 
                        yActual + this.getMovimientoY());
    }
    
    public void act()
    {
        desplazar();
    }
}
