public class Punto  
{
    private int X;
    private int Y;

    public Punto(){
        this.X = 300;
        this.Y = 200;
    }
    
    public Punto (int X, int Y){
        this.X = X;
        this.Y = Y;
    }
    
    public int getX(){
        return this.X;
    }
    
    public int getY(){
        return this.Y;
    }
    
    public void setX(int X){
        this.X = X;
    }
    
    public void setY(int Y){
        this.Y = Y;
    }
    
}
