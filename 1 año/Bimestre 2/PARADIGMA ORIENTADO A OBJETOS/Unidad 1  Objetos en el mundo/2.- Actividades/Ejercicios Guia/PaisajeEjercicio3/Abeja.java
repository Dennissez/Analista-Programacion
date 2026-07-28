import greenfoot.*;  

public class Abeja extends Actor
{
    private int anios;
    private String panal;

    public Abeja(){
        this.anios = 0;
        this.panal = "Panal 1";
    }

    public Abeja(int anios, String panal){
        this.anios = anios;
        this.panal = panal;
    }
    
    public int getAnios(){
        return this.anios;
    }
    
    public String getPanal(){
        return this.panal;
    }
    
    public void setAnios(int anios){
        this.anios = anios;
    }
    
    public void setPanal(String panal){
        this.panal = panal;
    }
    
    public void aumentarAnios(){
        this.anios = this.anios + 1;
    }
    
    public String obtenerDatos(){
        String datos = "";
        datos = "Esta abeja pertenece al panal " + this.getPanal(); 
        datos = datos + " y tiene " + this.getAnios() + " años.";
        return datos;
    }
    
    public void act()
    {
        move(200);
        turn(-90);
    }
}
