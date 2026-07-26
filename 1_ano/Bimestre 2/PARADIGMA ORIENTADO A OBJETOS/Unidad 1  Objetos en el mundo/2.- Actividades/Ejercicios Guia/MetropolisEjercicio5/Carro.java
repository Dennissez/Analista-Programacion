import greenfoot.*; 

public class Carro extends Actor
{
    private float cantidadGasolina;
    private String marca;
    private char categoria;
    
    public Carro(){
        this.cantidadGasolina = 0;
        this.marca = "Sin marca";
        this.categoria = 'C';
    }
    
    public float getCantidadGasolina(){
        return this.cantidadGasolina;
    }
    
    public String getMarca(){
        return this.marca;
    }
    
    public char getCategoria(){
        return this.categoria;
    }
    
    public void setCantidadGasolina(float cantidadGasolina){
        this.cantidadGasolina = cantidadGasolina;
    }
    
    public void setMarca(String marca){
        this.marca = marca;
    }
    
    public void setCategoria(char categoria){
        this.categoria = categoria;
    }
    
    public void avanzar(){
                
           move(1);
            this.cantidadGasolina = this.cantidadGasolina - 0.1f;  
        
       
    }
    
    public void act()
    {
        avanzar();
    }
}
